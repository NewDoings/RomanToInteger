using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_to_integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string roman_number = Console.ReadLine();     // Ввод римских чисел
            Console.WriteLine(RomanToInt(roman_number));  // Перевод и вывод арабских чисел
            Console.ReadKey();
        }
        public static int RomanToInt(string x)            // Перевод римских чисел в арабские
        {
            int to_integer = 0;
            for (int i = 0; i < x.Length; i++)
            {
                switch (x[i])
                {
                    case 'I':
                        to_integer += 1;
                        break;
                    case 'V':
                        if (i != 0)
                        {
                            if (x[i-1] == 'I')
                            {
                                to_integer += 3;
                                break;
                            }
                        }
                        to_integer += 5;
                        break;
                    case 'X':
                        if (i != 0)
                        {
                            if (x[i - 1] == 'I')
                            {
                                to_integer += 8;
                                break;
                            }
                        }
                        to_integer += 10;
                        break;
                    case 'L':
                        if (i != 0)
                        {
                            if (x[i - 1] == 'X')
                            {
                                to_integer += 30;
                                break;
                            }
                        }
                        to_integer += 50;
                        break;
                    case 'C':
                        if (i != 0)
                        {
                            if (x[i - 1] == 'X')
                            {
                                to_integer += 80;
                                break;
                            }
                        }
                        to_integer += 100;
                        break;
                    case 'D':
                        if (i != 0)
                        {
                            if (x[i - 1] == 'C')
                            {
                                to_integer += 300;
                                break;
                            }
                        }
                        to_integer += 500;
                        break;
                    case 'M':
                        if (i != 0)
                        {
                            if (x[i - 1] == 'C')
                            {
                                to_integer += 800;
                                break;
                            }
                        }
                        to_integer += 1000;
                        break;
                }
            }
            return to_integer;
        }
    }
}
