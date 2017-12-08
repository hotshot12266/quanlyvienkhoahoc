using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVienKhoaHoc.Enum;

namespace QuanLyVienKhoaHoc.Enties
{
    class NhanVien
    {
        public string HoTen { get; set; }

        public DateTime NamSinh { get; set; }

        public BangCap BangCap { get; set; }
    }
}
