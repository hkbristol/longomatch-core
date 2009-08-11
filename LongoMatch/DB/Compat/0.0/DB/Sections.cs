// Sections.cs
//
//  Copyright (C) 2007 Andoni Morales Alastruey
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
//
//
using System;
using Gdk;
using LongoMatch.DB.Compat.v00.TimeNodes;

namespace LongoMatch.DB.Compat.v00.DB
{
	
	
	public class Sections
	{
		private SectionsTimeNode[] timeNodesArray;
		private Color[] colorsArray;
		private int visibleSections;
		private int totalSections;
		
		
		public Sections(int sections)
		{
			this.timeNodesArray = new SectionsTimeNode[sections];
			this.colorsArray = new Color[sections];
			this.totalSections = sections;
			this.visibleSections = sections;
			for (int i=0;i<20;i++){
				colorsArray[i] = new Color(254,0,0);
				timeNodesArray[i] = null;
			}
			
		}

		public int VisibleSections {
			
			set{
				if (value > this.totalSections ||value < 0 )
					return;
				else
					this.visibleSections = value;
			}
			get{
				return this.visibleSections;
			}
					
		}
		
		
		public void SetTimeNodes(string[] names, Time[] startTimes, Time[] stopTimes,bool[] visible){
			for (int i=0;i<20;i++){
				timeNodesArray[i] = new SectionsTimeNode(names[i],startTimes[i],stopTimes[i],visible[i]);
				
				
			}
			
		}
		
		public Color[] Colors{
			
			set{this.colorsArray = value;}
			get{return this.colorsArray;}			
		}		
	
		
		public SectionsTimeNode[] SectionsTimeNodes{
			set{this.timeNodesArray = value;}
			get{return timeNodesArray;}
		}
		
		public string[] GetSectionsNames(){
			string[] names = new string[totalSections];
			SectionsTimeNode tNode;
			for (int i=0; i<totalSections; i++){
				tNode = timeNodesArray[i];
				names[i]=tNode.Name;
			}
			return names;
		
		}
		
		public Time[] GetSectionsStartTimes(){
			Time[] startTimes = new Time[totalSections];
			SectionsTimeNode tNode;
			for (int i=0; i<totalSections; i++){
				tNode = timeNodesArray[i];
				startTimes[i]=tNode.Start;
			}
			return startTimes;
		}
		
		public Time[] GetSectionsStopTimes(){
			Time[] stopTimes = new Time[totalSections];
			SectionsTimeNode tNode;
			for (int i=0; i<totalSections; i++){
				tNode = timeNodesArray[i];
				stopTimes[i]=tNode.Start;
			}
			return stopTimes;
			
		}
		
		public bool[] GetSectionsVisibility(){
			bool[] visibility = new bool[20];
			SectionsTimeNode tNode;
			for (int i=0; i<totalSections; i++){
				tNode = timeNodesArray[i];
				visibility[i]=tNode.Visible;
			}
			return visibility;
		}
		
		public SectionsTimeNode GetTimeNode (int section){
			return timeNodesArray[section];
		}
		
		public string GetName ( int section){
			return timeNodesArray[section].Name;
		}
		
		public Time GetStartTime ( int section){
			return this.timeNodesArray[section].Start;
		}
		
		public Time GetStopTime ( int section){
			return this.timeNodesArray[section].Stop;
		}
		
		public bool GetVisibility (int section){
			return this.timeNodesArray[section].Visible;
		}
		public Color GetColor (int section){
			return this.colorsArray[section];
		}
	}
}
