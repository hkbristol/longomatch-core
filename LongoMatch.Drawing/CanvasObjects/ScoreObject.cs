//
//  Copyright (C) 2014 Andoni Morales Alastruey
//
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
using System;
using LongoMatch.Core.Interfaces.Drawing;
using LongoMatch.Core.Common;
using LongoMatch.Core.Interfaces;
using LongoMatch.Core.Store;

namespace LongoMatch.Drawing.CanvasObjects
{
	public class ScoreObject: TaggerObject
	{
		public ScoreObject (ScoreButton score): base (score)
		{
			Button = score;
		}

		public ScoreButton Button {
			get;
			set;
		}

		public override void Draw (IDrawingToolkit tk, Area area)
		{
			if (!UpdateDrawArea (tk, area, new Area (Position, Width, Height))) {
				return;
			}

			tk.Begin ();

			/* Draw Rectangle */
			DrawButton (tk);
			
			/* Draw header */
			tk.LineWidth = 2;
			tk.StrokeColor = Button.TextColor;
			tk.FillColor = Button.TextColor;
			tk.DrawText (DrawPosition, Button.Width, Button.Height, Button.Score.Name);
			DrawSelectionArea (tk);
			tk.End ();
		}
	}
}

