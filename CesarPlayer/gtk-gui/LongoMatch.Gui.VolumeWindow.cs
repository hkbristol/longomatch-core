// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch.Gui {
    
    
    public partial class VolumeWindow {
        
        private Gtk.VBox vbox2;
        
        private Gtk.Button morebutton;
        
        private Gtk.VScale volumescale;
        
        private Gtk.Button lessbutton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.Gui.VolumeWindow
            this.Name = "LongoMatch.Gui.VolumeWindow";
            this.Title = "";
            this.WindowPosition = ((Gtk.WindowPosition)(2));
            this.Decorated = false;
            this.DestroyWithParent = true;
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            // Container child LongoMatch.Gui.VolumeWindow.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            // Container child vbox2.Gtk.Box+BoxChild
            this.morebutton = new Gtk.Button();
            this.morebutton.Name = "morebutton";
            this.morebutton.Relief = ((Gtk.ReliefStyle)(2));
            this.morebutton.Label = "+";
            this.vbox2.Add(this.morebutton);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox2[this.morebutton]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.volumescale = new Gtk.VScale(null);
            this.volumescale.CanFocus = true;
            this.volumescale.Name = "volumescale";
            this.volumescale.Inverted = true;
            this.volumescale.Adjustment.Upper = 100;
            this.volumescale.Adjustment.PageIncrement = 10;
            this.volumescale.Adjustment.StepIncrement = 1;
            this.volumescale.Adjustment.Value = 100;
            this.volumescale.DrawValue = false;
            this.volumescale.Digits = 0;
            this.volumescale.ValuePos = ((Gtk.PositionType)(2));
            this.vbox2.Add(this.volumescale);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox2[this.volumescale]));
            w2.Position = 1;
            // Container child vbox2.Gtk.Box+BoxChild
            this.lessbutton = new Gtk.Button();
            this.lessbutton.Name = "lessbutton";
            this.lessbutton.Relief = ((Gtk.ReliefStyle)(2));
            this.lessbutton.Label = "-";
            this.vbox2.Add(this.lessbutton);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox2[this.lessbutton]));
            w3.Position = 2;
            w3.Expand = false;
            w3.Fill = false;
            this.Add(this.vbox2);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 31;
            this.DefaultHeight = 204;
            this.Hide();
            this.FocusOutEvent += new Gtk.FocusOutEventHandler(this.OnFocusOutEvent);
            this.morebutton.Clicked += new System.EventHandler(this.OnMorebuttonClicked);
            this.volumescale.ValueChanged += new System.EventHandler(this.OnVolumescaleValueChanged);
            this.lessbutton.Clicked += new System.EventHandler(this.OnLessbuttonClicked);
        }
    }
}
