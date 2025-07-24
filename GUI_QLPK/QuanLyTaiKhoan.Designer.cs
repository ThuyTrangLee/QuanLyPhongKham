namespace GUI_QLPM
{
    partial class QuanLyTaiKhoan
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
            this.comboBoxRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HoanTac = new Guna.UI2.WinForms.Guna2Button();
            this.Sua = new Guna.UI2.WinForms.Guna2Button();
            this.TimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.hoten = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Them = new Guna.UI2.WinForms.Guna2Button();
            this.QLTaiKhoan = new Guna.UI2.WinForms.Guna2Panel();
            this.search = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gird)).BeginInit();
            this.QLTaiKhoan.SuspendLayout();
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
            this.gird.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gird.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gird.Location = new System.Drawing.Point(0, 391);
            this.gird.Name = "gird";
            this.gird.RowHeadersVisible = false;
            this.gird.RowHeadersWidth = 45;
            this.gird.RowTemplate.Height = 28;
            this.gird.Size = new System.Drawing.Size(1092, 534);
            this.gird.TabIndex = 28;
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
            this.gird.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gird_CellContentClick);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxRole.Font = new System.Drawing.Font("Times New Roman", 12.22642F);
            this.comboBoxRole.ForeColor = System.Drawing.Color.Black;
            this.comboBoxRole.ItemHeight = 30;
            this.comboBoxRole.Location = new System.Drawing.Point(729, 202);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(247, 36);
            this.comboBoxRole.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(610, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Role";
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.Location = new System.Drawing.Point(198, 202);
            this.password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password.Name = "password";
            this.password.PlaceholderText = "";
            this.password.SelectedText = "";
            this.password.Size = new System.Drawing.Size(247, 40);
            this.password.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Password:";
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
            this.HoanTac.Location = new System.Drawing.Point(729, 296);
            this.HoanTac.Name = "HoanTac";
            this.HoanTac.Size = new System.Drawing.Size(123, 36);
            this.HoanTac.TabIndex = 24;
            this.HoanTac.Text = "Hoàn tác";
            this.HoanTac.Click += new System.EventHandler(this.QuayLai_Click);
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
            this.Sua.Location = new System.Drawing.Point(493, 296);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(123, 36);
            this.Sua.TabIndex = 22;
            this.Sua.Text = "Cập nhật";
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
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
            // username
            // 
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.Location = new System.Drawing.Point(198, 140);
            this.username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.username.Name = "username";
            this.username.PlaceholderText = "";
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(247, 40);
            this.username.TabIndex = 18;
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
            this.hoten.Location = new System.Drawing.Point(729, 140);
            this.hoten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hoten.Name = "hoten";
            this.hoten.PlaceholderText = "";
            this.hoten.SelectedText = "";
            this.hoten.Size = new System.Drawing.Size(247, 40);
            this.hoten.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(610, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username:";
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
            this.Them.Location = new System.Drawing.Point(245, 296);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(123, 36);
            this.Them.TabIndex = 2;
            this.Them.Text = "Thêm";
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // QLTaiKhoan
            // 
            this.QLTaiKhoan.BackColor = System.Drawing.Color.LightCyan;
            this.QLTaiKhoan.Controls.Add(this.comboBoxRole);
            this.QLTaiKhoan.Controls.Add(this.label5);
            this.QLTaiKhoan.Controls.Add(this.password);
            this.QLTaiKhoan.Controls.Add(this.label2);
            this.QLTaiKhoan.Controls.Add(this.HoanTac);
            this.QLTaiKhoan.Controls.Add(this.Sua);
            this.QLTaiKhoan.Controls.Add(this.TimKiem);
            this.QLTaiKhoan.Controls.Add(this.search);
            this.QLTaiKhoan.Controls.Add(this.username);
            this.QLTaiKhoan.Controls.Add(this.hoten);
            this.QLTaiKhoan.Controls.Add(this.label4);
            this.QLTaiKhoan.Controls.Add(this.label3);
            this.QLTaiKhoan.Controls.Add(this.Them);
            this.QLTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.QLTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.QLTaiKhoan.Name = "QLTaiKhoan";
            this.QLTaiKhoan.Size = new System.Drawing.Size(1092, 391);
            this.QLTaiKhoan.TabIndex = 27;
            // 
            // search
            // 
            this.search.BorderRadius = 20;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.DefaultText = "";
            this.search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.IconLeft = global::GUI_QLPK.Properties.Resources.search;
            this.search.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.search.Location = new System.Drawing.Point(141, 23);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Name = "search";
            this.search.PlaceholderText = "Tìm từ khóa";
            this.search.SelectedText = "";
            this.search.Size = new System.Drawing.Size(460, 48);
            this.search.TabIndex = 20;
            this.search.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 925);
            this.Controls.Add(this.gird);
            this.Controls.Add(this.QLTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyTaiKhoan";
            this.Text = "QuanLyTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.gird)).EndInit();
            this.QLTaiKhoan.ResumeLayout(false);
            this.QLTaiKhoan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gird;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxRole;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button HoanTac;
        private Guna.UI2.WinForms.Guna2Button Sua;
        private Guna.UI2.WinForms.Guna2Button TimKiem;
        private Guna.UI2.WinForms.Guna2TextBox search;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private Guna.UI2.WinForms.Guna2TextBox hoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button Them;
        private Guna.UI2.WinForms.Guna2Panel QLTaiKhoan;
    }
}