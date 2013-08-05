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
using System;
using Gtk;
using LongoMatch.Stats;
using System.Collections.Generic;
using LongoMatch.Common;

namespace LongoMatch.Gui.Component.Stats
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class CategoryViewer : Gtk.Bin
	{
		List<SubCategoryViewer> subcatViewers;
		
		public CategoryViewer ()
		{
			this.Build ();
		}
		
		public void LoadStats (CategoryStats stats) {
			alltagger.LoadBackgrounds (stats.Field, stats.HalfField, stats.Goal);
			alltagger.LoadFieldCoordinates (stats.FieldCoordinates);
			alltagger.LoadHalfFieldCoordinates (stats.HalfFieldCoordinates);
			alltagger.LoadGoalCoordinates (stats.GoalCoordinates);
			alltagger.CoordinatesSensitive = false;
			allframe.Visible = stats.FieldCoordinates.Count + stats.HalfFieldCoordinates.Count +
			    stats.GoalCoordinates.Count != 0;
			    
			hometagger.LoadBackgrounds (stats.Field, stats.HalfField, stats.Goal);
			hometagger.LoadFieldCoordinates (stats.HomeFieldCoordinates);
			hometagger.LoadHalfFieldCoordinates (stats.HomeHalfFieldCoordinates);
			hometagger.LoadGoalCoordinates (stats.HomeGoalCoordinates);
			hometagger.CoordinatesSensitive = false;
			homeframe.Visible = stats.HomeFieldCoordinates.Count + stats.HomeHalfFieldCoordinates.Count +
			    stats.HomeGoalCoordinates.Count != 0;
			    
			awaytagger.LoadBackgrounds (stats.Field, stats.HalfField, stats.Goal);
			awaytagger.LoadFieldCoordinates (stats.AwayFieldCoordinates);
			awaytagger.LoadHalfFieldCoordinates (stats.AwayHalfFieldCoordinates);
			awaytagger.LoadGoalCoordinates (stats.AwayGoalCoordinates);
			awaytagger.CoordinatesSensitive = false;
			awayframe.Visible = stats.AwayFieldCoordinates.Count + stats.AwayHalfFieldCoordinates.Count +
			    stats.AwayGoalCoordinates.Count != 0;
			
			foreach (Widget child in vbox1.AllChildren) {
				if (child is SubCategoryViewer || child is HSeparator)
					vbox1.Remove (child);
			}
			subcatViewers = new List<SubCategoryViewer>();
			foreach (SubCategoryStat st in stats.SubcategoriesStats) {
				SubCategoryViewer subcatviewer = new SubCategoryViewer();
				subcatviewer.LoadStats (st);
				subcatViewers.Add (subcatviewer);
				vbox1.PackStart (subcatviewer);
				vbox1.PackStart (new HSeparator());
				subcatviewer.Show ();
			}
		}
	}
}

