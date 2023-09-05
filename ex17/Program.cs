using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startSymbol = '(';
            char endSymbol = ')';
            int maxDepthSymbols = 0;
            int symbolsEquality = 0;
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == startSymbol)
                {
                    symbolsEquality++;

                    if (symbolsEquality > maxDepthSymbols)
                    {
                        maxDepthSymbols = symbolsEquality;
                    }

                }
                else if (text[i] == endSymbol)
                {
                    symbolsEquality--;

                    if (symbolsEquality < 0)
                    {
                        break;
                    }
                }
            }

            if (symbolsEquality != 0)
            {
                Console.WriteLine("Некорректная запись");
            }
            else
            {
                Console.WriteLine($"Запись корректна. Глубина вложенности скобки равна {maxDepthSymbols}");
            }
        }
    }
}
