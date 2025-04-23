
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LAB01
{
    internal class Bai8
    {
        public static void Run()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine($"Bang cuu chuong {i}");
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }   
         
    }
}
