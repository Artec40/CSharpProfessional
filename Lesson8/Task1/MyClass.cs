using System;
using System.Xml.Serialization;

namespace Task1
{
    [XmlRoot("className")]
    public class MyClass
    {
        private string propertyOne = "firstProperty";
        private string propertyTwo = "secondProperty";

        [XmlElement("firstProperty")]
        public string PropertyOne
        {
            get { return propertyOne; }
            set { propertyOne = value; }
        }

        [XmlElement("secondProperty")]
        public string PropertyTwo
        {
            get { return propertyTwo;}
            set { propertyTwo = value;}

        }

        public MyClass()
        {
            
        }
        
        public MyClass(string propOne, string propTwo)
        {
            this.PropertyOne = propOne;
            this.PropertyTwo = propTwo;
        }
        
        
    }
}