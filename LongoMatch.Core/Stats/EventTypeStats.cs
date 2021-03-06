// 
//  Copyright (C) 2012 Andoni Morales Alastruey
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
using LongoMatch.Core.Filters;
using LongoMatch.Core.Store;
using VAS.Core.Common;
using VAS.Core.Store;

namespace LongoMatch.Core.Stats
{
	public class EventTypeStats: Stat
	{
		List<LMTimelineEvent> events, homeEvents, awayEvents;
		EventType eventType;
		LMProject project;
		EventsFilter filter;

		public EventTypeStats (LMProject project, EventsFilter filter, EventType evType)
		{
			Name = evType.Name;
			events = new List<LMTimelineEvent> ();
			this.project = project;
			this.filter = filter;
			this.eventType = evType;
		}

		public void Update ()
		{
			List<TimelineEvent> originalEventsByType = project.EventsByType (eventType);
			var eventsByType = new List<LMTimelineEvent> ();
			foreach (var eventType in originalEventsByType) {
				eventsByType.Add (eventType as LMTimelineEvent);
			}
			events = eventsByType.Where (filter.IsVisible).ToList ();
			homeEvents = events.Where (e => e.Teams.Contains (project.LocalTeamTemplate) ||
			e.Players.Intersect (project.LocalTeamTemplate.List).Any ()).ToList ();
			awayEvents = events.Where (e => e.Teams.Contains (project.VisitorTeamTemplate) ||
			e.Players.Intersect (project.VisitorTeamTemplate.List).Any ()).ToList ();
			TotalCount = events.Count;
			LocalTeamCount = homeEvents.Count;
			VisitorTeamCount = awayEvents.Count;
			SubcategoriesStats = new List<SubCategoryStat> ();
			if (eventType is AnalysisEventType) {
				CreateGroupStats ((eventType as AnalysisEventType).TagsByGroup);
				CreateGroupStats (project.Dashboard.CommonTagsByGroup, false);
			}
		}

		public List<SubCategoryStat> SubcategoriesStats {
			get;
			protected set;
		}

		public EventType Category {
			get {
				return eventType;
			}
		}

		public bool HasPositionTags (TeamType team)
		{
			List<LMTimelineEvent> evts = EventsForTeam (team);
			return evts.Count (e => e.FieldPosition != null || e.HalfFieldPosition != null || e.GoalPosition != null) != 0; 
		}

		public List<Coordinates> GetFieldCoordinates (TeamType team, FieldPositionType pos)
		{
			List<LMTimelineEvent> evts = EventsForTeam (team);
			
			switch (pos) {
			case FieldPositionType.Field:
				return evts.Where (e => e.FieldPosition != null).Select (e => e.FieldPosition).ToList ();
			case FieldPositionType.HalfField:
				return evts.Where (e => e.HalfFieldPosition != null).Select (e => e.HalfFieldPosition).ToList ();
			default:
				return evts.Where (e => e.GoalPosition != null).Select (e => e.GoalPosition).ToList ();
			}
		}

		List<LMTimelineEvent> EventsForTeam (TeamType team)
		{
			List<LMTimelineEvent> evts;
			
			switch (team) {
			case TeamType.LOCAL:
				evts = homeEvents;
				break;
			case TeamType.VISITOR:
				evts = awayEvents;
				break;
			default:
				evts = events;
				break;
			}
			return evts;
		}

		void CreateGroupStats (Dictionary<string, List<Tag>> tagsByGroup, bool forceInclude = true)
		{
			foreach (string grp in tagsByGroup.Keys) {
				bool hasData = false;
				SubCategoryStat substat = new SubCategoryStat (grp);
				foreach (Tag t in tagsByGroup [grp]) {
					int count, localTeamCount, visitorTeamCount;
					count = events.Count (e => e.Tags.Contains (t));
					localTeamCount = homeEvents.Count (e => e.Tags.Contains (t));
					visitorTeamCount = awayEvents.Count (e => e.Tags.Contains (t));
					PercentualStat pStat = new PercentualStat (t.Value, count, localTeamCount, visitorTeamCount, TotalCount);
					substat.OptionStats.Add (pStat);
					hasData |= count > 0;
				}
				if (forceInclude || hasData)
					SubcategoriesStats.Add (substat);
			}
		}
	}
}

