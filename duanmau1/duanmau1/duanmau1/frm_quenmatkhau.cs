﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duanmau1
{
    public partial class frm_quenmatkhau : Form
    {
        public frm_quenmatkhau()
        {
            InitializeComponent();
        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_tieptuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_dangnhap dangnhap = new Frm_dangnhap();
            dangnhap.Show();
        }

        private void frm_quenmatkhau_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gunapcb_anhnen_Click(object sender, EventArgs e)
        {

        }
    }
}
