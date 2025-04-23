using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class Bai3
    {
        public static void Run()
        {
            Console.Write("Nhập nhiệt độ: ");
            double C = double.Parse(Console.ReadLine());
            double F = (C * 9 / 5) + 32;
            Console.WriteLine($"Nhiệt độ {C}°C tương đương với {F}°F");
        }
    }
}
