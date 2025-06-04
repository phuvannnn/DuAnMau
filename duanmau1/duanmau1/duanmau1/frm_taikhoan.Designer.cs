namespace duanmau1
{
    partial class frm_taikhoan
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panel_dangky = new System.Windows.Forms.Panel();
            this.linkLbl_quayvedanhnhap = new System.Windows.Forms.LinkLabel();
            this.btn_dangky = new Guna.UI2.WinForms.Guna2Button();
            this.txt_matkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_sdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txt_nhaplaimatkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_taikhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_anh = new System.Windows.Forms.Panel();
            this.pb_anhnen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_dangky.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel_anh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anhnen)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // panel_dangky
            // 
            this.panel_dangky.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_dangky.Controls.Add(this.linkLbl_quayvedanhnhap);
            this.panel_dangky.Controls.Add(this.btn_dangky);
            this.panel_dangky.Controls.Add(this.txt_matkhau);
            this.panel_dangky.Controls.Add(this.txt_sdt);
            this.panel_dangky.Controls.Add(this.guna2Panel2);
            this.panel_dangky.Controls.Add(this.txt_nhaplaimatkhau);
            this.panel_dangky.Controls.Add(this.txt_taikhoan);
            this.panel_dangky.Controls.Add(this.label3);
            this.panel_dangky.Controls.Add(this.guna2PictureBox1);
            this.panel_dangky.Location = new System.Drawing.Point(476, 3);
            this.panel_dangky.Name = "panel_dangky";
            this.panel_dangky.Size = new System.Drawing.Size(497, 674);
            this.panel_dangky.TabIndex = 0;
            // 
            // linkLbl_quayvedanhnhap
            // 
            this.linkLbl_quayvedanhnhap.ActiveLinkColor = System.Drawing.Color.SandyBrown;
            this.linkLbl_quayvedanhnhap.AutoSize = true;
            this.linkLbl_quayvedanhnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLbl_quayvedanhnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbl_quayvedanhnhap.LinkColor = System.Drawing.Color.White;
            this.linkLbl_quayvedanhnhap.Location = new System.Drawing.Point(318, 637);
            this.linkLbl_quayvedanhnhap.Name = "linkLbl_quayvedanhnhap";
            this.linkLbl_quayvedanhnhap.Size = new System.Drawing.Size(152, 20);
            this.linkLbl_quayvedanhnhap.TabIndex = 32;
            this.linkLbl_quayvedanhnhap.TabStop = true;
            this.linkLbl_quayvedanhnhap.Text = "Quay về đăng nhập";
            this.linkLbl_quayvedanhnhap.Click += new System.EventHandler(this.linkLbl_quayvedanhnhap_Click);
            // 
            // btn_dangky
            // 
            this.btn_dangky.Animated = true;
            this.btn_dangky.AutoRoundedCorners = true;
            this.btn_dangky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangky.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dangky.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dangky.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dangky.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dangky.FillColor = System.Drawing.Color.Peru;
            this.btn_dangky.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_dangky.ForeColor = System.Drawing.Color.White;
            this.btn_dangky.Location = new System.Drawing.Point(129, 534);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Size = new System.Drawing.Size(256, 57);
            this.btn_dangky.TabIndex = 31;
            this.btn_dangky.Text = "Đăng ký";
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Animated = true;
            this.txt_matkhau.BorderColor = System.Drawing.Color.White;
            this.txt_matkhau.BorderRadius = 8;
            this.txt_matkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matkhau.DefaultText = "";
            this.txt_matkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_matkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_matkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_matkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_matkhau.FillColor = System.Drawing.Color.Gray;
            this.txt_matkhau.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txt_matkhau.FocusedState.FillColor = System.Drawing.Color.DarkGray;
            this.txt_matkhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_matkhau.ForeColor = System.Drawing.Color.White;
            this.txt_matkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_matkhau.IconLeft = global::duanmau1.Properties.Resources.locked_computer;
            this.txt_matkhau.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txt_matkhau.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txt_matkhau.Location = new System.Drawing.Point(99, 375);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_matkhau.PlaceholderText = "Mật khẩu";
            this.txt_matkhau.SelectedText = "";
            this.txt_matkhau.Size = new System.Drawing.Size(315, 55);
            this.txt_matkhau.TabIndex = 30;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Animated = true;
            this.txt_sdt.BorderColor = System.Drawing.Color.White;
            this.txt_sdt.BorderRadius = 8;
            this.txt_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sdt.DefaultText = "";
            this.txt_sdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_sdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_sdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sdt.FillColor = System.Drawing.Color.Gray;
            this.txt_sdt.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txt_sdt.FocusedState.FillColor = System.Drawing.Color.DarkGray;
            this.txt_sdt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_sdt.ForeColor = System.Drawing.Color.White;
            this.txt_sdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sdt.IconLeft = global::duanmau1.Properties.Resources.old_typical_phone;
            this.txt_sdt.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txt_sdt.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txt_sdt.Location = new System.Drawing.Point(99, 300);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_sdt.PlaceholderText = "SĐT";
            this.txt_sdt.SelectedText = "";
            this.txt_sdt.Size = new System.Drawing.Size(315, 55);
            this.txt_sdt.TabIndex = 28;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox4);
            this.guna2Panel2.Location = new System.Drawing.Point(394, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(102, 30);
            this.guna2Panel2.TabIndex = 27;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Gray;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(4, 3);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(46, 27);
            this.guna2ControlBox3.TabIndex = 14;
            // 
            // guna2ControlBox4
            // 
            this.guna2ControlBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox4.FillColor = System.Drawing.Color.Gray;
            this.guna2ControlBox4.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox4.Location = new System.Drawing.Point(53, 3);
            this.guna2ControlBox4.Name = "guna2ControlBox4";
            this.guna2ControlBox4.Size = new System.Drawing.Size(46, 27);
            this.guna2ControlBox4.TabIndex = 13;
            // 
            // txt_nhaplaimatkhau
            // 
            this.txt_nhaplaimatkhau.Animated = true;
            this.txt_nhaplaimatkhau.BorderColor = System.Drawing.Color.White;
            this.txt_nhaplaimatkhau.BorderRadius = 8;
            this.txt_nhaplaimatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nhaplaimatkhau.DefaultText = "";
            this.txt_nhaplaimatkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nhaplaimatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nhaplaimatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nhaplaimatkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nhaplaimatkhau.FillColor = System.Drawing.Color.Gray;
            this.txt_nhaplaimatkhau.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txt_nhaplaimatkhau.FocusedState.FillColor = System.Drawing.Color.DarkGray;
            this.txt_nhaplaimatkhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nhaplaimatkhau.ForeColor = System.Drawing.Color.White;
            this.txt_nhaplaimatkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nhaplaimatkhau.IconLeft = global::duanmau1.Properties.Resources.locked_computer;
            this.txt_nhaplaimatkhau.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txt_nhaplaimatkhau.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txt_nhaplaimatkhau.Location = new System.Drawing.Point(99, 449);
            this.txt_nhaplaimatkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nhaplaimatkhau.Name = "txt_nhaplaimatkhau";
            this.txt_nhaplaimatkhau.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_nhaplaimatkhau.PlaceholderText = "Nhập lại mật khẩu";
            this.txt_nhaplaimatkhau.SelectedText = "";
            this.txt_nhaplaimatkhau.Size = new System.Drawing.Size(315, 55);
            this.txt_nhaplaimatkhau.TabIndex = 26;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Animated = true;
            this.txt_taikhoan.BorderColor = System.Drawing.Color.White;
            this.txt_taikhoan.BorderRadius = 8;
            this.txt_taikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_taikhoan.DefaultText = "";
            this.txt_taikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_taikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_taikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_taikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_taikhoan.FillColor = System.Drawing.Color.Gray;
            this.txt_taikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_taikhoan.FocusedState.FillColor = System.Drawing.Color.DarkGray;
            this.txt_taikhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_taikhoan.ForeColor = System.Drawing.Color.White;
            this.txt_taikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_taikhoan.IconLeft = global::duanmau1.Properties.Resources.user__1_;
            this.txt_taikhoan.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txt_taikhoan.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txt_taikhoan.Location = new System.Drawing.Point(99, 222);
            this.txt_taikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_taikhoan.PlaceholderText = "Tài khoản";
            this.txt_taikhoan.SelectedText = "";
            this.txt_taikhoan.Size = new System.Drawing.Size(315, 55);
            this.txt_taikhoan.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Đăng ký vào  HOLA House ";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::duanmau1.Properties.Resources.z6626326737484_37bd088ccf334141d3288b5f3d2975b4_removebg_preview_removebg_preview;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(143, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(204, 200);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 23;
            this.guna2PictureBox1.TabStop = false;
            // 
            // panel_anh
            // 
            this.panel_anh.Controls.Add(this.pb_anhnen);
            this.panel_anh.Location = new System.Drawing.Point(3, 4);
            this.panel_anh.Name = "panel_anh";
            this.panel_anh.Size = new System.Drawing.Size(467, 657);
            this.panel_anh.TabIndex = 1;
            // 
            // pb_anhnen
            // 
            this.pb_anhnen.Image = global::duanmau1.Properties.Resources.anhnen;
            this.pb_anhnen.ImageRotate = 0F;
            this.pb_anhnen.Location = new System.Drawing.Point(3, 3);
            this.pb_anhnen.Name = "pb_anhnen";
            this.pb_anhnen.Size = new System.Drawing.Size(461, 651);
            this.pb_anhnen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_anhnen.TabIndex = 0;
            this.pb_anhnen.TabStop = false;
            // 
            // frm_taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(975, 674);
            this.Controls.Add(this.panel_anh);
            this.Controls.Add(this.panel_dangky);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_taikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_taikhoan_Load);
            this.panel_dangky.ResumeLayout(false);
            this.panel_dangky.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel_anh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_anhnen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel_dangky;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox4;
        private Guna.UI2.WinForms.Guna2TextBox txt_nhaplaimatkhau;
        private Guna.UI2.WinForms.Guna2TextBox txt_taikhoan;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_matkhau;
        private Guna.UI2.WinForms.Guna2TextBox txt_sdt;
        private Guna.UI2.WinForms.Guna2Button btn_dangky;
        private System.Windows.Forms.LinkLabel linkLbl_quayvedanhnhap;
        private System.Windows.Forms.Panel panel_anh;
        private Guna.UI2.WinForms.Guna2PictureBox pb_anhnen;
    }
}