﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MckiverRacing.MVC.Data.Utilities
{
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumDisplayNameAttribute : Attribute 
    {
        private string _displayName; 

        public EnumDisplayNameAttribute(string displayName) {
            _displayName = displayName; 
        
        } 
        
        public string DisplayName { 
            get { return _displayName; } 
        } 
    
    }
}
