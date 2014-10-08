//
//  Copyright (C) 2014 Andoni Morales Alastruey
//
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
using System;
using System.Linq;
using System.Collections.Generic;
using Gtk;
using Gdk;
using LongoMatch.Core.Handlers;
using LongoMatch.Core.Interfaces.Multimedia;
using LongoMatch.Core.Store;
using LongoMatch.Core.Common;
using LongoMatch.Core.Store.Templates;
using Misc = LongoMatch.Gui.Helpers.Misc;
using Mono.Unix;
using LongoMatch.Gui.Helpers;
using LongoMatch.Core.Interfaces.GUI;
using Device = LongoMatch.Core.Common.Device;
using Color = Gdk.Color;
using LongoMatch.Drawing.Widgets;
using LongoMatch.Drawing.Cairo;
using LongoMatch.Gui.Component;

namespace LongoMatch.Gui.Panel
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class NewProjectPanel : Gtk.Bin, IPanel
	{
		public event BackEventHandle BackEvent;

		const int PROJECT_TYPE = 0;
		const int PROJECT_DETAILS = 1;
		const int PROJECT_PERIODS = 2;
		Project project;
		ProjectType projectType;
		CaptureSettings captureSettings;
		EncodingSettings encSettings;
		List<Device> videoDevices;
		ListStore teams, videoStandardList, encProfileList, qualList;
		IMultimediaToolkit mtoolkit;
		IGUIToolkit gtoolkit;
		Color red;
		TeamTemplate hometemplate, awaytemplate;
		Dashboard analysisTemplate;
		TeamTagger teamtagger;

		public NewProjectPanel (Project project)
		{
			this.Build ();
			this.mtoolkit = Config.MultimediaToolkit;
			this.gtoolkit = Config.GUIToolkit;
			capturemediafilechooser.FileChooserMode = FileChooserMode.File;
			notebook1.ShowTabs = false;
			notebook1.ShowBorder = false;
			
			
			panelheader1.ApplyClicked += HandleNextClicked;
			panelheader1.BackClicked += HandleBackClicked;
			LoadIcons ();
			ConnectSignals ();
			FillCategories ();
			FillFormats ();
			FillDevices (mtoolkit.VideoDevices);
			LoadTeams ();
			if (project == null) {
				notebook1.Page = 0;
				datepicker1.Date = DateTime.Now;
				mediafilesetselection1.FileSet = new MediaFileSet ();
			} else {
				notebook1.Page = 1;
				this.project = project;
				projectType = ProjectType.EditProject;
				FillProjectDetails ();
			}
			UpdateTitle ();
			Color.Parse ("red", ref red);
			outputfilelabel.ModifyFg (StateType.Normal, red);
			Color.Parse ("red", ref red);
			urilabel.ModifyFg (StateType.Normal, red);
			Color.Parse ("red", ref red);
			ApplyStyle ();
		}

		protected override void OnDestroyed ()
		{
			teamtagger.Dispose ();
			projectperiods1.Destroy ();
			base.OnDestroyed ();
		}

		void ApplyStyle ()
		{
			/* Keep the central box aligned in the center of the widget */
			SizeGroup grp = new  SizeGroup (SizeGroupMode.Horizontal);
			grp.AddWidget (lefttable);
			grp.AddWidget (righttable);
			
			centerbox.WidthRequest = StyleConf.NewTeamsComboWidth * 2 + StyleConf.NewTeamsSpacing;
			notebook1.BorderWidth = StyleConf.NewHeaderSpacing;
			lefttable.RowSpacing = outputfiletable.RowSpacing =
				righttable.RowSpacing = StyleConf.NewTableHSpacing;
			lefttable.ColumnSpacing = righttable.ColumnSpacing = StyleConf.NewTableHSpacing;
			outputfiletable.ColumnSpacing = StyleConf.NewTeamsSpacing; 
			vsimage.WidthRequest = StyleConf.NewTeamsSpacing;
			hometeamscombobox.WidthRequest = awayteamscombobox.WidthRequest = StyleConf.NewTeamsComboWidth;
			hometeamscombobox.HeightRequest = awayteamscombobox.HeightRequest = StyleConf.NewTeamsComboHeight;
		}

		void LoadIcons ()
		{
			int s = StyleConf.ProjectTypeIconSize;
			IconLookupFlags f = IconLookupFlags.ForceSvg;
 
			fileimage.Pixbuf = Helpers.Misc.LoadIcon ("longomatch-video-file", s, f);
			captureimage.Pixbuf = Helpers.Misc.LoadIcon ("longomatch-video-device", s, f);
			fakeimage.Pixbuf = Helpers.Misc.LoadIcon ("longomatch-video-device-fake", s, f);
			ipimage.Pixbuf = Helpers.Misc.LoadIcon ("longomatch-video-device-ip", s, f);
			vsimage.Pixbuf = Helpers.Misc.LoadIcon ("longomatch-vs", 50, f);

			filebutton.Clicked += HandleProjectTypeSet;
			capturebutton.Clicked += HandleProjectTypeSet;
			fakebutton.Clicked += HandleProjectTypeSet;
			ipbutton.Clicked += HandleProjectTypeSet;
		}

		void LoadTeams ()
		{
			List<TeamTemplate> teams;
			
			drawingarea.HeightRequest = 200;
			teamtagger = new TeamTagger (new WidgetWrapper (drawingarea));
			teamtagger.ShowMenuEvent += HandleShowMenuEvent;
			teamtagger.SubstitutionMode = true;
			teamtagger.ShowSubstitutionButtons = false;
			teamtagger.PlayersSubstitutionEvent += HandlePlayersSubstitutionEvent;
			teams = Config.TeamTemplatesProvider.Templates;
			hometeamscombobox.Load (teams);
			hometeamscombobox.Changed += (sender, e) => {
				LoadTemplate (hometeamscombobox.ActiveTeam, Team.LOCAL);};
			awayteamscombobox.Load (teams);
			awayteamscombobox.Changed += (sender, e) => {
				LoadTemplate (awayteamscombobox.ActiveTeam, Team.VISITOR);};
			hometeamscombobox.Active = 0;
			awayteamscombobox.Active = 0;
		}

		void ConnectSignals ()
		{
			urientry.Changed += HandleEntryChanged;
			tagscombobox.Changed += HandleSportsTemplateChanged;
		}

		void FillProjectDetails ()
		{
			seasonentry.Text = project.Description.Season;
			competitionentry.Text = project.Description.Competition;
			datelabel2.Text = project.Description.MatchDate.ToShortDateString ();
			datepicker1.Date = project.Description.MatchDate;
			hometeamscombobox.Sensitive = false;
			awayteamscombobox.Sensitive = false;
			tagscombobox.Visible = false;
			analysislabel.Visible = false;
			analysisTemplate = project.Dashboard;
			LoadTemplate (project.LocalTeamTemplate, Team.LOCAL);
			LoadTemplate (project.VisitorTeamTemplate, Team.VISITOR);
			mediafilesetselection1.Visible = true;
			mediafilesetselection1.FileSet = project.Description.FileSet;
		}

		void FillCategories ()
		{
			int i = 0;
			int index = 0;

			foreach (string template in Config.CategoriesTemplatesProvider.TemplatesNames) {
				tagscombobox.AppendText (template);
				if (template == Config.DefaultTemplate)
					index = i;
				i++;
			}
			tagscombobox.Active = index;
		}

		void SetProjectType ()
		{
			bool filemode = false, urimode = false, capturemode = false;
			
			if (projectType == ProjectType.FileProject) {
				filemode = true;
			} else if (projectType == ProjectType.CaptureProject) {
				capturemode = true;
			} else if (projectType == ProjectType.URICaptureProject) {
				urimode = true;
			}
			mediafilesetselection1.Visible = filemode;
			outputfiletable.Visible = capturemode || urimode;
			rcapturetable.Visible = capturemode || urimode;
			lcapturetable.Visible = capturemode || urimode;
			urientry.Visible = urimode;
			urilabel.Visible = urimode;
			device.Visible = capturemode;
			devicecombobox.Visible = capturemode;
		}

		void FillFormats ()
		{
			videoStandardList = Misc.FillImageFormat (imagecombobox, Config.CaptureVideoStandard);
			encProfileList = Misc.FillEncodingFormat (encodingcombobox, Config.CaptureEncodingProfile);
			qualList = Misc.FillQuality (qualitycombobox, Config.CaptureEncodingQuality);
		}

		public void FillDevices (List<Device> devices)
		{
			videoDevices = devices;

			foreach (Device device in devices) {
				string deviceElement, deviceName;

				if (Environment.OSVersion.Platform == PlatformID.Win32NT) {
					deviceElement = Catalog.GetString ("DirectShow source");
				} else {
					if (device.DeviceType == CaptureSourceType.DV)
						deviceElement = Catalog.GetString (Catalog.GetString ("DV source"));
					else if (device.DeviceType == CaptureSourceType.System) {
						deviceElement = Catalog.GetString (Catalog.GetString ("System source"));
					} else {
						deviceElement = Catalog.GetString (Catalog.GetString ("GConf source"));
					}
				}
				deviceName = (device.ID == "") ? Catalog.GetString ("Unknown") : device.ID;
				devicecombobox.AppendText (deviceName + " (" + deviceElement + ")");
				devicecombobox.Active = 0;
			}
		}

		void LoadTemplate (string name, Team team)
		{
			TeamTemplate template;
			if (name != null) {
				template = Config.TeamTemplatesProvider.Load (name);
				LoadTemplate (template, team);
			}
		}

		void LoadTemplate (TeamTemplate template, Team team)
		{
			if (team == Team.LOCAL) {
				hometemplate = Cloner.Clone (template);
			} else {
				awaytemplate = Cloner.Clone (template);
			}
			teamtagger.LoadTeams (hometemplate, awaytemplate,
			                      analysisTemplate.FieldBackground);
		}

		void UpdateTitle ()
		{
			if (notebook1.Page == 0) {
				panelheader1.Title = "PROJECT TYPE";
			} else if (notebook1.Page == 1) {
				panelheader1.Title = "PROJECT PROPERTIES";
			} else if (notebook1.Page == 2) {
				panelheader1.Title = "PERIODS SYNCHRONIZATION";
			}
		}

		bool CreateProject ()
		{
			TreeIter iter;
			MediaFile file;
			
			if (projectType == ProjectType.FileProject ||
				projectType == ProjectType.EditProject) {
				if (mediafilesetselection1.FileSet.GetAngle (MediaFileAngle.Angle1) == null) {
					gtoolkit.WarningMessage (Catalog.GetString ("You need at least 1 video file for the main angle"));
					return false;
				}
			}

			if (project != null) {
				return true;
			}
			
			if (projectType == ProjectType.CaptureProject ||
				projectType == ProjectType.URICaptureProject) {
				if (String.IsNullOrEmpty (capturemediafilechooser.CurrentPath)) {
					gtoolkit.WarningMessage (Catalog.GetString ("No output video file"));
					return false;
				}
			}
			if (projectType == ProjectType.URICaptureProject) {
				if (urientry.Text == "") {
					gtoolkit.WarningMessage (Catalog.GetString ("No input URI"));
					return false;
				}
			}
			project = new Project ();
			project.Dashboard = analysisTemplate;
			project.LocalTeamTemplate = hometemplate;
			project.VisitorTeamTemplate = awaytemplate;
			project.Description = new ProjectDescription ();
			project.Description.Competition = competitionentry.Text;
			project.Description.MatchDate = datepicker1.Date;
			project.Description.Season = seasonentry.Text;
			project.Description.LocalName = project.LocalTeamTemplate.TeamName;
			project.Description.VisitorName = project.VisitorTeamTemplate.TeamName;
			project.Description.FileSet = mediafilesetselection1.FileSet;
			project.UpdateEventTypesAndTimers ();
			
			encSettings = new EncodingSettings ();
			captureSettings = new CaptureSettings ();
				
			encSettings.OutputFile = capturemediafilechooser.CurrentPath;
			
			/* Get quality info */
			qualitycombobox.GetActiveIter (out iter);
			encSettings.EncodingQuality = (EncodingQuality)qualList.GetValue (iter, 1);
			
			/* Get size info */
			imagecombobox.GetActiveIter (out iter);
			encSettings.VideoStandard = (VideoStandard)videoStandardList.GetValue (iter, 1);
			
			/* Get encoding profile info */
			encodingcombobox.GetActiveIter (out iter);
			encSettings.EncodingProfile = (EncodingProfile)encProfileList.GetValue (iter, 1);
			
			encSettings.Framerate_n = Config.FPS_N;
			encSettings.Framerate_d = Config.FPS_D;
			
			captureSettings.EncodingSettings = encSettings;

			file = project.Description.FileSet.GetAngle (MediaFileAngle.Angle1); 
			if (file == null) {
				file = new MediaFile ();
				file.FilePath = capturemediafilechooser.CurrentPath;
				file.Fps = (ushort)(Config.FPS_N / Config.FPS_D);
				file.Par = 1;
				project.Description.FileSet.SetAngle (MediaFileAngle.Angle1, file);
			}
			
			if (projectType == ProjectType.CaptureProject) {
				Device device = videoDevices [devicecombobox.Active];
				captureSettings.CaptureSourceType = device.DeviceType;
				captureSettings.DeviceID = device.ID;
				captureSettings.SourceElement = device.SourceElement;
				file.VideoHeight = encSettings.VideoStandard.Height;
				file.VideoWidth = encSettings.VideoStandard.Width;
			} else if (projectType == ProjectType.URICaptureProject) {
				captureSettings.CaptureSourceType = CaptureSourceType.URI;
				captureSettings.DeviceID = urientry.Text;
				file.VideoHeight = encSettings.VideoStandard.Height;
				file.VideoWidth = encSettings.VideoStandard.Width;
			} else if (projectType == ProjectType.FakeCaptureProject) {
				captureSettings.CaptureSourceType = CaptureSourceType.None;
				file.FilePath = Constants.FAKE_PROJECT;
			}
			return true;
		}
		
		void StartProject ()
		{
			if (CreateProject ()) {
				if (projectType == ProjectType.EditProject) {
					projectType = ProjectType.FileProject;
				} else {
					project.CreateLineupEvent ();
				}
				Config.EventsBroker.EmitOpenNewProject (project, projectType, captureSettings);
			}
		}

		void HandleEntryChanged (object sender, EventArgs e)
		{
			if (urientry.Text != "") {
				urilabel.ModifyFg (StateType.Normal);
			} else {
				urilabel.ModifyFg (StateType.Normal, red);
			}
			if (String.IsNullOrEmpty (capturemediafilechooser.CurrentPath)) {
				outputfilelabel.ModifyFg (StateType.Normal);
			} else {
				outputfilelabel.ModifyFg (StateType.Normal, red);
			}
			QueueDraw ();
		}

		void HandleSportsTemplateChanged (object sender, EventArgs e)
		{
			analysisTemplate = Config.CategoriesTemplatesProvider.Load (tagscombobox.ActiveText);
			if (teamtagger != null) {
				teamtagger.LoadTeams (hometemplate, awaytemplate, analysisTemplate.FieldBackground);
			}
		}

		void HandleProjectTypeSet (object sender, EventArgs e)
		{
			if (sender == filebutton) {
				projectType = ProjectType.FileProject;
			} else if (sender == capturebutton) {
				projectType = ProjectType.CaptureProject;
			} else if (sender == fakebutton) {
				projectType = ProjectType.FakeCaptureProject;
			} else if (sender == ipbutton) {
				projectType = ProjectType.URICaptureProject;
			}
			HandleNextClicked (this, e);
		}

		void HandleBackClicked (object sender, EventArgs e)
		{
			if (notebook1.Page == PROJECT_TYPE) {
				if (BackEvent != null) {
					BackEvent ();
				}
			} else {
				notebook1.Page --;
			}
			if (notebook1.Page == PROJECT_TYPE) {
				project = null;
			}
			UpdateTitle ();
		}

		void HandleNextClicked (object sender, EventArgs e)
		{
			if (notebook1.Page == PROJECT_TYPE) {
				SetProjectType ();	
			}
			if (notebook1.Page == PROJECT_DETAILS) {
				if (!CreateProject ()) {
					return;
				}
				if (projectType == ProjectType.CaptureProject ||
				    projectType == ProjectType.FakeCaptureProject ||
				    projectType == ProjectType.URICaptureProject) {
				    project.CreateLineupEvent ();
					Config.EventsBroker.EmitOpenNewProject (project, projectType, captureSettings);
					return;
				}
			} else if (notebook1.Page == PROJECT_PERIODS) {
				StartProject ();
				return;
			}

			notebook1.Page ++;

			panelheader1.ApplyVisible = notebook1.Page != PROJECT_TYPE;

			if (notebook1.Page == PROJECT_PERIODS) {
				projectperiods1.Project = project;
			}
			UpdateTitle ();
		}

		void HandleShowMenuEvent (List<Player> players)
		{
			Menu menu = new Menu ();
			MenuItem item = new MenuItem ("Remove for this match");
			item.Activated += (sender, e) => {
					hometemplate.RemovePlayers (players, false);
					awaytemplate.RemovePlayers (players, false);
					teamtagger.Reload ();
			};
			menu.Add (item);
			menu.ShowAll ();
			menu.Popup ();
		}
		
		void HandlePlayersSubstitutionEvent (TeamTemplate team, Player p1, Player p2,
		                                     SubstitutionReason reason, Time time)
		{
			team.List.Swap (p1, p2);
			teamtagger.Substitute (p1, p2, team);
		}
		
	}
}

