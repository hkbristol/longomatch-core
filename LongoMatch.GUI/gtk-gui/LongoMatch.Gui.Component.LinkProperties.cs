
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class LinkProperties
	{
		private global::Gtk.Table tabledata;

		private global::Gtk.CheckButton checkbuttonkeepgenerictags;

		private global::Gtk.CheckButton checkbuttonkeepplayertags;

		private global::Gtk.ComboBox comboboxaction;

		private global::Gtk.ComboBox comboboxteamaction;

		private global::Gtk.Label labelaction;

		private global::Gtk.Label labelfrom;

		private global::Gtk.Label labelfromdata;

		private global::Gtk.Label labelfromtagsdata;

		private global::Gtk.Label labelkeepgenerictags;

		private global::Gtk.Label labelkeepplayertags;

		private global::Gtk.Label labelteamaction;

		private global::Gtk.Label labelto;

		private global::Gtk.Label labeltodata;

		private global::Gtk.Label labeltotagsdata;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.LinkProperties
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.LinkProperties";
			// Container child LongoMatch.Gui.Component.LinkProperties.Gtk.Container+ContainerChild
			this.tabledata = new global::Gtk.Table (((uint)(8)), ((uint)(2)), false);
			this.tabledata.Name = "tabledata";
			this.tabledata.RowSpacing = ((uint)(6));
			this.tabledata.ColumnSpacing = ((uint)(6));
			// Container child tabledata.Gtk.Table+TableChild
			this.checkbuttonkeepgenerictags = new global::Gtk.CheckButton ();
			this.checkbuttonkeepgenerictags.Name = "checkbuttonkeepgenerictags";
			this.checkbuttonkeepgenerictags.Label = "";
			this.checkbuttonkeepgenerictags.DrawIndicator = true;
			this.checkbuttonkeepgenerictags.UseUnderline = true;
			this.tabledata.Add (this.checkbuttonkeepgenerictags);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.tabledata [this.checkbuttonkeepgenerictags]));
			w1.TopAttach = ((uint)(7));
			w1.BottomAttach = ((uint)(8));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tabledata.Gtk.Table+TableChild
			this.checkbuttonkeepplayertags = new global::Gtk.CheckButton ();
			this.checkbuttonkeepplayertags.Name = "checkbuttonkeepplayertags";
			this.checkbuttonkeepplayertags.Label = "";
			this.checkbuttonkeepplayertags.DrawIndicator = true;
			this.checkbuttonkeepplayertags.UseUnderline = true;
			this.checkbuttonkeepplayertags.FocusOnClick = false;
			this.tabledata.Add (this.checkbuttonkeepplayertags);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.tabledata [this.checkbuttonkeepplayertags]));
			w2.TopAttach = ((uint)(6));
			w2.BottomAttach = ((uint)(7));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tabledata.Gtk.Table+TableChild
			this.comboboxaction = global::Gtk.ComboBox.NewText ();
			this.comboboxaction.AppendText (global::VAS.Core.Catalog.GetString ("Activate -> Deactivate"));
			this.comboboxaction.AppendText (global::VAS.Core.Catalog.GetString ("Activate -> Activate"));
			this.comboboxaction.Name = "comboboxaction";
			this.comboboxaction.FocusOnClick = false;
			this.tabledata.Add (this.comboboxaction);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.tabledata [this.comboboxaction]));
			w3.TopAttach = ((uint)(4));
			w3.BottomAttach = ((uint)(5));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tabledata.Gtk.Table+TableChild
			this.comboboxteamaction = global::Gtk.ComboBox.NewText ();
			this.comboboxteamaction.AppendText (global::VAS.Core.Catalog.GetString ("Clear"));
			this.comboboxteamaction.AppendText (global::VAS.Core.Catalog.GetString ("Keep"));
			this.comboboxteamaction.AppendText (global::VAS.Core.Catalog.GetString ("Invert"));
			this.comboboxteamaction.Name = "comboboxteamaction";
			this.tabledata.Add (this.comboboxteamaction);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.tabledata [this.comboboxteamaction]));
			w4.TopAttach = ((uint)(5));
			w4.BottomAttach = ((uint)(6));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tabledata.Gtk.Table+TableChild
			this.labelaction = new global::Gtk.Label ();
			this.labelaction.Name = "labelaction";
			this.labelaction.Xalign = 1F;
			this.labelaction.LabelProp = global::VAS.Core.Catalog.GetString ("Action");
			this.tabledata.Add (this.labelaction);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.tabledata [this.labelaction]));
			w5.TopAttach = ((uint)(4));
			w5.BottomAttach = ((uint)(5));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tabledata.Gtk.Table+TableChild
			this.labelfrom = new global::Gtk.Label ();
			this.labelfrom.Name = "labelfrom";
			this.labelfrom.Xalign = 1F;
			this.labelfrom.LabelProp = global::VAS.Core.Catalog.GetString ("From:");
			this.tabledata.Add (this.labelfrom);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.tabledata [this.labelfrom]));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tabledata.Gtk.Table+TableChild
			this.labelfromdata = new global::Gtk.Label ();
			this.labelfromdata.Sensitive = false;
			this.labelfromdata.Name = "labelfromdata";
			this.labelfromdata.Xalign = 0F;
			this.labelfromdata.Wrap = true;
			this.tabledata.Add (this.labelfromdata);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.tabledata [this.labelfromdata]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tabledata.Gtk.Table+TableChild
			this.labelfromtagsdata = new global::Gtk.Label ();
			this.labelfromtagsdata.Sensitive = false;
			this.labelfromtagsdata.Name = "labelfromtagsdata";
			this.labelfromtagsdata.Xalign = 0F;
			this.labelfromtagsdata.Wrap = true;
			this.tabledata.Add (this.labelfromtagsdata);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.tabledata [this.labelfromtagsdata]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tabledata.Gtk.Table+TableChild
			this.labelkeepgenerictags = new global::Gtk.Label ();
			this.labelkeepgenerictags.Name = "labelkeepgenerictags";
			this.labelkeepgenerictags.Xalign = 1F;
			this.labelkeepgenerictags.LabelProp = global::VAS.Core.Catalog.GetString ("Keep generic tags");
			this.tabledata.Add (this.labelkeepgenerictags);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.tabledata [this.labelkeepgenerictags]));
			w9.TopAttach = ((uint)(7));
			w9.BottomAttach = ((uint)(8));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tabledata.Gtk.Table+TableChild
			this.labelkeepplayertags = new global::Gtk.Label ();
			this.labelkeepplayertags.Name = "labelkeepplayertags";
			this.labelkeepplayertags.Xalign = 1F;
			this.labelkeepplayertags.LabelProp = global::VAS.Core.Catalog.GetString ("Keep player tags");
			this.tabledata.Add (this.labelkeepplayertags);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.tabledata [this.labelkeepplayertags]));
			w10.TopAttach = ((uint)(6));
			w10.BottomAttach = ((uint)(7));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tabledata.Gtk.Table+TableChild
			this.labelteamaction = new global::Gtk.Label ();
			this.labelteamaction.Name = "labelteamaction";
			this.labelteamaction.Xalign = 1F;
			this.labelteamaction.LabelProp = global::VAS.Core.Catalog.GetString ("Team action");
			this.tabledata.Add (this.labelteamaction);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.tabledata [this.labelteamaction]));
			w11.TopAttach = ((uint)(5));
			w11.BottomAttach = ((uint)(6));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tabledata.Gtk.Table+TableChild
			this.labelto = new global::Gtk.Label ();
			this.labelto.Name = "labelto";
			this.labelto.Xalign = 1F;
			this.labelto.LabelProp = global::VAS.Core.Catalog.GetString ("To:");
			this.tabledata.Add (this.labelto);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.tabledata [this.labelto]));
			w12.TopAttach = ((uint)(2));
			w12.BottomAttach = ((uint)(3));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tabledata.Gtk.Table+TableChild
			this.labeltodata = new global::Gtk.Label ();
			this.labeltodata.Sensitive = false;
			this.labeltodata.Name = "labeltodata";
			this.labeltodata.Xalign = 0F;
			this.labeltodata.Wrap = true;
			this.tabledata.Add (this.labeltodata);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.tabledata [this.labeltodata]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tabledata.Gtk.Table+TableChild
			this.labeltotagsdata = new global::Gtk.Label ();
			this.labeltotagsdata.Sensitive = false;
			this.labeltotagsdata.Name = "labeltotagsdata";
			this.labeltotagsdata.Xalign = 0F;
			this.labeltotagsdata.Wrap = true;
			this.tabledata.Add (this.labeltotagsdata);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.tabledata [this.labeltotagsdata]));
			w14.TopAttach = ((uint)(3));
			w14.BottomAttach = ((uint)(4));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.tabledata);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
