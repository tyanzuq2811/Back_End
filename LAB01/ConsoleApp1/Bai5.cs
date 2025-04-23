using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class Bai5
    {
        static void Run()
        {
            double so1, so2, tong, tich;
            Console.Write("Nhập số thứ nhất: ");
            so1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            so2 = Convert.ToDouble(Console.ReadLine());
            tong = so1 + so2;
            tich = so1 * so2;
            Console.WriteLine($"Tổng của {so1} và {so2} là: {tong}");
            Console.WriteLine($"Tích của {so1} và {so2} là: {tich}");
        }
    }
}
