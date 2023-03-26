using System;
using System.Xml;

namespace Translator
{
    public class AddWord
    {
        public string EnglWord;
        public string RussWord;

        public AddWord() { }
        public AddWord(string EW, string RW)
        {
            EnglWord = EW;
            RussWord = RW;
        }

        public void ADDAngl()
        {
            Console.WriteLine("Введите английское слово!");
            string word1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите русское слово!");
            string word2 = Convert.ToString(Console.ReadLine());
            XmlDocument xml = new XmlDocument();
            xml.Load("../../English.xml");
            xml.DocumentElement["Word"].SetAttribute(word1, word2);
            xml.Save("../../English.xml");
            Console.WriteLine("Вы добавили слово!!!");
        }
        public void ADDRuss()
        {
            Console.WriteLine("Введите русское слово!");
            string word2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите английское слово!");
            string word1 = Convert.ToString(Console.ReadLine());
            XmlDocument xml = new XmlDocument();
            xml.Load("../../Russian.xml");
            xml.DocumentElement["Слово"].SetAttribute(word2, word1);
            xml.Save("../../Russian.xml");
            Console.WriteLine("Вы добавили слово!!!");
        }
    }
}
