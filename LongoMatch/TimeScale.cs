// TimeScale.cs
//
//  Copyright (C) 2008 Andoni Morales Alastruey
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
using System.Collections.Generic;
using Cairo;
using Gdk;
namespace LongoMatch
{
	
	
	public class TimeScale : Gtk.DrawingArea
	{
		private const int SECTION_HEIGHT = 25;
		private const double ALPHA = 0.6;
		private uint frames;
		private uint pixelRatio=1;
		MediaTimeNode candidateTN;
		private Cairo.Color color;
		private double zoom;
		private List<TimeNode> list;
		private bool candidateStart;
		private bool movingLimit;
		private TimeNode selected=null;
		private uint lastTime=0;
		
		
		public event TimeNodeChangedHandler TimeNodeChanged;
		public event TimeNodeSelectedHandler TimeNodeSelected;
		public event TimeNodeDeletedHandler TimeNodeDeleted;
		public event PlayListNodeAddedHandler PlayListNodeAdded;
		
		public TimeScale(List<TimeNode> list,uint frames,Gdk.Color color)
		{			
			this.frames = frames;	
			this.list = list;				
			this.Size((int)(frames/pixelRatio), SECTION_HEIGHT);
			this.HeightRequest= SECTION_HEIGHT;
			this.WidthRequest = (int)(frames/pixelRatio);		
			this.color = this.RGBToCairoColor(color);
			this.color.A = ALPHA;
			this.Events = EventMask.PointerMotionMask | EventMask.ButtonPressMask | EventMask.ButtonReleaseMask ;
			
		
		}
		
		public uint PixelRatio{
			get {return pixelRatio;}
			set {
				this.pixelRatio = value;
				this.Size((int)(frames/pixelRatio),SECTION_HEIGHT);
				
			}
		}
	
		public TimeNode SelectedTimeNode{
			get{return this.selected;}
			set{this.selected = value;}
		}
		public void ReDraw(){
			Gdk.Region region = this.GdkWindow.ClipRegion;
			this.GdkWindow.InvalidateRegion(region,true);
			this.GdkWindow.ProcessUpdates(true);
		}
			
		private Cairo.Color RGBToCairoColor(Gdk.Color gdkColor){			
		
			return   new Cairo.Color((double)(gdkColor.Red)/ushort.MaxValue,(double)(gdkColor.Green)/ushort.MaxValue,(double)(gdkColor.Blue)/ushort.MaxValue);
		}
		
		private void DrawTimeNodes(Gdk.Window win){
			
			using (Cairo.Context g = Gdk.CairoHelper.Create (win)){	
				int height;
				int width;	
				double[] dashed = new double[2];
				
				win.Resize((int)(frames/pixelRatio), this.Allocation.Height);
				win.GetSize(out width, out height);	
				g.Color = new Cairo.Color(0,0,0);
				g.LineWidth = 1;
				g.MoveTo(new PointD(0,0));
				g.LineTo(new PointD(width,0));
				g.Stroke();	
				g.MoveTo(new PointD(0,height));
				g.LineTo(new PointD(width,height));
				g.Stroke();					
												
				foreach (MediaTimeNode tn in list){					
					g.Operator = Operator.Add;				
					
					g.Rectangle( new Cairo.Rectangle(tn.StartFrame/pixelRatio,3,tn.TotalFrames/pixelRatio,height-6));					
					g.Color = this.color;					
					g.FillPreserve();
					if (tn == this.selected) {						
					
						dashed[0] = 4;
						dashed[1] = 2;
						g.Color = new Cairo.Color (0.5, 0.5 , 0.5, 1);						
					}
					else{
						g.Color = new Cairo.Color (color.R+0.1, color.G+0.1,color.B+0.1, 1);
					}					
					g.LineWidth = 2;
					g.LineJoin = LineJoin.Round;
					g.Stroke();
					dashed[0] = 1;
					dashed[1] = 0;
					g.SetDash(dashed,0);
				}
				
				
			
			}
			
			
		}
		
		protected override bool OnExposeEvent (EventExpose evnt)
		{			
			
			this.DrawTimeNodes(evnt.Window);
			return base.OnExposeEvent (evnt);			
		}
		
		protected override bool OnMotionNotifyEvent (EventMotion evnt)
		{
			
			if (this.movingLimit){
				
				uint pos = (uint) (evnt.X*pixelRatio);
				if (this.candidateStart && pos  > 0 && pos < this.candidateTN.StopFrame-10){
					this.candidateTN.StartFrame = pos;					
					if (this.TimeNodeChanged != null)
						this.TimeNodeChanged(this.candidateTN,this.candidateTN.Start);
				}
				else if (!this.candidateStart && pos < this.frames && pos > this.candidateTN.StartFrame+10){
					this.candidateTN.StopFrame = pos;					
					if (this.TimeNodeChanged != null)
						this.TimeNodeChanged(this.candidateTN,this.candidateTN.Stop);
				}
				Gdk.Region region = this.GdkWindow.ClipRegion;
					this.GdkWindow.InvalidateRegion(region,true);
					this.GdkWindow.ProcessUpdates(true);
							
			
			}
			return base.OnMotionNotifyEvent (evnt);
		}
		
		protected override bool OnButtonPressEvent (EventButton evnt)
		{
			
			
			if (evnt.Button == 1){
				if (this.lastTime != evnt.Time){
					candidateTN = null;
					foreach (MediaTimeNode tn in list){	
						int pos = (int) (evnt.X*pixelRatio);
						if (Math.Abs(pos-tn.StopFrame) < 3*pixelRatio ){
							this.candidateStart = false;
							candidateTN = tn;
							this.movingLimit = true;
							this.TimeNodeChanged(tn,tn.Start);
							this.ReDraw();
							break;
						}
						else if (Math.Abs(pos-tn.StartFrame) < 3*pixelRatio){
							this.candidateStart =true;
							candidateTN = tn;
							this.movingLimit = true;
							this.TimeNodeChanged(tn,tn.Stop);
							this.ReDraw();
							break;
						}			
					}
				}
				//On Double Click
				else {
					foreach (MediaTimeNode tn in list){
						int pos = (int) (evnt.X*pixelRatio);
						if (this.TimeNodeSelected!= null && tn.HasFrame(pos) ){							
							TimeNodeSelected(tn);
							break;
						}
					}
					
				}
			}
			this.lastTime = evnt.Time;
			return base.OnButtonPressEvent (evnt);
	}
		
		protected override bool OnButtonReleaseEvent (EventButton evnt)
		{
			if (this.movingLimit){
				this.movingLimit = false;
				candidateTN.Selected = false;
				this.ReDraw();
			}
			return base.OnButtonReleaseEvent (evnt);
		}	
	}
}
