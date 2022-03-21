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
using DTO_DuAn;
using BUS_DuAn;

namespace QuanLyDuAn.UL
{
    public partial class FormDanhSachDuAn : DevExpress.XtraEditors.XtraForm
    {
        public FormDanhSachDuAn()
        {
            InitializeComponent();
        }

        private void BtnThemDuAn_Click(object sender, EventArgs e)
        {
            string MaDuAn = TxtMaDuAn.Text;
            string TenDuAn = TxtTenDuAn.Text;
            string CoVan = TxtCoVan.Text;
            string ThongTinCoVan = TxtThongTinCoVan.Text;
            string SDTCoVan = TxtSDTCoVan.Text;
            string NoiDungDuAn = TxtNoiDungDuAn.Text;
            DuAnDTO DuAn = new DuAnDTO(MaDuAn, TenDuAn, CoVan, ThongTinCoVan, SDTCoVan, NoiDungDuAn);
            if(MaDuAn == "" || TenDuAn == "" || CoVan == "" || ThongTinCoVan == "" || SDTCoVan == "" || SDTCoVan == "" || NoiDungDuAn == "")
            {
                MessageBox.Show("Không được để trống các mục cần nhập !");
            }
            else
            {
                try
                {
                    B_DuAn.ThemDuAn(DuAn);
                    MessageBox.Show("Bạn đã thêm thành công một dự án mới !");
                }
                catch
                {
                    MessageBox.Show("Lỗi khi thêm dự án mới");
                }
            }
            GCDSDuAn.DataSource = B_DuAn.GetAllDuAn();
        }

        private void FormDanhSachDuAn_Load(object sender, EventArgs e)
        {
            GCDSDuAn.DataSource = B_DuAn.GetAllDuAn();
        }

        private void BtnLoadLaiDuAn_Click(object sender, EventArgs e)
        {
            GCDSDuAn.DataSource = B_DuAn.GetAllDuAn();
        }

        private void GrdViewDSDuAn_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int row_index = GrdViewDSDuAn.FocusedRowHandle;
            TxtMaDuAn.Text = GrdViewDSDuAn.GetRowCellValue(row_index, "MaDuAn").ToString();
            TxtTenDuAn.Text = GrdViewDSDuAn.GetRowCellValue(row_index, "TenDuAn").ToString();
            TxtCoVan.Text = GrdViewDSDuAn.GetRowCellValue(row_index, "CoVan").ToString();
            TxtThongTinCoVan.Text = GrdViewDSDuAn.GetRowCellValue(row_index, "ThongTinCoVan").ToString();
            TxtSDTCoVan.Text = GrdViewDSDuAn.GetRowCellValue(row_index, "SDTCoVan").ToString();
            TxtNoiDungDuAn.Text = GrdViewDSDuAn.GetRowCellValue(row_index, "NoiDungDuAn").ToString();
        }

        private void BtnSuaDuAn_Click(object sender, EventArgs e)
        {
            string MaDuAn = TxtMaDuAn.Text;
            string TenDuAn = TxtTenDuAn.Text;
            string CoVan = TxtCoVan.Text;
            string ThongTinCoVan = TxtThongTinCoVan.Text;
            string SDTCoVan = TxtSDTCoVan.Text;
            string NoiDungDuAn = TxtNoiDungDuAn.Text;
            DuAnDTO DuAn = new DuAnDTO(MaDuAn, TenDuAn, CoVan, ThongTinCoVan, SDTCoVan, NoiDungDuAn);
            if(MaDuAn == "" || TenDuAn == "" || CoVan == "" || ThongTinCoVan == "" || SDTCoVan == "" || SDTCoVan == "" || NoiDungDuAn == "")
            {
                MessageBox.Show("Không được để trống các mục cần nhập !");
            }
            else
            {
                try
                {
                    B_DuAn.SuaDuAn(DuAn);
                    MessageBox.Show("Bạn đã sửa thành công một dự án mới !");
                }
                catch
                {
                    MessageBox.Show("Lỗi khi sửa dự án !");
                }

            } 
            GCDSDuAn.DataSource = B_DuAn.GetAllDuAn();
        }

        private void BtnXoaDuAn_Click(object sender, EventArgs e)
        {
            string MaDuAn = TxtMaDuAn.Text;
            try
            {
                B_DuAn.XoaDuAn(MaDuAn);
                MessageBox.Show("Bạn đã xóa thành công một dự án !");
            }
            catch
            {
                MessageBox.Show("Không thể xóa dự án đang diễn ra !");
            }
            GCDSDuAn.DataSource = B_DuAn.GetAllDuAn();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDanhSachDuAn_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát form dự án không?", "Thoát", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}