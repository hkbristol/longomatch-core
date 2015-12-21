
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class Timeline
	{
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.VBox leftbox;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.Button focusbutton;
		
		private global::Gtk.Image focusbuttonimage;
		
		private global::Gtk.DrawingArea labelsarea;
		
		private global::Gtk.HBox zoomhbox;
		
		private global::Gtk.Image zoomoutimage;
		
		private global::Gtk.HScale focusscale;
		
		private global::Gtk.Image zoominimage;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.DrawingArea timerulearea;
		
		private global::Gtk.ScrolledWindow scrolledwindow1;
		
		private global::Gtk.DrawingArea timelinearea;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.Timeline
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.Timeline";
			// Container child LongoMatch.Gui.Component.Timeline.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			// Container child hbox1.Gtk.Box+BoxChild
			this.leftbox = new global::Gtk.VBox ();
			this.leftbox.Name = "leftbox";
			// Container child leftbox.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.HeightRequest = 30;
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.focusbutton = new global::Gtk.Button ();
			this.focusbutton.Name = "focusbutton";
			// Container child focusbutton.Gtk.Container+ContainerChild
			this.focusbuttonimage = new global::Gtk.Image ();
			this.focusbuttonimage.Name = "focusbuttonimage";
			this.focusbutton.Add (this.focusbuttonimage);
			this.hbox2.Add (this.focusbutton);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.focusbutton]));
			w2.Position = 0;
			this.leftbox.Add (this.hbox2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.leftbox [this.hbox2]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child leftbox.Gtk.Box+BoxChild
			this.labelsarea = new global::Gtk.DrawingArea ();
			this.labelsarea.Name = "labelsarea";
			this.leftbox.Add (this.labelsarea);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.leftbox [this.labelsarea]));
			w4.Position = 1;
			// Container child leftbox.Gtk.Box+BoxChild
			this.zoomhbox = new global::Gtk.HBox ();
			this.zoomhbox.Name = "zoomhbox";
			this.zoomhbox.Spacing = 6;
			// Container child zoomhbox.Gtk.Box+BoxChild
			this.zoomoutimage = new global::Gtk.Image ();
			this.zoomoutimage.WidthRequest = 14;
			this.zoomoutimage.HeightRequest = 8;
			this.zoomoutimage.Name = "zoomoutimage";
			this.zoomhbox.Add (this.zoomoutimage);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.zoomhbox [this.zoomoutimage]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child zoomhbox.Gtk.Box+BoxChild
			this.focusscale = new global::Gtk.HScale (null);
			this.focusscale.CanFocus = true;
			this.focusscale.Name = "focusscale";
			this.focusscale.Inverted = true;
			this.focusscale.Adjustment.Upper = 100;
			this.focusscale.Adjustment.PageIncrement = 10;
			this.focusscale.Adjustment.StepIncrement = 1;
			this.focusscale.DrawValue = false;
			this.focusscale.Digits = 0;
			this.focusscale.ValuePos = ((global::Gtk.PositionType)(2));
			this.zoomhbox.Add (this.focusscale);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.zoomhbox [this.focusscale]));
			w6.Position = 1;
			// Container child zoomhbox.Gtk.Box+BoxChild
			this.zoominimage = new global::Gtk.Image ();
			this.zoominimage.WidthRequest = 14;
			this.zoominimage.HeightRequest = 8;
			this.zoominimage.Name = "zoominimage";
			this.zoomhbox.Add (this.zoominimage);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.zoomhbox [this.zoominimage]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			this.leftbox.Add (this.zoomhbox);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.leftbox [this.zoomhbox]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			this.hbox1.Add (this.leftbox);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.leftbox]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			// Container child vbox1.Gtk.Box+BoxChild
			this.timerulearea = new global::Gtk.DrawingArea ();
			this.timerulearea.Name = "timerulearea";
			this.vbox1.Add (this.timerulearea);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.timerulearea]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w11 = new global::Gtk.Viewport ();
			w11.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.timelinearea = new global::Gtk.DrawingArea ();
			this.timelinearea.Name = "timelinearea";
			w11.Add (this.timelinearea);
			this.scrolledwindow1.Add (w11);
			this.vbox1.Add (this.scrolledwindow1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.scrolledwindow1]));
			w14.Position = 1;
			this.hbox1.Add (this.vbox1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox1]));
			w15.Position = 1;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
