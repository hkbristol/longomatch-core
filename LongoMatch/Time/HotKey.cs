// HotKey.cs
//
//  Copyright (C) 2007-2009 Andoni Morales Alastruey
//
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
//


using System;
using System.Collections.Generic;
using Gtk;
using Gdk;
using Mono.Unix;

namespace LongoMatch.TimeNodes
{
	
	public class HotKey : IEquatable<HotKey>
	{
		private int key;
		private int modifier;
	
#region Constructors
		public HotKey()
		{
			this.key = -1;
			this.modifier = -1;
		}
#endregion
		
	
#region Properties
		public Gdk.Key Key{
			get{return (Gdk.Key)key;}
			set{key = (int)value;}
		}
		
		public Gdk.ModifierType Modifier{
			get{return (Gdk.ModifierType)modifier;}
			set{modifier= (int)value; }
		}
		
		public Boolean Defined{
			get{return (key!=-1 && modifier != -1);}
		}
		
		public bool Equals(HotKey hotkeyComp){
			return (this.Key == hotkeyComp.Key && this.Modifier == hotkeyComp.Modifier);
		}
		
		static public bool operator == (HotKey hk1, HotKey hk2){
			return hk1.Equals(hk2);
		}
		
		static public bool operator != (HotKey hk1, HotKey hk2){
			return !hk1.Equals(hk2);
		}
			
#endregion	
		
#region Override
		public override bool Equals (object obj)
		{
			HotKey hotkey= obj as HotKey;
   		 	if (hotkey != null)
        		return Equals(hotkey);
    		else
        		return false;
		}
		
		public override int GetHashCode ()
		{
			return key ^ modifier;
		}

		
		public override string ToString ()
		{
			string modifierS = Catalog.GetString("none");
			if (!Defined)
				return Catalog.GetString("Not defined");
			if (Modifier == ModifierType.Mod1Mask)
				modifierS = "Alt";
			else if (Modifier == ModifierType.ShiftMask)
				modifierS = "Shift";
				
			return string.Format("<{0}>+{1}", modifierS,(Key.ToString()).ToLower());
		}

#endregion
	}
}
