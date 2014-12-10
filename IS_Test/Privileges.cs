using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace IS_Test
{

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class privilegeSets
    {
        [XmlElement(ElementName = "privilegeSet")]
        public privilegeSet[] privilegeGroups { get; set; }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class privilegeSet
    {
        [XmlElement(ElementName = "id")]
        public string id { get; set; }
        [XmlElement(ElementName = "type")] 
        public string type { get; set; }
        [XmlElement(ElementName = "privileges")]
        public privileges standardPrivileges;
        [XmlElement(ElementName = "inheritedPrivileges")]
        public privileges inheritedPrivileges;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class privileges
    {
        [XmlElement(ElementName = "privilege")]
        public privilege[] privilegeList { get; set; }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class privilege
    {
        [XmlElement(ElementName = "name")] 
        public string name { get; set; }
        [XmlElement(ElementName = "value")] 
        public string value { get; set; }
    }

}


