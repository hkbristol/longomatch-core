// ObjectManager.cs
//
//  Copyright (C) 2007-2009 Andoni Morales Alastruey
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
// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace LongoMatch.GtkSharp.Encoder {

	public class ObjectManager {

		static bool initialized = false;
		// Call this method from the appropriate module init function.
		public static void Initialize()
		{
			if(initialized)
				return;

			initialized = true;

			GLib.GType.Register(LongoMatch.Video.Converter.GstVideoConverter.GType,
			                    typeof(LongoMatch.Video.Converter.GstVideoConverter));
		}
	}
}
