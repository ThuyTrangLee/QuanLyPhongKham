namespace GUI_QLPK
{
    partial class QuanLyThuoc
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
            this.Them = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dongia = new Guna.UI2.WinForms.Guna2TextBox();
            this.mathuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.key = new Guna.UI2.WinForms.Guna2TextBox();
            this.TimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.Sua = new Guna.UI2.WinForms.Guna2Button();
            this.Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.HoanTac = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.donvitinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tenthuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cachdung = new Guna.UI2.WinForms.Guna2ComboBox();
            this.QLThuoc = new Guna.UI2.WinForms.Guna2Panel();
            this.gird = new Guna.UI2.WinForms.Guna2DataGridView();
            this.QLThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gird)).BeginInit();
            this.SuspendLayout();
            // 
            // Them
            // 
            this.Them.BackColor = System.Drawing.Color.White;
            this.Them.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.Them.BorderThickness = 1;
            this.Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Them.FillColor = System.Drawing.Color.Transparent;
            this.Them.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.Them.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.Them.HoverState.ForeColor = System.Drawing.Color.White;
            this.Them.Location = new System.Drawing.Point(83, 347);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(123, 36);
            this.Them.TabIndex = 2;
            this.Them.Text = "Thêm";
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã thuốc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(610, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đơn giá:";
            // 
            // dongia
            // 
            this.dongia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dongia.DefaultText = "";
            this.dongia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dongia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dongia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dongia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dongia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dongia.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongia.ForeColor = System.Drawing.Color.Black;
            this.dongia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dongia.Location = new System.Drawing.Point(729, 140);
            this.dongia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dongia.Name = "dongia";
            this.dongia.PlaceholderText = "";
            this.dongia.SelectedText = "";
            this.dongia.Size = new System.Drawing.Size(247, 40);
            this.dongia.TabIndex = 9;
            // 
            // mathuoc
            // 
            this.mathuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mathuoc.DefaultText = "";
            this.mathuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mathuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mathuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mathuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mathuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mathuoc.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathuoc.ForeColor = System.Drawing.Color.Black;
            this.mathuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mathuoc.Location = new System.Drawing.Point(198, 140);
            this.mathuoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mathuoc.Name = "mathuoc";
            this.mathuoc.PlaceholderText = "";
            this.mathuoc.SelectedText = "";
            this.mathuoc.Size = new System.Drawing.Size(247, 40);
            this.mathuoc.TabIndex = 18;
            // 
            // key
            // 
            this.key.BorderRadius = 20;
            this.key.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.key.DefaultText = "";
            this.key.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.key.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.key.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.key.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.key.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.key.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key.ForeColor = System.Drawing.Color.Black;
            this.key.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.key.IconLeft = global::GUI_QLPK.Properties.Resources.search;
            this.key.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.key.Location = new System.Drawing.Point(141, 23);
            this.key.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.key.Name = "key";
            this.key.PlaceholderText = "Tìm từ khóa";
            this.key.SelectedText = "";
            this.key.Size = new System.Drawing.Size(460, 48);
            this.key.TabIndex = 20;
            this.key.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // TimKiem
            // 
            this.TimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.TimKiem.BorderRadius = 15;
            this.TimKiem.BorderThickness = 1;
            this.TimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TimKiem.FillColor = System.Drawing.Color.Transparent;
            this.TimKiem.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.TimKiem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.TimKiem.HoverState.ForeColor = System.Drawing.Color.White;
            this.TimKiem.Location = new System.Drawing.Point(634, 26);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(123, 45);
            this.TimKiem.TabIndex = 21;
            this.TimKiem.Text = "Tìm";
            this.TimKiem.Click += new System.EventHandler(this.TimKiem_Click);
            // 
            // Sua
            // 
            this.Sua.BackColor = System.Drawing.Color.White;
            this.Sua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.Sua.BorderThickness = 1;
            this.Sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Sua.FillColor = System.Drawing.Color.Transparent;
            this.Sua.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.Sua.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.Sua.HoverState.ForeColor = System.Drawing.Color.White;
            this.Sua.Location = new System.Drawing.Point(331, 347);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(123, 36);
            this.Sua.TabIndex = 22;
            this.Sua.Text = "Cập nhật";
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.Color.White;
            this.Xoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.Xoa.BorderThickness = 1;
            this.Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Xoa.FillColor = System.Drawing.Color.Transparent;
            this.Xoa.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.Xoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.Xoa.HoverState.ForeColor = System.Drawing.Color.White;
            this.Xoa.Location = new System.Drawing.Point(585, 347);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(123, 36);
            this.Xoa.TabIndex = 23;
            this.Xoa.Text = "Xóa";
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // HoanTac
            // 
            this.HoanTac.BackColor = System.Drawing.Color.White;
            this.HoanTac.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.HoanTac.BorderThickness = 1;
            this.HoanTac.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HoanTac.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HoanTac.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HoanTac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HoanTac.FillColor = System.Drawing.Color.Transparent;
            this.HoanTac.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoanTac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.HoanTac.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.HoanTac.HoverState.ForeColor = System.Drawing.Color.White;
            this.HoanTac.Location = new System.Drawing.Point(853, 347);
            this.HoanTac.Name = "HoanTac";
            this.HoanTac.Size = new System.Drawing.Size(123, 36);
            this.HoanTac.TabIndex = 24;
            this.HoanTac.Text = "Hoàn tác";
            this.HoanTac.Click += new System.EventHandler(this.HoanTac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Đơn vị tính:";
            // 
            // donvitinh
            // 
            this.donvitinh.BackColor = System.Drawing.Color.Transparent;
            this.donvitinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.donvitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.donvitinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.donvitinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.donvitinh.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donvitinh.ForeColor = System.Drawing.Color.Black;
            this.donvitinh.ItemHeight = 30;
            this.donvitinh.Location = new System.Drawing.Point(198, 267);
            this.donvitinh.Name = "donvitinh";
            this.donvitinh.Size = new System.Drawing.Size(247, 36);
            this.donvitinh.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tên thuốc:";
            // 
            // tenthuoc
            // 
            this.tenthuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tenthuoc.DefaultText = "";
            this.tenthuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tenthuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tenthuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tenthuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tenthuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tenthuoc.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenthuoc.ForeColor = System.Drawing.Color.Black;
            this.tenthuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tenthuoc.Location = new System.Drawing.Point(198, 202);
            this.tenthuoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tenthuoc.Name = "tenthuoc";
            this.tenthuoc.PlaceholderText = "";
            this.tenthuoc.SelectedText = "";
            this.tenthuoc.Size = new System.Drawing.Size(247, 40);
            this.tenthuoc.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(610, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Cách dùng:";
            // 
            // cachdung
            // 
            this.cachdung.BackColor = System.Drawing.Color.Transparent;
            this.cachdung.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cachdung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cachdung.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cachdung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cachdung.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cachdung.ForeColor = System.Drawing.Color.Black;
            this.cachdung.ItemHeight = 30;
            this.cachdung.Location = new System.Drawing.Point(729, 202);
            this.cachdung.Name = "cachdung";
            this.cachdung.Size = new System.Drawing.Size(247, 36);
            this.cachdung.TabIndex = 36;
            // 
            // QLThuoc
            // 
            this.QLThuoc.BackColor = System.Drawing.Color.LightCyan;
            this.QLThuoc.Controls.Add(this.cachdung);
            this.QLThuoc.Controls.Add(this.label5);
            this.QLThuoc.Controls.Add(this.tenthuoc);
            this.QLThuoc.Controls.Add(this.label2);
            this.QLThuoc.Controls.Add(this.donvitinh);
            this.QLThuoc.Controls.Add(this.label1);
            this.QLThuoc.Controls.Add(this.HoanTac);
            this.QLThuoc.Controls.Add(this.Xoa);
            this.QLThuoc.Controls.Add(this.Sua);
            this.QLThuoc.Controls.Add(this.TimKiem);
            this.QLThuoc.Controls.Add(this.key);
            this.QLThuoc.Controls.Add(this.mathuoc);
            this.QLThuoc.Controls.Add(this.dongia);
            this.QLThuoc.Controls.Add(this.label4);
            this.QLThuoc.Controls.Add(this.label3);
            this.QLThuoc.Controls.Add(this.Them);
            this.QLThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.QLThuoc.Location = new System.Drawing.Point(0, 0);
            this.QLThuoc.Name = "QLThuoc";
            this.QLThuoc.Size = new System.Drawing.Size(1092, 410);
            this.QLThuoc.TabIndex = 25;
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
            this.gird.Location = new System.Drawing.Point(0, 410);
            this.gird.Name = "gird";
            this.gird.RowHeadersVisible = false;
            this.gird.RowHeadersWidth = 45;
            this.gird.RowTemplate.Height = 28;
            this.gird.Size = new System.Drawing.Size(1092, 515);
            this.gird.TabIndex = 26;
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
            this.gird.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // QuanLyThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 925);
            this.Controls.Add(this.gird);
            this.Controls.Add(this.QLThuoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyThuoc";
            this.Text = "QuanLyThuoc";
            this.QLThuoc.ResumeLayout(false);
            this.QLThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gird)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox dongia;
        private Guna.UI2.WinForms.Guna2TextBox mathuoc;
        private Guna.UI2.WinForms.Guna2TextBox key;
        private Guna.UI2.WinForms.Guna2Button TimKiem;
        private Guna.UI2.WinForms.Guna2Button Sua;
        private Guna.UI2.WinForms.Guna2Button Xoa;
        private Guna.UI2.WinForms.Guna2Button HoanTac;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox donvitinh;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tenthuoc;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cachdung;
        private Guna.UI2.WinForms.Guna2Panel QLThuoc;
        private Guna.UI2.WinForms.Guna2DataGridView gird;
    }
}