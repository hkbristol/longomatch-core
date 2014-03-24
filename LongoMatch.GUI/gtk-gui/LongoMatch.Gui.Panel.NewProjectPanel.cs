
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Panel
{
	public partial class NewProjectPanel
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox3;
		private global::LongoMatch.Gui.Component.BackgroundWidget backgroundwidget;
		private global::Gtk.Notebook notebook1;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Label label6;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.HBox hbox1;
		private global::Gtk.RadioButton fromfileradiobutton;
		private global::Gtk.Image image61;
		private global::Gtk.HBox hbox2;
		private global::Gtk.RadioButton liveradiobutton;
		private global::Gtk.Image image63;
		private global::Gtk.HBox hbox4;
		private global::Gtk.RadioButton fakeliveradiobutton;
		private global::Gtk.Image image62;
		private global::Gtk.HBox ipcamerabox;
		private global::Gtk.RadioButton uriliveradiobutton;
		private global::Gtk.Image image64;
		private global::Gtk.Label label1;
		private global::Gtk.VBox vbox4;
		private global::Gtk.Label label4;
		private global::Gtk.HSeparator hseparator2;
		private global::Gtk.Table table1;
		private global::Gtk.Entry competitionentry;
		private global::Gtk.Label Competitionlabel;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Entry dateEntry;
		private global::Gtk.Button calendarbutton;
		private global::Gtk.HBox hbox9;
		private global::Gtk.SpinButton localSpinButton;
		private global::Gtk.Label label2;
		private global::Gtk.SpinButton visitorSpinButton;
		private global::Gtk.Label label11;
		private global::Gtk.Label label5;
		private global::Gtk.Label label9;
		private global::Gtk.Entry seasonentry;
		private global::Gtk.Label seasonlabel;
		private global::Gtk.ComboBox tagscombobox;
		private global::Gtk.HSeparator hseparator3;
		private global::Gtk.Table filetable;
		private global::Gtk.HBox filehbox;
		private global::Gtk.Entry fileEntry;
		private global::Gtk.Button openbutton;
		private global::Gtk.Label filelabel;
		private global::Gtk.Table outputfiletable;
		private global::Gtk.HBox outputfilehbox1;
		private global::Gtk.Entry outfileEntry;
		private global::Gtk.Button savebutton;
		private global::Gtk.Label outputfilelabel;
		private global::Gtk.Table capturetable;
		private global::Gtk.ComboBox encodingcombobox;
		private global::Gtk.HBox hbox6;
		private global::Gtk.Label device;
		private global::Gtk.Label urilabel;
		private global::Gtk.HBox hbox7;
		private global::Gtk.ComboBox devicecombobox;
		private global::Gtk.Entry urientry;
		private global::Gtk.ComboBox imagecombobox;
		private global::Gtk.ComboBox qualitycombobox;
		private global::Gtk.Label qualitylabel;
		private global::Gtk.Label sizelabel;
		private global::Gtk.Label videoformatlabel;
		private global::Gtk.HBox hbox8;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment6;
		private global::LongoMatch.Gui.Component.TeamPlayersSelection localteamplayersselection;
		private global::Gtk.Label GtkLabel10;
		private global::Gtk.Frame frame2;
		private global::Gtk.Alignment GtkAlignment7;
		private global::LongoMatch.Gui.Component.TeamPlayersSelection awayteamplayersselection;
		private global::Gtk.Label GtkLabel11;
		private global::Gtk.Label label3;
		private global::Gtk.HButtonBox hbuttonbox2;
		private global::Gtk.Button backbutton;
		private global::Gtk.Button nextbutton;
		private global::Gtk.Button createbutton;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Panel.NewProjectPanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Panel.NewProjectPanel";
			// Container child LongoMatch.Gui.Panel.NewProjectPanel.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.backgroundwidget = new global::LongoMatch.Gui.Component.BackgroundWidget ();
			this.backgroundwidget.Events = ((global::Gdk.EventMask)(256));
			this.backgroundwidget.Name = "backgroundwidget";
			this.hbox3.Add (this.backgroundwidget);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.backgroundwidget]));
			w1.Position = 0;
			w1.Expand = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 1;
			this.notebook1.ShowBorder = false;
			this.notebook1.Scrollable = true;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Select new project type</b>");
			this.label6.UseMarkup = true;
			this.label6.Justify = ((global::Gtk.Justification)(2));
			this.vbox3.Add (this.label6);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.label6]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			w2.Padding = ((uint)(30));
			// Container child vbox3.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox3.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hseparator1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.fromfileradiobutton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("New project using a video file"));
			this.fromfileradiobutton.CanFocus = true;
			this.fromfileradiobutton.Name = "fromfileradiobutton";
			this.fromfileradiobutton.Active = true;
			this.fromfileradiobutton.DrawIndicator = true;
			this.fromfileradiobutton.UseUnderline = true;
			this.fromfileradiobutton.FocusOnClick = false;
			this.fromfileradiobutton.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.hbox1.Add (this.fromfileradiobutton);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.fromfileradiobutton]));
			w4.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.image61 = new global::Gtk.Image ();
			this.image61.Name = "image61";
			this.image61.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("video.png");
			this.hbox1.Add (this.image61);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.image61]));
			w5.Position = 1;
			this.vbox3.Add (this.hbox1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox1]));
			w6.Position = 2;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.liveradiobutton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Live project using a capture device"));
			this.liveradiobutton.CanFocus = true;
			this.liveradiobutton.Name = "liveradiobutton";
			this.liveradiobutton.DrawIndicator = true;
			this.liveradiobutton.UseUnderline = true;
			this.liveradiobutton.Group = this.fromfileradiobutton.Group;
			this.hbox2.Add (this.liveradiobutton);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.liveradiobutton]));
			w7.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.image63 = new global::Gtk.Image ();
			this.image63.Name = "image63";
			this.image63.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("camera-video.png");
			this.hbox2.Add (this.image63);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.image63]));
			w8.Position = 1;
			this.vbox3.Add (this.hbox2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox2]));
			w9.Position = 3;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.fakeliveradiobutton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Live project using a fake capture device"));
			this.fakeliveradiobutton.CanFocus = true;
			this.fakeliveradiobutton.Name = "fakeliveradiobutton";
			this.fakeliveradiobutton.DrawIndicator = true;
			this.fakeliveradiobutton.UseUnderline = true;
			this.fakeliveradiobutton.Group = this.fromfileradiobutton.Group;
			this.hbox4.Add (this.fakeliveradiobutton);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.fakeliveradiobutton]));
			w10.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.image62 = new global::Gtk.Image ();
			this.image62.Name = "image62";
			this.image62.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("camera-video.png");
			this.hbox4.Add (this.image62);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.image62]));
			w11.Position = 1;
			this.vbox3.Add (this.hbox4);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox4]));
			w12.Position = 4;
			// Container child vbox3.Gtk.Box+BoxChild
			this.ipcamerabox = new global::Gtk.HBox ();
			this.ipcamerabox.Name = "ipcamerabox";
			this.ipcamerabox.Spacing = 6;
			// Container child ipcamerabox.Gtk.Box+BoxChild
			this.uriliveradiobutton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Live project using an IP camera"));
			this.uriliveradiobutton.CanFocus = true;
			this.uriliveradiobutton.Name = "uriliveradiobutton";
			this.uriliveradiobutton.DrawIndicator = true;
			this.uriliveradiobutton.UseUnderline = true;
			this.uriliveradiobutton.Group = this.fromfileradiobutton.Group;
			this.ipcamerabox.Add (this.uriliveradiobutton);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.ipcamerabox [this.uriliveradiobutton]));
			w13.Position = 0;
			// Container child ipcamerabox.Gtk.Box+BoxChild
			this.image64 = new global::Gtk.Image ();
			this.image64.Name = "image64";
			this.image64.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("camera-video.png");
			this.ipcamerabox.Add (this.image64);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.ipcamerabox [this.image64]));
			w14.Position = 1;
			this.vbox3.Add (this.ipcamerabox);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.ipcamerabox]));
			w15.Position = 5;
			this.notebook1.Add (this.vbox3);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("page1");
			this.notebook1.SetTabLabel (this.vbox3, this.label1);
			this.label1.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Project properties</b>");
			this.label4.UseMarkup = true;
			this.label4.Justify = ((global::Gtk.Justification)(2));
			this.vbox4.Add (this.label4);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label4]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Padding = ((uint)(20));
			// Container child vbox4.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			this.vbox4.Add (this.hseparator2);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hseparator2]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(4)), true);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.competitionentry = new global::Gtk.Entry ();
			this.competitionentry.CanFocus = true;
			this.competitionentry.Name = "competitionentry";
			this.competitionentry.IsEditable = true;
			this.competitionentry.InvisibleChar = '●';
			this.table1.Add (this.competitionentry);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1 [this.competitionentry]));
			w19.LeftAttach = ((uint)(3));
			w19.RightAttach = ((uint)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.Competitionlabel = new global::Gtk.Label ();
			this.Competitionlabel.Name = "Competitionlabel";
			this.Competitionlabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Competition:");
			this.table1.Add (this.Competitionlabel);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1 [this.Competitionlabel]));
			w20.LeftAttach = ((uint)(2));
			w20.RightAttach = ((uint)(3));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			// Container child hbox5.Gtk.Box+BoxChild
			this.dateEntry = new global::Gtk.Entry ();
			this.dateEntry.CanFocus = true;
			this.dateEntry.Name = "dateEntry";
			this.dateEntry.IsEditable = false;
			this.dateEntry.InvisibleChar = '●';
			this.hbox5.Add (this.dateEntry);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.dateEntry]));
			w21.Position = 0;
			// Container child hbox5.Gtk.Box+BoxChild
			this.calendarbutton = new global::Gtk.Button ();
			this.calendarbutton.CanFocus = true;
			this.calendarbutton.Name = "calendarbutton";
			this.calendarbutton.UseUnderline = true;
			// Container child calendarbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w22 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w23 = new global::Gtk.HBox ();
			w23.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w24 = new global::Gtk.Image ();
			w24.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "stock_calendar", global::Gtk.IconSize.Button);
			w23.Add (w24);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w26 = new global::Gtk.Label ();
			w26.LabelProp = global::Mono.Unix.Catalog.GetString ("_Calendar");
			w26.UseUnderline = true;
			w23.Add (w26);
			w22.Add (w23);
			this.calendarbutton.Add (w22);
			this.hbox5.Add (this.calendarbutton);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.calendarbutton]));
			w30.Position = 1;
			w30.Expand = false;
			w30.Fill = false;
			this.table1.Add (this.hbox5);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox5]));
			w31.TopAttach = ((uint)(1));
			w31.BottomAttach = ((uint)(2));
			w31.LeftAttach = ((uint)(3));
			w31.RightAttach = ((uint)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox9 = new global::Gtk.HBox ();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.localSpinButton = new global::Gtk.SpinButton (0, 1000, 1);
			this.localSpinButton.CanFocus = true;
			this.localSpinButton.Name = "localSpinButton";
			this.localSpinButton.Adjustment.PageIncrement = 10;
			this.localSpinButton.ClimbRate = 1;
			this.localSpinButton.Numeric = true;
			this.hbox9.Add (this.localSpinButton);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.localSpinButton]));
			w32.Position = 0;
			w32.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("-");
			this.hbox9.Add (this.label2);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.label2]));
			w33.Position = 1;
			w33.Expand = false;
			w33.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.visitorSpinButton = new global::Gtk.SpinButton (0, 1000, 1);
			this.visitorSpinButton.CanFocus = true;
			this.visitorSpinButton.Name = "visitorSpinButton";
			this.visitorSpinButton.Adjustment.PageIncrement = 10;
			this.visitorSpinButton.ClimbRate = 1;
			this.visitorSpinButton.Numeric = true;
			this.hbox9.Add (this.visitorSpinButton);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.visitorSpinButton]));
			w34.Position = 2;
			w34.Fill = false;
			this.table1.Add (this.hbox9);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox9]));
			w35.TopAttach = ((uint)(1));
			w35.BottomAttach = ((uint)(2));
			w35.LeftAttach = ((uint)(1));
			w35.RightAttach = ((uint)(2));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Score:");
			this.table1.Add (this.label11);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table1 [this.label11]));
			w36.TopAttach = ((uint)(1));
			w36.BottomAttach = ((uint)(2));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Date:");
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w37.TopAttach = ((uint)(1));
			w37.BottomAttach = ((uint)(2));
			w37.LeftAttach = ((uint)(2));
			w37.RightAttach = ((uint)(3));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Analisys Template:");
			this.table1.Add (this.label9);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table1 [this.label9]));
			w38.TopAttach = ((uint)(2));
			w38.BottomAttach = ((uint)(3));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.seasonentry = new global::Gtk.Entry ();
			this.seasonentry.CanFocus = true;
			this.seasonentry.Name = "seasonentry";
			this.seasonentry.IsEditable = true;
			this.seasonentry.InvisibleChar = '●';
			this.table1.Add (this.seasonentry);
			global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.table1 [this.seasonentry]));
			w39.LeftAttach = ((uint)(1));
			w39.RightAttach = ((uint)(2));
			w39.XOptions = ((global::Gtk.AttachOptions)(4));
			w39.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.seasonlabel = new global::Gtk.Label ();
			this.seasonlabel.Name = "seasonlabel";
			this.seasonlabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Season:");
			this.table1.Add (this.seasonlabel);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.table1 [this.seasonlabel]));
			w40.XOptions = ((global::Gtk.AttachOptions)(4));
			w40.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.tagscombobox = global::Gtk.ComboBox.NewText ();
			this.tagscombobox.Name = "tagscombobox";
			this.table1.Add (this.tagscombobox);
			global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.table1 [this.tagscombobox]));
			w41.TopAttach = ((uint)(2));
			w41.BottomAttach = ((uint)(3));
			w41.LeftAttach = ((uint)(1));
			w41.RightAttach = ((uint)(2));
			w41.XOptions = ((global::Gtk.AttachOptions)(4));
			w41.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox4.Add (this.table1);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.table1]));
			w42.Position = 2;
			w42.Expand = false;
			w42.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hseparator3 = new global::Gtk.HSeparator ();
			this.hseparator3.Name = "hseparator3";
			this.vbox4.Add (this.hseparator3);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hseparator3]));
			w43.Position = 3;
			w43.Expand = false;
			w43.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.filetable = new global::Gtk.Table (((uint)(1)), ((uint)(4)), true);
			this.filetable.Name = "filetable";
			this.filetable.RowSpacing = ((uint)(6));
			this.filetable.ColumnSpacing = ((uint)(6));
			// Container child filetable.Gtk.Table+TableChild
			this.filehbox = new global::Gtk.HBox ();
			this.filehbox.Name = "filehbox";
			this.filehbox.Spacing = 6;
			// Container child filehbox.Gtk.Box+BoxChild
			this.fileEntry = new global::Gtk.Entry ();
			this.fileEntry.CanFocus = true;
			this.fileEntry.Name = "fileEntry";
			this.fileEntry.IsEditable = false;
			this.fileEntry.HasFrame = false;
			this.fileEntry.InvisibleChar = '●';
			this.filehbox.Add (this.fileEntry);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.filehbox [this.fileEntry]));
			w44.Position = 0;
			// Container child filehbox.Gtk.Box+BoxChild
			this.openbutton = new global::Gtk.Button ();
			this.openbutton.CanFocus = true;
			this.openbutton.Name = "openbutton";
			this.openbutton.UseStock = true;
			this.openbutton.UseUnderline = true;
			this.openbutton.Label = "gtk-open";
			this.filehbox.Add (this.openbutton);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.filehbox [this.openbutton]));
			w45.Position = 1;
			w45.Expand = false;
			this.filetable.Add (this.filehbox);
			global::Gtk.Table.TableChild w46 = ((global::Gtk.Table.TableChild)(this.filetable [this.filehbox]));
			w46.LeftAttach = ((uint)(1));
			w46.RightAttach = ((uint)(2));
			w46.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child filetable.Gtk.Table+TableChild
			this.filelabel = new global::Gtk.Label ();
			this.filelabel.Name = "filelabel";
			this.filelabel.LabelProp = global::Mono.Unix.Catalog.GetString ("File:");
			this.filetable.Add (this.filelabel);
			global::Gtk.Table.TableChild w47 = ((global::Gtk.Table.TableChild)(this.filetable [this.filelabel]));
			w47.XOptions = ((global::Gtk.AttachOptions)(4));
			w47.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox4.Add (this.filetable);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.filetable]));
			w48.Position = 4;
			w48.Expand = false;
			w48.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.outputfiletable = new global::Gtk.Table (((uint)(1)), ((uint)(4)), true);
			this.outputfiletable.Name = "outputfiletable";
			this.outputfiletable.RowSpacing = ((uint)(6));
			this.outputfiletable.ColumnSpacing = ((uint)(6));
			// Container child outputfiletable.Gtk.Table+TableChild
			this.outputfilehbox1 = new global::Gtk.HBox ();
			this.outputfilehbox1.Name = "outputfilehbox1";
			this.outputfilehbox1.Spacing = 6;
			// Container child outputfilehbox1.Gtk.Box+BoxChild
			this.outfileEntry = new global::Gtk.Entry ();
			this.outfileEntry.CanFocus = true;
			this.outfileEntry.Name = "outfileEntry";
			this.outfileEntry.IsEditable = false;
			this.outfileEntry.HasFrame = false;
			this.outfileEntry.InvisibleChar = '●';
			this.outputfilehbox1.Add (this.outfileEntry);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.outputfilehbox1 [this.outfileEntry]));
			w49.Position = 0;
			// Container child outputfilehbox1.Gtk.Box+BoxChild
			this.savebutton = new global::Gtk.Button ();
			this.savebutton.CanFocus = true;
			this.savebutton.Name = "savebutton";
			this.savebutton.UseStock = true;
			this.savebutton.UseUnderline = true;
			this.savebutton.Label = "gtk-save-as";
			this.outputfilehbox1.Add (this.savebutton);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.outputfilehbox1 [this.savebutton]));
			w50.Position = 1;
			w50.Expand = false;
			this.outputfiletable.Add (this.outputfilehbox1);
			global::Gtk.Table.TableChild w51 = ((global::Gtk.Table.TableChild)(this.outputfiletable [this.outputfilehbox1]));
			w51.LeftAttach = ((uint)(1));
			w51.RightAttach = ((uint)(2));
			w51.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child outputfiletable.Gtk.Table+TableChild
			this.outputfilelabel = new global::Gtk.Label ();
			this.outputfilelabel.Name = "outputfilelabel";
			this.outputfilelabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Output file:");
			this.outputfiletable.Add (this.outputfilelabel);
			global::Gtk.Table.TableChild w52 = ((global::Gtk.Table.TableChild)(this.outputfiletable [this.outputfilelabel]));
			w52.XOptions = ((global::Gtk.AttachOptions)(4));
			w52.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox4.Add (this.outputfiletable);
			global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.outputfiletable]));
			w53.Position = 5;
			w53.Expand = false;
			w53.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.capturetable = new global::Gtk.Table (((uint)(2)), ((uint)(4)), true);
			this.capturetable.Name = "capturetable";
			this.capturetable.RowSpacing = ((uint)(6));
			this.capturetable.ColumnSpacing = ((uint)(6));
			// Container child capturetable.Gtk.Table+TableChild
			this.encodingcombobox = global::Gtk.ComboBox.NewText ();
			this.encodingcombobox.Name = "encodingcombobox";
			this.capturetable.Add (this.encodingcombobox);
			global::Gtk.Table.TableChild w54 = ((global::Gtk.Table.TableChild)(this.capturetable [this.encodingcombobox]));
			w54.LeftAttach = ((uint)(3));
			w54.RightAttach = ((uint)(4));
			w54.XOptions = ((global::Gtk.AttachOptions)(4));
			w54.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child capturetable.Gtk.Table+TableChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.device = new global::Gtk.Label ();
			this.device.Name = "device";
			this.device.LabelProp = global::Mono.Unix.Catalog.GetString ("Device:");
			this.hbox6.Add (this.device);
			global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.device]));
			w55.Position = 0;
			// Container child hbox6.Gtk.Box+BoxChild
			this.urilabel = new global::Gtk.Label ();
			this.urilabel.Name = "urilabel";
			this.urilabel.LabelProp = global::Mono.Unix.Catalog.GetString ("URL:");
			this.hbox6.Add (this.urilabel);
			global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.urilabel]));
			w56.Position = 1;
			this.capturetable.Add (this.hbox6);
			global::Gtk.Table.TableChild w57 = ((global::Gtk.Table.TableChild)(this.capturetable [this.hbox6]));
			w57.XOptions = ((global::Gtk.AttachOptions)(4));
			w57.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child capturetable.Gtk.Table+TableChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.devicecombobox = global::Gtk.ComboBox.NewText ();
			this.devicecombobox.Name = "devicecombobox";
			this.hbox7.Add (this.devicecombobox);
			global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.devicecombobox]));
			w58.Position = 0;
			// Container child hbox7.Gtk.Box+BoxChild
			this.urientry = new global::Gtk.Entry ();
			this.urientry.CanFocus = true;
			this.urientry.Name = "urientry";
			this.urientry.IsEditable = true;
			this.urientry.InvisibleChar = '•';
			this.hbox7.Add (this.urientry);
			global::Gtk.Box.BoxChild w59 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.urientry]));
			w59.Position = 1;
			this.capturetable.Add (this.hbox7);
			global::Gtk.Table.TableChild w60 = ((global::Gtk.Table.TableChild)(this.capturetable [this.hbox7]));
			w60.LeftAttach = ((uint)(1));
			w60.RightAttach = ((uint)(2));
			w60.XOptions = ((global::Gtk.AttachOptions)(4));
			w60.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child capturetable.Gtk.Table+TableChild
			this.imagecombobox = global::Gtk.ComboBox.NewText ();
			this.imagecombobox.Name = "imagecombobox";
			this.capturetable.Add (this.imagecombobox);
			global::Gtk.Table.TableChild w61 = ((global::Gtk.Table.TableChild)(this.capturetable [this.imagecombobox]));
			w61.TopAttach = ((uint)(1));
			w61.BottomAttach = ((uint)(2));
			w61.LeftAttach = ((uint)(1));
			w61.RightAttach = ((uint)(2));
			w61.XOptions = ((global::Gtk.AttachOptions)(4));
			w61.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child capturetable.Gtk.Table+TableChild
			this.qualitycombobox = global::Gtk.ComboBox.NewText ();
			this.qualitycombobox.Name = "qualitycombobox";
			this.capturetable.Add (this.qualitycombobox);
			global::Gtk.Table.TableChild w62 = ((global::Gtk.Table.TableChild)(this.capturetable [this.qualitycombobox]));
			w62.TopAttach = ((uint)(1));
			w62.BottomAttach = ((uint)(2));
			w62.LeftAttach = ((uint)(3));
			w62.RightAttach = ((uint)(4));
			w62.XOptions = ((global::Gtk.AttachOptions)(4));
			w62.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child capturetable.Gtk.Table+TableChild
			this.qualitylabel = new global::Gtk.Label ();
			this.qualitylabel.Name = "qualitylabel";
			this.qualitylabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Quality:");
			this.capturetable.Add (this.qualitylabel);
			global::Gtk.Table.TableChild w63 = ((global::Gtk.Table.TableChild)(this.capturetable [this.qualitylabel]));
			w63.TopAttach = ((uint)(1));
			w63.BottomAttach = ((uint)(2));
			w63.LeftAttach = ((uint)(2));
			w63.RightAttach = ((uint)(3));
			w63.XOptions = ((global::Gtk.AttachOptions)(4));
			w63.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child capturetable.Gtk.Table+TableChild
			this.sizelabel = new global::Gtk.Label ();
			this.sizelabel.Name = "sizelabel";
			this.sizelabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Image format:");
			this.capturetable.Add (this.sizelabel);
			global::Gtk.Table.TableChild w64 = ((global::Gtk.Table.TableChild)(this.capturetable [this.sizelabel]));
			w64.TopAttach = ((uint)(1));
			w64.BottomAttach = ((uint)(2));
			w64.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child capturetable.Gtk.Table+TableChild
			this.videoformatlabel = new global::Gtk.Label ();
			this.videoformatlabel.Name = "videoformatlabel";
			this.videoformatlabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Encoding format:");
			this.capturetable.Add (this.videoformatlabel);
			global::Gtk.Table.TableChild w65 = ((global::Gtk.Table.TableChild)(this.capturetable [this.videoformatlabel]));
			w65.LeftAttach = ((uint)(2));
			w65.RightAttach = ((uint)(3));
			w65.XOptions = ((global::Gtk.AttachOptions)(4));
			w65.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox4.Add (this.capturetable);
			global::Gtk.Box.BoxChild w66 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.capturetable]));
			w66.Position = 6;
			w66.Expand = false;
			w66.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Homogeneous = true;
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment6 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment6.Name = "GtkAlignment6";
			this.GtkAlignment6.LeftPadding = ((uint)(12));
			// Container child GtkAlignment6.Gtk.Container+ContainerChild
			this.localteamplayersselection = new global::LongoMatch.Gui.Component.TeamPlayersSelection ();
			this.localteamplayersselection.Events = ((global::Gdk.EventMask)(256));
			this.localteamplayersselection.Name = "localteamplayersselection";
			this.GtkAlignment6.Add (this.localteamplayersselection);
			this.frame1.Add (this.GtkAlignment6);
			this.GtkLabel10 = new global::Gtk.Label ();
			this.GtkLabel10.Name = "GtkLabel10";
			this.GtkLabel10.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Home team</b>");
			this.GtkLabel10.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel10;
			this.hbox8.Add (this.frame1);
			global::Gtk.Box.BoxChild w69 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.frame1]));
			w69.Position = 0;
			// Container child hbox8.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment7 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment7.Name = "GtkAlignment7";
			this.GtkAlignment7.LeftPadding = ((uint)(12));
			// Container child GtkAlignment7.Gtk.Container+ContainerChild
			this.awayteamplayersselection = new global::LongoMatch.Gui.Component.TeamPlayersSelection ();
			this.awayteamplayersselection.Events = ((global::Gdk.EventMask)(256));
			this.awayteamplayersselection.Name = "awayteamplayersselection";
			this.GtkAlignment7.Add (this.awayteamplayersselection);
			this.frame2.Add (this.GtkAlignment7);
			this.GtkLabel11 = new global::Gtk.Label ();
			this.GtkLabel11.Name = "GtkLabel11";
			this.GtkLabel11.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Away team</b>");
			this.GtkLabel11.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel11;
			this.hbox8.Add (this.frame2);
			global::Gtk.Box.BoxChild w72 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.frame2]));
			w72.Position = 1;
			this.vbox4.Add (this.hbox8);
			global::Gtk.Box.BoxChild w73 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox8]));
			w73.Position = 7;
			this.notebook1.Add (this.vbox4);
			global::Gtk.Notebook.NotebookChild w74 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox4]));
			w74.Position = 1;
			w74.TabFill = false;
			w74.MenuLabel = "";
			// Notebook tab
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("page2");
			this.notebook1.SetTabLabel (this.vbox4, this.label3);
			this.label3.ShowAll ();
			this.hbox3.Add (this.notebook1);
			global::Gtk.Box.BoxChild w75 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.notebook1]));
			w75.Position = 1;
			this.vbox2.Add (this.hbox3);
			global::Gtk.Box.BoxChild w76 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
			w76.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbuttonbox2 = new global::Gtk.HButtonBox ();
			this.hbuttonbox2.Name = "hbuttonbox2";
			this.hbuttonbox2.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.backbutton = new global::Gtk.Button ();
			this.backbutton.CanFocus = true;
			this.backbutton.Name = "backbutton";
			this.backbutton.UseUnderline = true;
			// Container child backbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w77 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w78 = new global::Gtk.HBox ();
			w78.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w79 = new global::Gtk.Image ();
			w79.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-back", global::Gtk.IconSize.Dialog);
			w78.Add (w79);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w81 = new global::Gtk.Label ();
			w81.LabelProp = global::Mono.Unix.Catalog.GetString ("_Back");
			w81.UseUnderline = true;
			w78.Add (w81);
			w77.Add (w78);
			this.backbutton.Add (w77);
			this.hbuttonbox2.Add (this.backbutton);
			global::Gtk.ButtonBox.ButtonBoxChild w85 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.backbutton]));
			w85.Expand = false;
			w85.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.nextbutton = new global::Gtk.Button ();
			this.nextbutton.CanFocus = true;
			this.nextbutton.Name = "nextbutton";
			this.nextbutton.UseUnderline = true;
			// Container child nextbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w86 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w87 = new global::Gtk.HBox ();
			w87.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w88 = new global::Gtk.Image ();
			w88.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-forward", global::Gtk.IconSize.Dialog);
			w87.Add (w88);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w90 = new global::Gtk.Label ();
			w90.LabelProp = global::Mono.Unix.Catalog.GetString ("_Next");
			w90.UseUnderline = true;
			w87.Add (w90);
			w86.Add (w87);
			this.nextbutton.Add (w86);
			this.hbuttonbox2.Add (this.nextbutton);
			global::Gtk.ButtonBox.ButtonBoxChild w94 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.nextbutton]));
			w94.Position = 1;
			w94.Expand = false;
			w94.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.createbutton = new global::Gtk.Button ();
			this.createbutton.CanFocus = true;
			this.createbutton.Name = "createbutton";
			this.createbutton.UseUnderline = true;
			// Container child createbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w95 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w96 = new global::Gtk.HBox ();
			w96.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w97 = new global::Gtk.Image ();
			w97.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-new", global::Gtk.IconSize.Dialog);
			w96.Add (w97);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w99 = new global::Gtk.Label ();
			w99.LabelProp = global::Mono.Unix.Catalog.GetString ("Create project");
			w99.UseUnderline = true;
			w96.Add (w99);
			w95.Add (w96);
			this.createbutton.Add (w95);
			this.hbuttonbox2.Add (this.createbutton);
			global::Gtk.ButtonBox.ButtonBoxChild w103 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.createbutton]));
			w103.Position = 2;
			w103.Expand = false;
			w103.Fill = false;
			this.vbox2.Add (this.hbuttonbox2);
			global::Gtk.Box.BoxChild w104 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbuttonbox2]));
			w104.Position = 1;
			w104.Expand = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.filetable.Hide ();
			this.outputfiletable.Hide ();
			this.device.Hide ();
			this.urilabel.Hide ();
			this.devicecombobox.Hide ();
			this.urientry.Hide ();
			this.capturetable.Hide ();
			this.createbutton.Hide ();
			this.Hide ();
		}
	}
}
