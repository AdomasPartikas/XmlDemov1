using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument asmuoDocument = new XmlDocument();
            XmlElement asmuo = asmuoDocument.CreateElement("Asmuo");
            asmuoDocument.AppendChild(asmuo);
            var vardas = asmuoDocument.CreateElement("Vardas");
            vardas.InnerText = "Jonas";
            asmuo.AppendChild(vardas);

            var pavardė = asmuoDocument.CreateElement("Pavardė");
            pavardė.InnerText = "Jonaitis";
            asmuo.AppendChild(pavardė);

            asmuo.SetAttribute("Amzius", "12");

            Console.WriteLine(asmuoDocument.OuterXml);
            Console.ReadKey();
        }
    }
}
