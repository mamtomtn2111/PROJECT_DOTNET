using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DuAn
{
    public class DuAnDTO
    {
        private string MaDuAn;
        private string TenDuAn;
        private string CoVan;
        private string ThongTinCoVan;
        private string SDTCoVan;
        private string NoiDungDuAn;

        public DuAnDTO(string maDuAn, string tenDuAn, string coVan, string thongTinCoVan, string sDTCoVan, string noiDungDuAn)
        {
            MaDuAn = maDuAn;
            TenDuAn = tenDuAn;
            CoVan = coVan;
            ThongTinCoVan = thongTinCoVan;
            SDTCoVan = sDTCoVan;
            NoiDungDuAn = noiDungDuAn;
        }

        public string MaDuAn1 { get => MaDuAn; set => MaDuAn = value; }
        public string TenDuAn1 { get => TenDuAn; set => TenDuAn = value; }
        public string CoVan1 { get => CoVan; set => CoVan = value; }
        public string ThongTinCoVan1 { get => ThongTinCoVan; set => ThongTinCoVan = value; }
        public string SDTCoVan1 { get => SDTCoVan; set => SDTCoVan = value; }
        public string NoiDungDuAn1 { get => NoiDungDuAn; set => NoiDungDuAn = value; }
    }
}
