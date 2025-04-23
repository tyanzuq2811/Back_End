using System;

namespace BaiTap
{
    class Bai1
    {
        public static void Run()
        {
            Console.Write("Nhập tên: ");
            string ten = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
        }
    }
}
