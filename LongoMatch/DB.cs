// DB.cs
//
//  Copyright (C) 2007 Andoni Morales Alastruey
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
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
//
//

using System;
using System.IO;
using System.Collections;
using Mono.Unix;
using Db4objects.Db4o;
using Db4objects.Db4o.Query;

namespace LongoMatch
{
	
	
	public sealed class DB
	{
		private IObjectContainer db;
		private string file;
		
		public DB()
		{
			string baseDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
			file = Path.Combine (baseDirectory, "db.yap");
		}
		
		
		// Singleton to avoid various instance of DB opened at once
		public static DB Instance
		{
			get
			{
				return Nested.instance;
			}
		}
		
		class Nested
		{
			static Nested(){
			}
			internal static readonly DB instance = new DB();
		}
		
		
		public ArrayList GetAllDB(){
			ArrayList allDB = new ArrayList();
			db = Db4oFactory.OpenFile(file);
			try	{   				
   				IQuery query = db.Query();
				query.Constrain(typeof(FileData));
				IObjectSet result = query.Execute();
				while (result.HasNext()){
					allDB.Add(result.Next());
					
				}
				return allDB;
					
   			 }
			
			finally
			{
    			db.Close();
			}
		
		}
		
		public FileData GetFileData(String filename){
			db = Db4oFactory.OpenFile(file);
			try	{   				
   				IQuery query = db.Query();
				query.Constrain(typeof(FileData));
				query.Descend("filename").Constrain(filename);
				IObjectSet result = query.Execute();
				return (FileData)result.Next();
   			 }
			
			finally
			{
    			db.Close();
			}
			
		}
		public void AddFileData (FileData fileData){
			db = Db4oFactory.OpenFile(file);
			
			try	
			{
				if (!this.Exists(fileData.Filename)){
				db.Set (fileData);
				}
				else throw new Exception (Catalog.GetString("The FileData for this video file already exists.\n Try to edit it whit the Database Manager"));
   			 }
			
			finally
			{
				
    			db.Close();
			}
		
		}
		public void RemoveFileData(FileData filedata){
			Db4oFactory.Configure().ObjectClass(typeof(FileData)).CascadeOnDelete(true);			
			db = Db4oFactory.OpenFile(file);
			try	{			
				IQuery query = db.Query();
				query.Constrain(typeof(FileData));
				query.Descend("filename").Constrain(filedata.Filename);
				IObjectSet result = query.Execute();
				filedata = (FileData)result.Next();
				db.Delete(filedata);   				
   			 }
			
			finally
			{
    			db.Close();
			}
			
		}
		
		public void UpdateFileData(FileData fData, string previousFileName){
			bool error = false;
			Db4oFactory.Configure().ObjectClass(typeof(FileData)).CascadeOnDelete(true);
			Db4oFactory.Configure().ObjectClass(typeof(ArrayList)).CascadeOnUpdate(true);
			db = Db4oFactory.OpenFile(file);
			try	{
				// Buscamos si ya existe un obejto FileData para el archivo multimedia
				if (!Exists(fData.Filename)){
					//Borramos el antiguo archivo FileData
					IQuery query = db.Query();
					query.Constrain(typeof(FileData));
					query.Descend("filename").Constrain(previousFileName);
					IObjectSet result = query.Execute();  
					FileData fd = (FileData)result.Next();
					db.Delete(fd);
					// Agregamos el nuevo obejto actualizado
					db.Set(fData);	
				}
				else 
					error = true;
					
   			 }
			finally{
				db.Close();
				if (error)
					throw new Exception();
			}
		
		}
		
		public void UpdateFileData(FileData fData){
			
			Db4oFactory.Configure().ObjectClass(typeof(FileData)).CascadeOnDelete(true);
			Db4oFactory.Configure().ObjectClass(typeof(ArrayList)).CascadeOnUpdate(true);
			db = Db4oFactory.OpenFile(file);
			try	{				
				IQuery query = db.Query();
				query.Constrain(typeof(FileData));
				query.Descend("filename").Constrain(fData.Filename);
				IObjectSet result = query.Execute();  
				FileData fd = (FileData)result.Next();
				db.Delete(fd);
				db.Set(fData);				
   			 }
			
			finally
			{
    			db.Close();
			}
		
		
		}
		
		private bool Exists(string filename){
			IQuery query = db.Query();
			query.Constrain(typeof(FileData));
			query.Descend("filename").Constrain(filename);
			IObjectSet result = query.Execute();
			return (result.HasNext());
		}
		

	}
}
