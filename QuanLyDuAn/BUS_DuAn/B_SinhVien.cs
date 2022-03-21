using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_DuAn;
using DTO_DuAn;

namespace BUS_DuAn
{
    public class B_SinhVien
    {
        public static DataTable GetAllSinhVien()
        {
            return D_SinhVien.GetDataSinhVien();
        }
        public static void ThemSinhVien(SinhVienDTO SinhVien)
        {
            D_SinhVien.ThemSinhVien(SinhVien);
        }
        public static void SuaSinhVien(SinhVienDTO SinhVien)
        {
            D_SinhVien.SuaSinhVien(SinhVien);
        }
        public static void XoaSinhVien(string MaSinhVien)
        {
            D_SinhVien.XoaSinhVien(MaSinhVien);
        }
    }
}
