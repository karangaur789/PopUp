using System;
using System.IO;
using System.Xml;

namespace xmlttext
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var converter = new GroupDocs.Conversion.Converter("C:\\Users\\raj\\Desktop\\hello.xml");
            //// Set conversion parameters for TXT format
            //var convertOptions = converter.GetPossibleConversions()["txt"].ConvertOptions;
            //// Convert to TXT format
            //converter.Convert("output.txt", convertOptions);
            //Console.WriteLine("hh");
            ////Console.ReadLine();
            ///

            string onlyContent = string.Empty;

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(@"C:\\Users\\raj\\Desktop\\hello.xml");

            var food = xdoc.SelectNodes("breakfast_menu/food");
            for (int i = 0; i < food.Count; i++)
            {
                //onlyContent += string.Format("\n bankname", i);
                onlyContent += string.Format("\n{0}:", i);
                foreach (XmlNode node in food[i].ChildNodes)
                    onlyContent += string.Format("{0},", node.InnerText);
            }


            File.WriteAllText(@"C:\\Users\\raj\\Desktop\\DetOders.txt", onlyContent);
        }
    }
}
