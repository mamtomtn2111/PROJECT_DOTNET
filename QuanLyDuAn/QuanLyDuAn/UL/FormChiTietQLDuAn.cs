using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_DuAn;
using System.Data.SqlClient;

namespace QuanLyDuAn.UL
{
    public partial class FormChiTietQLDuAn : Form
    {
        public FormChiTietQLDuAn()
        {
            InitializeComponent();
        }
        public string MaDuAn = "";
        private void FormChiTietQLDuAn_Load(object sender, EventArgs e)
        {
            GCSinhVienQuanLyDuAn.DataSource = B_QuanLyDuAn.GetAllSinhVienQLDuAn(MaDuAn);
            TxtMaDuAn.Text = MaDuAn;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L3O70G8\SQLVUHAI;Initial Catalog=BaiTapLon;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select DuAn.TenDuAn, DuAn.CoVan, Duan.SDTCoVan, QuanLyDuAn.TGBD, QuanLyDuAn.TGKT, DuAn.ThongTinCoVan, DuAn.NoiDungDuAn from QuanLyDuAn, DuAn where DuAn.MaDuAn = QuanLyDuAn.MaDuAn and QuanLyDuAn.MaDuAn = '" + MaDuAn+"'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                TxtTenDuAn.Text = da.GetValue(0).ToString();
                TxtCoVan.Text = da.GetValue(1).ToString();
                TxtSDTCoVan.Text = da.GetValue(2).ToString();
                DTPTgbd.Text = da.GetValue(3).ToString();
                DTPTgkt.Text = da.GetValue(4).ToString();
                TxtThongTinCoVan.Text = da.GetValue(5).ToString();
                TxtNoiDungDuAn.Text = da.GetValue(6).ToString();
            }
            con.Close();
        }
    }
}
