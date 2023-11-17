using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyNhanVienVINGROUP
{
    internal abstract class NhanVien
    {
        protected string maSo;
        public string MaSo
        {
            get { return maSo; }
            set
            {
                if (value.Length == 6 && value.StartsWith("VG") && value.Substring(2).All(char.IsDigit))
                {
                    maSo = value;
                }
                else
                {
                    maSo = "";
                    Console.WriteLine("Da gan ma so bang rong.");
                }
            }
        }
        protected string HoTen;
        protected string NgaySinh;
        protected string GioiTinh;
        protected int ThamNien;
        protected double LuongCoBan = 1300000.0;
        protected double heSoLuong;
        public double HeSoLuong
        {
            get { return heSoLuong; }
            set
            {
                if (value == 2.34 || value == 2.67 || value == 3.0 || value == 3.33 || value == 3.66 || value == 3.99 || value == 4.32 || value == 4.65)
                {
                    heSoLuong = value;
                }
                else
                {
                    heSoLuong = 0;
                    Console.WriteLine("Da gan he so luong bang 0.");
                }
            }
        }
        public NhanVien()
        {
            MaSo = "";
            HoTen = "";
            NgaySinh = "";
            GioiTinh = "";
            ThamNien = 0;
            heSoLuong = 0.0;
        }
        public NhanVien(string MaSo, string HoTen, string NgaySinh, string GioiTinh, int ThamNien, double heSoLuong)
        {
            this.MaSo = MaSo;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.ThamNien = ThamNien;
            this.heSoLuong = heSoLuong;
        }
        public double PhuCapThamNien()
        {
            if (ThamNien / 12 <= 3)
                return 1000000;
            else if (ThamNien / 12 <= 6)
                return 2000000;
            else if (ThamNien / 12 <= 10)
                return 4000000;
            else
                return 5000000 + (ThamNien / 12 - 10) * 1000000;
        }
        public abstract string XepLoai();
        public abstract double Luong();
        public double ThuNhap()
        {
            if (XepLoai() == "A")
                return Luong() + PhuCapThamNien();
            else if (XepLoai() == "B")
                return Luong() * 0.75 + PhuCapThamNien();
            else if (XepLoai() == "C")
                return Luong() * 0.50 + PhuCapThamNien();
            else
                return Luong() * 0.0 + PhuCapThamNien();
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ma so: ");
            MaSo = Console.ReadLine();
            Console.WriteLine("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            NgaySinh = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh: ");
            GioiTinh = Console.ReadLine();
            Console.WriteLine("Nhap tham nien: ");
            ThamNien = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap he so luong\t 2.34\t2.67\t 3.0\t 3.33\t 3.66\t 3.99\t 4.32\t 4.65: ");
            HeSoLuong = double.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ma so la: {0}", maSo);
            Console.WriteLine("Ho ten la: {0}", HoTen);
            Console.WriteLine("Ngay sinh la: {0}", NgaySinh);
            Console.WriteLine("Gioi tinh la: {0}", GioiTinh);
            Console.WriteLine("Tham nien la: {0}", ThamNien);
            Console.WriteLine("He so luong la: {0}", HeSoLuong);
            Console.WriteLine("Luong co ban la: {0}", LuongCoBan);
            Console.WriteLine("Phu cap tham nien la: {0}", PhuCapThamNien());
            Console.WriteLine("Xep loai la: {0}", XepLoai());
            Console.WriteLine("Luong la: {0:f}", Luong());
            Console.WriteLine("Thu nhap la: {0:f}", ThuNhap());
        }
    }
}
