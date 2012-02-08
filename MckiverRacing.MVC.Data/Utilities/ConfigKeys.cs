using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace MckiverRacing.MVC.Data.Utilities
{
    public static class ConfigKeys
    {
        public static string GetConfigValue(string key){
            return ConfigurationManager.AppSettings[key].ToString();
        }

        public static object GetConfigSection(string section){
            return ConfigurationManager.GetSection(section);
        }
    }
}
