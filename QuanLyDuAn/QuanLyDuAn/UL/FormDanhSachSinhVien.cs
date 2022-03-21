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
using BUS_DuAn;
using DTO_DuAn;

namespace QuanLyDuAn.UL
{
    public partial class FormDanhSachSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public FormDanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void FormDanhSachSinhVien_Load(object sender, EventArgs e)
        {
            GCDSSinhVien.DataSource = B_SinhVien.GetAllSinhVien();
        }

        private void BtnThemSinhVien_Click(object sender, EventArgs e)
        {
            string MSV = TxtMaSinhVien.Text;
            string MaDuAn = TxtMaDuAn.Text;
            string TenSV = TxtTenSinhVien.Text;
            string Lop = TxtLop.Text;
            string SDT = TxtSDT.Text;
            string DiaChi = TxtDiaChi.Text;
            SinhVienDTO SinhVien = new SinhVienDTO(MSV, MaDuAn, TenSV, Lop, SDT, DiaChi);
            if(MSV == "" || MaDuAn == "" || TenSV == "" || Lop == "" || SDT == "" || DiaChi == "")
            {
                MessageBox.Show("Không được để trống các mục cần nhập !");
            }
            else
            {
                try
                {
                    B_SinhVien.ThemSinhVien(SinhVien);
                    MessageBox.Show("Thêm thành công sinh viên !");
                }
                catch
                {
                    MessageBox.Show("Không thể tham sinh viên !");
                }
                GCDSSinhVien.DataSource = B_SinhVien.GetAllSinhVien();
            }
        }

        private void BtnLoadLaiDuAn_Click(object sender, EventArgs e)
        {
            GCDSSinhVien.DataSource = B_SinhVien.GetAllSinhVien();
        }

        private void BtnSuaSinhVien_Click(object sender, EventArgs e)
        {
            string MSV = TxtMaSinhVien.Text;
            string MaDuAn = TxtMaDuAn.Text;
            string TenSV = TxtTenSinhVien.Text;
            string Lop = TxtLop.Text;
            string SDT = TxtSDT.Text;
            string DiaChi = TxtDiaChi.Text;
            SinhVienDTO SinhVien = new SinhVienDTO(MSV, MaDuAn, TenSV, Lop, SDT, DiaChi);
            if (MSV == "" || MaDuAn == "" || TenSV == "" || Lop == "" || SDT == "" || DiaChi == "")
            {
                MessageBox.Show("Không được để trống các mục cần nhập !");
            }
            else
            {
                try
                {
                    B_SinhVien.SuaSinhVien(SinhVien);
                    MessageBox.Show("Sửa thành công sinh viên !");
                }
                catch
                {
                    MessageBox.Show("Không thể sửa sinh viên !");
                }
                GCDSSinhVien.DataSource = B_SinhVien.GetAllSinhVien();
            }
        }

        private void GrdViewDSSinhVien_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int row_index = GrdViewDSSinhVien.FocusedRowHandle;
            TxtMaSinhVien.Text = GrdViewDSSinhVien.GetRowCellValue(row_index, "MSV").ToString();
            TxtMaDuAn.Text = GrdViewDSSinhVien.GetRowCellValue(row_index, "MaDuAn").ToString();
            TxtTenSinhVien.Text = GrdViewDSSinhVien.GetRowCellValue(row_index, "TenSV").ToString();
            TxtLop.Text = GrdViewDSSinhVien.GetRowCellValue(row_index, "Lop").ToString();
            TxtSDT.Text = GrdViewDSSinhVien.GetRowCellValue(row_index, "SDT").ToString();
            TxtDiaChi.Text = GrdViewDSSinhVien.GetRowCellValue(row_index, "DiaChi").ToString();
        }

        private void BtnXoaSinhVien_Click(object sender, EventArgs e)
        {
            string MaSV = TxtMaSinhVien.Text;
            try
            {
                B_SinhVien.XoaSinhVien(MaSV);
                MessageBox.Show("Bạn đã xóa thành công sinh viên!");
            }
            catch
            {
                MessageBox.Show("Lỗi khi xóa sinh viên này !");
            }
            GCDSSinhVien.DataSource = B_SinhVien.GetAllSinhVien();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDanhSachSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát form quản lý dự án không?", "Thoát", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}