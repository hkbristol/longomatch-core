
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class DatePicker
	{
		private global::Gtk.EventBox dateentryeventbox;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Entry dateentry;
		private global::Gtk.Button datebutton;
		private global::Gtk.Image datebuttonimage;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.DatePicker
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.DatePicker";
			// Container child LongoMatch.Gui.Component.DatePicker.Gtk.Container+ContainerChild
			this.dateentryeventbox = new global::Gtk.EventBox ();
			this.dateentryeventbox.Name = "dateentryeventbox";
			// Container child dateentryeventbox.Gtk.Container+ContainerChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.BorderWidth = ((uint)(2));
			// Container child hbox2.Gtk.Box+BoxChild
			this.dateentry = new global::Gtk.Entry ();
			this.dateentry.CanFocus = true;
			this.dateentry.Name = "dateentry";
			this.dateentry.IsEditable = false;
			this.dateentry.HasFrame = false;
			this.dateentry.InvisibleChar = '•';
			this.hbox2.Add (this.dateentry);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.dateentry]));
			w1.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.datebutton = new global::Gtk.Button ();
			this.datebutton.CanFocus = true;
			this.datebutton.Name = "datebutton";
			// Container child datebutton.Gtk.Container+ContainerChild
			this.datebuttonimage = new global::Gtk.Image ();
			this.datebuttonimage.Name = "datebuttonimage";
			this.datebutton.Add (this.datebuttonimage);
			this.datebutton.Label = null;
			this.hbox2.Add (this.datebutton);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.datebutton]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.dateentryeventbox.Add (this.hbox2);
			this.Add (this.dateentryeventbox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
