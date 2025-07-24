namespace GUI_QLPK
{
    partial class BaoCaoSuDungThuoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoSuDungThuoc));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nam = new System.Windows.Forms.ComboBox();
            this.thang = new System.Windows.Forms.ComboBox();
            this.xem = new Guna.UI2.WinForms.Guna2Button();
            this.gird = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_Xuatpdf = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gird)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.73585F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(378, 43);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(354, 39);
            this.guna2HtmlLabel1.TabIndex = 38;
            this.guna2HtmlLabel1.Text = "Báo cáo sử dụng thuốc";
            // 
            // nam
            // 
            this.nam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nam.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam.FormattingEnabled = true;
            this.nam.Items.AddRange(new object[] {
            "2025",
            "2026",
            "2027",
            "2028"});
            this.nam.Location = new System.Drawing.Point(428, 133);
            this.nam.Margin = new System.Windows.Forms.Padding(2);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(135, 31);
            this.nam.TabIndex = 37;
            this.nam.Text = "Năm";
            // 
            // thang
            // 
            this.thang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thang.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thang.FormattingEnabled = true;
            this.thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.thang.Location = new System.Drawing.Point(251, 133);
            this.thang.Margin = new System.Windows.Forms.Padding(2);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(135, 31);
            this.thang.TabIndex = 36;
            this.thang.Text = "Tháng";
            // 
            // xem
            // 
            this.xem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.xem.BorderRadius = 10;
            this.xem.BorderThickness = 1;
            this.xem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.xem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.xem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.xem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.xem.FillColor = System.Drawing.Color.Transparent;
            this.xem.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.xem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.xem.HoverState.ForeColor = System.Drawing.Color.White;
            this.xem.Location = new System.Drawing.Point(617, 133);
            this.xem.Name = "xem";
            this.xem.Size = new System.Drawing.Size(123, 33);
            this.xem.TabIndex = 35;
            this.xem.Text = "Xem";
            this.xem.Click += new System.EventHandler(this.xem_Click);
            // 
            // gird
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gird.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gird.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gird.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gird.ColumnHeadersHeight = 30;
            this.gird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gird.DefaultCellStyle = dataGridViewCellStyle3;
            this.gird.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gird.Location = new System.Drawing.Point(1, 240);
            this.gird.Name = "gird";
            this.gird.RowHeadersVisible = false;
            this.gird.RowHeadersWidth = 45;
            this.gird.RowTemplate.Height = 28;
            this.gird.Size = new System.Drawing.Size(1090, 548);
            this.gird.TabIndex = 39;
            this.gird.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gird.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gird.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gird.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gird.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gird.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gird.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gird.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gird.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gird.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gird.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gird.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gird.ThemeStyle.HeaderStyle.Height = 30;
            this.gird.ThemeStyle.ReadOnly = false;
            this.gird.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gird.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gird.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gird.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gird.ThemeStyle.RowsStyle.Height = 28;
            this.gird.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gird.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_Xuatpdf
            // 
            this.btn_Xuatpdf.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_Xuatpdf.BorderRadius = 10;
            this.btn_Xuatpdf.BorderThickness = 1;
            this.btn_Xuatpdf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xuatpdf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xuatpdf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xuatpdf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xuatpdf.FillColor = System.Drawing.Color.Transparent;
            this.btn_Xuatpdf.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuatpdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_Xuatpdf.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_Xuatpdf.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Xuatpdf.Location = new System.Drawing.Point(790, 133);
            this.btn_Xuatpdf.Name = "btn_Xuatpdf";
            this.btn_Xuatpdf.Size = new System.Drawing.Size(123, 33);
            this.btn_Xuatpdf.TabIndex = 40;
            this.btn_Xuatpdf.Text = "Xuất file";
            this.btn_Xuatpdf.Click += new System.EventHandler(this.btn_Xuatpdf_Click);
            // 
            // BaoCaoSuDungThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1092, 925);
            this.Controls.Add(this.btn_Xuatpdf);
            this.Controls.Add(this.gird);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.thang);
            this.Controls.Add(this.xem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaoCaoSuDungThuoc";
            this.Text = "BaoCaoSuDungThuoc";
            ((System.ComponentModel.ISupportInitialize)(this.gird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.ComboBox nam;
        private System.Windows.Forms.ComboBox thang;
        private Guna.UI2.WinForms.Guna2Button xem;
        private Guna.UI2.WinForms.Guna2DataGridView gird;
        private Guna.UI2.WinForms.Guna2Button btn_Xuatpdf;
    }
}