using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DuAn
{
    public class QuanLyDuAnDTO
    {
        private string MaDuAn;
        private string TGBD;
        private string TGKT;
        private string MoTa;

        public QuanLyDuAnDTO(string maDuAn, string tGBD, string tGKT, string moTa)
        {
            MaDuAn = maDuAn;
            TGBD = tGBD;
            TGKT = tGKT;
            MoTa = moTa;
        }

        public string MaDuAn1 { get => MaDuAn; set => MaDuAn = value; }
        public string TGBD1 { get => TGBD; set => TGBD = value; }
        public string TGKT1 { get => TGKT; set => TGKT = value; }
        public string MoTa1 { get => MoTa; set => MoTa = value; }
    }
}
