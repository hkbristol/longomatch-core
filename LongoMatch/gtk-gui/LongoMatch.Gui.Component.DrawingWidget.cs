
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class DrawingWidget
	{
		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.DrawingArea drawingarea;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.DrawingWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.DrawingWidget";
			// Container child LongoMatch.Gui.Component.DrawingWidget.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			global::Gtk.Viewport w1 = new global::Gtk.Viewport ();
			w1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.drawingarea = new global::Gtk.DrawingArea ();
			this.drawingarea.Events = ((global::Gdk.EventMask)(784));
			this.drawingarea.Name = "drawingarea";
			w1.Add (this.drawingarea);
			this.GtkScrolledWindow.Add (w1);
			this.Add (this.GtkScrolledWindow);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.drawingarea.ExposeEvent += new global::Gtk.ExposeEventHandler (this.OnDrawingareaExposeEvent);
			this.drawingarea.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnDrawingareaButtonPressEvent);
			this.drawingarea.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnDrawingareaButtonReleaseEvent);
			this.drawingarea.MotionNotifyEvent += new global::Gtk.MotionNotifyEventHandler (this.OnDrawingareaMotionNotifyEvent);
			this.drawingarea.SizeAllocated += new global::Gtk.SizeAllocatedHandler (this.OnDrawingareaSizeAllocated);
			this.drawingarea.ConfigureEvent += new global::Gtk.ConfigureEventHandler (this.OnDrawingareaConfigureEvent);
		}
	}
}
