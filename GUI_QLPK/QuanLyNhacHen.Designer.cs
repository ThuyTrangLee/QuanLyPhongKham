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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gird = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.trangthaigui = new Guna.UI2.WinForms.Guna2ComboBox();
            this.timkiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gird)).BeginInit();
            this.SuspendLayout();
            // 
            // gird
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gird.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gird.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gird.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gird.ColumnHeadersHeight = 30;
            this.gird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gird.DefaultCellStyle = dataGridViewCellStyle6;
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
            // trangthaigui
            // 
            this.trangthaigui.BackColor = System.Drawing.Color.Transparent;
            this.trangthaigui.BorderRadius = 5;
            this.trangthaigui.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.trangthaigui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trangthaigui.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.trangthaigui.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.trangthaigui.Font = new System.Drawing.Font("Times New Roman", 12.22642F);
            this.trangthaigui.ForeColor = System.Drawing.Color.Black;
            this.trangthaigui.ItemHeight = 30;
            this.trangthaigui.Items.AddRange(new object[] {
            "Tất cả",
            "Chưa gửi",
            "Đã gửi"});
            this.trangthaigui.Location = new System.Drawing.Point(102, 106);
            this.trangthaigui.Name = "trangthaigui";
            this.trangthaigui.Size = new System.Drawing.Size(247, 36);
            this.trangthaigui.TabIndex = 33;
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
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
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
            this.Controls.Add(this.trangthaigui);
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
        private Guna.UI2.WinForms.Guna2ComboBox trangthaigui;
        private Guna.UI2.WinForms.Guna2Button timkiem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}