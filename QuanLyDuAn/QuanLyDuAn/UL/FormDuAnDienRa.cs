using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS_DuAn;
using DTO_DuAn;

namespace QuanLyDuAn.UL
{
    public partial class FormDuAnDienRa : DevExpress.XtraEditors.XtraForm
    {
        public FormDuAnDienRa()
        {
            InitializeComponent();
        }

        private void BtnThemQLDuAn_Click(object sender, EventArgs e)
        {
            string maDuAn = CBMaDuAn.Text;
            string CheckMaDuAn = CBMaDuAn.Text;
            string CheckTenDuAn = TxtTenDuAn.Text;
            string TGBD = DTPTgbd.Text;
            string TGKT = DTPTgkt.Text;
            string MoTa = TxtMoTa.Text;
            QuanLyDuAnDTO QlDa = new QuanLyDuAnDTO(maDuAn, TGBD, TGKT, MoTa);
            if(maDuAn == "" || MoTa == "" || CheckMaDuAn == "" || CheckTenDuAn == "")
            {
                MessageBox.Show("Không được để trống các mục cần nhập !");
            }
            else
            {
                try
                {
                    B_QuanLyDuAn.ThemQuanLyDuAn(QlDa);
                    MessageBox.Show("Bạn đã thêm thành công một quản lý dự án mới !");
                }
                catch
                {
                    MessageBox.Show("Lỗi khi thêm quản lý dự án mới");
                }
            }
            GCQuanLyDuAn.DataSource = B_QuanLyDuAn.GetAllQLDuAn();
        }

        private void FormDuAnDienRa_Load(object sender, EventArgs e)
        {
            GCQuanLyDuAn.DataSource = B_QuanLyDuAn.GetAllQLDuAn();
            try
            {
                SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-L3O70G8\SQLVUHAI;Initial Catalog=BaiTapLon;Integrated Security=True");
                Conn.Open();
                string cmdline = "select MaDuAn, TenDuAn from DuAn";
                SqlCommand cmd = new SqlCommand(cmdline, Conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                CBMaDuAn.DataSource = dt;
                CBMaDuAn.DisplayMember = "MaDuAn";
                CBMaDuAn.ValueMember = "TenDuAn";
            }
            catch
            {
                MessageBox.Show("Lỗi xảy ra !");
            }
        }

        private void BtnLoadLaiDuLieu_Click(object sender, EventArgs e)
        {
            GCQuanLyDuAn.DataSource = B_QuanLyDuAn.GetAllQLDuAn();
        }

        private void BtnSuaQLDuAn_Click(object sender, EventArgs e)
        {
            string maDuAn = CBMaDuAn.Text;
            string CheckTenDuAn = TxtTenDuAn.Text;
            string TGBD = DTPTgbd.Text;
            string TGKT = DTPTgkt.Text;
            string MoTa = TxtMoTa.Text;
            QuanLyDuAnDTO QlDa = new QuanLyDuAnDTO(maDuAn, TGBD, TGKT, MoTa);
            if (maDuAn == "" || MoTa == "" || CheckTenDuAn == "")
            {
                MessageBox.Show("Không được phép để trống các mục cần nhập !");
            }
            else
            {
                try
                {
                    B_QuanLyDuAn.SuaQuanLyDuAn(QlDa);
                    MessageBox.Show("Bạn đã sửa thành công một quản lý dự án mới !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa quản lý dự án mới\n" + ex);
                }
            }
            GCQuanLyDuAn.DataSource = B_QuanLyDuAn.GetAllQLDuAn();
        }

        private void BtnXoaQLDuAn_Click(object sender, EventArgs e)
        {
            string maDuAn = CBMaDuAn.Text;
            try
            {
                B_QuanLyDuAn.XoaQuanLyDuAn(maDuAn);
                MessageBox.Show("Bạn đã xóa thành công một quản lý dự án mới !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa quản lý dự án mới\n" + ex);
            }

            GCQuanLyDuAn.DataSource = B_QuanLyDuAn.GetAllQLDuAn();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDuAnDienRa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát form quản lý dự án không?", "Thoát", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void BtnChiTietQLDuAn_Click(object sender, EventArgs e)
        {
            FormChiTietQLDuAn _FormChiTietQLDuAn = new FormChiTietQLDuAn();
            _FormChiTietQLDuAn.MaDuAn = CBMaDuAn.Text;
            _FormChiTietQLDuAn.WindowState = FormWindowState.Normal;
            _FormChiTietQLDuAn.ShowDialog();
        }

        private void GrdViewQuanLyDuAn_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int row_index = GrdViewQuanLyDuAn.FocusedRowHandle;
            CBMaDuAn.Text = GrdViewQuanLyDuAn.GetRowCellValue(row_index, "MaDuAn").ToString();
            DTPTgbd.Text = GrdViewQuanLyDuAn.GetRowCellValue(row_index, "TGBD").ToString();
            DTPTgkt.Text = GrdViewQuanLyDuAn.GetRowCellValue(row_index, "TGKT").ToString();
            TxtMoTa.Text = GrdViewQuanLyDuAn.GetRowCellValue(row_index, "MoTa").ToString();
        }

        private void CBMaDuAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtTenDuAn.Text = CBMaDuAn.SelectedValue.ToString();
        }
    }
}