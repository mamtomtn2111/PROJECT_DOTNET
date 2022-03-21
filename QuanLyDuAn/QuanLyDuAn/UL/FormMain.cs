using QuanLyDuAn.UL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDuAn
{
    public partial class FormQuanLyDuAn : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormQuanLyDuAn()
        {
            InitializeComponent();
        }

        public void OpenForm<T>()
        {
            var f = MdiChildren.FirstOrDefault(i => i is T);
            if (f == null)
            {
                f = Activator.CreateInstance<T>() as Form;
                f.MdiParent = this;
                f.Show();
            }
            else f.Activate();
        }

        private void FormQuanLyDuAn_Load(object sender, EventArgs e)
        {
            
        }

        private void BarBtnQLDuAn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<FormDuAnDienRa>();
        }

        private void BarBtnAboutUs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Nhóm số 2\n- Nguyễn Vũ Hải\n- Nguyễn Ngọc Đoàn\n- Vũ Quang Huy\nPhần mềm quản lý dự án sinh viên", "About us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BarBtnDanhSachDuAn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<FormDanhSachDuAn>();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<FormDanhSachSinhVien>();
        }
    }
}
