// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch.Gui.Component {
    
    
    public partial class SectionsPropertiesWidget {
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.Table table1;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.Gui.Component.SectionsPropertiesWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "LongoMatch.Gui.Component.SectionsPropertiesWidget";
            // Container child LongoMatch.Gui.Component.SectionsPropertiesWidget.Gtk.Container+ContainerChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            Gtk.Viewport w1 = new Gtk.Viewport();
            w1.ShadowType = ((Gtk.ShadowType)(0));
            // Container child GtkViewport.Gtk.Container+ContainerChild
            this.table1 = new Gtk.Table(((uint)(3)), ((uint)(3)), true);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            w1.Add(this.table1);
            this.scrolledwindow1.Add(w1);
            this.Add(this.scrolledwindow1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}
