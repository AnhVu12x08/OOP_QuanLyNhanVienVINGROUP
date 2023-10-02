using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyNhanVienVINGROUP
{
    internal class NhanVienKinhDoanh : NhanVien
    {
        private double DoanhSoToiThieu;
        private double DoanhSoTheoThang;
        public NhanVienKinhDoanh() : base()
        {
            DoanhSoToiThieu = 0.0;
            DoanhSoTheoThang = 0.0;
        }
        public NhanVienKinhDoanh(string MaSo, string HoTen, DateTime NgaySinh, string GioiTinh, int ThamNien, double heSoLuong, double DoanhSoToiThieu, double DoanhSoTheoThang) : base(MaSo, HoTen, NgaySinh, GioiTinh, ThamNien, heSoLuong)
        {
            this.DoanhSoToiThieu = DoanhSoToiThieu;
        }
        public override string XepLoai()
        {
            if (DoanhSoTheoThang >= DoanhSoToiThieu *2)
                return "A";
            else if (DoanhSoTheoThang >= DoanhSoToiThieu)
                return "B";
            else if (DoanhSoTheoThang >= DoanhSoToiThieu /2)
                return "C";
            else
                return "D";
        }
        public double HoaHong()
        {
            if (DoanhSoTheoThang > DoanhSoToiThieu)
            {
                return (DoanhSoTheoThang - DoanhSoToiThieu) * 0.15;
            }
            else 
                return 0.0;
        }
        public override double Luong()
        {
            return (HeSoLuong * LuongCoBan) + HoaHong();
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap doanh so toi thieu");
            DoanhSoToiThieu = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap doanh so theo thang");
            DoanhSoTheoThang = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("============================================");
            base.Xuat();
            Console.WriteLine("Doanh so toi thieu la: {0}", DoanhSoToiThieu);
            Console.WriteLine("Doanh so theo thang la: {0}", DoanhSoTheoThang);
            Console.WriteLine("============================================");

        }
    }
}
