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
    
    
    public partial class FileDescriptionWidget {
        
        private Gtk.VBox vbox2;
        
        private Gtk.Table table1;
        
        private Gtk.SpinButton dataSpinButton;
        
        private Gtk.HBox hbox3;
        
        private Gtk.HBox hbox2;
        
        private Gtk.Button editbutton;
        
        private Gtk.ComboBox combobox1;
        
        private Gtk.HBox hbox4;
        
        private Gtk.Entry fileEntry;
        
        private Gtk.Button openbutton;
        
        private Gtk.HBox hbox5;
        
        private Gtk.Entry dateEntry;
        
        private Gtk.Button calendarbutton;
        
        private Gtk.HSeparator hseparator1;
        
        private Gtk.HSeparator hseparator2;
        
        private Gtk.HSeparator hseparator4;
        
        private Gtk.HSeparator hseparator5;
        
        private Gtk.Label label2;
        
        private Gtk.Label label3;
        
        private Gtk.Label label4;
        
        private Gtk.Label label5;
        
        private Gtk.Label label6;
        
        private Gtk.Label label7;
        
        private Gtk.Label label8;
        
        private Gtk.Label label9;
        
        private Gtk.SpinButton localSpinButton;
        
        private Gtk.Entry localTeamEntry;
        
        private Gtk.SpinButton visitorSpinButton;
        
        private Gtk.Entry visitorTeamEntry;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.FileDescriptionWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "LongoMatch.FileDescriptionWidget";
            // Container child LongoMatch.FileDescriptionWidget.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.table1 = new Gtk.Table(((uint)(11)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.dataSpinButton = new Gtk.SpinButton(4, 20, 4);
            this.dataSpinButton.CanFocus = true;
            this.dataSpinButton.Name = "dataSpinButton";
            this.dataSpinButton.Adjustment.PageIncrement = 4;
            this.dataSpinButton.ClimbRate = 1;
            this.dataSpinButton.Numeric = true;
            this.dataSpinButton.Value = 4;
            this.table1.Add(this.dataSpinButton);
            Gtk.Table.TableChild w1 = ((Gtk.Table.TableChild)(this.table1[this.dataSpinButton]));
            w1.TopAttach = ((uint)(5));
            w1.BottomAttach = ((uint)(6));
            w1.LeftAttach = ((uint)(1));
            w1.RightAttach = ((uint)(2));
            w1.XOptions = ((Gtk.AttachOptions)(1));
            w1.YOptions = ((Gtk.AttachOptions)(1));
            // Container child table1.Gtk.Table+TableChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.editbutton = new Gtk.Button();
            this.editbutton.Sensitive = false;
            this.editbutton.CanFocus = true;
            this.editbutton.Name = "editbutton";
            this.editbutton.UseStock = true;
            this.editbutton.UseUnderline = true;
            this.editbutton.Label = "gtk-edit";
            this.hbox2.Add(this.editbutton);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox2[this.editbutton]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.combobox1 = Gtk.ComboBox.NewText();
            this.combobox1.Name = "combobox1";
            this.combobox1.Active = 0;
            this.hbox2.Add(this.combobox1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox2[this.combobox1]));
            w3.Position = 1;
            this.hbox3.Add(this.hbox2);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox3[this.hbox2]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            this.table1.Add(this.hbox3);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table1[this.hbox3]));
            w5.TopAttach = ((uint)(6));
            w5.BottomAttach = ((uint)(7));
            w5.LeftAttach = ((uint)(1));
            w5.RightAttach = ((uint)(2));
            w5.XOptions = ((Gtk.AttachOptions)(1));
            w5.YOptions = ((Gtk.AttachOptions)(1));
            // Container child table1.Gtk.Table+TableChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Spacing = 6;
            // Container child hbox4.Gtk.Box+BoxChild
            this.fileEntry = new Gtk.Entry();
            this.fileEntry.CanFocus = true;
            this.fileEntry.Name = "fileEntry";
            this.fileEntry.IsEditable = true;
            this.fileEntry.InvisibleChar = '●';
            this.hbox4.Add(this.fileEntry);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox4[this.fileEntry]));
            w6.Position = 0;
            // Container child hbox4.Gtk.Box+BoxChild
            this.openbutton = new Gtk.Button();
            this.openbutton.CanFocus = true;
            this.openbutton.Name = "openbutton";
            this.openbutton.UseStock = true;
            this.openbutton.UseUnderline = true;
            this.openbutton.Label = "gtk-open";
            this.hbox4.Add(this.openbutton);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox4[this.openbutton]));
            w7.Position = 1;
            w7.Expand = false;
            this.table1.Add(this.hbox4);
            Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.table1[this.hbox4]));
            w8.TopAttach = ((uint)(9));
            w8.BottomAttach = ((uint)(10));
            w8.LeftAttach = ((uint)(1));
            w8.RightAttach = ((uint)(2));
            w8.XOptions = ((Gtk.AttachOptions)(4));
            w8.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.hbox5 = new Gtk.HBox();
            this.hbox5.Name = "hbox5";
            // Container child hbox5.Gtk.Box+BoxChild
            this.dateEntry = new Gtk.Entry();
            this.dateEntry.CanFocus = true;
            this.dateEntry.Name = "dateEntry";
            this.dateEntry.IsEditable = false;
            this.dateEntry.InvisibleChar = '●';
            this.hbox5.Add(this.dateEntry);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox5[this.dateEntry]));
            w9.Position = 0;
            // Container child hbox5.Gtk.Box+BoxChild
            this.calendarbutton = new Gtk.Button();
            this.calendarbutton.CanFocus = true;
            this.calendarbutton.Name = "calendarbutton";
            this.calendarbutton.UseUnderline = true;
            // Container child calendarbutton.Gtk.Container+ContainerChild
            Gtk.Alignment w10 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w11 = new Gtk.HBox();
            w11.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w12 = new Gtk.Image();
            w12.Pixbuf = Stetic.IconLoader.LoadIcon(this, "stock_calendar", Gtk.IconSize.Button, 20);
            w11.Add(w12);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w14 = new Gtk.Label();
            w14.LabelProp = Mono.Unix.Catalog.GetString("_Calendar");
            w14.UseUnderline = true;
            w11.Add(w14);
            w10.Add(w11);
            this.calendarbutton.Add(w10);
            this.hbox5.Add(this.calendarbutton);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.hbox5[this.calendarbutton]));
            w18.Position = 1;
            w18.Expand = false;
            w18.Fill = false;
            this.table1.Add(this.hbox5);
            Gtk.Table.TableChild w19 = ((Gtk.Table.TableChild)(this.table1[this.hbox5]));
            w19.TopAttach = ((uint)(8));
            w19.BottomAttach = ((uint)(9));
            w19.LeftAttach = ((uint)(1));
            w19.RightAttach = ((uint)(2));
            w19.YOptions = ((Gtk.AttachOptions)(1));
            // Container child table1.Gtk.Table+TableChild
            this.hseparator1 = new Gtk.HSeparator();
            this.hseparator1.Name = "hseparator1";
            this.table1.Add(this.hseparator1);
            Gtk.Table.TableChild w20 = ((Gtk.Table.TableChild)(this.table1[this.hseparator1]));
            w20.TopAttach = ((uint)(7));
            w20.BottomAttach = ((uint)(8));
            w20.LeftAttach = ((uint)(1));
            w20.RightAttach = ((uint)(2));
            w20.XOptions = ((Gtk.AttachOptions)(4));
            w20.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.hseparator2 = new Gtk.HSeparator();
            this.hseparator2.Name = "hseparator2";
            this.table1.Add(this.hseparator2);
            Gtk.Table.TableChild w21 = ((Gtk.Table.TableChild)(this.table1[this.hseparator2]));
            w21.TopAttach = ((uint)(7));
            w21.BottomAttach = ((uint)(8));
            w21.XOptions = ((Gtk.AttachOptions)(4));
            w21.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.hseparator4 = new Gtk.HSeparator();
            this.hseparator4.Name = "hseparator4";
            this.table1.Add(this.hseparator4);
            Gtk.Table.TableChild w22 = ((Gtk.Table.TableChild)(this.table1[this.hseparator4]));
            w22.TopAttach = ((uint)(4));
            w22.BottomAttach = ((uint)(5));
            w22.XOptions = ((Gtk.AttachOptions)(4));
            w22.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.hseparator5 = new Gtk.HSeparator();
            this.hseparator5.Name = "hseparator5";
            this.table1.Add(this.hseparator5);
            Gtk.Table.TableChild w23 = ((Gtk.Table.TableChild)(this.table1[this.hseparator5]));
            w23.TopAttach = ((uint)(4));
            w23.BottomAttach = ((uint)(5));
            w23.LeftAttach = ((uint)(1));
            w23.RightAttach = ((uint)(2));
            w23.XOptions = ((Gtk.AttachOptions)(4));
            w23.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Visitor Team");
            this.table1.Add(this.label2);
            Gtk.Table.TableChild w24 = ((Gtk.Table.TableChild)(this.table1[this.label2]));
            w24.TopAttach = ((uint)(1));
            w24.BottomAttach = ((uint)(2));
            w24.XOptions = ((Gtk.AttachOptions)(4));
            w24.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Local Goals");
            this.table1.Add(this.label3);
            Gtk.Table.TableChild w25 = ((Gtk.Table.TableChild)(this.table1[this.label3]));
            w25.TopAttach = ((uint)(2));
            w25.BottomAttach = ((uint)(3));
            w25.XOptions = ((Gtk.AttachOptions)(4));
            w25.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("Visitor Goals");
            this.table1.Add(this.label4);
            Gtk.Table.TableChild w26 = ((Gtk.Table.TableChild)(this.table1[this.label4]));
            w26.TopAttach = ((uint)(3));
            w26.BottomAttach = ((uint)(4));
            w26.XOptions = ((Gtk.AttachOptions)(4));
            w26.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("Date");
            this.table1.Add(this.label5);
            Gtk.Table.TableChild w27 = ((Gtk.Table.TableChild)(this.table1[this.label5]));
            w27.TopAttach = ((uint)(8));
            w27.BottomAttach = ((uint)(9));
            w27.XOptions = ((Gtk.AttachOptions)(4));
            w27.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.LabelProp = Mono.Unix.Catalog.GetString("File");
            this.table1.Add(this.label6);
            Gtk.Table.TableChild w28 = ((Gtk.Table.TableChild)(this.table1[this.label6]));
            w28.TopAttach = ((uint)(9));
            w28.BottomAttach = ((uint)(10));
            w28.XOptions = ((Gtk.AttachOptions)(4));
            w28.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("Data Sections");
            this.table1.Add(this.label7);
            Gtk.Table.TableChild w29 = ((Gtk.Table.TableChild)(this.table1[this.label7]));
            w29.TopAttach = ((uint)(5));
            w29.BottomAttach = ((uint)(6));
            w29.XOptions = ((Gtk.AttachOptions)(4));
            w29.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label8 = new Gtk.Label();
            this.label8.Name = "label8";
            this.label8.LabelProp = Mono.Unix.Catalog.GetString("Local Team");
            this.table1.Add(this.label8);
            Gtk.Table.TableChild w30 = ((Gtk.Table.TableChild)(this.table1[this.label8]));
            w30.XOptions = ((Gtk.AttachOptions)(4));
            w30.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label9 = new Gtk.Label();
            this.label9.Name = "label9";
            this.label9.LabelProp = Mono.Unix.Catalog.GetString("Sections Template File");
            this.table1.Add(this.label9);
            Gtk.Table.TableChild w31 = ((Gtk.Table.TableChild)(this.table1[this.label9]));
            w31.TopAttach = ((uint)(6));
            w31.BottomAttach = ((uint)(7));
            w31.XOptions = ((Gtk.AttachOptions)(4));
            w31.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.localSpinButton = new Gtk.SpinButton(0, 100, 1);
            this.localSpinButton.CanFocus = true;
            this.localSpinButton.Name = "localSpinButton";
            this.localSpinButton.Adjustment.PageIncrement = 10;
            this.localSpinButton.ClimbRate = 1;
            this.localSpinButton.Numeric = true;
            this.table1.Add(this.localSpinButton);
            Gtk.Table.TableChild w32 = ((Gtk.Table.TableChild)(this.table1[this.localSpinButton]));
            w32.TopAttach = ((uint)(2));
            w32.BottomAttach = ((uint)(3));
            w32.LeftAttach = ((uint)(1));
            w32.RightAttach = ((uint)(2));
            w32.XOptions = ((Gtk.AttachOptions)(1));
            w32.YOptions = ((Gtk.AttachOptions)(1));
            // Container child table1.Gtk.Table+TableChild
            this.localTeamEntry = new Gtk.Entry();
            this.localTeamEntry.CanFocus = true;
            this.localTeamEntry.Name = "localTeamEntry";
            this.localTeamEntry.IsEditable = true;
            this.localTeamEntry.InvisibleChar = '●';
            this.table1.Add(this.localTeamEntry);
            Gtk.Table.TableChild w33 = ((Gtk.Table.TableChild)(this.table1[this.localTeamEntry]));
            w33.LeftAttach = ((uint)(1));
            w33.RightAttach = ((uint)(2));
            // Container child table1.Gtk.Table+TableChild
            this.visitorSpinButton = new Gtk.SpinButton(0, 100, 1);
            this.visitorSpinButton.CanFocus = true;
            this.visitorSpinButton.Name = "visitorSpinButton";
            this.visitorSpinButton.Adjustment.PageIncrement = 10;
            this.visitorSpinButton.ClimbRate = 1;
            this.visitorSpinButton.Numeric = true;
            this.table1.Add(this.visitorSpinButton);
            Gtk.Table.TableChild w34 = ((Gtk.Table.TableChild)(this.table1[this.visitorSpinButton]));
            w34.TopAttach = ((uint)(3));
            w34.BottomAttach = ((uint)(4));
            w34.LeftAttach = ((uint)(1));
            w34.RightAttach = ((uint)(2));
            w34.XOptions = ((Gtk.AttachOptions)(1));
            w34.YOptions = ((Gtk.AttachOptions)(1));
            // Container child table1.Gtk.Table+TableChild
            this.visitorTeamEntry = new Gtk.Entry();
            this.visitorTeamEntry.CanFocus = true;
            this.visitorTeamEntry.Name = "visitorTeamEntry";
            this.visitorTeamEntry.IsEditable = true;
            this.visitorTeamEntry.InvisibleChar = '●';
            this.table1.Add(this.visitorTeamEntry);
            Gtk.Table.TableChild w35 = ((Gtk.Table.TableChild)(this.table1[this.visitorTeamEntry]));
            w35.TopAttach = ((uint)(1));
            w35.BottomAttach = ((uint)(2));
            w35.LeftAttach = ((uint)(1));
            w35.RightAttach = ((uint)(2));
            w35.XOptions = ((Gtk.AttachOptions)(4));
            this.vbox2.Add(this.table1);
            Gtk.Box.BoxChild w36 = ((Gtk.Box.BoxChild)(this.vbox2[this.table1]));
            w36.Position = 0;
            this.Add(this.vbox2);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.editbutton.Hide();
            this.Show();
            this.calendarbutton.Clicked += new System.EventHandler(this.OnCalendarbuttonClicked);
            this.openbutton.Clicked += new System.EventHandler(this.OnOpenbuttonClicked);
            this.editbutton.Clicked += new System.EventHandler(this.OnEditbuttonClicked);
        }
    }
}
