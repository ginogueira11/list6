﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício1
{
    class exercício1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 número INTEIROS:");
            int num = Convert.ToInt16(Console.ReadLine());

            if (num % 2 == 1)
            {
                Console.WriteLine("{0}", num);
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine("{0}", num);
            }

            Console.ReadKey();
        }
    }
}
