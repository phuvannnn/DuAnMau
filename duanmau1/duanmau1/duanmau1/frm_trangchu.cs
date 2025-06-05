using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace duanmau1
{
    public partial class frm_trangchu : Form
    {
        public frm_trangchu()
        {
            InitializeComponent();
            Load_dgv_DanhSachPhong();
            Load_dgv_DanhSachNoTienPhong();
            dgv_DanhSachPhong.ColumnHeadersHeight = 40;
            dgv_DanhSachPhong.Columns[0].HeaderText = "Nhà";
            dgv_DanhSachPhong.Columns[1].HeaderText = "Phòng";
            dgv_DanhSachPhong.Columns[2].HeaderText = "Trạng thái";
            dgv_DanhSachPhong.Columns[3].HeaderText = "Doanh thu";
            dgv_DanhSachNoTienPhong.ColumnHeadersHeight = 40;
            dgv_DanhSachNoTienPhong.Columns[0].HeaderText = "Nhà";
            dgv_DanhSachNoTienPhong.Columns[1].HeaderText = "Phòng";
            dgv_DanhSachNoTienPhong.Columns[2].HeaderText = "Khách";
            dgv_DanhSachNoTienPhong.Columns[3].HeaderText = "Tháng";
            dgv_DanhSachNoTienPhong.Columns[4].HeaderText = "Số tiền(VND)";
            btn_TrangChu.FillColor = Color.FromArgb(255, 64, 64, 64);
        }
        string chuoiKetNoi = "Data Source=.;Initial Catalog=QuanLyPhongTro;Integrated Security=True;";
        public void Load_dgv_DanhSachPhong()
        {
            try
            {
                using (var db = new QuanLyPhongTroDataContext(chuoiKetNoi))
                {
                    var ketQua = from pt in db.PHONG_TROs
                                 join hd in db.HOP_DONG_THUEs on pt.MaPhongTro equals hd.MaPhongTro into dsTam
                                 from d in dsTam.DefaultIfEmpty()
                                 select new
                                 {
                                     Nha = pt.TenPT,
                                     Phong = pt.MaPhongTro,
                                     TrangThai = pt.TrangThaiPT,
                                     DoanhThu = d == null ? 0 : d.GiaThue,
                                 };
                    dgv_DanhSachPhong.DataSource = ketQua.ToList();
                    dgv_DanhSachPhong.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Single; // Đường dọc bên trái ô
                    dgv_DanhSachPhong.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single; // Đường dọc bên phải ô
                }
                ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Load_dgv_DanhSachNoTienPhong()
        {
            try
            {
                using (var db = new QuanLyPhongTroDataContext(chuoiKetNoi))
                {
                    var ketQua = from hd in db.HOP_DONG_THUEs
                                 join nt in db.NGUOI_THUEs on hd.MaNguoiThue equals nt.MaNguoiThue
                                 join pt in db.PHONG_TROs on hd.MaPhongTro equals pt.MaPhongTro
                                 join hdon in db.HOA_DONs on hd.MaHopDong equals hdon.MaHopDong
                                 into dsTam
                                 from d in dsTam.DefaultIfEmpty()
                                 where d.TrangThaiHD == "Chưa thanh toán"
                                 select new
                                 {
                                     pt.TenPT,
                                     pt.MaPhongTro,
                                     ten = nt.HoTen,
                                     thang= d== null? "Chưa có": d.KyThanhToan,
                                     tongtien= d== null? 0:d.TongTien
                                 };
                    dgv_DanhSachNoTienPhong.DataSource = ketQua.ToList();
                    dgv_DanhSachNoTienPhong.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Single; // Đường dọc bên trái ô
                    dgv_DanhSachNoTienPhong.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single; // Đường dọc bên phải ô

                }
                ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_phong_Click(object sender, EventArgs e)
        {

        }

        private void dgv_DanhSachPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_DanhSachNoTienPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_TrangChu.FillColor = Color.FromArgb(255, 64, 64, 64);
        }
        private void ResetButtonColors()
        {
            btn_TrangChu.BackColor = SystemColors.Control;
            btn_phong.BackColor = SystemColors.Control;
            btn_dichVu.BackColor = SystemColors.Control;
            btn_soDien.BackColor = SystemColors.Control;
            btn_soNuoc.BackColor = SystemColors.Control;
            btn_tinhTien.BackColor = SystemColors.Control;
            btn_cocPhong.BackColor = SystemColors.Control;
            btn_caiDat.BackColor = SystemColors.Control;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát không?","Xác nhận",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
