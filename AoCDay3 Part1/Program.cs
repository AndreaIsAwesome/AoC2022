﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;

namespace AoCDay3
{
    internal class Program
    {
        static int Convert(char letter)
        {
            int number = 0;

            if (letter == 'a')
            {
                number = 1;
            }
            else if (letter == 'b')
            {
                number = 2;
            }
            else if (letter == 'c')
            {
                number = 3;
            }
            else if (letter == 'd')
            {
                number = 4;
            }
            else if (letter == 'e')
            {
                number = 5;
            }
            else if (letter == 'f')
            {
                number = 6;
            }
            else if (letter == 'g')
            {
                number = 7;
            }
            else if (letter == 'h')
            {
                number = 8;
            }
            else if (letter == 'i')
            {
                number = 9;
            }
            else if (letter == 'j')
            {
                number = 10;
            }
            else if (letter == 'k')
            {
                number = 11;
            }
            else if (letter == 'l')
            {
                number = 12;
            }
            else if (letter == 'm')
            {
                number = 13;
            }
            else if (letter == 'n')
            {
                number = 14;
            }
            else if (letter == 'o')
            {
                number = 15;
            }
            else if (letter == 'p')
            {
                number = 16;
            }
            else if (letter == 'q')
            {
                number = 17;
            }
            else if (letter == 'r')
            {
                number = 18;
            }
            else if (letter == 's')
            {
                number = 19;
            }
            else if (letter == 't')
            {
                number = 20;
            }
            else if (letter == 'u')
            {
                number = 21;
            }

            else if (letter == 'v')
            {
                number = 22;
            }
            else if (letter == 'w')
            {
                number = 23;
            }
            else if (letter == 'x')
            {
                number = 24;
            }
            else if (letter == 'y')
            {
                number = 25;
            }
            else if (letter == 'z')
            {
                number = 26;
            }

            else if (letter == 'A')
            {
                number = 27;
            }
            else if (letter == 'B')
            {
                number = 28;
            }
            else if (letter == 'C')
            {
                number = 29;
            }
            else if (letter == 'D')
            {
                number = 30;
            }
            else if (letter == 'E')
            {
                number = 31;
            }
            else if (letter == 'F')
            {
                number = 32;
            }
            else if (letter == 'G')
            {
                number = 33;
            }
            else if (letter == 'H')
            {
                number = 34;
            }
            else if (letter == 'I')
            {
                number = 35;
            }
            else if (letter == 'J')
            {
                number = 36;
            }
            else if (letter == 'K')
            {
                number = 37;
            }
            else if (letter == 'L')
            {
                number = 38;
            }
            else if (letter == 'M')
            {
                number = 39;
            }
            else if (letter == 'N')
            {
                number = 40;
            }
            else if (letter == 'O')
            {
                number = 41;
            }
            else if (letter == 'P')
            {
                number = 42;
            }
            else if (letter == 'Q')
            {
                number = 43;
            }
            else if (letter == 'R')
            {
                number = 44;
            }
            else if (letter == 'S')
            {
                number = 45;
            }
            else if (letter == 'T')
            {
                number = 46;
            }
            else if (letter == 'U')
            {
                number = 47;
            }

            else if (letter == 'V')
            {
                number = 48;
            }
            else if (letter == 'W')
            {
                number = 49;
            }
            else if (letter == 'X')
            {
                number = 50;
            }
            else if (letter == 'Y')
            {
                number = 51;
            }
            else if (letter == 'Z')
            {
                number = 52;

            }

            return number;
        }

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("input.txt"))
            {
                string line; int total = 0;
                while ((line = sr.ReadLine()) != null)
                {

                    string secondhalf = line.Substring(line.Length / 2);
                    string firsthalf = line.Substring(0, line.Length / 2);
                    int repeat = 1;

                    foreach (char f in firsthalf)
                    {

                        foreach (char s in secondhalf)
                        {
                            if (f == s)
                            {
                                if (repeat == 1)
                                {
                                    int n = Convert(s);
                                    total = total + n;
                                }

                                repeat = 0;
                            }
                        }

                    }
                }
                Console.WriteLine(total);
                Console.ReadKey();
            }
        }
    }
}




