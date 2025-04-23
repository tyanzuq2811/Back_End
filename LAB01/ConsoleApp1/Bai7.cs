using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class Bai7
    {
        public static void Run()
        {
            Console.Write("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());
            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
            {
                Console.WriteLine($"{nam} la nam nhuan");
            }
            else
            {
                Console.WriteLine($"{nam} khong phai la nam nhuan");
            }
        }
    }
}
