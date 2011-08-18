
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Dialog
{
	public partial class VideoEditionProperties
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label1;

		private global::Gtk.ComboBox qualitycombobox;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label2;

		private global::Gtk.ComboBox sizecombobox;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Label label3;

		private global::Gtk.ComboBox formatcombobox;

		private global::Gtk.HBox hbox6;

		private global::Gtk.CheckButton descriptioncheckbutton;

		private global::Gtk.CheckButton audiocheckbutton;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label filenamelabel;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Entry fileentry;

		private global::Gtk.Button openbutton;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Dialog.VideoEditionProperties
			this.Name = "LongoMatch.Gui.Dialog.VideoEditionProperties";
			this.Title = global::Mono.Unix.Catalog.GetString ("Video Properties");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "longomatch", global::Gtk.IconSize.Dialog);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.Gravity = ((global::Gdk.Gravity)(5));
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Internal child LongoMatch.Gui.Dialog.VideoEditionProperties.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Homogeneous = true;
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0f;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Video Quality:");
			this.hbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label1]));
			w2.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.qualitycombobox = global::Gtk.ComboBox.NewText ();
			this.qualitycombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Low"));
			this.qualitycombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Normal"));
			this.qualitycombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Good"));
			this.qualitycombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Extra"));
			this.qualitycombobox.Name = "qualitycombobox";
			this.qualitycombobox.Active = 1;
			this.hbox2.Add (this.qualitycombobox);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.qualitycombobox]));
			w3.Position = 1;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Homogeneous = true;
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0f;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Size: ");
			this.hbox4.Add (this.label2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label2]));
			w5.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.sizecombobox = global::Gtk.ComboBox.NewText ();
			this.sizecombobox.Name = "sizecombobox";
			this.hbox4.Add (this.sizecombobox);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.sizecombobox]));
			w6.Position = 1;
			this.vbox2.Add (this.hbox4);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Homogeneous = true;
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0f;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Ouput Format:");
			this.hbox5.Add (this.label3);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label3]));
			w8.Position = 0;
			// Container child hbox5.Gtk.Box+BoxChild
			this.formatcombobox = global::Gtk.ComboBox.NewText ();
			this.formatcombobox.Name = "formatcombobox";
			this.hbox5.Add (this.formatcombobox);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.formatcombobox]));
			w9.Position = 1;
			this.vbox2.Add (this.hbox5);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox5]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.descriptioncheckbutton = new global::Gtk.CheckButton ();
			this.descriptioncheckbutton.CanFocus = true;
			this.descriptioncheckbutton.Name = "descriptioncheckbutton";
			this.descriptioncheckbutton.Label = global::Mono.Unix.Catalog.GetString ("Enable Title Overlay");
			this.descriptioncheckbutton.Active = true;
			this.descriptioncheckbutton.DrawIndicator = true;
			this.descriptioncheckbutton.UseUnderline = true;
			this.hbox6.Add (this.descriptioncheckbutton);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.descriptioncheckbutton]));
			w11.Position = 0;
			// Container child hbox6.Gtk.Box+BoxChild
			this.audiocheckbutton = new global::Gtk.CheckButton ();
			this.audiocheckbutton.CanFocus = true;
			this.audiocheckbutton.Name = "audiocheckbutton";
			this.audiocheckbutton.Label = global::Mono.Unix.Catalog.GetString ("Enable Audio (Experimental)");
			this.audiocheckbutton.DrawIndicator = true;
			this.audiocheckbutton.UseUnderline = true;
			this.hbox6.Add (this.audiocheckbutton);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.audiocheckbutton]));
			w12.Position = 1;
			this.vbox2.Add (this.hbox6);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox6]));
			w13.Position = 3;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.filenamelabel = new global::Gtk.Label ();
			this.filenamelabel.Name = "filenamelabel";
			this.filenamelabel.LabelProp = global::Mono.Unix.Catalog.GetString ("File name: ");
			this.hbox1.Add (this.filenamelabel);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.filenamelabel]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.fileentry = new global::Gtk.Entry ();
			this.fileentry.CanFocus = true;
			this.fileentry.Name = "fileentry";
			this.fileentry.IsEditable = false;
			this.fileentry.InvisibleChar = '●';
			this.hbox3.Add (this.fileentry);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.fileentry]));
			w15.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.openbutton = new global::Gtk.Button ();
			this.openbutton.CanFocus = true;
			this.openbutton.Name = "openbutton";
			this.openbutton.UseStock = true;
			this.openbutton.UseUnderline = true;
			this.openbutton.Label = "gtk-save-as";
			this.hbox3.Add (this.openbutton);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.openbutton]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			this.hbox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.hbox3]));
			w17.Position = 1;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w18.Position = 4;
			w18.Expand = false;
			w18.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(w1[this.vbox2]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Internal child LongoMatch.Gui.Dialog.VideoEditionProperties.ActionArea
			global::Gtk.HButtonBox w20 = this.ActionArea;
			w20.Name = "dialog1_ActionArea";
			w20.Spacing = 6;
			w20.BorderWidth = ((uint)(5));
			w20.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w21 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w20[this.buttonCancel]));
			w21.Expand = false;
			w21.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w22 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w20[this.buttonOk]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 516;
			this.DefaultHeight = 245;
			this.Show ();
			this.openbutton.Clicked += new global::System.EventHandler (this.OnOpenbuttonClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
