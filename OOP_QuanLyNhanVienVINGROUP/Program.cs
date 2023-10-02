using OOP_QuanLyNhanVienVINGROUP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIN
{
    class program
    {
        static void Main(string[] args)
        {
            NhanVienSanXuat nv1 = new NhanVienSanXuat();
            nv1.Nhap();
            nv1.Xuat();
            NhanVienKinhDoanh nv2 = new NhanVienKinhDoanh();
            nv2.Nhap();
            nv2.Xuat();
            NhanVienQuanLy nv3 = new NhanVienQuanLy();
            nv3.Nhap();
            nv3.Xuat();
        }
    }
}