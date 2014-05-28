
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class TeamTemplateEditor
	{
		private global::Gtk.VBox vbox3;
		private global::Gtk.HBox hbox4;
		private global::Gtk.VBox vbox5;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment1;
		private global::Gtk.EventBox shieldeventbox;
		private global::Gtk.Image shieldimage;
		private global::Gtk.Label shield;
		private global::Gtk.Frame frame6;
		private global::Gtk.Alignment GtkAlignment3;
		private global::Gtk.Entry teamnameentry;
		private global::Gtk.Label GtkLabel4;
		private global::Gtk.Frame frame2;
		private global::Gtk.Alignment GtkAlignment6;
		private global::Gtk.VBox vbox1;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Label label1;
		private global::Gtk.Label nplayerslabel;
		private global::Gtk.HBox hbox6;
		private global::Gtk.Label label2;
		private global::Gtk.Entry tacticsentry;
		private global::Gtk.Button applybutton;
		private global::Gtk.Label GtkLabel6;
		private global::Gtk.DrawingArea drawingarea;
		private global::Gtk.HBox hbox7;
		private global::Gtk.ToggleButton subsbutton;
		private global::Gtk.Label warninglabel;
		private global::Gtk.VSeparator vseparator1;
		private global::Gtk.Frame playerframe;
		private global::Gtk.Alignment GtkAlignment5;
		private global::Gtk.VBox vbox6;
		private global::Gtk.EventBox playereventbox;
		private global::Gtk.Image playerimage;
		private global::Gtk.Table table1;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Label bdaylabel;
		private global::Gtk.Button datebutton;
		private global::Gtk.SpinButton heightspinbutton;
		private global::Gtk.Label label11;
		private global::Gtk.Label label12;
		private global::Gtk.Label label3;
		private global::Gtk.Label label5;
		private global::Gtk.Label label6;
		private global::Gtk.Label label7;
		private global::Gtk.Label label8;
		private global::Gtk.Entry mailentry;
		private global::Gtk.Label maillabel;
		private global::Gtk.Entry nameentry;
		private global::Gtk.Entry nationalityentry;
		private global::Gtk.SpinButton numberspinbutton;
		private global::Gtk.Entry positionentry;
		private global::Gtk.SpinButton weightspinbutton;
		private global::Gtk.Label GtkLabel3;
		private global::Gtk.HButtonBox hbuttonbox2;
		private global::Gtk.Button savebutton;
		private global::Gtk.Button newplayerbutton;
		private global::Gtk.Button deletebutton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.TeamTemplateEditor
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.TeamTemplateEditor";
			// Container child LongoMatch.Gui.Component.TeamTemplateEditor.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 30;
			// Container child hbox2.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.shieldeventbox = new global::Gtk.EventBox ();
			this.shieldeventbox.Name = "shieldeventbox";
			// Container child shieldeventbox.Gtk.Container+ContainerChild
			this.shieldimage = new global::Gtk.Image ();
			this.shieldimage.Name = "shieldimage";
			this.shieldeventbox.Add (this.shieldimage);
			this.GtkAlignment1.Add (this.shieldeventbox);
			this.frame1.Add (this.GtkAlignment1);
			this.shield = new global::Gtk.Label ();
			this.shield.Name = "shield";
			this.shield.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Shield</b>");
			this.shield.UseMarkup = true;
			this.frame1.LabelWidget = this.shield;
			this.hbox2.Add (this.frame1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.frame1]));
			w4.Position = 0;
			w4.Expand = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.frame6 = new global::Gtk.Frame ();
			this.frame6.Name = "frame6";
			this.frame6.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame6.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.teamnameentry = new global::Gtk.Entry ();
			this.teamnameentry.WidthRequest = 100;
			this.teamnameentry.CanFocus = true;
			this.teamnameentry.Name = "teamnameentry";
			this.teamnameentry.IsEditable = true;
			this.teamnameentry.InvisibleChar = '•';
			this.GtkAlignment3.Add (this.teamnameentry);
			this.frame6.Add (this.GtkAlignment3);
			this.GtkLabel4 = new global::Gtk.Label ();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Team name</b>");
			this.GtkLabel4.UseMarkup = true;
			this.frame6.LabelWidget = this.GtkLabel4;
			this.hbox2.Add (this.frame6);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.frame6]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment6 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment6.Name = "GtkAlignment6";
			this.GtkAlignment6.LeftPadding = ((uint)(12));
			// Container child GtkAlignment6.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Number of players");
			this.hbox5.Add (this.label1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label1]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.nplayerslabel = new global::Gtk.Label ();
			this.nplayerslabel.Name = "nplayerslabel";
			this.hbox5.Add (this.nplayerslabel);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.nplayerslabel]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			this.vbox1.Add (this.hbox5);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox5]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Tactics");
			this.hbox6.Add (this.label2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.label2]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.tacticsentry = new global::Gtk.Entry ();
			this.tacticsentry.WidthRequest = 30;
			this.tacticsentry.CanFocus = true;
			this.tacticsentry.Name = "tacticsentry";
			this.tacticsentry.IsEditable = true;
			this.tacticsentry.InvisibleChar = '•';
			this.hbox6.Add (this.tacticsentry);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.tacticsentry]));
			w12.Position = 1;
			// Container child hbox6.Gtk.Box+BoxChild
			this.applybutton = new global::Gtk.Button ();
			this.applybutton.CanFocus = true;
			this.applybutton.Name = "applybutton";
			this.applybutton.UseUnderline = true;
			// Container child applybutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w13 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w14 = new global::Gtk.HBox ();
			w14.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w15 = new global::Gtk.Image ();
			w15.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			w14.Add (w15);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w17 = new global::Gtk.Label ();
			w14.Add (w17);
			w13.Add (w14);
			this.applybutton.Add (w13);
			this.hbox6.Add (this.applybutton);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.applybutton]));
			w21.Position = 2;
			w21.Expand = false;
			w21.Fill = false;
			this.vbox1.Add (this.hbox6);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox6]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			this.GtkAlignment6.Add (this.vbox1);
			this.frame2.Add (this.GtkAlignment6);
			this.GtkLabel6 = new global::Gtk.Label ();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Formation</b>");
			this.GtkLabel6.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel6;
			this.hbox2.Add (this.frame2);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.frame2]));
			w25.Position = 2;
			w25.Expand = false;
			w25.Fill = false;
			this.vbox5.Add (this.hbox2);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox2]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.drawingarea = new global::Gtk.DrawingArea ();
			this.drawingarea.Name = "drawingarea";
			this.vbox5.Add (this.drawingarea);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.drawingarea]));
			w27.Position = 1;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.subsbutton = new global::Gtk.ToggleButton ();
			this.subsbutton.Name = "subsbutton";
			this.subsbutton.UseUnderline = true;
			this.subsbutton.FocusOnClick = false;
			this.subsbutton.Active = true;
			// Container child subsbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w28 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w29 = new global::Gtk.HBox ();
			w29.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w30 = new global::Gtk.Image ();
			w30.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-refresh", global::Gtk.IconSize.Dialog);
			w29.Add (w30);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w32 = new global::Gtk.Label ();
			w29.Add (w32);
			w28.Add (w29);
			this.subsbutton.Add (w28);
			this.hbox7.Add (this.subsbutton);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.subsbutton]));
			w36.Position = 0;
			// Container child hbox7.Gtk.Box+BoxChild
			this.warninglabel = new global::Gtk.Label ();
			this.warninglabel.Name = "warninglabel";
			this.warninglabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Substitutions activated.\nClick 2 players to swap them");
			this.hbox7.Add (this.warninglabel);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.warninglabel]));
			w37.Position = 1;
			this.vbox5.Add (this.hbox7);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox7]));
			w38.Position = 2;
			w38.Expand = false;
			w38.Fill = false;
			this.hbox4.Add (this.vbox5);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.vbox5]));
			w39.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator ();
			this.vseparator1.Name = "vseparator1";
			this.hbox4.Add (this.vseparator1);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.vseparator1]));
			w40.Position = 1;
			w40.Expand = false;
			w40.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.playerframe = new global::Gtk.Frame ();
			this.playerframe.Name = "playerframe";
			this.playerframe.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child playerframe.Gtk.Container+ContainerChild
			this.GtkAlignment5 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment5.Name = "GtkAlignment5";
			this.GtkAlignment5.LeftPadding = ((uint)(12));
			// Container child GtkAlignment5.Gtk.Container+ContainerChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.playereventbox = new global::Gtk.EventBox ();
			this.playereventbox.Name = "playereventbox";
			// Container child playereventbox.Gtk.Container+ContainerChild
			this.playerimage = new global::Gtk.Image ();
			this.playerimage.Name = "playerimage";
			this.playereventbox.Add (this.playerimage);
			this.vbox6.Add (this.playereventbox);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.playereventbox]));
			w42.Position = 0;
			w42.Expand = false;
			w42.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(4)), ((uint)(4)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.bdaylabel = new global::Gtk.Label ();
			this.bdaylabel.Name = "bdaylabel";
			this.hbox3.Add (this.bdaylabel);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.bdaylabel]));
			w43.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.datebutton = new global::Gtk.Button ();
			this.datebutton.CanFocus = true;
			this.datebutton.Name = "datebutton";
			this.datebutton.UseUnderline = true;
			this.datebutton.Label = global::Mono.Unix.Catalog.GetString ("_Calendar");
			this.hbox3.Add (this.datebutton);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.datebutton]));
			w44.Position = 1;
			w44.Expand = false;
			w44.Fill = false;
			this.table1.Add (this.hbox3);
			global::Gtk.Table.TableChild w45 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox3]));
			w45.TopAttach = ((uint)(3));
			w45.BottomAttach = ((uint)(4));
			w45.LeftAttach = ((uint)(1));
			w45.RightAttach = ((uint)(2));
			w45.XOptions = ((global::Gtk.AttachOptions)(4));
			w45.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.heightspinbutton = new global::Gtk.SpinButton (0, 100, 1);
			this.heightspinbutton.CanFocus = true;
			this.heightspinbutton.Name = "heightspinbutton";
			this.heightspinbutton.Adjustment.PageIncrement = 10;
			this.heightspinbutton.ClimbRate = 1;
			this.heightspinbutton.Digits = ((uint)(2));
			this.heightspinbutton.Numeric = true;
			this.heightspinbutton.Value = 18;
			this.table1.Add (this.heightspinbutton);
			global::Gtk.Table.TableChild w46 = ((global::Gtk.Table.TableChild)(this.table1 [this.heightspinbutton]));
			w46.TopAttach = ((uint)(1));
			w46.BottomAttach = ((uint)(2));
			w46.LeftAttach = ((uint)(3));
			w46.RightAttach = ((uint)(4));
			w46.XOptions = ((global::Gtk.AttachOptions)(4));
			w46.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Position:");
			this.table1.Add (this.label11);
			global::Gtk.Table.TableChild w47 = ((global::Gtk.Table.TableChild)(this.table1 [this.label11]));
			w47.LeftAttach = ((uint)(2));
			w47.RightAttach = ((uint)(3));
			w47.XOptions = ((global::Gtk.AttachOptions)(4));
			w47.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Name:");
			this.table1.Add (this.label12);
			global::Gtk.Table.TableChild w48 = ((global::Gtk.Table.TableChild)(this.table1 [this.label12]));
			w48.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Number:");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w49 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w49.TopAttach = ((uint)(1));
			w49.BottomAttach = ((uint)(2));
			w49.XOptions = ((global::Gtk.AttachOptions)(4));
			w49.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Height");
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w50 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w50.TopAttach = ((uint)(1));
			w50.BottomAttach = ((uint)(2));
			w50.LeftAttach = ((uint)(2));
			w50.RightAttach = ((uint)(3));
			w50.XOptions = ((global::Gtk.AttachOptions)(4));
			w50.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Weight");
			this.table1.Add (this.label6);
			global::Gtk.Table.TableChild w51 = ((global::Gtk.Table.TableChild)(this.table1 [this.label6]));
			w51.TopAttach = ((uint)(2));
			w51.BottomAttach = ((uint)(3));
			w51.XOptions = ((global::Gtk.AttachOptions)(4));
			w51.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Birth day");
			this.table1.Add (this.label7);
			global::Gtk.Table.TableChild w52 = ((global::Gtk.Table.TableChild)(this.table1 [this.label7]));
			w52.TopAttach = ((uint)(3));
			w52.BottomAttach = ((uint)(4));
			w52.XOptions = ((global::Gtk.AttachOptions)(4));
			w52.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Nationality");
			this.table1.Add (this.label8);
			global::Gtk.Table.TableChild w53 = ((global::Gtk.Table.TableChild)(this.table1 [this.label8]));
			w53.TopAttach = ((uint)(2));
			w53.BottomAttach = ((uint)(3));
			w53.LeftAttach = ((uint)(2));
			w53.RightAttach = ((uint)(3));
			w53.XOptions = ((global::Gtk.AttachOptions)(4));
			w53.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.mailentry = new global::Gtk.Entry ();
			this.mailentry.CanFocus = true;
			this.mailentry.Name = "mailentry";
			this.mailentry.IsEditable = true;
			this.mailentry.InvisibleChar = '•';
			this.table1.Add (this.mailentry);
			global::Gtk.Table.TableChild w54 = ((global::Gtk.Table.TableChild)(this.table1 [this.mailentry]));
			w54.TopAttach = ((uint)(3));
			w54.BottomAttach = ((uint)(4));
			w54.LeftAttach = ((uint)(3));
			w54.RightAttach = ((uint)(4));
			w54.XOptions = ((global::Gtk.AttachOptions)(4));
			w54.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.maillabel = new global::Gtk.Label ();
			this.maillabel.Name = "maillabel";
			this.maillabel.LabelProp = global::Mono.Unix.Catalog.GetString ("E-mail:");
			this.table1.Add (this.maillabel);
			global::Gtk.Table.TableChild w55 = ((global::Gtk.Table.TableChild)(this.table1 [this.maillabel]));
			w55.TopAttach = ((uint)(3));
			w55.BottomAttach = ((uint)(4));
			w55.LeftAttach = ((uint)(2));
			w55.RightAttach = ((uint)(3));
			w55.XOptions = ((global::Gtk.AttachOptions)(4));
			w55.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.nameentry = new global::Gtk.Entry ();
			this.nameentry.CanFocus = true;
			this.nameentry.Name = "nameentry";
			this.nameentry.IsEditable = true;
			this.nameentry.InvisibleChar = '●';
			this.table1.Add (this.nameentry);
			global::Gtk.Table.TableChild w56 = ((global::Gtk.Table.TableChild)(this.table1 [this.nameentry]));
			w56.LeftAttach = ((uint)(1));
			w56.RightAttach = ((uint)(2));
			w56.XOptions = ((global::Gtk.AttachOptions)(4));
			w56.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.nationalityentry = new global::Gtk.Entry ();
			this.nationalityentry.CanFocus = true;
			this.nationalityentry.Name = "nationalityentry";
			this.nationalityentry.IsEditable = true;
			this.nationalityentry.InvisibleChar = '●';
			this.table1.Add (this.nationalityentry);
			global::Gtk.Table.TableChild w57 = ((global::Gtk.Table.TableChild)(this.table1 [this.nationalityentry]));
			w57.TopAttach = ((uint)(2));
			w57.BottomAttach = ((uint)(3));
			w57.LeftAttach = ((uint)(3));
			w57.RightAttach = ((uint)(4));
			w57.XOptions = ((global::Gtk.AttachOptions)(4));
			w57.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.numberspinbutton = new global::Gtk.SpinButton (0, 100, 1);
			this.numberspinbutton.CanFocus = true;
			this.numberspinbutton.Name = "numberspinbutton";
			this.numberspinbutton.Adjustment.PageIncrement = 10;
			this.numberspinbutton.ClimbRate = 1;
			this.numberspinbutton.Numeric = true;
			this.table1.Add (this.numberspinbutton);
			global::Gtk.Table.TableChild w58 = ((global::Gtk.Table.TableChild)(this.table1 [this.numberspinbutton]));
			w58.TopAttach = ((uint)(1));
			w58.BottomAttach = ((uint)(2));
			w58.LeftAttach = ((uint)(1));
			w58.RightAttach = ((uint)(2));
			w58.XOptions = ((global::Gtk.AttachOptions)(4));
			w58.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.positionentry = new global::Gtk.Entry ();
			this.positionentry.CanFocus = true;
			this.positionentry.Name = "positionentry";
			this.positionentry.IsEditable = true;
			this.positionentry.InvisibleChar = '●';
			this.table1.Add (this.positionentry);
			global::Gtk.Table.TableChild w59 = ((global::Gtk.Table.TableChild)(this.table1 [this.positionentry]));
			w59.LeftAttach = ((uint)(3));
			w59.RightAttach = ((uint)(4));
			w59.XOptions = ((global::Gtk.AttachOptions)(4));
			w59.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.weightspinbutton = new global::Gtk.SpinButton (0, 1000, 1);
			this.weightspinbutton.CanFocus = true;
			this.weightspinbutton.Name = "weightspinbutton";
			this.weightspinbutton.Adjustment.PageIncrement = 10;
			this.weightspinbutton.ClimbRate = 1;
			this.weightspinbutton.Numeric = true;
			this.weightspinbutton.Value = 80;
			this.table1.Add (this.weightspinbutton);
			global::Gtk.Table.TableChild w60 = ((global::Gtk.Table.TableChild)(this.table1 [this.weightspinbutton]));
			w60.TopAttach = ((uint)(2));
			w60.BottomAttach = ((uint)(3));
			w60.LeftAttach = ((uint)(1));
			w60.RightAttach = ((uint)(2));
			w60.XOptions = ((global::Gtk.AttachOptions)(4));
			w60.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox6.Add (this.table1);
			global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.table1]));
			w61.Position = 1;
			w61.Expand = false;
			w61.Fill = false;
			this.GtkAlignment5.Add (this.vbox6);
			this.playerframe.Add (this.GtkAlignment5);
			this.GtkLabel3 = new global::Gtk.Label ();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Player  description</b>");
			this.GtkLabel3.UseMarkup = true;
			this.playerframe.LabelWidget = this.GtkLabel3;
			this.hbox4.Add (this.playerframe);
			global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.playerframe]));
			w64.Position = 2;
			w64.Expand = false;
			w64.Fill = false;
			this.vbox3.Add (this.hbox4);
			global::Gtk.Box.BoxChild w65 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox4]));
			w65.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbuttonbox2 = new global::Gtk.HButtonBox ();
			this.hbuttonbox2.Name = "hbuttonbox2";
			this.hbuttonbox2.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.savebutton = new global::Gtk.Button ();
			this.savebutton.CanFocus = true;
			this.savebutton.Name = "savebutton";
			this.savebutton.UseUnderline = true;
			// Container child savebutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w66 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w67 = new global::Gtk.HBox ();
			w67.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w68 = new global::Gtk.Image ();
			w68.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Dialog);
			w67.Add (w68);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w70 = new global::Gtk.Label ();
			w70.LabelProp = global::Mono.Unix.Catalog.GetString ("Save template");
			w70.UseUnderline = true;
			w67.Add (w70);
			w66.Add (w67);
			this.savebutton.Add (w66);
			this.hbuttonbox2.Add (this.savebutton);
			global::Gtk.ButtonBox.ButtonBoxChild w74 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.savebutton]));
			w74.Expand = false;
			w74.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.newplayerbutton = new global::Gtk.Button ();
			this.newplayerbutton.CanFocus = true;
			this.newplayerbutton.Name = "newplayerbutton";
			this.newplayerbutton.UseUnderline = true;
			// Container child newplayerbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w75 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w76 = new global::Gtk.HBox ();
			w76.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w77 = new global::Gtk.Image ();
			w77.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-new", global::Gtk.IconSize.Dialog);
			w76.Add (w77);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w79 = new global::Gtk.Label ();
			w79.LabelProp = global::Mono.Unix.Catalog.GetString ("New player");
			w79.UseUnderline = true;
			w76.Add (w79);
			w75.Add (w76);
			this.newplayerbutton.Add (w75);
			this.hbuttonbox2.Add (this.newplayerbutton);
			global::Gtk.ButtonBox.ButtonBoxChild w83 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.newplayerbutton]));
			w83.Position = 1;
			w83.Expand = false;
			w83.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.deletebutton = new global::Gtk.Button ();
			this.deletebutton.CanFocus = true;
			this.deletebutton.Name = "deletebutton";
			this.deletebutton.UseUnderline = true;
			// Container child deletebutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w84 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w85 = new global::Gtk.HBox ();
			w85.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w86 = new global::Gtk.Image ();
			w86.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-delete", global::Gtk.IconSize.Dialog);
			w85.Add (w86);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w88 = new global::Gtk.Label ();
			w88.LabelProp = global::Mono.Unix.Catalog.GetString ("Delete player");
			w88.UseUnderline = true;
			w85.Add (w88);
			w84.Add (w85);
			this.deletebutton.Add (w84);
			this.hbuttonbox2.Add (this.deletebutton);
			global::Gtk.ButtonBox.ButtonBoxChild w92 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.deletebutton]));
			w92.Position = 2;
			w92.Expand = false;
			w92.Fill = false;
			this.vbox3.Add (this.hbuttonbox2);
			global::Gtk.Box.BoxChild w93 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbuttonbox2]));
			w93.Position = 1;
			w93.Expand = false;
			w93.Fill = false;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.warninglabel.Hide ();
			this.Hide ();
		}
	}
}
