﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int count0_25 = 0, count26_50 = 0, count51_75 = 0, count76_100 = 0;
            do
            {
                Console.WriteLine("Digite um número:");
                num = Convert.ToInt16(Console.ReadLine());

                if (num >= 0 && num <=25 )
                {
                    count0_25 = count0_25 + 1; 
                }else if (num >= 26 && num <=50)
                {
                    count26_50++;
                }else if (num >= 51 && num <= 75)
                {
                    count51_75++;
                }else if (num >= 76 && num <= 100)
                {
                    count76_100++;
                }

            } while (num != 0);

            Console.WriteLine("count0_25" + count0_25);
            Console.WriteLine("count26_50" + count26_50);
            Console.WriteLine("count51_75" + count51_75);
            Console.WriteLine("count76_100" + count76_100);
        }
    }
}
