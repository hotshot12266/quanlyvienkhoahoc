using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVienKhoaHoc.Enties;

namespace QuanLyVienKhoaHoc
{
    class QuanLyVienKhoaHoc
    {
        //dinh nghia danh sach luu nhan vien (nhakhoahoc,nhaquanly,nhanvienphongthinghiem)
        List<NhanVien> nhanViens = new List<NhanVien>();
        //nhapdanhsach
        public void NhapDanhSach()
        {
            int soLuongNhanVien;
            int loaiNhanVien;
            NhanVien NhanVien;
            //nhapsoluong
            Console.Write("Nhap so luong nhan vien: ");
            soLuongNhanVien = int.Parse(Console.ReadLine());
            //nhapnhanvien
            for (int i = 0; i < soLuongNhanVien; i++)
            {
                Console.WriteLine("\tThong tin nhan vien thu :{0}", i + 1);
                Console.WriteLine("\t\tChon loai nhan vien: ");
                Console.WriteLine("\t\t\t1.Nha quan ly  ");
                Console.WriteLine("\t\t\t2.khoa hoc  ");
                Console.WriteLine("\t\t\t3.nhan vien phong thi nghiem   ");
                Console.Write("\t\tChon :");
                //lay gia tri chon lua 
                loaiNhanVien = int.Parse(Console.ReadLine());
                //xac dinh laoi nhan vien 
                switch (loaiNhanVien)
                {
                    default;
                }
            }
        }
    }
}
