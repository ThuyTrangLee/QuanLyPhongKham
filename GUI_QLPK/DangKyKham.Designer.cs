namespace GUI_QLPK
{
    partial class DangKyKham
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
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.mabenhnhan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.giokham = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.hoten = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ngaykham = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.bacsi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.malichhen = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dangky = new Guna.UI2.WinForms.Guna2Button();
            this.gird = new Guna.UI2.WinForms.Guna2DataGridView();
            this.QLBenhNhan = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gird)).BeginInit();
            this.QLBenhNhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(22, 359);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(332, 32);
            this.guna2HtmlLabel2.TabIndex = 46;
            this.guna2HtmlLabel2.Text = "Danh sách lấy số khám bệnh";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.73585F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(395, 29);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(365, 39);
            this.guna2HtmlLabel1.TabIndex = 44;
            this.guna2HtmlLabel1.Text = "ĐĂNG KÝ KHÁM BỆNH";
            // 
            // mabenhnhan
            // 
            this.mabenhnhan.BackColor = System.Drawing.Color.Transparent;
            this.mabenhnhan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mabenhnhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mabenhnhan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mabenhnhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mabenhnhan.Font = new System.Drawing.Font("Times New Roman", 12.22642F);
            this.mabenhnhan.ForeColor = System.Drawing.Color.Black;
            this.mabenhnhan.ItemHeight = 30;
            this.mabenhnhan.Location = new System.Drawing.Point(206, 175);
            this.mabenhnhan.Name = "mabenhnhan";
            this.mabenhnhan.Size = new System.Drawing.Size(247, 36);
            this.mabenhnhan.TabIndex = 43;
            this.mabenhnhan.SelectedIndexChanged += new System.EventHandler(this.mabenhnhan_SelectedIndexChanged);
            // 
            // giokham
            // 
            this.giokham.BackColor = System.Drawing.Color.White;
            this.giokham.Checked = true;
            this.giokham.FillColor = System.Drawing.Color.White;
            this.giokham.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giokham.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.giokham.Location = new System.Drawing.Point(737, 171);
            this.giokham.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.giokham.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.giokham.Name = "giokham";
            this.giokham.ShowUpDown = true;
            this.giokham.Size = new System.Drawing.Size(247, 40);
            this.giokham.TabIndex = 42;
            this.giokham.Value = new System.DateTime(2025, 7, 18, 8, 17, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(618, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 41;
            this.label6.Text = "Giờ khám:";
            // 
            // hoten
            // 
            this.hoten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hoten.DefaultText = "";
            this.hoten.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hoten.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hoten.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hoten.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hoten.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hoten.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten.ForeColor = System.Drawing.Color.Black;
            this.hoten.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hoten.Location = new System.Drawing.Point(206, 239);
            this.hoten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hoten.Name = "hoten";
            this.hoten.PlaceholderText = "";
            this.hoten.SelectedText = "";
            this.hoten.Size = new System.Drawing.Size(247, 40);
            this.hoten.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Họ tên:";
            // 
            // ngaykham
            // 
            this.ngaykham.BackColor = System.Drawing.Color.White;
            this.ngaykham.Checked = true;
            this.ngaykham.FillColor = System.Drawing.Color.White;
            this.ngaykham.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaykham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaykham.Location = new System.Drawing.Point(737, 109);
            this.ngaykham.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ngaykham.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ngaykham.Name = "ngaykham";
            this.ngaykham.Size = new System.Drawing.Size(247, 40);
            this.ngaykham.TabIndex = 38;
            this.ngaykham.Value = new System.DateTime(2025, 7, 14, 8, 17, 50, 518);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.White;
            this.btn_xoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_xoa.BorderThickness = 1;
            this.btn_xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoa.FillColor = System.Drawing.Color.Transparent;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_xoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_xoa.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(593, 318);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(123, 36);
            this.btn_xoa.TabIndex = 37;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // bacsi
            // 
            this.bacsi.BackColor = System.Drawing.Color.Transparent;
            this.bacsi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bacsi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bacsi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bacsi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bacsi.Font = new System.Drawing.Font("Times New Roman", 12.22642F);
            this.bacsi.ForeColor = System.Drawing.Color.Black;
            this.bacsi.ItemHeight = 30;
            this.bacsi.Location = new System.Drawing.Point(737, 239);
            this.bacsi.Name = "bacsi";
            this.bacsi.Size = new System.Drawing.Size(247, 36);
            this.bacsi.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(618, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Bác sĩ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã bệnh nhân:";
            // 
            // malichhen
            // 
            this.malichhen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.malichhen.DefaultText = "";
            this.malichhen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.malichhen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.malichhen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.malichhen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.malichhen.Enabled = false;
            this.malichhen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.malichhen.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malichhen.ForeColor = System.Drawing.Color.Black;
            this.malichhen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.malichhen.Location = new System.Drawing.Point(206, 109);
            this.malichhen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.malichhen.Name = "malichhen";
            this.malichhen.PlaceholderText = "";
            this.malichhen.SelectedText = "";
            this.malichhen.Size = new System.Drawing.Size(247, 40);
            this.malichhen.TabIndex = 18;
            this.malichhen.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(618, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày khám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã khám bệnh:";
            // 
            // btn_dangky
            // 
            this.btn_dangky.BackColor = System.Drawing.Color.White;
            this.btn_dangky.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_dangky.BorderThickness = 1;
            this.btn_dangky.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dangky.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dangky.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dangky.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dangky.FillColor = System.Drawing.Color.Transparent;
            this.btn_dangky.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangky.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_dangky.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_dangky.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_dangky.Location = new System.Drawing.Point(395, 318);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Size = new System.Drawing.Size(123, 36);
            this.btn_dangky.TabIndex = 2;
            this.btn_dangky.Text = "Đăng Ký";
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
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
            this.gird.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gird.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gird.Location = new System.Drawing.Point(0, 391);
            this.gird.Name = "gird";
            this.gird.RowHeadersVisible = false;
            this.gird.RowHeadersWidth = 45;
            this.gird.RowTemplate.Height = 28;
            this.gird.Size = new System.Drawing.Size(1076, 493);
            this.gird.TabIndex = 34;
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
            this.gird.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gird_CellClick);
            // 
            // QLBenhNhan
            // 
            this.QLBenhNhan.BackColor = System.Drawing.Color.LightCyan;
            this.QLBenhNhan.Controls.Add(this.guna2HtmlLabel2);
            this.QLBenhNhan.Controls.Add(this.guna2HtmlLabel1);
            this.QLBenhNhan.Controls.Add(this.mabenhnhan);
            this.QLBenhNhan.Controls.Add(this.giokham);
            this.QLBenhNhan.Controls.Add(this.label6);
            this.QLBenhNhan.Controls.Add(this.hoten);
            this.QLBenhNhan.Controls.Add(this.label1);
            this.QLBenhNhan.Controls.Add(this.ngaykham);
            this.QLBenhNhan.Controls.Add(this.btn_xoa);
            this.QLBenhNhan.Controls.Add(this.bacsi);
            this.QLBenhNhan.Controls.Add(this.label5);
            this.QLBenhNhan.Controls.Add(this.label2);
            this.QLBenhNhan.Controls.Add(this.malichhen);
            this.QLBenhNhan.Controls.Add(this.label4);
            this.QLBenhNhan.Controls.Add(this.label3);
            this.QLBenhNhan.Controls.Add(this.btn_dangky);
            this.QLBenhNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.QLBenhNhan.Location = new System.Drawing.Point(0, 0);
            this.QLBenhNhan.Name = "QLBenhNhan";
            this.QLBenhNhan.Size = new System.Drawing.Size(1076, 391);
            this.QLBenhNhan.TabIndex = 33;
            // 
            // DangKyKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 884);
            this.Controls.Add(this.gird);
            this.Controls.Add(this.QLBenhNhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangKyKham";
            this.Text = "DangKyKham";
            ((System.ComponentModel.ISupportInitialize)(this.gird)).EndInit();
            this.QLBenhNhan.ResumeLayout(false);
            this.QLBenhNhan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox mabenhnhan;
        private Guna.UI2.WinForms.Guna2DateTimePicker giokham;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox hoten;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker ngaykham;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private Guna.UI2.WinForms.Guna2ComboBox bacsi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox malichhen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_dangky;
        private Guna.UI2.WinForms.Guna2DataGridView gird;
        private Guna.UI2.WinForms.Guna2Panel QLBenhNhan;
    }
}