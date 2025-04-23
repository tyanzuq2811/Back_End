using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class CanBo
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public CanBo() { }

        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap gioi tinh: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Nam sinh: {NamSinh}");
            Console.WriteLine($"Gioi tinh: {GioiTinh}");
            Console.WriteLine($"Dia chi: {DiaChi}");
        }
    }

    public class CongNhan : CanBo
    {
        public string Bac { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap bac: ");
            Bac = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Bac: {Bac}");
        }
    }

    public class KySu : CanBo
    {
        public string NganhDaoTao { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap nganh dao tao: ");
            NganhDaoTao = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Nganh dao tao: {NganhDaoTao}");
        }
    }

    public class NhanVien : CanBo
    {
        public string CongViec { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap cong viec: ");
            CongViec = Console.ReadLine();
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Cong viec: {CongViec}");
        }
    }

    public class QLCB
    {
        private List<CanBo> danhSachCanBo;
        public QLCB()
        {
            danhSachCanBo = new List<CanBo>();
        }

        public void NhapThongTin()
        {
            Console.WriteLine("Chọn loại cán bộ (1-Công nhân, 2-Kỹ sư, 3-Nhân viên): ");
            int choice = int.Parse(Console.ReadLine());

            CanBo canBo = null;
            switch (choice)
            {
                case 1:
                    canBo = new CongNhan(); 
                    break;
                case 2:
                    canBo = new KySu();
                    break;
                case 3:
                    canBo = new NhanVien();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    return;
            }

            canBo.Nhap();
            danhSachCanBo.Add(canBo);
            Console.WriteLine("Nhap thong tin thanh cong!");
        }

        public void TimKiemTheoHoten()
        {
            Console.WriteLine("Nhap ho ten can tim:");
            string hoten = Console.ReadLine();

            bool found = false;
            foreach(var canBo in danhSachCanBo)
            {
                if (canBo.HoTen.ToLower().Contains(hoten.ToLower()))
                {
                    canBo.HienThi();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Khong tim thay can bo nao!");
            }
        }

        public void HienThiDanhSach()
        {
            Console.WriteLine("Hien thi danh sach can bo:");
            foreach (var canBo in danhSachCanBo)
            {
                canBo.HienThi();
                Console.WriteLine("---------------------");
            }
        }

        public void ChayChuongTrinh()
        {
            while (true)
            {
                Console.WriteLine("\n=== QUẢN LÝ CÁN BỘ ===");
                Console.WriteLine("1. Thêm cán bộ mới");
                Console.WriteLine("2. Tìm kiếm theo họ tên");
                Console.WriteLine("3. Hiển thị danh sách cán bộ");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Vui lòng nhập số hợp lệ!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        NhapThongTin();
                        break;
                    case 2:
                        TimKiemTheoHoten();
                        break;
                    case 3:
                        HienThiDanhSach();
                        break;
                    case 4:
                        Console.WriteLine("Tạm biệt!");
                        return;
                    default:
                        Console.WriteLine("Chức năng không hợp lệ!");
                        break;
                }
            }
        }
    }
}
