
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Panel
{
	public partial class TeamsTemplatesPanel
	{
		private global::Gtk.VBox teameditorvbox;
		
		private global::Gtk.EventBox headereventbox;
		
		private global::LongoMatch.Gui.Panel.PanelHeader panelheader1;
		
		private global::Gtk.Alignment contentalignment;
		
		private global::Gtk.VBox contentvbox;
		
		private global::Gtk.HBox teameditorbuttonbar;
		
		private global::Gtk.Alignment templateimagealignment;
		
		private global::Gtk.Image teamimage;
		
		private global::Gtk.VBox editteamsvbox;
		
		private global::Gtk.Label editteamslabel;
		
		private global::Gtk.HBox hbox8;
		
		private global::Gtk.Button newteambutton;
		
		private global::Gtk.Image newteamimage;
		
		private global::Gtk.Button exportteambutton;
		
		private global::Gtk.Image exportteamimage;
		
		private global::Gtk.Button deleteteambutton;
		
		private global::Gtk.Image deleteteamimage;
		
		private global::Gtk.Button saveteambutton;
		
		private global::Gtk.Image saveteamimage;
		
		private global::Gtk.Image vseparatorimage;
		
		private global::Gtk.VBox editplayersvbox;
		
		private global::Gtk.Label editplayerslabel;
		
		private global::Gtk.HBox hbox7;
		
		private global::Gtk.Button newplayerbutton1;
		
		private global::Gtk.Image newplayerimage;
		
		private global::Gtk.Button deleteplayerbutton;
		
		private global::Gtk.Image deleteplayerimage;
		
		private global::Gtk.Alignment playerheaderalignment;
		
		private global::Gtk.Image playerheaderimage;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.VBox teamsvbox;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		
		private global::Gtk.TreeView teamseditortreeview;
		
		private global::LongoMatch.Gui.Component.TeamTemplateEditor teamtemplateeditor1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Panel.TeamsTemplatesPanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Panel.TeamsTemplatesPanel";
			// Container child LongoMatch.Gui.Panel.TeamsTemplatesPanel.Gtk.Container+ContainerChild
			this.teameditorvbox = new global::Gtk.VBox ();
			this.teameditorvbox.Name = "teameditorvbox";
			this.teameditorvbox.Spacing = 6;
			// Container child teameditorvbox.Gtk.Box+BoxChild
			this.headereventbox = new global::Gtk.EventBox ();
			this.headereventbox.Name = "headereventbox";
			// Container child headereventbox.Gtk.Container+ContainerChild
			this.panelheader1 = new global::LongoMatch.Gui.Panel.PanelHeader ();
			this.panelheader1.Events = ((global::Gdk.EventMask)(256));
			this.panelheader1.Name = "panelheader1";
			this.headereventbox.Add (this.panelheader1);
			this.teameditorvbox.Add (this.headereventbox);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.teameditorvbox [this.headereventbox]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child teameditorvbox.Gtk.Box+BoxChild
			this.contentalignment = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.contentalignment.Name = "contentalignment";
			this.contentalignment.LeftPadding = ((uint)(12));
			this.contentalignment.RightPadding = ((uint)(12));
			// Container child contentalignment.Gtk.Container+ContainerChild
			this.contentvbox = new global::Gtk.VBox ();
			this.contentvbox.Name = "contentvbox";
			// Container child contentvbox.Gtk.Box+BoxChild
			this.teameditorbuttonbar = new global::Gtk.HBox ();
			this.teameditorbuttonbar.Name = "teameditorbuttonbar";
			this.teameditorbuttonbar.Spacing = 24;
			// Container child teameditorbuttonbar.Gtk.Box+BoxChild
			this.templateimagealignment = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.templateimagealignment.Name = "templateimagealignment";
			this.templateimagealignment.LeftPadding = ((uint)(12));
			this.templateimagealignment.RightPadding = ((uint)(24));
			// Container child templateimagealignment.Gtk.Container+ContainerChild
			this.teamimage = new global::Gtk.Image ();
			this.teamimage.Name = "teamimage";
			this.teamimage.Yalign = 1F;
			this.templateimagealignment.Add (this.teamimage);
			this.teameditorbuttonbar.Add (this.templateimagealignment);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.teameditorbuttonbar [this.templateimagealignment]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child teameditorbuttonbar.Gtk.Box+BoxChild
			this.editteamsvbox = new global::Gtk.VBox ();
			this.editteamsvbox.Name = "editteamsvbox";
			this.editteamsvbox.Spacing = 2;
			this.editteamsvbox.BorderWidth = ((uint)(6));
			// Container child editteamsvbox.Gtk.Box+BoxChild
			this.editteamslabel = new global::Gtk.Label ();
			this.editteamslabel.Name = "editteamslabel";
			this.editteamslabel.Xalign = 0F;
			this.editteamslabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Manage teams");
			this.editteamslabel.UseMarkup = true;
			this.editteamsvbox.Add (this.editteamslabel);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.editteamsvbox [this.editteamslabel]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child editteamsvbox.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.newteambutton = new global::Gtk.Button ();
			this.newteambutton.CanFocus = true;
			this.newteambutton.Name = "newteambutton";
			// Container child newteambutton.Gtk.Container+ContainerChild
			this.newteamimage = new global::Gtk.Image ();
			this.newteamimage.Name = "newteamimage";
			this.newteamimage.Xpad = 5;
			this.newteamimage.Ypad = 5;
			this.newteambutton.Add (this.newteamimage);
			this.hbox8.Add (this.newteambutton);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.newteambutton]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.exportteambutton = new global::Gtk.Button ();
			this.exportteambutton.CanFocus = true;
			this.exportteambutton.Name = "exportteambutton";
			// Container child exportteambutton.Gtk.Container+ContainerChild
			this.exportteamimage = new global::Gtk.Image ();
			this.exportteamimage.Name = "exportteamimage";
			this.exportteamimage.Xpad = 5;
			this.exportteamimage.Ypad = 5;
			this.exportteambutton.Add (this.exportteamimage);
			this.hbox8.Add (this.exportteambutton);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.exportteambutton]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.deleteteambutton = new global::Gtk.Button ();
			this.deleteteambutton.CanFocus = true;
			this.deleteteambutton.Name = "deleteteambutton";
			// Container child deleteteambutton.Gtk.Container+ContainerChild
			this.deleteteamimage = new global::Gtk.Image ();
			this.deleteteamimage.Name = "deleteteamimage";
			this.deleteteamimage.Xpad = 5;
			this.deleteteamimage.Ypad = 5;
			this.deleteteambutton.Add (this.deleteteamimage);
			this.hbox8.Add (this.deleteteambutton);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.deleteteambutton]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.saveteambutton = new global::Gtk.Button ();
			this.saveteambutton.CanFocus = true;
			this.saveteambutton.Name = "saveteambutton";
			// Container child saveteambutton.Gtk.Container+ContainerChild
			this.saveteamimage = new global::Gtk.Image ();
			this.saveteamimage.Name = "saveteamimage";
			this.saveteamimage.Xpad = 5;
			this.saveteamimage.Ypad = 5;
			this.saveteambutton.Add (this.saveteamimage);
			this.hbox8.Add (this.saveteambutton);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.saveteambutton]));
			w13.Position = 3;
			w13.Expand = false;
			w13.Fill = false;
			this.editteamsvbox.Add (this.hbox8);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.editteamsvbox [this.hbox8]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.teameditorbuttonbar.Add (this.editteamsvbox);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.teameditorbuttonbar [this.editteamsvbox]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child teameditorbuttonbar.Gtk.Box+BoxChild
			this.vseparatorimage = new global::Gtk.Image ();
			this.vseparatorimage.Name = "vseparatorimage";
			this.teameditorbuttonbar.Add (this.vseparatorimage);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.teameditorbuttonbar [this.vseparatorimage]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			// Container child teameditorbuttonbar.Gtk.Box+BoxChild
			this.editplayersvbox = new global::Gtk.VBox ();
			this.editplayersvbox.Name = "editplayersvbox";
			this.editplayersvbox.Spacing = 2;
			this.editplayersvbox.BorderWidth = ((uint)(6));
			// Container child editplayersvbox.Gtk.Box+BoxChild
			this.editplayerslabel = new global::Gtk.Label ();
			this.editplayerslabel.Name = "editplayerslabel";
			this.editplayerslabel.Xalign = 0F;
			this.editplayerslabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Manage players");
			this.editplayerslabel.UseMarkup = true;
			this.editplayersvbox.Add (this.editplayerslabel);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.editplayersvbox [this.editplayerslabel]));
			w17.Position = 0;
			w17.Fill = false;
			// Container child editplayersvbox.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.newplayerbutton1 = new global::Gtk.Button ();
			this.newplayerbutton1.CanFocus = true;
			this.newplayerbutton1.Name = "newplayerbutton1";
			// Container child newplayerbutton1.Gtk.Container+ContainerChild
			this.newplayerimage = new global::Gtk.Image ();
			this.newplayerimage.Name = "newplayerimage";
			this.newplayerimage.Xpad = 5;
			this.newplayerimage.Ypad = 5;
			this.newplayerbutton1.Add (this.newplayerimage);
			this.hbox7.Add (this.newplayerbutton1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.newplayerbutton1]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.deleteplayerbutton = new global::Gtk.Button ();
			this.deleteplayerbutton.CanFocus = true;
			this.deleteplayerbutton.Name = "deleteplayerbutton";
			// Container child deleteplayerbutton.Gtk.Container+ContainerChild
			this.deleteplayerimage = new global::Gtk.Image ();
			this.deleteplayerimage.Name = "deleteplayerimage";
			this.deleteplayerimage.Xpad = 5;
			this.deleteplayerimage.Ypad = 5;
			this.deleteplayerbutton.Add (this.deleteplayerimage);
			this.hbox7.Add (this.deleteplayerbutton);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.deleteplayerbutton]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			this.editplayersvbox.Add (this.hbox7);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.editplayersvbox [this.hbox7]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			this.teameditorbuttonbar.Add (this.editplayersvbox);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.teameditorbuttonbar [this.editplayersvbox]));
			w23.Position = 3;
			w23.Expand = false;
			w23.Fill = false;
			// Container child teameditorbuttonbar.Gtk.Box+BoxChild
			this.playerheaderalignment = new global::Gtk.Alignment (1F, 1F, 0F, 0F);
			this.playerheaderalignment.Name = "playerheaderalignment";
			this.playerheaderalignment.RightPadding = ((uint)(12));
			// Container child playerheaderalignment.Gtk.Container+ContainerChild
			this.playerheaderimage = new global::Gtk.Image ();
			this.playerheaderimage.Name = "playerheaderimage";
			this.playerheaderimage.Ypad = 14;
			this.playerheaderalignment.Add (this.playerheaderimage);
			this.teameditorbuttonbar.Add (this.playerheaderalignment);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.teameditorbuttonbar [this.playerheaderalignment]));
			w25.Position = 4;
			this.contentvbox.Add (this.teameditorbuttonbar);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.contentvbox [this.teameditorbuttonbar]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child contentvbox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 15;
			// Container child hbox1.Gtk.Box+BoxChild
			this.teamsvbox = new global::Gtk.VBox ();
			this.teamsvbox.WidthRequest = 280;
			this.teamsvbox.Name = "teamsvbox";
			this.teamsvbox.Spacing = 6;
			// Container child teamsvbox.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.teamseditortreeview = new global::Gtk.TreeView ();
			this.teamseditortreeview.CanFocus = true;
			this.teamseditortreeview.Name = "teamseditortreeview";
			this.GtkScrolledWindow1.Add (this.teamseditortreeview);
			this.teamsvbox.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.teamsvbox [this.GtkScrolledWindow1]));
			w28.Position = 0;
			this.hbox1.Add (this.teamsvbox);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.teamsvbox]));
			w29.Position = 0;
			w29.Expand = false;
			w29.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.teamtemplateeditor1 = new global::LongoMatch.Gui.Component.TeamTemplateEditor ();
			this.teamtemplateeditor1.Events = ((global::Gdk.EventMask)(256));
			this.teamtemplateeditor1.Name = "teamtemplateeditor1";
			this.teamtemplateeditor1.Edited = false;
			this.hbox1.Add (this.teamtemplateeditor1);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.teamtemplateeditor1]));
			w30.Position = 1;
			this.contentvbox.Add (this.hbox1);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.contentvbox [this.hbox1]));
			w31.Position = 1;
			this.contentalignment.Add (this.contentvbox);
			this.teameditorvbox.Add (this.contentalignment);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.teameditorvbox [this.contentalignment]));
			w33.Position = 1;
			this.Add (this.teameditorvbox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
