using System;
using System.Reflection.Metadata.Ecma335;

namespace LAB2
{
    class Program
    {
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public static int TinhTong(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            return tong;
        }

        public static int TongChan(int[] a, int n)
        {
            int tongChan = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    tongChan += a[i];
                }
            }
            return tongChan;
        }

        public static bool SoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static (int duong, int am) DemAmDuong (int[] a, int n)
        {
            int duong = 0;
            int am = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0)
                {
                    duong++;
                }
                else if (a[i] < 0)
                {
                    am++;
                }
            }
            return (duong, am);
        }

        public static int SoLonThu2(int[] a, int n)
        {
            int max = int.MinValue;
            int max2 = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max2 = max;
                    max = a[i];
                }
                else if (a[i] > max2 && a[i] != max)
                {
                    max2 = a[i];
                }
            }
            return max2;
        }

        public static void SapXepTangDan(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Khai báo biến n 
            int n;
            //Nhập giá trị cho biến n 
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            //Khai báo và khởi tạo mảng số nguyên có n phần tử 
            int[] a = new int[n];
            //Gọi hàm nhập mảng 
            NhapMang(a, n);
            //Gọi hàm Tính Tổng các phần tử trong mảng và hiển thị kết quả ra màn hình 
            Console.WriteLine($"Tổng = {TinhTong(a, n)}");

            Console.WriteLine($"Tong cac so chan trong mang: {TongChan(a, n)}");

            Console.Write($"Cac phan tu la so nguyen to trong mang:");
            for (int i = 0; i < n; i++)
            {
                if (SoNguyenTo(a[i]))
                {
                    Console.WriteLine($"{a[i]} ");
                }
            }

            var (duong, am) = DemAmDuong(a, n);
            Console.WriteLine($"So phan tu duong: {duong}");
            Console.WriteLine($"So phan tu am: {am}");

            int soLonThu2 = SoLonThu2(a, n);
            Console.WriteLine($"So lon thu 2 trong mang: {soLonThu2}");

            SapXepTangDan(a, n);
            Console.Write("Sap xep theo chieu tang dan: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }
    }
}