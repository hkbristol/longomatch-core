
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class AnalysisTemplateEditor
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox1;
		private global::LongoMatch.Gui.Component.ButtonsWidget buttonswidget;
		private global::LongoMatch.Gui.Component.CategoryProperties categoryproperties;
		private global::Gtk.HButtonBox hbuttonbox2;
		private global::Gtk.Button button486;
		private global::Gtk.Button button485;
		private global::Gtk.Button button484;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.AnalysisTemplateEditor
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.AnalysisTemplateEditor";
			// Container child LongoMatch.Gui.Component.AnalysisTemplateEditor.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonswidget = new global::LongoMatch.Gui.Component.ButtonsWidget ();
			this.buttonswidget.Events = ((global::Gdk.EventMask)(256));
			this.buttonswidget.Name = "buttonswidget";
			this.hbox1.Add (this.buttonswidget);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonswidget]));
			w1.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.categoryproperties = new global::LongoMatch.Gui.Component.CategoryProperties ();
			this.categoryproperties.Events = ((global::Gdk.EventMask)(256));
			this.categoryproperties.Name = "categoryproperties";
			this.hbox1.Add (this.categoryproperties);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.categoryproperties]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w3.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbuttonbox2 = new global::Gtk.HButtonBox ();
			this.hbuttonbox2.Name = "hbuttonbox2";
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.button486 = new global::Gtk.Button ();
			this.button486.CanFocus = true;
			this.button486.Name = "button486";
			this.button486.UseUnderline = true;
			this.button486.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
			this.hbuttonbox2.Add (this.button486);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.button486]));
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.button485 = new global::Gtk.Button ();
			this.button485.CanFocus = true;
			this.button485.Name = "button485";
			this.button485.UseUnderline = true;
			this.button485.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
			this.hbuttonbox2.Add (this.button485);
			global::Gtk.ButtonBox.ButtonBoxChild w5 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.button485]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.button484 = new global::Gtk.Button ();
			this.button484.CanFocus = true;
			this.button484.Name = "button484";
			this.button484.UseUnderline = true;
			this.button484.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
			this.hbuttonbox2.Add (this.button484);
			global::Gtk.ButtonBox.ButtonBoxChild w6 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.button484]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox2.Add (this.hbuttonbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbuttonbox2]));
			w7.Position = 1;
			w7.Expand = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
