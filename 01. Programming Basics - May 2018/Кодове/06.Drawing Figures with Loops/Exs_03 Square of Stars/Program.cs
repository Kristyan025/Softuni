﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {

            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
        }
    }
}
