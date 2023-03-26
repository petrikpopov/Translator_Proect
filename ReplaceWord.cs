using System;
using System.Linq;
using System.Xml.Linq;


namespace Translator_END
{
    public class ReplaceWord
    {
       
        public string New_Word_Angl;
        public string New_Word_Russ;

        public ReplaceWord() { }
        public ReplaceWord(string NWA, string NWR)
        {
            New_Word_Angl = NWA;
            New_Word_Russ = NWR;
        }

        public void Repl_Angl()
        {
            Console.Write("Введите старое слово:");
            string old = Console.ReadLine();
            Console.Write("Введите новое английское слово:");
            string new_word = Console.ReadLine();
            XDocument doc = XDocument.Load("../../English.xml");
            var element = doc.Root.Element("Word");
            var attList = element.Attributes().ToList();
            var oldAtt = attList.Where(p => p.Name == old).SingleOrDefault();
            if (oldAtt != null)
            {
                XAttribute newAtt = new XAttribute(new_word, oldAtt.Value);
                attList.Add(newAtt);
                attList.Remove(oldAtt);
                element.ReplaceAttributes(attList);
                doc.Save("../../English.xml");
            }
            Console.WriteLine("Вы заменили слово!!!");
        }
        public void Repl_Russ()
        {
            Console.Write("Введите старое слово:");
            string old = Console.ReadLine();
            Console.Write("Введите новое русское слово:");
            string new_word = Console.ReadLine();
            XDocument document = XDocument.Load("../../Russian.xml");
            var element = document.Root.Element("Слово");
            var attList = element.Attributes().ToList();
            var oldAtt = attList.Where(p => p.Name == old).SingleOrDefault();
            if (oldAtt != null)
            {
                XAttribute newAtt = new XAttribute(new_word, oldAtt.Value);
                attList.Add(newAtt);
                attList.Remove(oldAtt);
                element.ReplaceAttributes(attList);
                document.Save("../../Russian.xml");
            }
            Console.WriteLine("Вы заменили перевод!!!");
        }
    }
}
