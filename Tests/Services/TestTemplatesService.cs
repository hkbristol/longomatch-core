//
//  Copyright (C) 2015 jl
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
using System.IO;
using LongoMatch.Core.Common;
using LongoMatch.Core.Interfaces;
using LongoMatch.Core.Store.Templates;
using LongoMatch.DB;
using LongoMatch.Services;
using NUnit.Framework;

namespace Tests.Services
{
	[TestFixture ()]
	public class TestTemplatesService
	{
		IStorage storage;
		string tempPath;

		[SetUp]
		public void CreateStorage ()
		{
			tempPath = Path.Combine (Path.GetTempPath (), "TestTemplatesService");
			try {
				Directory.Delete (tempPath, true);
			} catch {
			}
			storage = new CouchbaseStorage (tempPath, "templates");
		}

		[TearDown]
		public void RemoveStorage ()
		{
			try {
				storage.Reset ();
				Directory.Delete (tempPath, true);
			} catch {
			}
		}

		[Test ()]
		public void TestSystemTemplates ()
		{
			TemplatesService ts = new TemplatesService (storage);
			// Start service
			ts.Start ();
			ICategoriesTemplatesProvider ctp = ts.CategoriesTemplateProvider;
			// We must have at least one template provider called 'Default'
			Dashboard dash = ctp.Templates [0];
			Assert.IsNotNull (dash);
			// Test we dont have a template
			Assert.IsFalse (ctp.Exists ("NonExistingTemplate"));

			ITeamTemplatesProvider ttp = ts.TeamTemplateProvider;
			Assert.AreEqual (2, ttp.Templates.Count);
			// Test we dont have a template
			Assert.IsFalse (ctp.Exists ("NonExistingTemplate"));
		}

		[Test ()]
		public void TestExists ()
		{
			CategoriesTemplatesProvider provider = new CategoriesTemplatesProvider (storage);
			Assert.IsFalse (provider.Exists ("ACANDEMOR"));
			Dashboard d = Dashboard.DefaultTemplate (10);
			d.Name = "NEW";
			provider.Save (d);
			Assert.IsTrue (provider.Exists ("NEW"));
		}

		[Test ()]
		public void TestListTemplates ()
		{
			CategoriesTemplatesProvider provider = new CategoriesTemplatesProvider (storage);
			Assert.AreEqual (1, provider.Templates.Count);
			Dashboard d = Dashboard.DefaultTemplate (10);
			d.Name = "NEW";
			provider.Save (d);
			Assert.AreEqual (2, provider.Templates.Count);
		}

		[Test ()]
		public void TestSaveUpdateLoad ()
		{
			CategoriesTemplatesProvider provider = new CategoriesTemplatesProvider (storage);
			Dashboard d = Dashboard.DefaultTemplate (10);
			d.Name = "jamematen";
			provider.Save (d);
			Assert.IsTrue (provider.Exists ("jamematen"));

			d = Dashboard.DefaultTemplate (10);
			d.Name = "system";
			provider.Register (d);
			Assert.IsNotNull (provider.Exists ("system"));
		}

		[Test ()]
		public void TestLoadFile ()
		{
			CategoriesTemplatesProvider provider = new CategoriesTemplatesProvider (storage);
			Dashboard d = Dashboard.DefaultTemplate (10);
			d.Name = "jamematen";
			string path = Path.GetTempFileName ();
			try {
				Serializer.Instance.Save (d, path);
				Assert.IsNotNull (provider.LoadFile (path));
			} finally {
				File.Delete (path);
			}
		}

		[Test ()]
		public void TestRegister ()
		{
			CategoriesTemplatesProvider provider = new CategoriesTemplatesProvider (storage);
			Dashboard d = Dashboard.DefaultTemplate (10);
			d.Name = "system";
			provider.Register (d);
			Assert.IsNotNull (provider.Exists ("system"));
		}

		[Test ()]
		public void TestCopy ()
		{
			CategoriesTemplatesProvider provider = new CategoriesTemplatesProvider (storage);
			provider.Copy (provider.Templates [0], "NEW");
			Assert.AreEqual (2, provider.Templates.Count);
			Assert.IsNotNull (provider.Exists ("NEW"));
			Assert.DoesNotThrow (() => provider.Copy (Dashboard.DefaultTemplate (5), "NEW"));
		}

		[Test ()]
		public void TestDelete ()
		{
			CategoriesTemplatesProvider provider = new CategoriesTemplatesProvider (storage);
			Assert.AreEqual (1, provider.Templates.Count);
			// Template does not exists
			Assert.DoesNotThrow (() => provider.Delete (Dashboard.DefaultTemplate (1)));
			// System template
			Assert.Throws<TemplateNotFoundException<Dashboard>> (() => provider.Delete (provider.Templates [0]));
			Dashboard d = Dashboard.DefaultTemplate (10);
			d.Name = "jamematen";
			provider.Save (d);
			Assert.AreEqual (2, provider.Templates.Count);
			provider.Delete (d);
			Assert.AreEqual (1, provider.Templates.Count);
			Assert.IsFalse (provider.Exists (d.Name));
		}

		[Test ()]
		public void TestCreate ()
		{
			CategoriesTemplatesProvider provider = new CategoriesTemplatesProvider (storage);
			provider.Create ("jamematen");
			Assert.AreEqual (2, provider.Templates.Count);
			Assert.IsTrue (provider.Exists ("jamematen"));
		}

		[Test]
		public void TestAdd ()
		{
			CategoriesTemplatesProvider provider = new CategoriesTemplatesProvider (storage);
			Assert.AreEqual (1, provider.Templates.Count);
			provider.Add (Dashboard.DefaultTemplate (5));
			Assert.AreEqual (2, provider.Templates.Count);
		}
	}
}

