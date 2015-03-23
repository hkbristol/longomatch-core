
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Dialog
{
	public partial class SubstitutionsEditor
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.HBox playershbox;
		
		private global::Gtk.Frame inframe;
		
		private global::Gtk.Alignment GtkAlignment2;
		
		private global::Gtk.DrawingArea drawingarea2;
		
		private global::Gtk.Label GtkLabel2;
		
		private global::Gtk.Frame outframe;
		
		private global::Gtk.Alignment GtkAlignment3;
		
		private global::Gtk.DrawingArea drawingarea3;
		
		private global::Gtk.Label GtkLabel3;
		
		private global::Gtk.DrawingArea drawingarea;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Dialog.SubstitutionsEditor
			this.Name = "LongoMatch.Gui.Dialog.SubstitutionsEditor";
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "longomatch", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.DestroyWithParent = true;
			this.Gravity = ((global::Gdk.Gravity)(5));
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Internal child LongoMatch.Gui.Dialog.SubstitutionsEditor.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.playershbox = new global::Gtk.HBox ();
			this.playershbox.Name = "playershbox";
			this.playershbox.Spacing = 6;
			// Container child playershbox.Gtk.Box+BoxChild
			this.inframe = new global::Gtk.Frame ();
			this.inframe.Name = "inframe";
			this.inframe.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child inframe.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.drawingarea2 = new global::Gtk.DrawingArea ();
			this.drawingarea2.Name = "drawingarea2";
			this.GtkAlignment2.Add (this.drawingarea2);
			this.inframe.Add (this.GtkAlignment2);
			this.GtkLabel2 = new global::Gtk.Label ();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Player in</b>");
			this.GtkLabel2.UseMarkup = true;
			this.inframe.LabelWidget = this.GtkLabel2;
			this.playershbox.Add (this.inframe);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.playershbox [this.inframe]));
			w4.Position = 0;
			w4.Fill = false;
			// Container child playershbox.Gtk.Box+BoxChild
			this.outframe = new global::Gtk.Frame ();
			this.outframe.Name = "outframe";
			this.outframe.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child outframe.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.drawingarea3 = new global::Gtk.DrawingArea ();
			this.drawingarea3.Name = "drawingarea3";
			this.GtkAlignment3.Add (this.drawingarea3);
			this.outframe.Add (this.GtkAlignment3);
			this.GtkLabel3 = new global::Gtk.Label ();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Player out</b>");
			this.GtkLabel3.UseMarkup = true;
			this.outframe.LabelWidget = this.GtkLabel3;
			this.playershbox.Add (this.outframe);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.playershbox [this.outframe]));
			w7.Position = 1;
			w7.Fill = false;
			this.vbox2.Add (this.playershbox);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.playershbox]));
			w8.Position = 0;
			w8.Expand = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.drawingarea = new global::Gtk.DrawingArea ();
			this.drawingarea.Name = "drawingarea";
			this.vbox2.Add (this.drawingarea);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.drawingarea]));
			w9.Position = 1;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w10.Position = 0;
			// Internal child LongoMatch.Gui.Dialog.SubstitutionsEditor.ActionArea
			global::Gtk.HButtonBox w11 = this.ActionArea;
			w11.Name = "dialog1_ActionArea";
			w11.Spacing = 10;
			w11.BorderWidth = ((uint)(5));
			w11.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w12 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w11 [this.buttonCancel]));
			w12.Expand = false;
			w12.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w11 [this.buttonOk]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 726;
			this.DefaultHeight = 404;
			this.Show ();
		}
	}
}
