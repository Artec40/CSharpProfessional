using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlWriter = new XmlTextWriter("C:/Repositories/CSharpProfessional/Lesson5/Task1/telephoneBook.xml",null);
            
                //Включает форматирование документа с отступом.
            xmlWriter.Formatting = Formatting.Indented;
                // Для выделения уровня элемента используется табуляция в 1 символ.
            xmlWriter.IndentChar = '\t';
            xmlWriter.Indentation = 1;
            
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("MyContacts");
            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteStartAttribute("Phone");
            xmlWriter.WriteString("+7(908)911-37-36");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteString("Name - Andrew");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            
            xmlWriter.Close();
            
            FileStream stream = new FileStream("C:/Repositories/CSharpProfessional/Lesson5/Task1/telephoneBook.xml", FileMode.Open);
            var xmlReader = new XmlTextReader(stream);

            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes)
                {
                    if (xmlReader.Name.Equals("Contact"))
                    {
                        Console.WriteLine(xmlReader.GetAttribute("Phone"));
                    }
                }
            }

            xmlReader.Close();
        }
    }
}