namespace GUI_QLPK
{
    partial class QuanLyNhacHen
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
            this.gird = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.donvitinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.timkiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gird)).BeginInit();
            this.SuspendLayout();
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
            this.gird.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gird.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gird.Location = new System.Drawing.Point(0, 195);
            this.gird.Name = "gird";
            this.gird.RowHeadersVisible = false;
            this.gird.RowHeadersWidth = 45;
            this.gird.RowTemplate.Height = 28;
            this.gird.Size = new System.Drawing.Size(1092, 730);
            this.gird.TabIndex = 27;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 28;
            // 
            // donvitinh
            // 
            this.donvitinh.BackColor = System.Drawing.Color.Transparent;
            this.donvitinh.BorderRadius = 5;
            this.donvitinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.donvitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.donvitinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.donvitinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.donvitinh.Font = new System.Drawing.Font("Times New Roman", 12.22642F);
            this.donvitinh.ForeColor = System.Drawing.Color.Black;
            this.donvitinh.ItemHeight = 30;
            this.donvitinh.Items.AddRange(new object[] {
            "Tất cả",
            "Chưa gửi",
            "Đã gửi"});
            this.donvitinh.Location = new System.Drawing.Point(102, 106);
            this.donvitinh.Name = "donvitinh";
            this.donvitinh.Size = new System.Drawing.Size(247, 36);
            this.donvitinh.TabIndex = 33;
            // 
            // timkiem
            // 
            this.timkiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.timkiem.BorderRadius = 15;
            this.timkiem.BorderThickness = 1;
            this.timkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.timkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.timkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.timkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.timkiem.FillColor = System.Drawing.Color.Transparent;
            this.timkiem.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.timkiem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.timkiem.HoverState.ForeColor = System.Drawing.Color.White;
            this.timkiem.Location = new System.Drawing.Point(407, 106);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(123, 36);
            this.timkiem.TabIndex = 34;
            this.timkiem.Text = "Lọc";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.73585F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(351, 25);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(389, 39);
            this.guna2HtmlLabel1.TabIndex = 35;
            this.guna2HtmlLabel1.Text = "DANH SÁCH NHẮC HẸN";
            // 
            // QuanLyNhacHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1092, 925);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.donvitinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyNhacHen";
            this.Text = "QuanLyNhacHen";
            ((System.ComponentModel.ISupportInitialize)(this.gird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gird;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox donvitinh;
        private Guna.UI2.WinForms.Guna2Button timkiem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}