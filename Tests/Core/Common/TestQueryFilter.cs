﻿//
//  Copyright (C) 2015 Fluendo S.A.
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
using System.Collections.Generic;
using LongoMatch.Core.Common;
using NUnit.Framework;

namespace Tests.Core.Common
{
	[TestFixture ()]
	public class TestQueryFilter
	{
		QueryFilter filter;

		[SetUp ()]
		public void SetUp ()
		{
			filter = new QueryFilter ();
		}

		[Test ()]
		public void TestAddOneValue ()
		{
			filter.Add ("Test", 4);
			Assert.AreEqual (1, filter.Count);
			Assert.AreEqual (new List<int> { 4 }, filter ["Test"]);
		}

		[Test ()]
		public void TestAddOneStringValue ()
		{
			filter.Add ("Test", "hola");
			Assert.AreEqual (new List<string> { "hola" }, filter ["Test"]);
			Assert.AreEqual (1, filter.Count);
		}

		[Test ()]
		public void TestAddList ()
		{
			var list = new List<string> { "hola", "test", "adios" };
			filter.Add ("Test", list);
			Assert.AreEqual (1, filter.Count);
			Assert.AreEqual (list, filter ["Test"]);
		}

		[Test ()]
		public void TestChanged ()
		{
			Assert.IsFalse (filter.Changed);

			// Add a new key
			var list = new List<string> { "hola", "test", "adios" };
			filter.Add ("Test", list);
			Assert.IsTrue (filter.Changed);
			filter.SaveChanges ();
			Assert.IsFalse (filter.Changed);

			// Remove a key
			filter.Remove ("Test");
			Assert.IsTrue (filter.Changed);
			filter.SaveChanges ();
			Assert.IsFalse (filter.Changed);

			// Add and remove without saving
			filter.Add ("Test", list);
			Assert.IsTrue (filter.Changed);
			filter.Remove ("Test");
			Assert.IsFalse (filter.Changed);

			// Modify list
			filter.Add ("Test", list);
			filter ["Test"].RemoveAt (0);
			Assert.IsTrue (filter.Changed);
		}
	}
}
