using System;

namespace ЧЕРНОВИК_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное число");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конечное число");
            int y = int.Parse(Console.ReadLine());

            int counterX = 0;
            int max = x * y;

            for (int a = max; 0 < a; counterX++)
            {
                a = a / 10;
            }

            
            int counter = 0;

            for (int a = max; 0 < a; counter++)
            {
                a = a / 10;
            }
            Console.WriteLine();
            
            Console.WriteLine();

            for (int count = y; 0 < count; count /= 10)
            {
                Console.Write(" ");
            }
            Console.Write(" ");
            Console.Write("|");
            
            for (int toprow = 1; toprow <= x; toprow++)
            {
                int count = 0;
                for (int i = toprow; i > 0; i /= 10)
                {
                    count++;
                }

                for (int topspaces = counterX - count; 0 <= topspaces; topspaces--)
                {
                    Console.Write(" ");
                }
                Console.Write(toprow);
            }
            Console.WriteLine();

            for (int counthyphen = y; 0 < counthyphen; counthyphen /= 10)
            {
                Console.Write("-");
            }
            Console.Write("-");
            Console.Write("+");

            for (int hyphenrow = 0; hyphenrow < x; hyphenrow++)
            {
                for (int counthyphenrow = max; counthyphenrow > 0; counthyphenrow /= 10)
                {
                    Console.Write("-");
                }
                Console.Write("-");
            }

            for (int downrow = x; 0 < downrow; downrow /= 10)
            {
                Console.Write(" ");
            }
            Console.WriteLine();

            for (int a = 1; a <= x; a++)
            {
                int counterY = 0;

                for (int z = y; 0 < z; counterY++)
                {
                    z /= 10;
                }

                int countY = 0;
                for (int i = a; i > 0; i /= 10)
                {
                    countY++;
                }

                for (int downspaces = counterY - countY; 0 <= downspaces; downspaces--)
                {
                    Console.Write(" ");
                }

                Console.Write(a);

                Console.Write("|");

                for (int b = 1; b <= y; b++)
                {
                    int count = 0;
                    for (int i = a * b; i > 0; i /= 10)
                    {
                        count++;
                    }
                    
                    for (int spaces = counter - count; 0 <= spaces; spaces--)
                    {
                        Console.Write(" ");
                    }
                    
                    Console.Write(a * b);
                }
                Console.WriteLine();
            }
        }
    }
}

