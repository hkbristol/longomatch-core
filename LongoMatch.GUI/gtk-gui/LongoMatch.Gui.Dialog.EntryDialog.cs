
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Dialog
{
	public partial class EntryDialog
	{
		private global::Gtk.Table table1;
		
		private global::Gtk.CheckButton checkbutton;
		
		private global::Gtk.Entry entry1;
		
		private global::Gtk.Label existentemplatelabel;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label playerslabel;
		
		private global::Gtk.SpinButton playersspinbutton;
		
		private global::Gtk.ComboBox combobox;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Dialog.EntryDialog
			this.Name = "LongoMatch.Gui.Dialog.EntryDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Select template name");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "longomatch", global::Gtk.IconSize.Dialog);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.Gravity = ((global::Gdk.Gravity)(5));
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Internal child LongoMatch.Gui.Dialog.EntryDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.checkbutton = new global::Gtk.CheckButton ();
			this.checkbutton.CanFocus = true;
			this.checkbutton.Name = "checkbutton";
			this.checkbutton.Label = "";
			this.checkbutton.DrawIndicator = true;
			this.checkbutton.UseUnderline = true;
			this.table1.Add (this.checkbutton);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkbutton]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entry1 = new global::Gtk.Entry ();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '●';
			this.table1.Add (this.entry1);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry1]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.existentemplatelabel = new global::Gtk.Label ();
			this.existentemplatelabel.Name = "existentemplatelabel";
			this.existentemplatelabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Copy existent template:");
			this.table1.Add (this.existentemplatelabel);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.existentemplatelabel]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Name:");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.playerslabel = new global::Gtk.Label ();
			this.playerslabel.Name = "playerslabel";
			this.playerslabel.Xalign = 0F;
			this.playerslabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Players:");
			this.table1.Add (this.playerslabel);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.playerslabel]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.playersspinbutton = new global::Gtk.SpinButton (1, 100, 1);
			this.playersspinbutton.CanFocus = true;
			this.playersspinbutton.Name = "playersspinbutton";
			this.playersspinbutton.Adjustment.PageIncrement = 10;
			this.playersspinbutton.ClimbRate = 1;
			this.playersspinbutton.Numeric = true;
			this.playersspinbutton.Value = 15;
			this.table1.Add (this.playersspinbutton);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.playersspinbutton]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(0));
			w1.Add (this.table1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(w1 [this.table1]));
			w8.Position = 0;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.combobox = global::Gtk.ComboBox.NewText ();
			this.combobox.Sensitive = false;
			this.combobox.Name = "combobox";
			w1.Add (this.combobox);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(w1 [this.combobox]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Internal child LongoMatch.Gui.Dialog.EntryDialog.ActionArea
			global::Gtk.HButtonBox w10 = this.ActionArea;
			w10.Name = "dialog1_ActionArea";
			w10.Spacing = 6;
			w10.BorderWidth = ((uint)(5));
			w10.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w11 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w10 [this.buttonCancel]));
			w11.Expand = false;
			w11.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w12 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w10 [this.buttonOk]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 339;
			this.DefaultHeight = 195;
			this.Show ();
			this.checkbutton.Toggled += new global::System.EventHandler (this.OnCheckbuttonToggled);
		}
	}
}
