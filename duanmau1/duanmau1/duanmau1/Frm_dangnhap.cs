using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duanmau1
{
    public partial class Frm_dangnhap : Form
    {
        public Frm_dangnhap()
        {
            InitializeComponent();
        }
                     
    
        private void chk_hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hienmatkhau.Checked)
            {
                txt_matkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = true;
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string dangnhap = txt_taikhoan.Text;
            string matkhau = txt_matkhau.Text;
            if (dangnhap == "admin" && matkhau == "123")
            {
                this.Hide();
                frm_trangchu trangchu = new frm_trangchu();
                trangchu.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu.");
            }
        }

        private void linklbl_dangky_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_taikhoan tk = new frm_taikhoan();
            tk.Show();
        }

        private void linklbl_quenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_quenmatkhau quenmatkhau = new frm_quenmatkhau();
            quenmatkhau.Show();
        }
    }
}
