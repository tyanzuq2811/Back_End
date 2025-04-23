using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bai4
    {
        public static void Run()
        {
            int number;
            Console.Write("Nhập một số nguyên dương: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} là số chẵn.");
            }
            else
            {
                Console.WriteLine($"{number} là số lẻ.");
            }
        }
    }
}
