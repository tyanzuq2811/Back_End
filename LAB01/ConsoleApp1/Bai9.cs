using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class Bai9
    {
        public static void Run()
        {
            Console.Write("Nhap mot so nguyen duong: ");
            int n = int.Parse(Console.ReadLine());
            int tich = 1;
            for (int i = 1; i<=n; i++)
            {
                tich *= i;
            }
            Console.WriteLine($"Giai thua cua {n} la: {tich}");
        }
    }
}
