using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IS_Test
{
    public class CustomProperty
    {
        public string ID;
        public string Name;
        public string Type;
        public bool Required;
        public string DefaultValue;
        public string Value;
        public List<string> Options;

        public CustomProperty()
        {
            ID = string.Empty;
            Name = string.Empty;
            Type = string.Empty;
            Required = false;
            DefaultValue = string.Empty;
            Value = string.Empty;
            Options = new List<string>();
        }
    }
}
