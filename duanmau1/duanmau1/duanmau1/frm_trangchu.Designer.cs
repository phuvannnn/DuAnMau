namespace duanmau1
{
    partial class frm_trangchu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_trangchu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Cha = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_Con = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_DanhSachNoTienPhong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_DanhSachNoTienPhong = new System.Windows.Forms.Label();
            this.dgv_DanhSachPhong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_DanhSachPhong = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_caiDat = new Guna.UI2.WinForms.Guna2Button();
            this.btn_soNuoc = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cocPhong = new Guna.UI2.WinForms.Guna2Button();
            this.btn_tinhTien = new Guna.UI2.WinForms.Guna2Button();
            this.btn_soDien = new Guna.UI2.WinForms.Guna2Button();
            this.btn_dichVu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_phong = new Guna.UI2.WinForms.Guna2Button();
            this.btn_TrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            this.pnl_Cha.SuspendLayout();
            this.pnl_Con.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNoTienPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btn_caiDat);
            this.panel1.Controls.Add(this.btn_soNuoc);
            this.panel1.Controls.Add(this.btn_cocPhong);
            this.panel1.Controls.Add(this.btn_tinhTien);
            this.panel1.Controls.Add(this.btn_soDien);
            this.panel1.Controls.Add(this.btn_dichVu);
            this.panel1.Controls.Add(this.btn_phong);
            this.panel1.Controls.Add(this.btn_TrangChu);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 861);
            this.panel1.TabIndex = 0;
            // 
            // pnl_Cha
            // 
            this.pnl_Cha.Controls.Add(this.pnl_Con);
            this.pnl_Cha.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Cha.Location = new System.Drawing.Point(319, 0);
            this.pnl_Cha.Name = "pnl_Cha";
            this.pnl_Cha.Size = new System.Drawing.Size(1163, 853);
            this.pnl_Cha.TabIndex = 1;
            // 
            // pnl_Con
            // 
            this.pnl_Con.AutoScroll = true;
            this.pnl_Con.Controls.Add(this.guna2Button1);
            this.pnl_Con.Controls.Add(this.dgv_DanhSachNoTienPhong);
            this.pnl_Con.Controls.Add(this.lbl_DanhSachNoTienPhong);
            this.pnl_Con.Controls.Add(this.dgv_DanhSachPhong);
            this.pnl_Con.Controls.Add(this.lbl_DanhSachPhong);
            this.pnl_Con.Location = new System.Drawing.Point(7, 12);
            this.pnl_Con.Name = "pnl_Con";
            this.pnl_Con.Size = new System.Drawing.Size(1153, 956);
            this.pnl_Con.TabIndex = 0;
            // 
            // dgv_DanhSachNoTienPhong
            // 
            this.dgv_DanhSachNoTienPhong.AllowUserToResizeColumns = false;
            this.dgv_DanhSachNoTienPhong.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_DanhSachNoTienPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSachNoTienPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DanhSachNoTienPhong.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DanhSachNoTienPhong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DanhSachNoTienPhong.GridColor = System.Drawing.Color.Black;
            this.dgv_DanhSachNoTienPhong.Location = new System.Drawing.Point(0, 574);
            this.dgv_DanhSachNoTienPhong.Name = "dgv_DanhSachNoTienPhong";
            this.dgv_DanhSachNoTienPhong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_DanhSachNoTienPhong.RowHeadersVisible = false;
            this.dgv_DanhSachNoTienPhong.RowHeadersWidth = 51;
            this.dgv_DanhSachNoTienPhong.RowTemplate.Height = 24;
            this.dgv_DanhSachNoTienPhong.Size = new System.Drawing.Size(1145, 304);
            this.dgv_DanhSachNoTienPhong.TabIndex = 3;
            this.dgv_DanhSachNoTienPhong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DanhSachNoTienPhong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_DanhSachNoTienPhong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_DanhSachNoTienPhong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_DanhSachNoTienPhong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_DanhSachNoTienPhong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DanhSachNoTienPhong.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgv_DanhSachNoTienPhong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_DanhSachNoTienPhong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_DanhSachNoTienPhong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DanhSachNoTienPhong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_DanhSachNoTienPhong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_DanhSachNoTienPhong.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_DanhSachNoTienPhong.ThemeStyle.ReadOnly = false;
            this.dgv_DanhSachNoTienPhong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DanhSachNoTienPhong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DanhSachNoTienPhong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DanhSachNoTienPhong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_DanhSachNoTienPhong.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_DanhSachNoTienPhong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DanhSachNoTienPhong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lbl_DanhSachNoTienPhong
            // 
            this.lbl_DanhSachNoTienPhong.AutoSize = true;
            this.lbl_DanhSachNoTienPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanhSachNoTienPhong.ForeColor = System.Drawing.Color.White;
            this.lbl_DanhSachNoTienPhong.Location = new System.Drawing.Point(49, 531);
            this.lbl_DanhSachNoTienPhong.Name = "lbl_DanhSachNoTienPhong";
            this.lbl_DanhSachNoTienPhong.Size = new System.Drawing.Size(233, 22);
            this.lbl_DanhSachNoTienPhong.TabIndex = 2;
            this.lbl_DanhSachNoTienPhong.Text = "Danh sách nợ tiền phòng";
            // 
            // dgv_DanhSachPhong
            // 
            this.dgv_DanhSachPhong.AllowUserToResizeColumns = false;
            this.dgv_DanhSachPhong.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_DanhSachPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSachPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_DanhSachPhong.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DanhSachPhong.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_DanhSachPhong.GridColor = System.Drawing.Color.Black;
            this.dgv_DanhSachPhong.Location = new System.Drawing.Point(5, 51);
            this.dgv_DanhSachPhong.Name = "dgv_DanhSachPhong";
            this.dgv_DanhSachPhong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_DanhSachPhong.RowHeadersVisible = false;
            this.dgv_DanhSachPhong.RowHeadersWidth = 51;
            this.dgv_DanhSachPhong.RowTemplate.Height = 24;
            this.dgv_DanhSachPhong.Size = new System.Drawing.Size(1145, 433);
            this.dgv_DanhSachPhong.TabIndex = 1;
            this.dgv_DanhSachPhong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DanhSachPhong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_DanhSachPhong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_DanhSachPhong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_DanhSachPhong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_DanhSachPhong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DanhSachPhong.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgv_DanhSachPhong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_DanhSachPhong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_DanhSachPhong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DanhSachPhong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_DanhSachPhong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_DanhSachPhong.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_DanhSachPhong.ThemeStyle.ReadOnly = false;
            this.dgv_DanhSachPhong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DanhSachPhong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DanhSachPhong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DanhSachPhong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_DanhSachPhong.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_DanhSachPhong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DanhSachPhong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lbl_DanhSachPhong
            // 
            this.lbl_DanhSachPhong.AutoSize = true;
            this.lbl_DanhSachPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanhSachPhong.ForeColor = System.Drawing.Color.White;
            this.lbl_DanhSachPhong.Location = new System.Drawing.Point(49, 14);
            this.lbl_DanhSachPhong.Name = "lbl_DanhSachPhong";
            this.lbl_DanhSachPhong.Size = new System.Drawing.Size(166, 22);
            this.lbl_DanhSachPhong.TabIndex = 0;
            this.lbl_DanhSachPhong.Text = "Danh sách phòng";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(1101, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(31, 24);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btn_caiDat
            // 
            this.btn_caiDat.BorderColor = System.Drawing.Color.White;
            this.btn_caiDat.BorderRadius = 1;
            this.btn_caiDat.BorderThickness = 1;
            this.btn_caiDat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_caiDat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_caiDat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_caiDat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_caiDat.FillColor = System.Drawing.Color.Black;
            this.btn_caiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_caiDat.ForeColor = System.Drawing.Color.White;
            this.btn_caiDat.Image = global::duanmau1.Properties.Resources.settings;
            this.btn_caiDat.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_caiDat.Location = new System.Drawing.Point(-5, 751);
            this.btn_caiDat.Name = "btn_caiDat";
            this.btn_caiDat.Size = new System.Drawing.Size(329, 107);
            this.btn_caiDat.TabIndex = 32;
            this.btn_caiDat.Text = " Cài Đặt";
            this.btn_caiDat.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // btn_soNuoc
            // 
            this.btn_soNuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_soNuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_soNuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_soNuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_soNuoc.FillColor = System.Drawing.Color.Black;
            this.btn_soNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_soNuoc.ForeColor = System.Drawing.Color.White;
            this.btn_soNuoc.Image = global::duanmau1.Properties.Resources.water;
            this.btn_soNuoc.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_soNuoc.Location = new System.Drawing.Point(3, 472);
            this.btn_soNuoc.Name = "btn_soNuoc";
            this.btn_soNuoc.Size = new System.Drawing.Size(314, 53);
            this.btn_soNuoc.TabIndex = 29;
            this.btn_soNuoc.Text = " Chỉ Số Nước";
            this.btn_soNuoc.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // btn_cocPhong
            // 
            this.btn_cocPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cocPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cocPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cocPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cocPhong.FillColor = System.Drawing.Color.Black;
            this.btn_cocPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_cocPhong.ForeColor = System.Drawing.Color.White;
            this.btn_cocPhong.Image = global::duanmau1.Properties.Resources._lock;
            this.btn_cocPhong.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_cocPhong.Location = new System.Drawing.Point(3, 590);
            this.btn_cocPhong.Name = "btn_cocPhong";
            this.btn_cocPhong.Size = new System.Drawing.Size(314, 53);
            this.btn_cocPhong.TabIndex = 31;
            this.btn_cocPhong.Text = " Cọc Giữ Phòng";
            this.btn_cocPhong.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // btn_tinhTien
            // 
            this.btn_tinhTien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tinhTien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tinhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tinhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tinhTien.FillColor = System.Drawing.Color.Black;
            this.btn_tinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_tinhTien.ForeColor = System.Drawing.Color.White;
            this.btn_tinhTien.Image = global::duanmau1.Properties.Resources.card;
            this.btn_tinhTien.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_tinhTien.Location = new System.Drawing.Point(5, 531);
            this.btn_tinhTien.Name = "btn_tinhTien";
            this.btn_tinhTien.Size = new System.Drawing.Size(314, 53);
            this.btn_tinhTien.TabIndex = 30;
            this.btn_tinhTien.Text = " Tính Tiền";
            this.btn_tinhTien.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // btn_soDien
            // 
            this.btn_soDien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_soDien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_soDien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_soDien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_soDien.FillColor = System.Drawing.Color.Black;
            this.btn_soDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_soDien.ForeColor = System.Drawing.Color.White;
            this.btn_soDien.Image = global::duanmau1.Properties.Resources.lightning;
            this.btn_soDien.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_soDien.Location = new System.Drawing.Point(3, 413);
            this.btn_soDien.Name = "btn_soDien";
            this.btn_soDien.Size = new System.Drawing.Size(314, 53);
            this.btn_soDien.TabIndex = 28;
            this.btn_soDien.Text = " Chỉ Số Điện";
            this.btn_soDien.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // btn_dichVu
            // 
            this.btn_dichVu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dichVu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dichVu.FillColor = System.Drawing.Color.Black;
            this.btn_dichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dichVu.ForeColor = System.Drawing.Color.White;
            this.btn_dichVu.Image = global::duanmau1.Properties.Resources.customer;
            this.btn_dichVu.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_dichVu.Location = new System.Drawing.Point(3, 354);
            this.btn_dichVu.Name = "btn_dichVu";
            this.btn_dichVu.Size = new System.Drawing.Size(314, 53);
            this.btn_dichVu.TabIndex = 27;
            this.btn_dichVu.Text = " Dịch Vụ";
            this.btn_dichVu.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // btn_phong
            // 
            this.btn_phong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_phong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_phong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_phong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_phong.FillColor = System.Drawing.Color.Black;
            this.btn_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_phong.ForeColor = System.Drawing.Color.White;
            this.btn_phong.Image = global::duanmau1.Properties.Resources.home;
            this.btn_phong.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_phong.Location = new System.Drawing.Point(3, 295);
            this.btn_phong.Name = "btn_phong";
            this.btn_phong.Size = new System.Drawing.Size(314, 53);
            this.btn_phong.TabIndex = 26;
            this.btn_phong.Text = " Phòng ";
            this.btn_phong.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_TrangChu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TrangChu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TrangChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TrangChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TrangChu.FillColor = System.Drawing.Color.Black;
            this.btn_TrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TrangChu.ForeColor = System.Drawing.Color.White;
            this.btn_TrangChu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_TrangChu.Image = global::duanmau1.Properties.Resources.compass1png;
            this.btn_TrangChu.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_TrangChu.Location = new System.Drawing.Point(3, 236);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.Size = new System.Drawing.Size(314, 53);
            this.btn_TrangChu.TabIndex = 25;
            this.btn_TrangChu.Text = " Trang Chủ";
            this.btn_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::duanmau1.Properties.Resources.z6626326737484_37bd088ccf334141d3288b5f3d2975b4_removebg_preview_removebg_preview;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-5, -30);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(324, 303);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 24;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frm_trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.pnl_Cha);
            this.Controls.Add(this.panel1);
            this.Name = "frm_trangchu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_trangchu";
            this.panel1.ResumeLayout(false);
            this.pnl_Cha.ResumeLayout(false);
            this.pnl_Con.ResumeLayout(false);
            this.pnl_Con.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNoTienPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_TrangChu;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_phong;
        private Guna.UI2.WinForms.Guna2Button btn_dichVu;
        private Guna.UI2.WinForms.Guna2Button btn_caiDat;
        private Guna.UI2.WinForms.Guna2Button btn_cocPhong;
        private Guna.UI2.WinForms.Guna2Button btn_tinhTien;
        private Guna.UI2.WinForms.Guna2Button btn_soNuoc;
        private Guna.UI2.WinForms.Guna2Button btn_soDien;
        private Guna.UI2.WinForms.Guna2Panel pnl_Cha;
        private Guna.UI2.WinForms.Guna2Panel pnl_Con;
        private System.Windows.Forms.Label lbl_DanhSachPhong;
        private System.Windows.Forms.Label lbl_DanhSachNoTienPhong;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_DanhSachPhong;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_DanhSachNoTienPhong;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}