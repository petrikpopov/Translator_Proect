using System;
using System.Xml.Linq;

namespace Translator
{
    public class SearchWord
    {
        public string SearchWordEndl;
        public string SearchWordRuss;

        public SearchWord() { }
        public SearchWord(string S, string SW)
        {
            SearchWordEndl = S;
            SearchWordRuss = SW;

        }

        public void SearchlEngl()
        {
            Console.WriteLine("Введите слово которое вы хотите перевести");
            string w = Convert.ToString(Console.ReadLine());
            XElement xElement = XElement.Load("../../English.xml");
            foreach (XElement i in xElement.Elements("Word"))
            {
                Console.Write($"{i.Name} ");
                foreach (XAttribute a in i.Attributes())
                {
                    if (a.Name == w)
                    {
                        Console.Write($"{a.Name}--->{a.Value}");
                    }
                    else
                    {
                        Console.WriteLine("Такого слова в словаре нет!!!");
                    }
                }

            }
            Console.WriteLine("\n");

        }
        public void SearchlRuss()
        {
            Console.WriteLine("Введите слово которое вы хотите перевести");
            string w = Convert.ToString(Console.ReadLine());
            XElement xElement = XElement.Load("../../Russian.xml");
            foreach (XElement i in xElement.Elements("Слово"))
            {
                Console.Write($"{i.Name} ");
                foreach (XAttribute a in i.Attributes())
                {
                    if (a.Name == w)
                    {
                        Console.Write($"{a.Name}--->{a.Value} ");
                    }
                    else
                    {
                        Console.WriteLine("Такого слова в словаре нет!!!");
                    }
                }

            }
            Console.WriteLine("\n");

        }
    }
}
