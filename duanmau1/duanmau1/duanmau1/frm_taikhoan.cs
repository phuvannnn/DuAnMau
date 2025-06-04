using System;
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
    public partial class frm_taikhoan : Form
    {
        public frm_taikhoan()
        {
            InitializeComponent();
        }

        

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chúc mừng bạn đã đăng ký thành công!");
        }

        private void linkLbl_quayvedanhnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_dangnhap dangnhap = new Frm_dangnhap();
            dangnhap.Show();
        }

        private void frm_taikhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
