// Config.cs
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
using System.Configuration;
using System.IO;
using System.Xml;

namespace LongoMatch
{
	
	
	public class SectionsWriter
	{
		private XmlDocument configXml;
		private string fConfig;
		

		
		public static void CreateNewTemplate(string templateName){
			XmlDocument configXml = new XmlDocument();
			string fConfig = Path.Combine (MainClass.TemplatesDir(), templateName);
			 System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sb.Append("<configuration>");
            
			for (int i=1;i<21;i++){
				sb.Append("<add key=\"Name"+i+"\" value=\"Data "+i+"\" />");
				sb.Append("<add key=\"Start"+i+"\" value=\"10\" />");
				sb.Append("<add key=\"Stop"+i+"\" value=\"10\" />");
			}
			
			sb.Append("</configuration>");
			configXml.LoadXml(sb.ToString());
            configXml.Save(fConfig);			
		}

		
		public static void SetValue(XmlDocument configXml,string section, string clave, string valor) 
		{    
    		XmlNode n;
    		n = configXml.SelectSingleNode(section + "/add[@key=\"" + clave + "\"]");
    		if( n != null )    {

        		n.Attributes["value"].Value = valor;
    		}
		}
		

		
		public static void UpdateTemplate(string templateName,Sections sections){
			
			string fConfig = Path.Combine (MainClass.TemplatesDir(), templateName);
			
			if (!File.Exists(fConfig)){
				//Salimos silenciosamente
				return;
			}
		
			Console.WriteLine(fConfig);
			Console.WriteLine(File.Exists(fConfig));
			
			
			XmlDocument configXml = new XmlDocument();
			configXml.Load(fConfig);
			
			for (int i = 0; i<20;i++){
				SetValue(configXml,"configuration","Name" + (i+1),sections.GetName(i));
				SetValue(configXml,"configuration","Start"+ (i+1),sections.GetStartTime(i).ToString());
				SetValue(configXml,"configuration","Stop"+ (i+1),sections.GetStopTime(i).ToString());
			}
			configXml.Save(fConfig);
		}
		
	
		private bool isDefaultTemplateName(string templateName){
			return templateName == "default.sct";
		}
	
		
	}
}
