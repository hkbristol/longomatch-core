// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch.Gui.Dialog {
    
    
    public partial class ProjectSelectionDialog {
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox hbox1;
        
        private Gtk.RadioButton fromfileradiobutton;
        
        private Gtk.Image image61;
        
        private Gtk.HBox hbox2;
        
        private Gtk.RadioButton liveradiobutton;
        
        private Gtk.Image image63;
        
        private Gtk.HBox hbox3;
        
        private Gtk.RadioButton fakeliveradiobutton;
        
        private Gtk.Image image62;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.Gui.Dialog.ProjectSelectionDialog
            this.Name = "LongoMatch.Gui.Dialog.ProjectSelectionDialog";
            this.Title = Mono.Unix.Catalog.GetString("New Project");
            this.Icon = Stetic.IconLoader.LoadIcon(this, "longomatch", Gtk.IconSize.Menu, 16);
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            this.Gravity = ((Gdk.Gravity)(5));
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            this.HasSeparator = false;
            // Internal child LongoMatch.Gui.Dialog.ProjectSelectionDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.fromfileradiobutton = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("New project usng a video file"));
            this.fromfileradiobutton.CanFocus = true;
            this.fromfileradiobutton.Name = "fromfileradiobutton";
            this.fromfileradiobutton.DrawIndicator = true;
            this.fromfileradiobutton.UseUnderline = true;
            this.fromfileradiobutton.FocusOnClick = false;
            this.fromfileradiobutton.Group = new GLib.SList(System.IntPtr.Zero);
            this.hbox1.Add(this.fromfileradiobutton);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.fromfileradiobutton]));
            w2.Position = 0;
            // Container child hbox1.Gtk.Box+BoxChild
            this.image61 = new Gtk.Image();
            this.image61.Name = "image61";
            this.image61.Pixbuf = Gdk.Pixbuf.LoadFromResource("video.png");
            this.hbox1.Add(this.image61);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.image61]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            this.vbox2.Add(this.hbox1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.liveradiobutton = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Live project using a capture device"));
            this.liveradiobutton.CanFocus = true;
            this.liveradiobutton.Name = "liveradiobutton";
            this.liveradiobutton.DrawIndicator = true;
            this.liveradiobutton.UseUnderline = true;
            this.liveradiobutton.Group = this.fromfileradiobutton.Group;
            this.hbox2.Add(this.liveradiobutton);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox2[this.liveradiobutton]));
            w5.Position = 0;
            // Container child hbox2.Gtk.Box+BoxChild
            this.image63 = new Gtk.Image();
            this.image63.Name = "image63";
            this.image63.Pixbuf = Gdk.Pixbuf.LoadFromResource("camera-video.png");
            this.hbox2.Add(this.image63);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox2[this.image63]));
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            this.vbox2.Add(this.hbox2);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.fakeliveradiobutton = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Live project using a fake capture device"));
            this.fakeliveradiobutton.CanFocus = true;
            this.fakeliveradiobutton.Name = "fakeliveradiobutton";
            this.fakeliveradiobutton.DrawIndicator = true;
            this.fakeliveradiobutton.UseUnderline = true;
            this.fakeliveradiobutton.Group = this.fromfileradiobutton.Group;
            this.hbox3.Add(this.fakeliveradiobutton);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox3[this.fakeliveradiobutton]));
            w8.Position = 0;
            // Container child hbox3.Gtk.Box+BoxChild
            this.image62 = new Gtk.Image();
            this.image62.Name = "image62";
            this.image62.Pixbuf = Gdk.Pixbuf.LoadFromResource("camera-video.png");
            this.hbox3.Add(this.image62);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox3[this.image62]));
            w9.Position = 1;
            w9.Expand = false;
            w9.Fill = false;
            this.vbox2.Add(this.hbox3);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
            w10.Position = 2;
            w10.Expand = false;
            w10.Fill = false;
            w1.Add(this.vbox2);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(w1[this.vbox2]));
            w11.Position = 0;
            w11.Expand = false;
            w11.Fill = false;
            // Internal child LongoMatch.Gui.Dialog.ProjectSelectionDialog.ActionArea
            Gtk.HButtonBox w12 = this.ActionArea;
            w12.Name = "dialog1_ActionArea";
            w12.Spacing = 6;
            w12.BorderWidth = ((uint)(5));
            w12.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w13 = ((Gtk.ButtonBox.ButtonBoxChild)(w12[this.buttonCancel]));
            w13.Expand = false;
            w13.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w14 = ((Gtk.ButtonBox.ButtonBoxChild)(w12[this.buttonOk]));
            w14.Position = 1;
            w14.Expand = false;
            w14.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 298;
            this.DefaultHeight = 176;
            this.Show();
        }
    }
}
