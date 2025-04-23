using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class Bai10
    {
        public static void Run()
        {
            Console.Write("Nhap mot so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            if (NguyenTo(n))
            {
                Console.WriteLine($"{n} la so nguyen to");
            }
            else
            {
                Console.WriteLine("{n} khong phai la so nguyen to");
            }
        }
        private static bool NguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0) return false;    
            }
            return true;
        }
    }
}
