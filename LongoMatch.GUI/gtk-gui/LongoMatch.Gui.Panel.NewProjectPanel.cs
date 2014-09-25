
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Panel
{
	public partial class NewProjectPanel
	{
		private global::Gtk.VBox vbox3;
		private global::Gtk.EventBox headereventbox;
		private global::LongoMatch.Gui.Panel.PanelHeader panelheader1;
		private global::Gtk.Notebook notebook1;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.HBox hbox11;
		private global::Gtk.VBox vbox12;
		private global::Gtk.Alignment alignment4;
		private global::Gtk.Button filebutton;
		private global::Gtk.Image fileimage;
		private global::Gtk.Label label2;
		private global::Gtk.VBox vbox13;
		private global::Gtk.Alignment alignment3;
		private global::Gtk.Button capturebutton;
		private global::Gtk.Image captureimage;
		private global::Gtk.Label label4;
		private global::Gtk.VBox vbox14;
		private global::Gtk.Alignment alignment5;
		private global::Gtk.Button fakebutton;
		private global::Gtk.Image fakeimage;
		private global::Gtk.Label label5;
		private global::Gtk.VBox vbox15;
		private global::Gtk.Alignment alignment6;
		private global::Gtk.Button ipbutton;
		private global::Gtk.Image ipimage;
		private global::Gtk.Label label6;
		private global::Gtk.Label label1;
		private global::Gtk.VBox vbox5;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.HBox topbox;
		private global::Gtk.Table lefttable;
		private global::Gtk.Entry competitionentry;
		private global::Gtk.Label Competitionlabel;
		private global::Gtk.Label datelabel2;
		private global::LongoMatch.Gui.Component.DatePicker datepicker1;
		private global::Gtk.Entry seasonentry;
		private global::Gtk.Label seasonlabel;
		private global::Gtk.VBox centerbox;
		private global::Gtk.HBox hbox15;
		private global::LongoMatch.Gui.Component.HomeTeamsComboBox hometeamscombobox;
		private global::Gtk.Image vsimage;
		private global::LongoMatch.Gui.Component.AwayTeamsComboBox awayteamscombobox;
		private global::Gtk.Label filelabel;
		private global::Gtk.Table filetable;
		private global::LongoMatch.Gui.Component.MediaFileChooser mediafilechooser1;
		private global::LongoMatch.Gui.Component.MediaFileChooser mediafilechooser2;
		private global::Gtk.Table outputfiletable;
		private global::LongoMatch.Gui.Component.MediaFileChooser capturemediafilechooser;
		private global::Gtk.Label outputfilelabel;
		private global::Gtk.HBox hbox10;
		private global::Gtk.Table lcapturetable;
		private global::Gtk.HBox hbox6;
		private global::Gtk.Label device;
		private global::Gtk.Label urilabel;
		private global::Gtk.HBox hbox7;
		private global::Gtk.ComboBox devicecombobox;
		private global::Gtk.Entry urientry;
		private global::Gtk.ComboBox imagecombobox;
		private global::Gtk.Label sizelabel;
		private global::Gtk.Table rcapturetable;
		private global::Gtk.ComboBox encodingcombobox;
		private global::Gtk.ComboBox qualitycombobox;
		private global::Gtk.Label qualitylabel;
		private global::Gtk.Label videoformatlabel;
		private global::Gtk.Table righttable;
		private global::Gtk.Label analysislabel;
		private global::Gtk.ComboBox tagscombobox;
		private global::Gtk.VBox vbox6;
		private global::Gtk.DrawingArea drawingarea;
		private global::Gtk.Label label3;
		private global::LongoMatch.Gui.Component.ProjectPeriods projectperiods1;
		private global::Gtk.Label label7;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Panel.NewProjectPanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Panel.NewProjectPanel";
			// Container child LongoMatch.Gui.Panel.NewProjectPanel.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			// Container child vbox3.Gtk.Box+BoxChild
			this.headereventbox = new global::Gtk.EventBox ();
			this.headereventbox.Name = "headereventbox";
			// Container child headereventbox.Gtk.Container+ContainerChild
			this.panelheader1 = new global::LongoMatch.Gui.Panel.PanelHeader ();
			this.panelheader1.Events = ((global::Gdk.EventMask)(256));
			this.panelheader1.Name = "panelheader1";
			this.headereventbox.Add (this.panelheader1);
			this.vbox3.Add (this.headereventbox);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.headereventbox]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			this.notebook1.ShowBorder = false;
			this.notebook1.Scrollable = true;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			this.alignment2.Name = "alignment2";
			// Container child alignment2.Gtk.Container+ContainerChild
			this.hbox11 = new global::Gtk.HBox ();
			this.hbox11.Name = "hbox11";
			this.hbox11.Homogeneous = true;
			// Container child hbox11.Gtk.Box+BoxChild
			this.vbox12 = new global::Gtk.VBox ();
			this.vbox12.Name = "vbox12";
			this.vbox12.Spacing = 6;
			// Container child vbox12.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			this.alignment4.Name = "alignment4";
			// Container child alignment4.Gtk.Container+ContainerChild
			this.filebutton = new global::Gtk.Button ();
			this.filebutton.WidthRequest = 100;
			this.filebutton.HeightRequest = 100;
			this.filebutton.CanFocus = true;
			this.filebutton.Name = "filebutton";
			// Container child filebutton.Gtk.Container+ContainerChild
			this.fileimage = new global::Gtk.Image ();
			this.fileimage.Name = "fileimage";
			this.filebutton.Add (this.fileimage);
			this.filebutton.Label = null;
			this.alignment4.Add (this.filebutton);
			this.vbox12.Add (this.alignment4);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox12 [this.alignment4]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox12.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.WidthRequest = 180;
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Video file");
			this.vbox12.Add (this.label2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox12 [this.label2]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.hbox11.Add (this.vbox12);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.vbox12]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.vbox13 = new global::Gtk.VBox ();
			this.vbox13.Name = "vbox13";
			this.vbox13.Spacing = 6;
			// Container child vbox13.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			this.alignment3.Name = "alignment3";
			// Container child alignment3.Gtk.Container+ContainerChild
			this.capturebutton = new global::Gtk.Button ();
			this.capturebutton.WidthRequest = 100;
			this.capturebutton.HeightRequest = 100;
			this.capturebutton.CanFocus = true;
			this.capturebutton.Name = "capturebutton";
			// Container child capturebutton.Gtk.Container+ContainerChild
			this.captureimage = new global::Gtk.Image ();
			this.captureimage.Name = "captureimage";
			this.capturebutton.Add (this.captureimage);
			this.capturebutton.Label = null;
			this.alignment3.Add (this.capturebutton);
			this.vbox13.Add (this.alignment3);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox13 [this.alignment3]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.WidthRequest = 180;
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Capture device");
			this.vbox13.Add (this.label4);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox13 [this.label4]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.hbox11.Add (this.vbox13);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.vbox13]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.vbox14 = new global::Gtk.VBox ();
			this.vbox14.Name = "vbox14";
			this.vbox14.Spacing = 6;
			// Container child vbox14.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			this.alignment5.Name = "alignment5";
			// Container child alignment5.Gtk.Container+ContainerChild
			this.fakebutton = new global::Gtk.Button ();
			this.fakebutton.WidthRequest = 100;
			this.fakebutton.HeightRequest = 100;
			this.fakebutton.CanFocus = true;
			this.fakebutton.Name = "fakebutton";
			// Container child fakebutton.Gtk.Container+ContainerChild
			this.fakeimage = new global::Gtk.Image ();
			this.fakeimage.Name = "fakeimage";
			this.fakebutton.Add (this.fakeimage);
			this.fakebutton.Label = null;
			this.alignment5.Add (this.fakebutton);
			this.vbox14.Add (this.alignment5);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox14 [this.alignment5]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox14.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.WidthRequest = 180;
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Fake capture device");
			this.vbox14.Add (this.label5);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox14 [this.label5]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			this.hbox11.Add (this.vbox14);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.vbox14]));
			w17.Position = 2;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.vbox15 = new global::Gtk.VBox ();
			this.vbox15.Name = "vbox15";
			this.vbox15.Spacing = 6;
			// Container child vbox15.Gtk.Box+BoxChild
			this.alignment6 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			this.alignment6.Name = "alignment6";
			// Container child alignment6.Gtk.Container+ContainerChild
			this.ipbutton = new global::Gtk.Button ();
			this.ipbutton.WidthRequest = 100;
			this.ipbutton.HeightRequest = 100;
			this.ipbutton.CanFocus = true;
			this.ipbutton.Name = "ipbutton";
			// Container child ipbutton.Gtk.Container+ContainerChild
			this.ipimage = new global::Gtk.Image ();
			this.ipimage.Name = "ipimage";
			this.ipbutton.Add (this.ipimage);
			this.ipbutton.Label = null;
			this.alignment6.Add (this.ipbutton);
			this.vbox15.Add (this.alignment6);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox15 [this.alignment6]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox15.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.WidthRequest = 180;
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Ip camera");
			this.vbox15.Add (this.label6);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox15 [this.label6]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			this.hbox11.Add (this.vbox15);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.vbox15]));
			w22.Position = 3;
			w22.Expand = false;
			w22.Fill = false;
			this.alignment2.Add (this.hbox11);
			this.notebook1.Add (this.alignment2);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("page1");
			this.notebook1.SetTabLabel (this.alignment2, this.label1);
			this.label1.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.topbox = new global::Gtk.HBox ();
			this.topbox.Name = "topbox";
			this.topbox.Spacing = 6;
			// Container child topbox.Gtk.Box+BoxChild
			this.lefttable = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.lefttable.Name = "lefttable";
			this.lefttable.RowSpacing = ((uint)(6));
			this.lefttable.ColumnSpacing = ((uint)(6));
			// Container child lefttable.Gtk.Table+TableChild
			this.competitionentry = new global::Gtk.Entry ();
			this.competitionentry.CanFocus = true;
			this.competitionentry.Name = "competitionentry";
			this.competitionentry.IsEditable = true;
			this.competitionentry.InvisibleChar = '●';
			this.lefttable.Add (this.competitionentry);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.lefttable [this.competitionentry]));
			w25.TopAttach = ((uint)(1));
			w25.BottomAttach = ((uint)(2));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child lefttable.Gtk.Table+TableChild
			this.Competitionlabel = new global::Gtk.Label ();
			this.Competitionlabel.Name = "Competitionlabel";
			this.Competitionlabel.Xalign = 1F;
			this.Competitionlabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Competition");
			this.lefttable.Add (this.Competitionlabel);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.lefttable [this.Competitionlabel]));
			w26.TopAttach = ((uint)(1));
			w26.BottomAttach = ((uint)(2));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child lefttable.Gtk.Table+TableChild
			this.datelabel2 = new global::Gtk.Label ();
			this.datelabel2.Name = "datelabel2";
			this.datelabel2.Xalign = 1F;
			this.datelabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("Date");
			this.lefttable.Add (this.datelabel2);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.lefttable [this.datelabel2]));
			w27.TopAttach = ((uint)(2));
			w27.BottomAttach = ((uint)(3));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child lefttable.Gtk.Table+TableChild
			this.datepicker1 = new global::LongoMatch.Gui.Component.DatePicker ();
			this.datepicker1.Events = ((global::Gdk.EventMask)(256));
			this.datepicker1.Name = "datepicker1";
			this.datepicker1.Date = new global::System.DateTime (0);
			this.lefttable.Add (this.datepicker1);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.lefttable [this.datepicker1]));
			w28.TopAttach = ((uint)(2));
			w28.BottomAttach = ((uint)(3));
			w28.LeftAttach = ((uint)(1));
			w28.RightAttach = ((uint)(2));
			w28.XOptions = ((global::Gtk.AttachOptions)(0));
			w28.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child lefttable.Gtk.Table+TableChild
			this.seasonentry = new global::Gtk.Entry ();
			this.seasonentry.CanFocus = true;
			this.seasonentry.Name = "seasonentry";
			this.seasonentry.IsEditable = true;
			this.seasonentry.InvisibleChar = '●';
			this.lefttable.Add (this.seasonentry);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.lefttable [this.seasonentry]));
			w29.LeftAttach = ((uint)(1));
			w29.RightAttach = ((uint)(2));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child lefttable.Gtk.Table+TableChild
			this.seasonlabel = new global::Gtk.Label ();
			this.seasonlabel.Name = "seasonlabel";
			this.seasonlabel.Xalign = 1F;
			this.seasonlabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Season");
			this.lefttable.Add (this.seasonlabel);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.lefttable [this.seasonlabel]));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			this.topbox.Add (this.lefttable);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.topbox [this.lefttable]));
			w31.Position = 0;
			w31.Expand = false;
			w31.Fill = false;
			// Container child topbox.Gtk.Box+BoxChild
			this.centerbox = new global::Gtk.VBox ();
			this.centerbox.WidthRequest = 500;
			this.centerbox.Name = "centerbox";
			this.centerbox.Spacing = 6;
			// Container child centerbox.Gtk.Box+BoxChild
			this.hbox15 = new global::Gtk.HBox ();
			this.hbox15.HeightRequest = 60;
			this.hbox15.Name = "hbox15";
			// Container child hbox15.Gtk.Box+BoxChild
			this.hometeamscombobox = new global::LongoMatch.Gui.Component.HomeTeamsComboBox ();
			this.hometeamscombobox.Name = "hometeamscombobox";
			this.hbox15.Add (this.hometeamscombobox);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox15 [this.hometeamscombobox]));
			w32.Position = 0;
			// Container child hbox15.Gtk.Box+BoxChild
			this.vsimage = new global::Gtk.Image ();
			this.vsimage.Name = "vsimage";
			this.hbox15.Add (this.vsimage);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox15 [this.vsimage]));
			w33.Position = 1;
			w33.Expand = false;
			w33.Fill = false;
			// Container child hbox15.Gtk.Box+BoxChild
			this.awayteamscombobox = new global::LongoMatch.Gui.Component.AwayTeamsComboBox ();
			this.awayteamscombobox.Name = "awayteamscombobox";
			this.hbox15.Add (this.awayteamscombobox);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox15 [this.awayteamscombobox]));
			w34.Position = 2;
			this.centerbox.Add (this.hbox15);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.centerbox [this.hbox15]));
			w35.Position = 0;
			w35.Expand = false;
			w35.Fill = false;
			// Container child centerbox.Gtk.Box+BoxChild
			this.filelabel = new global::Gtk.Label ();
			this.filelabel.Name = "filelabel";
			this.filelabel.Xalign = 0F;
			this.filelabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Video files");
			this.centerbox.Add (this.filelabel);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.centerbox [this.filelabel]));
			w36.Position = 1;
			w36.Expand = false;
			w36.Fill = false;
			// Container child centerbox.Gtk.Box+BoxChild
			this.filetable = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.filetable.Name = "filetable";
			this.filetable.RowSpacing = ((uint)(6));
			this.filetable.ColumnSpacing = ((uint)(6));
			// Container child filetable.Gtk.Table+TableChild
			this.mediafilechooser1 = new global::LongoMatch.Gui.Component.MediaFileChooser ();
			this.mediafilechooser1.Events = ((global::Gdk.EventMask)(256));
			this.mediafilechooser1.Name = "mediafilechooser1";
			this.filetable.Add (this.mediafilechooser1);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.filetable [this.mediafilechooser1]));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child filetable.Gtk.Table+TableChild
			this.mediafilechooser2 = new global::LongoMatch.Gui.Component.MediaFileChooser ();
			this.mediafilechooser2.Events = ((global::Gdk.EventMask)(256));
			this.mediafilechooser2.Name = "mediafilechooser2";
			this.filetable.Add (this.mediafilechooser2);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.filetable [this.mediafilechooser2]));
			w38.LeftAttach = ((uint)(1));
			w38.RightAttach = ((uint)(2));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			this.centerbox.Add (this.filetable);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.centerbox [this.filetable]));
			w39.Position = 2;
			// Container child centerbox.Gtk.Box+BoxChild
			this.outputfiletable = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
			this.outputfiletable.Name = "outputfiletable";
			this.outputfiletable.RowSpacing = ((uint)(6));
			this.outputfiletable.ColumnSpacing = ((uint)(6));
			// Container child outputfiletable.Gtk.Table+TableChild
			this.capturemediafilechooser = new global::LongoMatch.Gui.Component.MediaFileChooser ();
			this.capturemediafilechooser.Events = ((global::Gdk.EventMask)(256));
			this.capturemediafilechooser.Name = "capturemediafilechooser";
			this.outputfiletable.Add (this.capturemediafilechooser);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.outputfiletable [this.capturemediafilechooser]));
			w40.LeftAttach = ((uint)(1));
			w40.RightAttach = ((uint)(2));
			w40.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child outputfiletable.Gtk.Table+TableChild
			this.outputfilelabel = new global::Gtk.Label ();
			this.outputfilelabel.Name = "outputfilelabel";
			this.outputfilelabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Output file");
			this.outputfiletable.Add (this.outputfilelabel);
			global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.outputfiletable [this.outputfilelabel]));
			w41.XOptions = ((global::Gtk.AttachOptions)(4));
			w41.YOptions = ((global::Gtk.AttachOptions)(4));
			this.centerbox.Add (this.outputfiletable);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.centerbox [this.outputfiletable]));
			w42.Position = 3;
			w42.Expand = false;
			w42.Fill = false;
			// Container child centerbox.Gtk.Box+BoxChild
			this.hbox10 = new global::Gtk.HBox ();
			this.hbox10.Name = "hbox10";
			this.hbox10.Homogeneous = true;
			this.hbox10.Spacing = 6;
			// Container child hbox10.Gtk.Box+BoxChild
			this.lcapturetable = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.lcapturetable.Name = "lcapturetable";
			this.lcapturetable.RowSpacing = ((uint)(6));
			this.lcapturetable.ColumnSpacing = ((uint)(6));
			// Container child lcapturetable.Gtk.Table+TableChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.device = new global::Gtk.Label ();
			this.device.Name = "device";
			this.device.LabelProp = global::Mono.Unix.Catalog.GetString ("Device");
			this.hbox6.Add (this.device);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.device]));
			w43.Position = 0;
			// Container child hbox6.Gtk.Box+BoxChild
			this.urilabel = new global::Gtk.Label ();
			this.urilabel.Name = "urilabel";
			this.urilabel.LabelProp = global::Mono.Unix.Catalog.GetString ("URL");
			this.hbox6.Add (this.urilabel);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.urilabel]));
			w44.Position = 1;
			this.lcapturetable.Add (this.hbox6);
			global::Gtk.Table.TableChild w45 = ((global::Gtk.Table.TableChild)(this.lcapturetable [this.hbox6]));
			w45.XOptions = ((global::Gtk.AttachOptions)(4));
			w45.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child lcapturetable.Gtk.Table+TableChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.devicecombobox = global::Gtk.ComboBox.NewText ();
			this.devicecombobox.Name = "devicecombobox";
			this.hbox7.Add (this.devicecombobox);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.devicecombobox]));
			w46.Position = 0;
			// Container child hbox7.Gtk.Box+BoxChild
			this.urientry = new global::Gtk.Entry ();
			this.urientry.CanFocus = true;
			this.urientry.Name = "urientry";
			this.urientry.IsEditable = true;
			this.urientry.InvisibleChar = '•';
			this.hbox7.Add (this.urientry);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.urientry]));
			w47.Position = 1;
			this.lcapturetable.Add (this.hbox7);
			global::Gtk.Table.TableChild w48 = ((global::Gtk.Table.TableChild)(this.lcapturetable [this.hbox7]));
			w48.LeftAttach = ((uint)(1));
			w48.RightAttach = ((uint)(2));
			w48.XOptions = ((global::Gtk.AttachOptions)(4));
			w48.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child lcapturetable.Gtk.Table+TableChild
			this.imagecombobox = global::Gtk.ComboBox.NewText ();
			this.imagecombobox.Name = "imagecombobox";
			this.lcapturetable.Add (this.imagecombobox);
			global::Gtk.Table.TableChild w49 = ((global::Gtk.Table.TableChild)(this.lcapturetable [this.imagecombobox]));
			w49.TopAttach = ((uint)(1));
			w49.BottomAttach = ((uint)(2));
			w49.LeftAttach = ((uint)(1));
			w49.RightAttach = ((uint)(2));
			w49.XOptions = ((global::Gtk.AttachOptions)(4));
			w49.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child lcapturetable.Gtk.Table+TableChild
			this.sizelabel = new global::Gtk.Label ();
			this.sizelabel.Name = "sizelabel";
			this.sizelabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Size");
			this.lcapturetable.Add (this.sizelabel);
			global::Gtk.Table.TableChild w50 = ((global::Gtk.Table.TableChild)(this.lcapturetable [this.sizelabel]));
			w50.TopAttach = ((uint)(1));
			w50.BottomAttach = ((uint)(2));
			w50.XOptions = ((global::Gtk.AttachOptions)(4));
			w50.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox10.Add (this.lcapturetable);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.lcapturetable]));
			w51.Position = 0;
			w51.Expand = false;
			w51.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.rcapturetable = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.rcapturetable.Name = "rcapturetable";
			this.rcapturetable.RowSpacing = ((uint)(6));
			this.rcapturetable.ColumnSpacing = ((uint)(6));
			// Container child rcapturetable.Gtk.Table+TableChild
			this.encodingcombobox = global::Gtk.ComboBox.NewText ();
			this.encodingcombobox.Name = "encodingcombobox";
			this.rcapturetable.Add (this.encodingcombobox);
			global::Gtk.Table.TableChild w52 = ((global::Gtk.Table.TableChild)(this.rcapturetable [this.encodingcombobox]));
			w52.LeftAttach = ((uint)(1));
			w52.RightAttach = ((uint)(2));
			w52.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child rcapturetable.Gtk.Table+TableChild
			this.qualitycombobox = global::Gtk.ComboBox.NewText ();
			this.qualitycombobox.Name = "qualitycombobox";
			this.rcapturetable.Add (this.qualitycombobox);
			global::Gtk.Table.TableChild w53 = ((global::Gtk.Table.TableChild)(this.rcapturetable [this.qualitycombobox]));
			w53.TopAttach = ((uint)(1));
			w53.BottomAttach = ((uint)(2));
			w53.LeftAttach = ((uint)(1));
			w53.RightAttach = ((uint)(2));
			w53.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child rcapturetable.Gtk.Table+TableChild
			this.qualitylabel = new global::Gtk.Label ();
			this.qualitylabel.Name = "qualitylabel";
			this.qualitylabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Quality");
			this.rcapturetable.Add (this.qualitylabel);
			global::Gtk.Table.TableChild w54 = ((global::Gtk.Table.TableChild)(this.rcapturetable [this.qualitylabel]));
			w54.TopAttach = ((uint)(1));
			w54.BottomAttach = ((uint)(2));
			w54.XOptions = ((global::Gtk.AttachOptions)(4));
			w54.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child rcapturetable.Gtk.Table+TableChild
			this.videoformatlabel = new global::Gtk.Label ();
			this.videoformatlabel.Name = "videoformatlabel";
			this.videoformatlabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Format");
			this.rcapturetable.Add (this.videoformatlabel);
			global::Gtk.Table.TableChild w55 = ((global::Gtk.Table.TableChild)(this.rcapturetable [this.videoformatlabel]));
			w55.XOptions = ((global::Gtk.AttachOptions)(4));
			w55.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox10.Add (this.rcapturetable);
			global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.rcapturetable]));
			w56.Position = 1;
			this.centerbox.Add (this.hbox10);
			global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.centerbox [this.hbox10]));
			w57.Position = 4;
			w57.Expand = false;
			w57.Fill = false;
			this.topbox.Add (this.centerbox);
			global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.topbox [this.centerbox]));
			w58.Position = 1;
			w58.Fill = false;
			// Container child topbox.Gtk.Box+BoxChild
			this.righttable = new global::Gtk.Table (((uint)(3)), ((uint)(2)), true);
			this.righttable.Name = "righttable";
			this.righttable.RowSpacing = ((uint)(6));
			this.righttable.ColumnSpacing = ((uint)(6));
			// Container child righttable.Gtk.Table+TableChild
			this.analysislabel = new global::Gtk.Label ();
			this.analysislabel.Name = "analysislabel";
			this.analysislabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Analysis Template:");
			this.righttable.Add (this.analysislabel);
			global::Gtk.Table.TableChild w59 = ((global::Gtk.Table.TableChild)(this.righttable [this.analysislabel]));
			w59.XOptions = ((global::Gtk.AttachOptions)(4));
			w59.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child righttable.Gtk.Table+TableChild
			this.tagscombobox = global::Gtk.ComboBox.NewText ();
			this.tagscombobox.Name = "tagscombobox";
			this.righttable.Add (this.tagscombobox);
			global::Gtk.Table.TableChild w60 = ((global::Gtk.Table.TableChild)(this.righttable [this.tagscombobox]));
			w60.LeftAttach = ((uint)(1));
			w60.RightAttach = ((uint)(2));
			w60.YOptions = ((global::Gtk.AttachOptions)(0));
			this.topbox.Add (this.righttable);
			global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.topbox [this.righttable]));
			w61.Position = 2;
			w61.Expand = false;
			w61.Fill = false;
			this.alignment1.Add (this.topbox);
			this.vbox5.Add (this.alignment1);
			global::Gtk.Box.BoxChild w63 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.alignment1]));
			w63.Position = 0;
			w63.Expand = false;
			w63.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.drawingarea = new global::Gtk.DrawingArea ();
			this.drawingarea.Name = "drawingarea";
			this.vbox6.Add (this.drawingarea);
			global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.drawingarea]));
			w64.Position = 0;
			this.vbox5.Add (this.vbox6);
			global::Gtk.Box.BoxChild w65 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.vbox6]));
			w65.Position = 1;
			this.notebook1.Add (this.vbox5);
			global::Gtk.Notebook.NotebookChild w66 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox5]));
			w66.Position = 1;
			w66.TabFill = false;
			w66.MenuLabel = "";
			// Notebook tab
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("page2");
			this.notebook1.SetTabLabel (this.vbox5, this.label3);
			this.label3.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.projectperiods1 = new global::LongoMatch.Gui.Component.ProjectPeriods ();
			this.projectperiods1.Events = ((global::Gdk.EventMask)(256));
			this.projectperiods1.Name = "projectperiods1";
			this.notebook1.Add (this.projectperiods1);
			global::Gtk.Notebook.NotebookChild w67 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.projectperiods1]));
			w67.Position = 2;
			// Notebook tab
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("page3");
			this.notebook1.SetTabLabel (this.projectperiods1, this.label7);
			this.label7.ShowAll ();
			this.vbox3.Add (this.notebook1);
			global::Gtk.Box.BoxChild w68 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.notebook1]));
			w68.Position = 1;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.device.Hide ();
			this.urilabel.Hide ();
			this.devicecombobox.Hide ();
			this.urientry.Hide ();
			this.rcapturetable.Hide ();
			this.Hide ();
		}
	}
}
