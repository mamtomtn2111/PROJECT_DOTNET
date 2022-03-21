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
    public class B_DuAn
    {
        public static DataTable GetAllDuAn()
        {
            return D_DuAn.GetDataDuAn();
        }

        public static void ThemDuAn(DuAnDTO DuAn)
        {
            D_DuAn.ThemDuAn(DuAn);
        }

        public static void SuaDuAn(DuAnDTO DuAn)
        {
            D_DuAn.SuaDuAn(DuAn);
        }

        public static void XoaDuAn(string MaDuAn)
        {
            D_DuAn.XoaDuAn(MaDuAn);
        }
    }
}
