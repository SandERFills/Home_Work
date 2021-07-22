using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWorld
{
    class SplitStrin
    {
        struct Point
        {
            private int X;
            private int Y;
            public Point(int PosX,int PosY)
            {
                X = PosX;
                Y = PosY;
            }
            public (int X, int Y) Distruct() => (X, Y);
        }
        static void Main(string[] args)
        {
            string StringLine = "Hello world this is my implementation of string splitter!";
            
            string oneWord=String.Empty; //переменная для одного слова
            for (int i = 0; i < StringLine.Length; i++)//проходимся по строке
            {
              
                if (!Char.IsWhiteSpace(StringLine[i]))//проходимся по всем символам до пробела
                {
                    oneWord =String.Concat(oneWord, StringLine[i]);//конкатенируем все символы в одну строку
                }
                else if (Char.IsWhiteSpace(StringLine[i]))//доходим до пробела
                {
                    Console.WriteLine(oneWord);//выводим целое слово,сюда можно добавить массив,для сохранения всех отдельных слов
                    oneWord = String.Empty;//присваеваем переменной пустое значение
                }
                
            }
            Console.WriteLine(oneWord);
            
            Point point = new Point(7, 5);
            var poitVal = point.Distruct();
            Console.WriteLine(poitVal.X+poitVal.Y);
            Console.ReadLine();
        }
    }
}
