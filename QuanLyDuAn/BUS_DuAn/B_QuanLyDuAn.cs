using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL_DuAn;
using DTO_DuAn;

namespace BUS_DuAn
{
    public class B_QuanLyDuAn
    {
        public static DataTable GetAllQLDuAn()
        {
            return D_QuanLyDuAn.GetDataQuanLyDuAn();
        }

        public static void ThemQuanLyDuAn(QuanLyDuAnDTO qlda)
        {
            D_QuanLyDuAn.ThemQuanLyDuAn(qlda);
        }
        public static void SuaQuanLyDuAn(QuanLyDuAnDTO qlda)
        {
            D_QuanLyDuAn.SuaQuanLyDuAn(qlda);
        }

        public static void XoaQuanLyDuAn(string MaDuAn)
        {
            D_QuanLyDuAn.XoaQuanLyDuAn(MaDuAn);
        }

        public static DataTable GetAllSinhVienQLDuAn(string MaDuAn)
        {
            return D_QuanLyDuAn.GetDataSinhVienQuanLyDuAn(MaDuAn);
        }
    }
}
