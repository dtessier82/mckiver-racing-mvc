using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MckiverRacing.MVC.Data.Utilities;
using System.Text;
using System.Reflection;

namespace MckiverRacing.MVC.Web.Helpers
{
    public static class HtmlExtensionHelper
    {
        public static string EnumDropDown(this HtmlHelper helper, Type enumType, string id) 
        { if (enumType == null || !enumType.IsEnum)        
            return ""; object defaultValue = null; 
            if (helper.ViewData != null)        
                defaultValue = helper.ViewData.Eval(id); 
            
            try { 
                    if (defaultValue == null)           
                        defaultValue = helper.ViewData.Model.GetType()
                            .GetProperty(id)
                            .GetValue(helper.ViewData.Model, null); 
            } catch (Exception) { } 

            StringBuilder sb = new StringBuilder(); 
            sb.AppendFormat("<select id=\"{0}\">", id); 

            foreach (var item in enumType.GetFields(BindingFlags.Public | BindingFlags.Static)) 
            { 
                string def = ""; 
                if (defaultValue != null && 
                    defaultValue.ToString() == item.GetRawConstantValue().ToString())            
                    def = "selected=\"selected\""; 

                EnumDisplayNameAttribute[] attributes = 
                    (EnumDisplayNameAttribute[])item.GetCustomAttributes(typeof(EnumDisplayNameAttribute), false); 
                
                if (attributes.Length > 0)            
                    sb.AppendFormat("<option value=\"{0}\" {1}>{2}</option>", 
                        item.GetRawConstantValue().ToString(), def, attributes[0].DisplayName); 
                else            
                    sb.AppendFormat("<option value=\"{0}\" {1}>{2}</option>", 
                        item.GetRawConstantValue().ToString(), def, item.Name); 
            } 

            sb.Append("</select>"); 

            return sb.ToString(); 
        
        }
    }
}