//
//  Copyright (C) 2013 Andoni Morales Alastruey
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
using System.Collections.Generic;
using System.Linq;
using LongoMatch.Core.Common;
using LongoMatch.Core.Interfaces.GUI;
using LongoMatch.Core.Store;
using VAS.Core.Common;
using VAS.Core.Events;
using VAS.Core.Filters;
using VAS.Core.Hotkeys;
using VAS.Core.Interfaces;
using VAS.Core.Interfaces.GUI;
using VAS.Core.Store;
using VAS.Services.ViewModel;
using VAS.UI.Helpers;
using Constants = LongoMatch.Core.Common.Constants;
using LMFilters = LongoMatch.Core.Filters;

namespace LongoMatch.Gui.Component
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class AnalysisComponent : Gtk.Bin, IAnalysisWindow
	{
		static ProjectLongoMatch openedProject;
		ProjectType projectType;
		LMFilters.EventsFilter filter;
		bool detachedPlayer;
		Gtk.Window playerWindow;

		public AnalysisComponent ()
		{
			this.Build ();
			projectType = ProjectType.None;
			detachedPlayer = false;
			//FIXME: Just a Temporal fix, until AnalysisComponent and codingwidget uses the playerVM.
			playercapturer.SetViewModel (new VideoPlayerVM ());
			codingwidget.Player = playercapturer.ViewModel.Player;
			App.Current.EventsBroker.Subscribe<EventCreatedEvent> (HandleEventCreated);
			App.Current.EventsBroker.Subscribe<EventsDeletedEvent> (HandleEventsDeleted);
		}

		#region IAnalysisWindow implementation

		public event VAS.Core.Handlers.BackEventHandle BackEvent;

		public void OnLoad ()
		{
		}

		public void OnUnload ()
		{
		}

		public string Title {
			get {
				return openedProject?.ShortDescription;
			}
		}

		//FIXME: add IPanel KeyContext using MMVMC pattern
		public KeyContext GetKeyContext ()
		{
			return new KeyContext ();
		}

		public void SetViewModel (object viewModel)
		{
			throw new System.NotImplementedException ();
		}

		#endregion

		protected override void OnUnmapped ()
		{
			base.OnUnmapped ();
			// When a container widget is unmapped there are 2 options, either it has a window and it hides it,
			// or it just unmaps all children. In our case we are use an event box with its own window for theming.
			// Unmapping this child will just hide its window and won't unmap the children below such as as the 
			// player view and the video window. This can be a problem as this widget will never detect that it has been 
			// hidden and on windows the actual gdkwindow will be hidden and won't be shown again. So we make sure to
			// proxy the unmap to the children below the eventbox.
			centralpane.Unmap ();
		}

		protected override void OnDestroyed ()
		{
			if (detachedPlayer) {
				playerWindow.Destroy ();
				detachedPlayer = false;
			}
			App.Current.EventsBroker.Unsubscribe<EventCreatedEvent> (HandleEventCreated);
			App.Current.EventsBroker.Unsubscribe<EventsDeletedEvent> (HandleEventsDeleted);
			playercapturer.Destroy ();
			base.OnDestroyed ();
		}

		public override void Destroy ()
		{
			if (detachedPlayer) {
				DetachPlayer ();
			}
			base.Destroy ();
		}

		public IVideoPlayerController Player {
			get {
				//FIXME: Just a Temporal fix, until AnalysisComponent uses the playerVM.
				return playercapturer.ViewModel.Player;
			}
		}

		public ICapturerBin Capturer {
			get {
				return playercapturer.Capturer;
			}
		}

		public void UpdateCategories ()
		{
			codingwidget.UpdateCategories ();
		}

		public void ZoomIn ()
		{
			codingwidget.ZoomIn ();
		}

		public void ZoomOut ()
		{
			codingwidget.ZoomOut ();
		}

		public void FitTimeline ()
		{
			codingwidget.FitTimeline ();
		}

		public void ShowDashboard ()
		{
			codingwidget.ShowDashboard ();
		}

		public void ShowTimeline ()
		{
			codingwidget.ShowTimeline ();
		}

		public void ShowZonalTags ()
		{
			codingwidget.ShowZonalTags ();
		}

		public void ClickButton (DashboardButton button, Tag tag = null)
		{
			codingwidget.ClickButton (button, tag);
		}

		public void TagPlayer (Player player)
		{
			codingwidget.TagPlayer ((PlayerLongoMatch)player);
		}

		public void TagTeam (TeamType team)
		{
			codingwidget.TagTeam (team);
		}

		public void DetachPlayer ()
		{
			bool isPlaying = Player.Playing;

			/* Pause the player here to prevent the sink drawing while the windows
			 * are beeing changed */
			Player.Pause ();
			if (!detachedPlayer) {
				Log.Debug ("Detaching player");

				ExternalWindow playerWindow = new ExternalWindow ();
				this.playerWindow = playerWindow;
				playerWindow.Title = Constants.SOFTWARE_NAME;
				int player_width = playercapturer.Allocation.Width;
				int player_height = playercapturer.Allocation.Height;
				playerWindow.SetDefaultSize (player_width, player_height);
				playerWindow.DeleteEvent += (o, args) => DetachPlayer ();
				playerWindow.Show ();
				playercapturer.Reparent (playerWindow.Box);
				// Hack to reposition video window in widget for OSX
				playerWindow.Resize (player_width + 10, player_height);
				videowidgetsbox.Visible = false;
				playsSelection.ExpandTabs = true;
			} else {
				Log.Debug ("Attaching player again");
				videowidgetsbox.Visible = true;
				playercapturer.Reparent (this.videowidgetsbox);
				playerWindow.Destroy ();
				playsSelection.ExpandTabs = false;
			}
			if (isPlaying) {
				Player.Play ();
			}
			detachedPlayer = !detachedPlayer;
			playercapturer.AttachPlayer (detachedPlayer);
		}

		public void CloseOpenedProject ()
		{
			openedProject = null;
			projectType = ProjectType.None;
			if (detachedPlayer)
				DetachPlayer ();
		}

		public void SetProject (Project project, ProjectType projectType, CaptureSettings props, EventsFilter filter)
		{
			openedProject = project as ProjectLongoMatch;
			this.projectType = projectType;
			this.filter = (LMFilters.EventsFilter)filter;

			codingwidget.SetProject (project as ProjectLongoMatch, projectType, (LMFilters.EventsFilter)filter);
			playsSelection.SetProject (project as ProjectLongoMatch, (LMFilters.EventsFilter)filter);
			if (projectType == ProjectType.FileProject) {
				playercapturer.Mode = PlayerViewOperationMode.Analysis;
			} else {
				playercapturer.Mode = playercapturer.Mode = PlayerViewOperationMode.LiveAnalysisReview;
				Capturer.PeriodsNames = project.Dashboard.GamePeriods.ToList ();
				Capturer.Periods = project.Periods.ToList ();
			}
		}

		public void ReloadProject ()
		{
			codingwidget.SetProject (openedProject, projectType, filter);
			playsSelection.SetProject (openedProject, filter);
		}

		void HandleEventCreated (EventCreatedEvent e)
		{
			playsSelection.AddPlay ((TimelineEventLongoMatch)e.TimelineEvent);
			codingwidget.AddPlay ((TimelineEventLongoMatch)e.TimelineEvent);
		}

		void HandleEventsDeleted (EventsDeletedEvent e)
		{
			playsSelection.RemovePlays (e.TimelineEvents.Cast<TimelineEventLongoMatch> ().ToList ());
			codingwidget.DeletePlays (e.TimelineEvents.Cast<TimelineEventLongoMatch> ().ToList ());
		}
	}
}
