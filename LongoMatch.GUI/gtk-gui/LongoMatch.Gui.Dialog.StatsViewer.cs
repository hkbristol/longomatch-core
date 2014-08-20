
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Dialog
{
	public partial class StatsViewer
	{
		private global::Gtk.Notebook notebook1;
		private global::LongoMatch.Gui.Component.GameViewer gameviewer;
		private global::Gtk.Label label2;
		private global::LongoMatch.Gui.Component.Stats.CategoriesViewer categoriesviewer;
		private global::Gtk.Label label4;
		private global::LongoMatch.Gui.Component.Stats.PlayersViewer playersviewer;
		private global::Gtk.Label label5;
		private global::Gtk.Button buttonCancel;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Dialog.StatsViewer
			this.Name = "LongoMatch.Gui.Dialog.StatsViewer";
			this.Title = global::Mono.Unix.Catalog.GetString ("Stats");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "longomatch", global::Gtk.IconSize.Menu);
			this.TypeHint = ((global::Gdk.WindowTypeHint)(5));
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.Modal = true;
			this.DestroyWithParent = true;
			this.Gravity = ((global::Gdk.Gravity)(5));
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Internal child LongoMatch.Gui.Dialog.StatsViewer.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 2;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.gameviewer = new global::LongoMatch.Gui.Component.GameViewer ();
			this.gameviewer.Events = ((global::Gdk.EventMask)(256));
			this.gameviewer.Name = "gameviewer";
			this.notebook1.Add (this.gameviewer);
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Game stats");
			this.notebook1.SetTabLabel (this.gameviewer, this.label2);
			this.label2.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.categoriesviewer = new global::LongoMatch.Gui.Component.Stats.CategoriesViewer ();
			this.categoriesviewer.Events = ((global::Gdk.EventMask)(256));
			this.categoriesviewer.Name = "categoriesviewer";
			this.notebook1.Add (this.categoriesviewer);
			global::Gtk.Notebook.NotebookChild w3 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.categoriesviewer]));
			w3.Position = 1;
			// Notebook tab
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Categories stats");
			this.notebook1.SetTabLabel (this.categoriesviewer, this.label4);
			this.label4.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.playersviewer = new global::LongoMatch.Gui.Component.Stats.PlayersViewer ();
			this.playersviewer.Events = ((global::Gdk.EventMask)(256));
			this.playersviewer.Name = "playersviewer";
			this.notebook1.Add (this.playersviewer);
			global::Gtk.Notebook.NotebookChild w4 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.playersviewer]));
			w4.Position = 2;
			// Notebook tab
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Players stats");
			this.notebook1.SetTabLabel (this.playersviewer, this.label5);
			this.label5.ShowAll ();
			w1.Add (this.notebook1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(w1 [this.notebook1]));
			w5.Position = 0;
			// Internal child LongoMatch.Gui.Dialog.StatsViewer.ActionArea
			global::Gtk.HButtonBox w6 = this.ActionArea;
			w6.Name = "dialog1_ActionArea";
			w6.Spacing = 10;
			w6.BorderWidth = ((uint)(5));
			w6.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-close";
			this.AddActionWidget (this.buttonCancel, -7);
			global::Gtk.ButtonBox.ButtonBoxChild w7 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w6 [this.buttonCancel]));
			w7.Expand = false;
			w7.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 1167;
			this.DefaultHeight = 619;
			this.Show ();
		}
	}
}
