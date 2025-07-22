namespace GUI_QLPK
{
    partial class DSLaySoKham
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timkiem = new Guna.UI2.WinForms.Guna2Button();
            this.gird = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.nhapngay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_hoantac = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gird)).BeginInit();
            this.SuspendLayout();
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
            this.timkiem.Location = new System.Drawing.Point(450, 122);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(123, 45);
            this.timkiem.TabIndex = 12;
            this.timkiem.Text = "Tìm";
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // gird
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.gird.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.gird.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gird.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gird.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gird.ColumnHeadersHeight = 30;
            this.gird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gird.DefaultCellStyle = dataGridViewCellStyle15;
            this.gird.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gird.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gird.Location = new System.Drawing.Point(0, 202);
            this.gird.Name = "gird";
            this.gird.RowHeadersVisible = false;
            this.gird.RowHeadersWidth = 45;
            this.gird.RowTemplate.Height = 28;
            this.gird.Size = new System.Drawing.Size(1076, 682);
            this.gird.TabIndex = 10;
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
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.73585F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(373, 29);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(394, 39);
            this.guna2HtmlLabel1.TabIndex = 9;
            this.guna2HtmlLabel1.Text = "DANH SÁCH LỊCH KHÁM";
            // 
            // nhapngay
            // 
            this.nhapngay.BorderRadius = 5;
            this.nhapngay.Checked = true;
            this.nhapngay.CustomFormat = "";
            this.nhapngay.FillColor = System.Drawing.SystemColors.Control;
            this.nhapngay.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nhapngay.Location = new System.Drawing.Point(52, 122);
            this.nhapngay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.nhapngay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.nhapngay.Name = "nhapngay";
            this.nhapngay.Size = new System.Drawing.Size(331, 45);
            this.nhapngay.TabIndex = 13;
            this.nhapngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nhapngay.Value = new System.DateTime(2025, 7, 20, 9, 59, 55, 392);
            // 
            // btn_hoantac
            // 
            this.btn_hoantac.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_hoantac.BorderRadius = 15;
            this.btn_hoantac.BorderThickness = 1;
            this.btn_hoantac.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_hoantac.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_hoantac.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_hoantac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_hoantac.FillColor = System.Drawing.Color.Transparent;
            this.btn_hoantac.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoantac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_hoantac.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_hoantac.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_hoantac.Location = new System.Drawing.Point(588, 122);
            this.btn_hoantac.Name = "btn_hoantac";
            this.btn_hoantac.Size = new System.Drawing.Size(123, 45);
            this.btn_hoantac.TabIndex = 14;
            this.btn_hoantac.Text = "Hoàn tác";
            this.btn_hoantac.Click += new System.EventHandler(this.btn_hoantac_Click);
            // 
            // DSLaySoKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1076, 884);
            this.Controls.Add(this.btn_hoantac);
            this.Controls.Add(this.nhapngay);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.gird);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DSLaySoKham";
            this.Text = "DSLaySoKham";
            ((System.ComponentModel.ISupportInitialize)(this.gird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button timkiem;
        private Guna.UI2.WinForms.Guna2DataGridView gird;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DateTimePicker nhapngay;
        private Guna.UI2.WinForms.Guna2Button btn_hoantac;
    }
}