// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch {
    
    
    public partial class CalendarPopup {
        
        private Gtk.Calendar calendar1;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.CalendarPopup
            this.Name = "LongoMatch.CalendarPopup";
            this.Title = "";
            this.WindowPosition = ((Gtk.WindowPosition)(2));
            this.Modal = true;
            this.Resizable = false;
            this.AllowGrow = false;
            this.Decorated = false;
            this.DestroyWithParent = true;
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            // Container child LongoMatch.CalendarPopup.Gtk.Container+ContainerChild
            this.calendar1 = new Gtk.Calendar();
            this.calendar1.CanFocus = true;
            this.calendar1.Name = "calendar1";
            this.calendar1.DisplayOptions = ((Gtk.CalendarDisplayOptions)(3));
            this.Add(this.calendar1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 281;
            this.DefaultHeight = 215;
            this.Show();
            this.calendar1.DaySelectedDoubleClick += new System.EventHandler(this.OnCalendar1DaySelectedDoubleClick);
        }
    }
}
