using System;
using System.Xml;

namespace Translator
{
    public class REMOVEWord
    {
        public string RemWord_Engl;
        public string RemWord_Russ;

        public REMOVEWord() { }

        public REMOVEWord(string RWE, string RWR)
        {
            RemWord_Engl = RWE;
            RemWord_Russ = RWR;
        }

        public void RemuvEngl()
        {
            Console.WriteLine("Введите английское слово которые вы хотите удалить!");
            string word_delet = Convert.ToString(Console.ReadLine());
            XmlDocument xml = new XmlDocument();
            xml.Load("../../English.xml");
            XmlAttributeCollection collection = xml.DocumentElement["Word"].Attributes;// получает атрибус с указаным элиментов
            collection.Remove(collection[word_delet]);
            xml.Save("../../English.xml");
            Console.WriteLine("Вы удалили слово!!!");
        }
        public void RemuvRuss()
        {
            Console.WriteLine("Введите слово которые вы хотите удалить!");
            string word_delet = Convert.ToString(Console.ReadLine());
            XmlDocument xml = new XmlDocument();
            xml.Load("../../Russian.xml");
            XmlAttributeCollection collection = xml.DocumentElement["Слово"].Attributes;
            collection.Remove(collection[word_delet]);
            xml.Save("../../Russian.xml");
            Console.WriteLine("Вы удалили слово!!!");
        }
    }
}
