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
            var asmenys = asmuoDocument.CreateElement("Asmenys");
            asmuoDocument.AppendChild(asmenys);

            for (int i = 0; i < 10; i++)
            {
                var r = new Random();

                XmlElement asmuo = asmuoDocument.CreateElement("Asmuo");
                //asmuoDocument.AppendChild(asmuo);
                var vardas = asmuoDocument.CreateElement("Vardas");
                vardas.InnerText = "Jonas" + r.Next(1, 10);
                asmuo.AppendChild(vardas);

                var pavardė = asmuoDocument.CreateElement("Pavardė");
                pavardė.InnerText = "Jonaitis" + r.Next(1, 10);
                asmuo.AppendChild(pavardė);

                asmuo.SetAttribute("Amzius", $"{r.Next(1, 10)}");

                asmenys.AppendChild(asmuo);
            }

            Console.WriteLine(asmuoDocument.OuterXml);


            //var asmuoReadDocument = new XmlDocument();
            //asmuoReadDocument.LoadXml(asmuoDocument.OuterXml);

            //var vardasRead = asmuoReadDocument.SelectSingleNode("/Asmuo/Vardas").InnerText;
            //var amziusRead = asmuoReadDocument.SelectSingleNode("/Asmuo").Attributes["Amzius"].Value;
            //Console.WriteLine(vardasRead);
            //Console.WriteLine(amziusRead);


            Console.ReadKey();
        }
    }
}
