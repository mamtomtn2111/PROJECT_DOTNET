
namespace QuanLyDuAn.UL
{
    partial class FormDanhSachSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDanhSachSinhVien));
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnXoaSinhVien = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSuaSinhVien = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLoadLaiDuAn = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThemSinhVien = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.GCDSSinhVien = new DevExpress.XtraGrid.GridControl();
            this.GrdViewDSSinhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TxtDiaChi = new System.Windows.Forms.RichTextBox();
            this.TxtSDT = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtMaDuAn = new System.Windows.Forms.TextBox();
            this.TxtLop = new System.Windows.Forms.TextBox();
            this.TxtTenSinhVien = new System.Windows.Forms.TextBox();
            this.TxtMaSinhVien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GCDSSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewDSSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(647, 430);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 44;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // BtnXoaSinhVien
            // 
            this.BtnXoaSinhVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnXoaSinhVien.ImageOptions.SvgImage")));
            this.BtnXoaSinhVien.Location = new System.Drawing.Point(306, 415);
            this.BtnXoaSinhVien.Name = "BtnXoaSinhVien";
            this.BtnXoaSinhVien.Size = new System.Drawing.Size(117, 38);
            this.BtnXoaSinhVien.TabIndex = 43;
            this.BtnXoaSinhVien.Text = "Xóa sinh viên";
            this.BtnXoaSinhVien.Click += new System.EventHandler(this.BtnXoaSinhVien_Click);
            // 
            // BtnSuaSinhVien
            // 
            this.BtnSuaSinhVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSuaSinhVien.ImageOptions.SvgImage")));
            this.BtnSuaSinhVien.Location = new System.Drawing.Point(158, 415);
            this.BtnSuaSinhVien.Name = "BtnSuaSinhVien";
            this.BtnSuaSinhVien.Size = new System.Drawing.Size(117, 38);
            this.BtnSuaSinhVien.TabIndex = 42;
            this.BtnSuaSinhVien.Text = "Sửa sinh viên";
            this.BtnSuaSinhVien.Click += new System.EventHandler(this.BtnSuaSinhVien_Click);
            // 
            // BtnLoadLaiDuAn
            // 
            this.BtnLoadLaiDuAn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnLoadLaiDuAn.ImageOptions.SvgImage")));
            this.BtnLoadLaiDuAn.Location = new System.Drawing.Point(593, 195);
            this.BtnLoadLaiDuAn.Name = "BtnLoadLaiDuAn";
            this.BtnLoadLaiDuAn.Size = new System.Drawing.Size(129, 38);
            this.BtnLoadLaiDuAn.TabIndex = 41;
            this.BtnLoadLaiDuAn.Text = "Load lại sinh viên";
            this.BtnLoadLaiDuAn.Click += new System.EventHandler(this.BtnLoadLaiDuAn_Click);
            // 
            // BtnThemSinhVien
            // 
            this.BtnThemSinhVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnThemSinhVien.ImageOptions.SvgImage")));
            this.BtnThemSinhVien.Location = new System.Drawing.Point(12, 415);
            this.BtnThemSinhVien.Name = "BtnThemSinhVien";
            this.BtnThemSinhVien.Size = new System.Drawing.Size(117, 38);
            this.BtnThemSinhVien.TabIndex = 40;
            this.BtnThemSinhVien.Text = "Thêm sinh viên";
            this.BtnThemSinhVien.Click += new System.EventHandler(this.BtnThemSinhVien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(285, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Danh sách sinh viên";
            // 
            // GCDSSinhVien
            // 
            this.GCDSSinhVien.Location = new System.Drawing.Point(12, 239);
            this.GCDSSinhVien.MainView = this.GrdViewDSSinhVien;
            this.GCDSSinhVien.Name = "GCDSSinhVien";
            this.GCDSSinhVien.Size = new System.Drawing.Size(710, 170);
            this.GCDSSinhVien.TabIndex = 38;
            this.GCDSSinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrdViewDSSinhVien});
            // 
            // GrdViewDSSinhVien
            // 
            this.GrdViewDSSinhVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn4});
            this.GrdViewDSSinhVien.GridControl = this.GCDSSinhVien;
            this.GrdViewDSSinhVien.Name = "GrdViewDSSinhVien";
            this.GrdViewDSSinhVien.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GrdViewDSSinhVien_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã sinh viên";
            this.gridColumn1.FieldName = "MSV";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 141;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên sinh viên";
            this.gridColumn2.FieldName = "TenSV";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 157;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Lớp";
            this.gridColumn3.FieldName = "Lop";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 140;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "SĐT";
            this.gridColumn6.FieldName = "SDT";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 154;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Địa chỉ";
            this.gridColumn5.FieldName = "DiaChi";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mã dự án";
            this.gridColumn4.FieldName = "MaDuAn";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 93;
            // 
            // TxtDiaChi
            // 
            this.TxtDiaChi.Location = new System.Drawing.Point(522, 48);
            this.TxtDiaChi.Name = "TxtDiaChi";
            this.TxtDiaChi.Size = new System.Drawing.Size(200, 140);
            this.TxtDiaChi.TabIndex = 36;
            this.TxtDiaChi.Text = "";
            // 
            // TxtSDT
            // 
            this.TxtSDT.Location = new System.Drawing.Point(289, 111);
            this.TxtSDT.Name = "TxtSDT";
            this.TxtSDT.Size = new System.Drawing.Size(180, 21);
            this.TxtSDT.TabIndex = 37;
            this.TxtSDT.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "SĐT";
            // 
            // TxtMaDuAn
            // 
            this.TxtMaDuAn.Location = new System.Drawing.Point(57, 167);
            this.TxtMaDuAn.Name = "TxtMaDuAn";
            this.TxtMaDuAn.Size = new System.Drawing.Size(177, 21);
            this.TxtMaDuAn.TabIndex = 30;
            // 
            // TxtLop
            // 
            this.TxtLop.Location = new System.Drawing.Point(289, 48);
            this.TxtLop.Name = "TxtLop";
            this.TxtLop.Size = new System.Drawing.Size(180, 21);
            this.TxtLop.TabIndex = 31;
            // 
            // TxtTenSinhVien
            // 
            this.TxtTenSinhVien.Location = new System.Drawing.Point(57, 111);
            this.TxtTenSinhVien.Name = "TxtTenSinhVien";
            this.TxtTenSinhVien.Size = new System.Drawing.Size(177, 21);
            this.TxtTenSinhVien.TabIndex = 32;
            // 
            // TxtMaSinhVien
            // 
            this.TxtMaSinhVien.Location = new System.Drawing.Point(57, 48);
            this.TxtMaSinhVien.Name = "TxtMaSinhVien";
            this.TxtMaSinhVien.Size = new System.Drawing.Size(177, 21);
            this.TxtMaSinhVien.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Mã Dự án";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Lớp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(103, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Tên sinh viên";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(107, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Mã sinh viên";
            // 
            // FormDanhSachSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 474);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnXoaSinhVien);
            this.Controls.Add(this.BtnSuaSinhVien);
            this.Controls.Add(this.BtnLoadLaiDuAn);
            this.Controls.Add(this.BtnThemSinhVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GCDSSinhVien);
            this.Controls.Add(this.TxtDiaChi);
            this.Controls.Add(this.TxtSDT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtMaDuAn);
            this.Controls.Add(this.TxtLop);
            this.Controls.Add(this.TxtTenSinhVien);
            this.Controls.Add(this.TxtMaSinhVien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Name = "FormDanhSachSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDanhSachSinhVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDanhSachSinhVien_FormClosing);
            this.Load += new System.EventHandler(this.FormDanhSachSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GCDSSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewDSSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnThoat;
        private DevExpress.XtraEditors.SimpleButton BtnXoaSinhVien;
        private DevExpress.XtraEditors.SimpleButton BtnSuaSinhVien;
        private DevExpress.XtraEditors.SimpleButton BtnLoadLaiDuAn;
        private DevExpress.XtraEditors.SimpleButton BtnThemSinhVien;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl GCDSSinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView GrdViewDSSinhVien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.RichTextBox TxtDiaChi;
        private System.Windows.Forms.RichTextBox TxtSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtMaDuAn;
        private System.Windows.Forms.TextBox TxtLop;
        private System.Windows.Forms.TextBox TxtTenSinhVien;
        private System.Windows.Forms.TextBox TxtMaSinhVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}