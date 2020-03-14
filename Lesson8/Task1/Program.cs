using System;
using System.IO;
using System.Xml.Serialization;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(MyClass));

            MyClass myClass = new MyClass();
            
            FileStream stream = new FileStream
            ("Serialization.XML", 
                FileMode.Create, FileAccess.Write, FileShare.Read);
            
            serializer.Serialize(stream,myClass);
            stream.Close();
        }    
    }
}