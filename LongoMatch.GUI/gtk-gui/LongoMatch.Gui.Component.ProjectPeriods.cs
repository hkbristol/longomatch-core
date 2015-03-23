
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class ProjectPeriods
	{
		private global::Gtk.EventBox headereventbox;
		
		private global::Gtk.VPaned vpaned2;
		
		private global::Gtk.HBox playbins_hbox;
		
		private global::Gtk.VBox main_cam_vbox;
		
		private global::LongoMatch.Gui.PlayerBin main_cam_playerbin;
		
		private global::Gtk.HBox main_cam_hbox;
		
		private global::Gtk.Label main_cam_label;
		
		private global::Gtk.Alignment main_cam_audio_alignment;
		
		private global::Gtk.ToggleButton main_cam_audio_button;
		
		private global::Gtk.Image main_cam_audio_button_image;
		
		private global::Gtk.VBox sec_cam_vbox;
		
		private global::LongoMatch.Gui.PlayerBin sec_cam_playerbin;
		
		private global::Gtk.HBox sec_cam_hbox;
		
		private global::Gtk.Label sec_cam_label;
		
		private global::Gtk.Alignment sec_cam_audio_alignment;
		
		private global::Gtk.ToggleButton sec_cam_audio_button;
		
		private global::Gtk.Image sec_cam_audio_button_image;
		
		private global::Gtk.Label sec_cam_didactic_label;
		
		private global::Gtk.HBox hbox5;
		
		private global::Gtk.Alignment labels_alignment;
		
		private global::Gtk.VBox labels_vbox;
		
		private global::Gtk.DrawingArea labelsarea;
		
		private global::Gtk.HBox zoomhbox;
		
		private global::Gtk.Image zoomoutimage;
		
		private global::Gtk.HScale zoomscale;
		
		private global::Gtk.Image zoominimage;
		
		private global::Gtk.VBox vbox9;
		
		private global::Gtk.DrawingArea timerulearea;
		
		private global::Gtk.ScrolledWindow scrolledwindow2;
		
		private global::Gtk.DrawingArea timelinearea;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.ProjectPeriods
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.ProjectPeriods";
			// Container child LongoMatch.Gui.Component.ProjectPeriods.Gtk.Container+ContainerChild
			this.headereventbox = new global::Gtk.EventBox ();
			this.headereventbox.Name = "headereventbox";
			// Container child headereventbox.Gtk.Container+ContainerChild
			this.vpaned2 = new global::Gtk.VPaned ();
			this.vpaned2.CanFocus = true;
			this.vpaned2.Name = "vpaned2";
			this.vpaned2.Position = 400;
			// Container child vpaned2.Gtk.Paned+PanedChild
			this.playbins_hbox = new global::Gtk.HBox ();
			this.playbins_hbox.Name = "playbins_hbox";
			this.playbins_hbox.Homogeneous = true;
			this.playbins_hbox.Spacing = 15;
			this.playbins_hbox.BorderWidth = ((uint)(15));
			// Container child playbins_hbox.Gtk.Box+BoxChild
			this.main_cam_vbox = new global::Gtk.VBox ();
			this.main_cam_vbox.Name = "main_cam_vbox";
			this.main_cam_vbox.Spacing = 6;
			// Container child main_cam_vbox.Gtk.Box+BoxChild
			this.main_cam_playerbin = new global::LongoMatch.Gui.PlayerBin ();
			this.main_cam_playerbin.Events = ((global::Gdk.EventMask)(256));
			this.main_cam_playerbin.Name = "main_cam_playerbin";
			this.main_cam_vbox.Add (this.main_cam_playerbin);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.main_cam_vbox [this.main_cam_playerbin]));
			w1.Position = 0;
			// Container child main_cam_vbox.Gtk.Box+BoxChild
			this.main_cam_hbox = new global::Gtk.HBox ();
			this.main_cam_hbox.Name = "main_cam_hbox";
			this.main_cam_hbox.Spacing = 6;
			// Container child main_cam_hbox.Gtk.Box+BoxChild
			this.main_cam_label = new global::Gtk.Label ();
			this.main_cam_label.Name = "main_cam_label";
			this.main_cam_label.Xalign = 0F;
			this.main_cam_hbox.Add (this.main_cam_label);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.main_cam_hbox [this.main_cam_label]));
			w2.Position = 0;
			// Container child main_cam_hbox.Gtk.Box+BoxChild
			this.main_cam_audio_alignment = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.main_cam_audio_alignment.Name = "main_cam_audio_alignment";
			this.main_cam_audio_alignment.RightPadding = ((uint)(50));
			// Container child main_cam_audio_alignment.Gtk.Container+ContainerChild
			this.main_cam_audio_button = new global::Gtk.ToggleButton ();
			this.main_cam_audio_button.CanFocus = true;
			this.main_cam_audio_button.Name = "main_cam_audio_button";
			this.main_cam_audio_button.Active = true;
			// Container child main_cam_audio_button.Gtk.Container+ContainerChild
			this.main_cam_audio_button_image = new global::Gtk.Image ();
			this.main_cam_audio_button_image.Name = "main_cam_audio_button_image";
			this.main_cam_audio_button.Add (this.main_cam_audio_button_image);
			this.main_cam_audio_alignment.Add (this.main_cam_audio_button);
			this.main_cam_hbox.Add (this.main_cam_audio_alignment);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.main_cam_hbox [this.main_cam_audio_alignment]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.main_cam_vbox.Add (this.main_cam_hbox);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.main_cam_vbox [this.main_cam_hbox]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.playbins_hbox.Add (this.main_cam_vbox);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.playbins_hbox [this.main_cam_vbox]));
			w7.Position = 0;
			// Container child playbins_hbox.Gtk.Box+BoxChild
			this.sec_cam_vbox = new global::Gtk.VBox ();
			this.sec_cam_vbox.Name = "sec_cam_vbox";
			this.sec_cam_vbox.Spacing = 6;
			// Container child sec_cam_vbox.Gtk.Box+BoxChild
			this.sec_cam_playerbin = new global::LongoMatch.Gui.PlayerBin ();
			this.sec_cam_playerbin.Events = ((global::Gdk.EventMask)(256));
			this.sec_cam_playerbin.Name = "sec_cam_playerbin";
			this.sec_cam_vbox.Add (this.sec_cam_playerbin);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.sec_cam_vbox [this.sec_cam_playerbin]));
			w8.Position = 0;
			// Container child sec_cam_vbox.Gtk.Box+BoxChild
			this.sec_cam_hbox = new global::Gtk.HBox ();
			this.sec_cam_hbox.Name = "sec_cam_hbox";
			this.sec_cam_hbox.Spacing = 6;
			// Container child sec_cam_hbox.Gtk.Box+BoxChild
			this.sec_cam_label = new global::Gtk.Label ();
			this.sec_cam_label.Name = "sec_cam_label";
			this.sec_cam_label.Xalign = 0F;
			this.sec_cam_label.UseMarkup = true;
			this.sec_cam_hbox.Add (this.sec_cam_label);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.sec_cam_hbox [this.sec_cam_label]));
			w9.Position = 0;
			// Container child sec_cam_hbox.Gtk.Box+BoxChild
			this.sec_cam_audio_alignment = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.sec_cam_audio_alignment.Name = "sec_cam_audio_alignment";
			this.sec_cam_audio_alignment.RightPadding = ((uint)(50));
			// Container child sec_cam_audio_alignment.Gtk.Container+ContainerChild
			this.sec_cam_audio_button = new global::Gtk.ToggleButton ();
			this.sec_cam_audio_button.CanFocus = true;
			this.sec_cam_audio_button.Name = "sec_cam_audio_button";
			// Container child sec_cam_audio_button.Gtk.Container+ContainerChild
			this.sec_cam_audio_button_image = new global::Gtk.Image ();
			this.sec_cam_audio_button_image.Name = "sec_cam_audio_button_image";
			this.sec_cam_audio_button.Add (this.sec_cam_audio_button_image);
			this.sec_cam_audio_alignment.Add (this.sec_cam_audio_button);
			this.sec_cam_hbox.Add (this.sec_cam_audio_alignment);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.sec_cam_hbox [this.sec_cam_audio_alignment]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.sec_cam_vbox.Add (this.sec_cam_hbox);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.sec_cam_vbox [this.sec_cam_hbox]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.playbins_hbox.Add (this.sec_cam_vbox);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.playbins_hbox [this.sec_cam_vbox]));
			w14.Position = 1;
			// Container child playbins_hbox.Gtk.Box+BoxChild
			this.sec_cam_didactic_label = new global::Gtk.Label ();
			this.sec_cam_didactic_label.Name = "sec_cam_didactic_label";
			this.playbins_hbox.Add (this.sec_cam_didactic_label);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.playbins_hbox [this.sec_cam_didactic_label]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			this.vpaned2.Add (this.playbins_hbox);
			global::Gtk.Paned.PanedChild w16 = ((global::Gtk.Paned.PanedChild)(this.vpaned2 [this.playbins_hbox]));
			w16.Resize = false;
			// Container child vpaned2.Gtk.Paned+PanedChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			// Container child hbox5.Gtk.Box+BoxChild
			this.labels_alignment = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.labels_alignment.Name = "labels_alignment";
			// Container child labels_alignment.Gtk.Container+ContainerChild
			this.labels_vbox = new global::Gtk.VBox ();
			this.labels_vbox.Name = "labels_vbox";
			// Container child labels_vbox.Gtk.Box+BoxChild
			this.labelsarea = new global::Gtk.DrawingArea ();
			this.labelsarea.Name = "labelsarea";
			this.labels_vbox.Add (this.labelsarea);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.labels_vbox [this.labelsarea]));
			w17.Position = 0;
			// Container child labels_vbox.Gtk.Box+BoxChild
			this.zoomhbox = new global::Gtk.HBox ();
			this.zoomhbox.Name = "zoomhbox";
			this.zoomhbox.Spacing = 6;
			// Container child zoomhbox.Gtk.Box+BoxChild
			this.zoomoutimage = new global::Gtk.Image ();
			this.zoomoutimage.WidthRequest = 14;
			this.zoomoutimage.HeightRequest = 8;
			this.zoomoutimage.Name = "zoomoutimage";
			this.zoomhbox.Add (this.zoomoutimage);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.zoomhbox [this.zoomoutimage]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child zoomhbox.Gtk.Box+BoxChild
			this.zoomscale = new global::Gtk.HScale (null);
			this.zoomscale.CanFocus = true;
			this.zoomscale.Name = "zoomscale";
			this.zoomscale.Adjustment.Upper = 100;
			this.zoomscale.Adjustment.PageIncrement = 10;
			this.zoomscale.Adjustment.StepIncrement = 1;
			this.zoomscale.DrawValue = false;
			this.zoomscale.Digits = 0;
			this.zoomscale.ValuePos = ((global::Gtk.PositionType)(2));
			this.zoomhbox.Add (this.zoomscale);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.zoomhbox [this.zoomscale]));
			w19.Position = 1;
			// Container child zoomhbox.Gtk.Box+BoxChild
			this.zoominimage = new global::Gtk.Image ();
			this.zoominimage.WidthRequest = 14;
			this.zoominimage.HeightRequest = 8;
			this.zoominimage.Name = "zoominimage";
			this.zoomhbox.Add (this.zoominimage);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.zoomhbox [this.zoominimage]));
			w20.Position = 2;
			w20.Expand = false;
			w20.Fill = false;
			this.labels_vbox.Add (this.zoomhbox);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.labels_vbox [this.zoomhbox]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			this.labels_alignment.Add (this.labels_vbox);
			this.hbox5.Add (this.labels_alignment);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.labels_alignment]));
			w23.Position = 0;
			w23.Expand = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vbox9 = new global::Gtk.VBox ();
			this.vbox9.Name = "vbox9";
			// Container child vbox9.Gtk.Box+BoxChild
			this.timerulearea = new global::Gtk.DrawingArea ();
			this.timerulearea.Name = "timerulearea";
			this.vbox9.Add (this.timerulearea);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.timerulearea]));
			w24.Position = 0;
			w24.Expand = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow2.HeightRequest = 50;
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.VscrollbarPolicy = ((global::Gtk.PolicyType)(0));
			this.scrolledwindow2.HscrollbarPolicy = ((global::Gtk.PolicyType)(0));
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			global::Gtk.Viewport w25 = new global::Gtk.Viewport ();
			w25.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.timelinearea = new global::Gtk.DrawingArea ();
			this.timelinearea.Name = "timelinearea";
			w25.Add (this.timelinearea);
			this.scrolledwindow2.Add (w25);
			this.vbox9.Add (this.scrolledwindow2);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.scrolledwindow2]));
			w28.Position = 1;
			this.hbox5.Add (this.vbox9);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.vbox9]));
			w29.Position = 1;
			this.vpaned2.Add (this.hbox5);
			this.headereventbox.Add (this.vpaned2);
			this.Add (this.headereventbox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.sec_cam_vbox.Hide ();
			this.sec_cam_didactic_label.Hide ();
			this.Hide ();
		}
	}
}
