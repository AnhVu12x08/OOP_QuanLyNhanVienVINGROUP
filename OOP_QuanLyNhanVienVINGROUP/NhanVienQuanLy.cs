using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyNhanVienVINGROUP
{
    internal class NhanVienQuanLy : NhanVien
    {
        private string ChucVu;
        private double HeSoChucVu;
        public NhanVienQuanLy() : base()
        {
            ChucVu = "";
            HeSoChucVu = 0.0;
        }
        public NhanVienQuanLy(string MaSo, string HoTen, DateTime NgaySinh, string GioiTinh, int ThamNien, double heSoLuong, string ChucVu, double HeSoChucVu) : base(MaSo, HoTen, NgaySinh, GioiTinh, ThamNien, heSoLuong)
        {
            this.ChucVu = ChucVu;
            this.HeSoChucVu = HeSoChucVu;
        }
        public override string XepLoai()
        {
            return "A";
        }
        public double PhuCapChucVu()
        {
            return HeSoChucVu * 2000000;
        }   
        public override double Luong()
        {
            return (HeSoLuong * LuongCoBan) + PhuCapChucVu();
        }
        public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap chuc vu");
            ChucVu = Console.ReadLine();
            Console.WriteLine("Nhap he so chuc vu");
            HeSoChucVu = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("============================================");
            base.Xuat();
            Console.WriteLine("Chuc vu la: {0}", ChucVu);
            Console.WriteLine("He so chuc vu la: {0}", HeSoChucVu);
        }
    }
}
