
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Dialog
{
	public partial class EventTypeTagsEditor
	{
		private global::Gtk.ScrolledWindow scrolledwindow2;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.VBox mainvbox;

		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Dialog.EventTypeTagsEditor
			this.Name = "LongoMatch.Gui.Dialog.EventTypeTagsEditor";
			this.Title = global::VAS.Core.Catalog.GetString ("Edit event subcategory tags");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "longomatch", global::Gtk.IconSize.Menu);
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.Gravity = ((global::Gdk.Gravity)(5));
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Internal child LongoMatch.Gui.Dialog.EventTypeTagsEditor.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			global::Gtk.Viewport w2 = new global::Gtk.Viewport ();
			w2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0F, 1F, 0F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.mainvbox = new global::Gtk.VBox ();
			this.mainvbox.Name = "mainvbox";
			this.mainvbox.Spacing = 6;
			this.alignment1.Add (this.mainvbox);
			w2.Add (this.alignment1);
			this.scrolledwindow2.Add (w2);
			w1.Add (this.scrolledwindow2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(w1 [this.scrolledwindow2]));
			w6.Position = 0;
			// Internal child LongoMatch.Gui.Dialog.EventTypeTagsEditor.ActionArea
			global::Gtk.HButtonBox w7 = this.ActionArea;
			w7.Name = "dialog1_ActionArea";
			w7.Spacing = 10;
			w7.BorderWidth = ((uint)(5));
			w7.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w7 [this.buttonOk]));
			w8.Expand = false;
			w8.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 1009;
			this.DefaultHeight = 532;
			this.Show ();
		}
	}
}
