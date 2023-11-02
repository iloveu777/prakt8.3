using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.2
            /*
            void print_empty(int num_of_columns)
            {
                for (int i = 0; i < num_of_columns; i++)
                {
                    WriteLine("");
                }
            }
            void print_char(int num_of_lines)
                {
                    for (int i = 0; i < num_of_lines; i++)
                    {
                        Write('#');
                    }
                }
                    WriteLine("сколько отступить сверху?");
                    int height = int.Parse(ReadLine());
                    WriteLine("какой длины строка?");
                    int width = int.Parse(ReadLine());
            Clear();
            print_empty(height); print_char(width);
            */

            //2.2
            /*
               Write("сколько решеток изначально? ");
            int count = int.Parse(ReadLine());
            int count1 = count;
            Clear();
            void print()
            {
                for(int i = 0; i < count; i++)
                {
                    Write('#');
                    
                }
                WriteLine("");
                count--;
            }
            for(int i = 0; i <= count1; i++)
            {
                print();
            }
            
            */

            //3.2
            /*
            double Sqrt(double number)
            {
                return Math.Sqrt(number);
            }
            double res()
            {
                double result = ((Sqrt(5) + 5) / (Sqrt(7) + 7) + (Sqrt(12) + 12) / (Sqrt(8) + 8) + (Sqrt(19) + 19) / Sqrt(2) + 2);
                return result;
            }
            double x = res();
            WriteLine($"{x:f2}");
            */
            int FindMax(int a, int b, int c, int d)
            {
                int max = a;

                if (b > max)
                {
                    max = b;
                }

                if (c > max)
                {
                    max = c;
                }

                if (d > max)
                {
                    max = d;
                }
                return max;
            }
            int z, x, c1, v;
            Write("введите первое число:");
            z = int.Parse(ReadLine());
            Write("введите второе число:");
            x = int.Parse(ReadLine());
            Write("введите третье число:");
            c1 = int.Parse(ReadLine());
            Write("введите четвертое число:");
            v = int.Parse(ReadLine());
            int maxx = FindMax(z, x, c1, v);
            Write(maxx);
            ReadKey();
                }
            }
        }
    

