
namespace QuanLyDuAn.UL
{
    partial class FormDuAnDienRa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDuAnDienRa));
            this.BtnThemQLDuAn = new DevExpress.XtraEditors.SimpleButton();
            this.BtnChiTietQLDuAn = new DevExpress.XtraEditors.SimpleButton();
            this.BtnXoaQLDuAn = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLoadLaiDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTenDuAn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPTgbd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPTgkt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMoTa = new System.Windows.Forms.RichTextBox();
            this.BtnSuaQLDuAn = new DevExpress.XtraEditors.SimpleButton();
            this.GCQuanLyDuAn = new DevExpress.XtraGrid.GridControl();
            this.GrdViewQuanLyDuAn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdMaDuAn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_TGBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CBMaDuAn = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GCQuanLyDuAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewQuanLyDuAn)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnThemQLDuAn
            // 
            this.BtnThemQLDuAn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnThemQLDuAn.ImageOptions.SvgImage")));
            this.BtnThemQLDuAn.Location = new System.Drawing.Point(210, 418);
            this.BtnThemQLDuAn.Name = "BtnThemQLDuAn";
            this.BtnThemQLDuAn.Size = new System.Drawing.Size(100, 35);
            this.BtnThemQLDuAn.TabIndex = 1;
            this.BtnThemQLDuAn.Text = "Thêm dự án";
            this.BtnThemQLDuAn.Click += new System.EventHandler(this.BtnThemQLDuAn_Click);
            // 
            // BtnChiTietQLDuAn
            // 
            this.BtnChiTietQLDuAn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnChiTietQLDuAn.ImageOptions.SvgImage")));
            this.BtnChiTietQLDuAn.Location = new System.Drawing.Point(475, 418);
            this.BtnChiTietQLDuAn.Name = "BtnChiTietQLDuAn";
            this.BtnChiTietQLDuAn.Size = new System.Drawing.Size(108, 35);
            this.BtnChiTietQLDuAn.TabIndex = 1;
            this.BtnChiTietQLDuAn.Text = "Chi tiết dự án";
            this.BtnChiTietQLDuAn.Click += new System.EventHandler(this.BtnChiTietQLDuAn_Click);
            // 
            // BtnXoaQLDuAn
            // 
            this.BtnXoaQLDuAn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnXoaQLDuAn.ImageOptions.SvgImage")));
            this.BtnXoaQLDuAn.Location = new System.Drawing.Point(607, 418);
            this.BtnXoaQLDuAn.Name = "BtnXoaQLDuAn";
            this.BtnXoaQLDuAn.Size = new System.Drawing.Size(106, 35);
            this.BtnXoaQLDuAn.TabIndex = 1;
            this.BtnXoaQLDuAn.Text = "Xóa dự án";
            this.BtnXoaQLDuAn.Click += new System.EventHandler(this.BtnXoaQLDuAn_Click);
            // 
            // BtnLoadLaiDuLieu
            // 
            this.BtnLoadLaiDuLieu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnLoadLaiDuLieu.ImageOptions.SvgImage")));
            this.BtnLoadLaiDuLieu.Location = new System.Drawing.Point(210, 3);
            this.BtnLoadLaiDuLieu.Name = "BtnLoadLaiDuLieu";
            this.BtnLoadLaiDuLieu.Size = new System.Drawing.Size(115, 41);
            this.BtnLoadLaiDuLieu.TabIndex = 2;
            this.BtnLoadLaiDuLieu.Text = "Load lại dữ liệu";
            this.BtnLoadLaiDuLieu.Click += new System.EventHandler(this.BtnLoadLaiDuLieu_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(638, 12);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 3;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã dự án";
            // 
            // TxtTenDuAn
            // 
            this.TxtTenDuAn.Location = new System.Drawing.Point(24, 127);
            this.TxtTenDuAn.Name = "TxtTenDuAn";
            this.TxtTenDuAn.Size = new System.Drawing.Size(166, 21);
            this.TxtTenDuAn.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thời gian bắt đầu";
            // 
            // DTPTgbd
            // 
            this.DTPTgbd.CustomFormat = "";
            this.DTPTgbd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPTgbd.Location = new System.Drawing.Point(24, 198);
            this.DTPTgbd.Name = "DTPTgbd";
            this.DTPTgbd.Size = new System.Drawing.Size(166, 21);
            this.DTPTgbd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thời gian kết thúc";
            // 
            // DTPTgkt
            // 
            this.DTPTgkt.CustomFormat = "";
            this.DTPTgkt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPTgkt.Location = new System.Drawing.Point(24, 290);
            this.DTPTgkt.Name = "DTPTgkt";
            this.DTPTgkt.Size = new System.Drawing.Size(166, 21);
            this.DTPTgkt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mô tả";
            // 
            // TxtMoTa
            // 
            this.TxtMoTa.Location = new System.Drawing.Point(24, 362);
            this.TxtMoTa.Name = "TxtMoTa";
            this.TxtMoTa.Size = new System.Drawing.Size(166, 80);
            this.TxtMoTa.TabIndex = 8;
            this.TxtMoTa.Text = "";
            // 
            // BtnSuaQLDuAn
            // 
            this.BtnSuaQLDuAn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSuaQLDuAn.ImageOptions.SvgImage")));
            this.BtnSuaQLDuAn.Location = new System.Drawing.Point(342, 418);
            this.BtnSuaQLDuAn.Name = "BtnSuaQLDuAn";
            this.BtnSuaQLDuAn.Size = new System.Drawing.Size(100, 35);
            this.BtnSuaQLDuAn.TabIndex = 1;
            this.BtnSuaQLDuAn.Text = "Sửa dự án";
            this.BtnSuaQLDuAn.Click += new System.EventHandler(this.BtnSuaQLDuAn_Click);
            // 
            // GCQuanLyDuAn
            // 
            this.GCQuanLyDuAn.Location = new System.Drawing.Point(210, 59);
            this.GCQuanLyDuAn.MainView = this.GrdViewQuanLyDuAn;
            this.GCQuanLyDuAn.Name = "GCQuanLyDuAn";
            this.GCQuanLyDuAn.Size = new System.Drawing.Size(503, 331);
            this.GCQuanLyDuAn.TabIndex = 9;
            this.GCQuanLyDuAn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrdViewQuanLyDuAn});
            // 
            // GrdViewQuanLyDuAn
            // 
            this.GrdViewQuanLyDuAn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GrdMaDuAn,
            this.grd_TGBD,
            this.gridColumn1,
            this.gridColumn2});
            this.GrdViewQuanLyDuAn.GridControl = this.GCQuanLyDuAn;
            this.GrdViewQuanLyDuAn.Name = "GrdViewQuanLyDuAn";
            this.GrdViewQuanLyDuAn.OptionsBehavior.AllowIncrementalSearch = true;
            this.GrdViewQuanLyDuAn.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GrdViewQuanLyDuAn_RowClick);
            // 
            // GrdMaDuAn
            // 
            this.GrdMaDuAn.Caption = "Mã dự án";
            this.GrdMaDuAn.FieldName = "MaDuAn";
            this.GrdMaDuAn.Name = "GrdMaDuAn";
            this.GrdMaDuAn.OptionsColumn.AllowEdit = false;
            this.GrdMaDuAn.Visible = true;
            this.GrdMaDuAn.VisibleIndex = 0;
            // 
            // grd_TGBD
            // 
            this.grd_TGBD.Caption = "Thời gian bắt đầu";
            this.grd_TGBD.FieldName = "TGBD";
            this.grd_TGBD.Name = "grd_TGBD";
            this.grd_TGBD.OptionsColumn.AllowEdit = false;
            this.grd_TGBD.Visible = true;
            this.grd_TGBD.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Thời gian kết thúc";
            this.gridColumn1.FieldName = "TGKT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mô tả";
            this.gridColumn2.FieldName = "MoTa";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // CBMaDuAn
            // 
            this.CBMaDuAn.FormattingEnabled = true;
            this.CBMaDuAn.Location = new System.Drawing.Point(24, 59);
            this.CBMaDuAn.Name = "CBMaDuAn";
            this.CBMaDuAn.Size = new System.Drawing.Size(166, 21);
            this.CBMaDuAn.TabIndex = 10;
            this.CBMaDuAn.SelectedIndexChanged += new System.EventHandler(this.CBMaDuAn_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên dự án";
            // 
            // FormDuAnDienRa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 488);
            this.Controls.Add(this.CBMaDuAn);
            this.Controls.Add(this.GCQuanLyDuAn);
            this.Controls.Add(this.TxtMoTa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTPTgkt);
            this.Controls.Add(this.DTPTgbd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTenDuAn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnLoadLaiDuLieu);
            this.Controls.Add(this.BtnXoaQLDuAn);
            this.Controls.Add(this.BtnChiTietQLDuAn);
            this.Controls.Add(this.BtnSuaQLDuAn);
            this.Controls.Add(this.BtnThemQLDuAn);
            this.Name = "FormDuAnDienRa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý dự án";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDuAnDienRa_FormClosing);
            this.Load += new System.EventHandler(this.FormDuAnDienRa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GCQuanLyDuAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewQuanLyDuAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton BtnThemQLDuAn;
        private DevExpress.XtraEditors.SimpleButton BtnChiTietQLDuAn;
        private DevExpress.XtraEditors.SimpleButton BtnXoaQLDuAn;
        private DevExpress.XtraEditors.SimpleButton BtnLoadLaiDuLieu;
        private DevExpress.XtraEditors.SimpleButton BtnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTenDuAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPTgbd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTPTgkt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox TxtMoTa;
        private DevExpress.XtraEditors.SimpleButton BtnSuaQLDuAn;
        private DevExpress.XtraGrid.GridControl GCQuanLyDuAn;
        private DevExpress.XtraGrid.Views.Grid.GridView GrdViewQuanLyDuAn;
        private DevExpress.XtraGrid.Columns.GridColumn GrdMaDuAn;
        private DevExpress.XtraGrid.Columns.GridColumn grd_TGBD;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.ComboBox CBMaDuAn;
        private System.Windows.Forms.Label label5;
    }
}