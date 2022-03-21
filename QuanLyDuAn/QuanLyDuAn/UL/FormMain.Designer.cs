
namespace QuanLyDuAn
{
    partial class FormQuanLyDuAn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyDuAn));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BarBtnDanhSachDuAn = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnQLDuAn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnAboutUs = new DevExpress.XtraBars.BarButtonItem();
            this.Tab1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Rb1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BarBtnDanhSachDuAn,
            this.BarBtnQLDuAn,
            this.barButtonItem3,
            this.BarBtnAboutUs});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Tab1});
            this.ribbonControl1.Size = new System.Drawing.Size(748, 158);
            // 
            // BarBtnDanhSachDuAn
            // 
            this.BarBtnDanhSachDuAn.Caption = "Danh sách dự án";
            this.BarBtnDanhSachDuAn.Id = 3;
            this.BarBtnDanhSachDuAn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BarBtnDanhSachDuAn.ImageOptions.SvgImage")));
            this.BarBtnDanhSachDuAn.Name = "BarBtnDanhSachDuAn";
            this.BarBtnDanhSachDuAn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnDanhSachDuAn_ItemClick);
            // 
            // BarBtnQLDuAn
            // 
            this.BarBtnQLDuAn.Caption = "Dự án đang diễn ra";
            this.BarBtnQLDuAn.Id = 4;
            this.BarBtnQLDuAn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BarBtnQLDuAn.ImageOptions.SvgImage")));
            this.BarBtnQLDuAn.Name = "BarBtnQLDuAn";
            this.BarBtnQLDuAn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnQLDuAn_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Danh sách sinh viên";
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // BarBtnAboutUs
            // 
            this.BarBtnAboutUs.Caption = "Về chúng tôi";
            this.BarBtnAboutUs.Id = 6;
            this.BarBtnAboutUs.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BarBtnAboutUs.ImageOptions.SvgImage")));
            this.BarBtnAboutUs.Name = "BarBtnAboutUs";
            this.BarBtnAboutUs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnAboutUs_ItemClick);
            // 
            // Tab1
            // 
            this.Tab1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Rb1,
            this.ribbonPageGroup1});
            this.Tab1.Name = "Tab1";
            this.Tab1.Text = "Quản lý dự án";
            // 
            // Rb1
            // 
            this.Rb1.ItemLinks.Add(this.BarBtnQLDuAn);
            this.Rb1.ItemLinks.Add(this.BarBtnDanhSachDuAn);
            this.Rb1.ItemLinks.Add(this.barButtonItem3);
            this.Rb1.Name = "Rb1";
            this.Rb1.Text = "Dự án sinh viên";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup1.ImageOptions.SvgImage")));
            this.ribbonPageGroup1.ItemLinks.Add(this.BarBtnAboutUs);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // FormQuanLyDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 649);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FormQuanLyDuAn.IconOptions.SvgImage")));
            this.IsMdiContainer = true;
            this.Name = "FormQuanLyDuAn";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý dự án";
            this.Load += new System.EventHandler(this.FormQuanLyDuAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage Tab1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Rb1;
        private DevExpress.XtraBars.BarButtonItem BarBtnDanhSachDuAn;
        private DevExpress.XtraBars.BarButtonItem BarBtnQLDuAn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem BarBtnAboutUs;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}

