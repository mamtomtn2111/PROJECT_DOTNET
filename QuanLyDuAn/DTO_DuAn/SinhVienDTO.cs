using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DuAn
{
    public class SinhVienDTO
    {
        private string MSV;
        private string MaDuAn;
        private string TenSV;
        private string Lop;
        private string SDT;
        private string DiaChi;

        public SinhVienDTO(string mSV, string maDuAn, string tenSV, string lop, string sDT, string diaChi)
        {
            MSV = mSV;
            MaDuAn = maDuAn;
            TenSV = tenSV;
            Lop = lop;
            SDT = sDT;
            DiaChi = diaChi;
        }

        public string MSV1 { get => MSV; set => MSV = value; }
        public string MaDuAn1 { get => MaDuAn; set => MaDuAn = value; }
        public string TenSV1 { get => TenSV; set => TenSV = value; }
        public string Lop1 { get => Lop; set => Lop = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
    }
}
