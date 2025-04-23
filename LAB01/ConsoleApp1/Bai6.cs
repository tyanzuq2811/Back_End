using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bai6
    {
        public static void Run()
        {
            double number;
            Console.Write("Nhập một số: ");
            number = Convert.ToDouble(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine($"{number} là số dương.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} là số âm.");
            }
            else
            {
                Console.WriteLine("Số nhập vào là 0.");
            }
        }
    }
}
