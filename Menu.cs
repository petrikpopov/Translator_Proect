using System;
using System.Text;
using System.Xml;
using Translator_END;

namespace Translator
{
    class Program
    {
        public class FAnglRuss
        {
            public void AnglDictionary()
            {
                XmlTextWriter xmlText = new XmlTextWriter("../../English.xml", Encoding.UTF8);
                xmlText.WriteStartDocument();
                xmlText.WriteStartElement("Dictionary");
                xmlText.WriteComment("English");
                xmlText.WriteStartElement("Word");
                xmlText.Close();
                Console.WriteLine("Файл успешно создан!!!");
            }
            public void RussDictionary()
            {
                XmlTextWriter xmlText = new XmlTextWriter("../../Russian.xml", Encoding.UTF8);
                xmlText.WriteStartDocument();
                xmlText.WriteStartElement("Словарь");
                xmlText.WriteComment("Русский");
                xmlText.WriteStartElement("Слово");
                xmlText.Close();
                Console.WriteLine("Файл успешно создан!!!");
            }
        }

        static void Main(string[] args)
        {

            FAnglRuss fAnglRuss = new FAnglRuss();
            AddWord addWord = new AddWord();
            REMOVEWord rEMOVEWord = new REMOVEWord();
            SearchWord searchWord = new SearchWord();
            ReplaceWord replaceWord = new ReplaceWord();
            while (true)
            {
                Console.WriteLine("Создать словарь --> 1)Англо-русский, 2)Русско-английский\n");
                Console.WriteLine("3)Добавить слово в словарь\n");
                Console.WriteLine("4)Удалить слово из словаря\n");
                Console.WriteLine("5)Найти слово в словаре\n");
                Console.WriteLine("6)Заменить слово в словаре\n");
                int vibor = Convert.ToInt32(Console.ReadLine());
                if (vibor == 1)
                {
                    fAnglRuss.AnglDictionary();
                }
                if (vibor == 2)
                {
                    fAnglRuss.RussDictionary();
                }
                if (vibor == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("В какой словарь вы хотите добавить слово??");
                    Console.WriteLine("1)Англо-русский\t2)русско-английский");
                    int vibo1 = Convert.ToInt32(Console.ReadLine());
                    if (vibo1 == 1)
                    {
                        addWord.ADDAngl();

                    }
                    if (vibo1 == 2)
                    {
                        addWord.ADDRuss();
                    }
                }
                if (vibor == 4)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Из какого словаря вы хотите удалить слово??");
                    Console.WriteLine("1)Aнгло-русского\t2)русско-английского\n");
                    int vibor2 = Convert.ToInt32(Console.ReadLine());
                    if (vibor2 == 1)
                    {
                        rEMOVEWord.RemuvEngl();
                    }
                    if (vibor2 == 2)
                    {
                        rEMOVEWord.RemuvRuss();
                    }
                }
                if (vibor == 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("В каком словаре вы хотите найти перевод слова?");
                    Console.WriteLine("1)Англо-русском\t2)Русско-английском");
                    int v = Convert.ToInt32(Console.ReadLine());
                    if (v == 1)
                    {
                        searchWord.SearchlEngl();
                    }
                    if (v == 2)
                    {
                        searchWord.SearchlRuss();
                    }
                }
                if (vibor==6)
                {
                    Console.WriteLine("В каком словаре вы хотите заменить слово/перевод\n");
                    Console.WriteLine("1)Англо - русском\t2)Русско - английском");
                    int vib = Convert.ToInt32(Console.ReadLine());
                    if (vib==1)
                    {
                        replaceWord.Repl_Angl();
                    }
                    if (vib==2)
                    {
                        replaceWord.Repl_Russ();
                    }
                }
            }
        }
    }
}
