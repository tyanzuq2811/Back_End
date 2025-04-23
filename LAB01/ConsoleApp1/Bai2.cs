using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class Bai2
    {
        public static void Run()
        {
            Console.Write("Nhập chiều dài hình chữ nhật: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng hình chữ nhật: ");
            double width = double.Parse(Console.ReadLine());
            double area = height * width;
            Console.WriteLine($"Diện tích hình chữ nhật: {area}");
        }
    }
}
