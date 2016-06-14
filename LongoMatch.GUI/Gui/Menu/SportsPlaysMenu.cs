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
using System.Collections.Generic;
using System.Linq;
using Gtk;
using LongoMatch.Core.Store;
using VAS;
using VAS.Core;
using VAS.Core.Common;
using VAS.Core.Interfaces;
using VAS.Core.Store;
using VAS.Core.Store.Playlists;
using VAS.UI.Menus;
using LMCommon = LongoMatch.Core.Common;

namespace LongoMatch.Gui.Menus
{
	public class SportsPlaysMenu : PlaysMenu
	{
		public event EventHandler EditPlayEvent;

		public SportsPlaysMenu ()
		{
			CreateMenu ();
		}

		public void ShowListMenu (ProjectLongoMatch project, List<TimelineEvent> plays)
		{
			ShowMenu (project, plays, null, null, project.EventTypes, true);
		}

		public void ShowMenu (ProjectLongoMatch project, IEnumerable<TimelineEvent> plays)
		{
			ShowMenu (project, plays, null, null, null, false);
		}

		public void ShowTimelineMenu (ProjectLongoMatch project, List<TimelineEvent> plays, EventType eventType, Time time)
		{
			ShowMenu (project, plays, eventType, time, null, false);
		}

		/// <summary>
		/// Fills the menu item "Add to playlist" with all the playlist options
		/// </summary>
		/// <param name="addToPlaylistMenu">Add to playlist menu.</param>
		/// <param name="project">Project.</param>
		/// <param name="events">Timeline events.</param>
		static public void FillAddToPlaylistMenu (MenuItem addToPlaylistMenu, ProjectLongoMatch project, IList<TimelineEventLongoMatch> events)
		{
			if (events.Count == 0) {
				addToPlaylistMenu.Visible = false;
				return;
			}

			addToPlaylistMenu.Visible = true;
			var label = String.Format ("{0} ({1})", Catalog.GetString ("Add to playlist"), events.Count);
			addToPlaylistMenu.SetLabel (label);

			if (project.Playlists != null) {
				Menu plMenu = new Menu ();
				MenuItem item;
				foreach (Playlist pl in project.Playlists) {
					item = new MenuItem (pl.Name);
					plMenu.Append (item);
					item.Activated += (sender, e) => {
						IEnumerable<IPlaylistElement> elements = events.Select (p => new PlaylistPlayElement (p));
						((LMCommon.EventsBroker)App.Current.EventsBroker).EmitAddPlaylistElement (pl, elements.ToList ());
					};
				}
				item = new MenuItem (Catalog.GetString ("Create new playlist..."));
				plMenu.Append (item);
				item.Activated += (sender, e) => {
					IEnumerable<IPlaylistElement> elements = events.Select (p => new PlaylistPlayElement (p));
					((LMCommon.EventsBroker)App.Current.EventsBroker).EmitAddPlaylistElement (null, elements.ToList ());
				};
				plMenu.ShowAll ();
				addToPlaylistMenu.Submenu = plMenu;
			}
		}

		protected override void ShowMenu (Project project, IEnumerable<TimelineEvent> plays, EventType eventType, Time time,
		                                  IList<EventType> eventTypes, bool editableName)
		{
			bool isLineup = false, isSubstitution = false;

			this.plays = plays.ToList ();
			this.eventType = eventType;
			this.time = time;
			this.project = project;

			if (eventType != null) {
				string label = String.Format ("{0} in {1}", Catalog.GetString ("Add new event"), eventType.Name);
				newPlay.SetLabel (label); 
				newPlay.Visible = true;
			} else {
				newPlay.Visible = false;
			}
			
			if (plays == null) {
				plays = new List<TimelineEvent> ();
			} else if (plays.Count () == 1) {
				isLineup = plays.FirstOrDefault () is LineupEvent;
				isSubstitution = plays.FirstOrDefault () is SubstitutionEvent;
			}

			if (isLineup || isSubstitution) {
				edit.Visible = true;
				del.Visible = isSubstitution;
				snapshot.Visible = moveCat.Visible = drawings.Visible =
					addPLN.Visible = render.Visible = duplicate.Visible = false;
			} else {
				edit.Visible = editableName && plays.Count () == 1;
				snapshot.Visible = plays.Count () == 1;
				moveCat.Visible = plays.Count () == 1 && eventTypes != null;
				drawings.Visible = plays.Count () == 1 && plays.FirstOrDefault ().Drawings.Count > 0;
				del.Visible = plays.Count () > 0;
				addPLN.Visible = plays.Count () > 0;
				render.Visible = plays.Count () > 0;
				duplicate.Visible = plays.Count () > 0;
			}

			if (project.ProjectType == ProjectType.FakeCaptureProject) {
				snapshot.Visible = render.Visible = false;
			}

			if (plays.Count () > 0) {
				string label = String.Format ("{0} ({1})", Catalog.GetString ("Delete"), plays.Count ());
				del.SetLabel (label);
				label = String.Format ("{0} ({1})", Catalog.GetString ("Export to video file"), plays.Count ());
				render.SetLabel (label);
				label = String.Format ("{0} ({1})", Catalog.GetString ("Duplicate "), plays.Count ());
				duplicate.SetLabel (label);
			}
			
			if (moveCat.Visible) {
				Menu catMenu = new Menu ();
				foreach (EventType c in eventTypes) {
					if (plays.FirstOrDefault ().EventType == c)
						continue;
					var item = new MenuItem (c.Name);
					catMenu.Append (item);
					item.Activated += (sender, e) => {
						((LMCommon.EventsBroker)App.Current.EventsBroker).EmitMoveToEventType (plays.FirstOrDefault () as TimelineEventLongoMatch, c);
					}; 
				}
				catMenu.ShowAll ();
				moveCat.Submenu = catMenu;
			}
			
			if (drawings.Visible) {
				Menu drawingsMenu = new Menu ();
				for (int i = 0; i < plays.FirstOrDefault ().Drawings.Count; i++) {
					int index = i;
					MenuItem drawingItem = new MenuItem (Catalog.GetString ("Drawing ") + (i + 1));
					MenuItem editItem = new MenuItem (Catalog.GetString ("Edit"));
					MenuItem deleteItem = new MenuItem (Catalog.GetString ("Delete"));
					Menu drawingMenu = new Menu ();

					drawingsMenu.Append (drawingItem);
					drawingMenu.Append (editItem);
					drawingMenu.Append (deleteItem);
					editItem.Activated += (sender, e) => {
						((LMCommon.EventsBroker)App.Current.EventsBroker).EmitDrawFrame (plays.FirstOrDefault (), index,
							plays.FirstOrDefault ().Drawings [index].CameraConfig, false);
					}; 
					deleteItem.Activated += (sender, e) => {
						plays.FirstOrDefault ().Drawings.RemoveAt (index);
						plays.FirstOrDefault ().UpdateMiniature ();
					}; 
					drawingItem.Submenu = drawingMenu;
					drawingMenu.ShowAll ();
				}
				drawingsMenu.ShowAll ();
				drawings.Submenu = drawingsMenu;
			}
			
			FillAddToPlaylistMenu (addPLN, project, this.plays);

			Popup ();
		}

		void CreateMenu ()
		{
			edit = new MenuItem (Catalog.GetString ("Edit properties"));
			edit.Activated += (sender, e) => {
				if (EditPlayEvent != null) {
					EditPlayEvent (this, null);
				}
			};
			Add (edit);

			duplicate = new MenuItem ("");
			duplicate.Activated += (sender, e) => Config.EventsBroker.EmitDuplicateEvent (plays);
			Add (duplicate);

			moveCat = new MenuItem (Catalog.GetString ("Move to"));
			Add (moveCat);

			drawings = new MenuItem (Catalog.GetString ("Drawings"));
			Add (drawings);

			addPLN = new MenuItem ("Add to playlist");
			Add (addPLN);
			
			render = new MenuItem ("");
			render.Activated += (sender, e) => EmitRenderPlaylist (plays);
			Add (render);
			
			snapshot = new MenuItem (Catalog.GetString ("Export to PNG images"));
			snapshot.Activated += (sender, e) => App.Current.EventsBroker.EmitSnapshotSeries (plays.FirstOrDefault ());
			Add (snapshot);

			ShowAll ();
		}

		void HandleNewPlayActivated (object sender, EventArgs e)
		{
			App.Current.EventsBroker.EmitNewEvent (eventType,
				eventTime: time,
				start: time - new Time { TotalSeconds = 10 },
				stop: time + new Time { TotalSeconds = 10 });
		}

		void EmitRenderPlaylist (List<TimelineEvent> plays)
		{
			Playlist pl = new Playlist ();
			foreach (TimelineEvent p in plays) {
				pl.Elements.Add (new PlaylistPlayElement (p));
			}
			App.Current.EventsBroker.EmitRenderPlaylist (pl);
		}
	}
}
