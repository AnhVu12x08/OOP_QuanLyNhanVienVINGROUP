using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyNhanVienVINGROUP
{
    internal class NhanVienSanXuat : NhanVien
    {
        private int SoNgayNghi;

        public NhanVienSanXuat() : base()
        {
            SoNgayNghi = 0;
        }
        public NhanVienSanXuat(string MaSo, string HoTen, string NgaySinh, string GioiTinh, int ThamNien, double heSoLuong, int SoNgayNghi) : base(MaSo, HoTen, NgaySinh, GioiTinh, ThamNien, heSoLuong)
        {
            this.SoNgayNghi = SoNgayNghi;
        }
        public override string XepLoai()
        {
            if(SoNgayNghi <= 1)
                return "A";
            else if(SoNgayNghi <= 3)
                return "B";
            else if (SoNgayNghi <= 5)
                return "C";
            else
                return "D";
        }
        public override double Luong()
        {
            return HeSoLuong * LuongCoBan * (1 + 0.1);
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap so ngay nghi");
            SoNgayNghi = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("============================================");
            base.Xuat();
            Console.WriteLine("So ngay nghi la: {0}", SoNgayNghi);
            Console.WriteLine("============================================");

        }
    }
}
