namespace GUI_QLPK
{
    partial class QuanLyDichVu
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
            this.themdv = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTienDV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenDV = new Guna.UI2.WinForms.Guna2TextBox();
            this.QLDichVu = new Guna.UI2.WinForms.Guna2Panel();
            this.huydv = new Guna.UI2.WinForms.Guna2Button();
            this.xoadv = new Guna.UI2.WinForms.Guna2Button();
            this.capnhatdv = new Guna.UI2.WinForms.Guna2Button();
            this.TimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.maDichVu = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gird)).BeginInit();
            this.QLDichVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gird
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gird.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gird.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.gird.Location = new System.Drawing.Point(0, 342);
            this.gird.Name = "gird";
            this.gird.RowHeadersVisible = false;
            this.gird.RowHeadersWidth = 45;
            this.gird.RowTemplate.Height = 28;
            this.gird.Size = new System.Drawing.Size(1076, 544);
            this.gird.TabIndex = 22;
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
            // themdv
            // 
            this.themdv.BackColor = System.Drawing.Color.White;
            this.themdv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.themdv.BorderThickness = 1;
            this.themdv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.themdv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.themdv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.themdv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.themdv.FillColor = System.Drawing.Color.Transparent;
            this.themdv.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themdv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.themdv.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.themdv.HoverState.ForeColor = System.Drawing.Color.White;
            this.themdv.Location = new System.Drawing.Point(83, 279);
            this.themdv.Name = "themdv";
            this.themdv.Size = new System.Drawing.Size(123, 36);
            this.themdv.TabIndex = 2;
            this.themdv.Text = "Thêm";
            this.themdv.Click += new System.EventHandler(this.themdv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên dịch vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(610, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tiền dịch vụ:";
            // 
            // txtTienDV
            // 
            this.txtTienDV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienDV.DefaultText = "";
            this.txtTienDV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTienDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTienDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienDV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienDV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienDV.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienDV.ForeColor = System.Drawing.Color.Black;
            this.txtTienDV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienDV.Location = new System.Drawing.Point(729, 163);
            this.txtTienDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTienDV.Name = "txtTienDV";
            this.txtTienDV.PlaceholderText = "";
            this.txtTienDV.SelectedText = "";
            this.txtTienDV.Size = new System.Drawing.Size(247, 40);
            this.txtTienDV.TabIndex = 9;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDV.DefaultText = "";
            this.txtTenDV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDV.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.ForeColor = System.Drawing.Color.Black;
            this.txtTenDV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDV.Location = new System.Drawing.Point(198, 163);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.PlaceholderText = "";
            this.txtTenDV.SelectedText = "";
            this.txtTenDV.Size = new System.Drawing.Size(247, 40);
            this.txtTenDV.TabIndex = 18;
            // 
            // QLDichVu
            // 
            this.QLDichVu.BackColor = System.Drawing.Color.LightCyan;
            this.QLDichVu.Controls.Add(this.huydv);
            this.QLDichVu.Controls.Add(this.xoadv);
            this.QLDichVu.Controls.Add(this.capnhatdv);
            this.QLDichVu.Controls.Add(this.TimKiem);
            this.QLDichVu.Controls.Add(this.maDichVu);
            this.QLDichVu.Controls.Add(this.txtTenDV);
            this.QLDichVu.Controls.Add(this.txtTienDV);
            this.QLDichVu.Controls.Add(this.label4);
            this.QLDichVu.Controls.Add(this.label3);
            this.QLDichVu.Controls.Add(this.themdv);
            this.QLDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.QLDichVu.Location = new System.Drawing.Point(0, 0);
            this.QLDichVu.Name = "QLDichVu";
            this.QLDichVu.Size = new System.Drawing.Size(1076, 342);
            this.QLDichVu.TabIndex = 21;
            this.QLDichVu.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // huydv
            // 
            this.huydv.BackColor = System.Drawing.Color.White;
            this.huydv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.huydv.BorderThickness = 1;
            this.huydv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.huydv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.huydv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.huydv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.huydv.FillColor = System.Drawing.Color.Transparent;
            this.huydv.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huydv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.huydv.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.huydv.HoverState.ForeColor = System.Drawing.Color.White;
            this.huydv.Location = new System.Drawing.Point(853, 279);
            this.huydv.Name = "huydv";
            this.huydv.Size = new System.Drawing.Size(123, 36);
            this.huydv.TabIndex = 24;
            this.huydv.Text = "Hoàn tác";
            this.huydv.Click += new System.EventHandler(this.huydv_Click_1);
            // 
            // xoadv
            // 
            this.xoadv.BackColor = System.Drawing.Color.White;
            this.xoadv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.xoadv.BorderThickness = 1;
            this.xoadv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.xoadv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.xoadv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.xoadv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.xoadv.FillColor = System.Drawing.Color.Transparent;
            this.xoadv.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoadv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.xoadv.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.xoadv.HoverState.ForeColor = System.Drawing.Color.White;
            this.xoadv.Location = new System.Drawing.Point(590, 279);
            this.xoadv.Name = "xoadv";
            this.xoadv.Size = new System.Drawing.Size(123, 36);
            this.xoadv.TabIndex = 23;
            this.xoadv.Text = "Xóa";
            this.xoadv.Click += new System.EventHandler(this.xoadv_Click_1);
            // 
            // capnhatdv
            // 
            this.capnhatdv.BackColor = System.Drawing.Color.White;
            this.capnhatdv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.capnhatdv.BorderThickness = 1;
            this.capnhatdv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.capnhatdv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.capnhatdv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.capnhatdv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.capnhatdv.FillColor = System.Drawing.Color.Transparent;
            this.capnhatdv.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capnhatdv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.capnhatdv.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.capnhatdv.HoverState.ForeColor = System.Drawing.Color.White;
            this.capnhatdv.Location = new System.Drawing.Point(334, 279);
            this.capnhatdv.Name = "capnhatdv";
            this.capnhatdv.Size = new System.Drawing.Size(123, 36);
            this.capnhatdv.TabIndex = 22;
            this.capnhatdv.Text = "Cập nhật";
            this.capnhatdv.Click += new System.EventHandler(this.capnhatdv_Click);
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
            this.TimKiem.Click += new System.EventHandler(this.TimKiem_Click_1);
            // 
            // maDichVu
            // 
            this.maDichVu.BorderRadius = 20;
            this.maDichVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maDichVu.DefaultText = "";
            this.maDichVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.maDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.maDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maDichVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maDichVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maDichVu.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maDichVu.ForeColor = System.Drawing.Color.Black;
            this.maDichVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maDichVu.IconLeft = global::GUI_QLPK.Properties.Resources.search;
            this.maDichVu.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.maDichVu.Location = new System.Drawing.Point(141, 23);
            this.maDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maDichVu.Name = "maDichVu";
            this.maDichVu.PlaceholderText = "Tìm từ khóa";
            this.maDichVu.SelectedText = "";
            this.maDichVu.Size = new System.Drawing.Size(460, 48);
            this.maDichVu.TabIndex = 20;
            this.maDichVu.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // QuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 886);
            this.Controls.Add(this.gird);
            this.Controls.Add(this.QLDichVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyDichVu";
            this.Text = "QuanLyDichVu";
            ((System.ComponentModel.ISupportInitialize)(this.gird)).EndInit();
            this.QLDichVu.ResumeLayout(false);
            this.QLDichVu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView gird;
        private Guna.UI2.WinForms.Guna2Button themdv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtTienDV;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDV;
        private Guna.UI2.WinForms.Guna2Panel QLDichVu;
        private Guna.UI2.WinForms.Guna2Button xoadv;
        private Guna.UI2.WinForms.Guna2Button capnhatdv;
        private Guna.UI2.WinForms.Guna2Button TimKiem;
        private Guna.UI2.WinForms.Guna2TextBox maDichVu;
        private Guna.UI2.WinForms.Guna2Button huydv;
    }
}