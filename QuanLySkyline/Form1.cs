using QuanLySkyline.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySkyline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trangChuUserControl11.BringToFront();
            PhanQuyen();
            lbQTV.Text = login.US_Name;
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            quanLyUserControl11.BringToFront();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            trangChuUserControl11.BringToFront();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void btnThietLap_Click(object sender, EventArgs e)
        {
            thietLapUserControl11.BringToFront();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            banHangUserControl11.BringToFront();
        }
        public void HienThiNgayGioHienTai()
        {
            DateTime aDateTime = DateTime.Now;
           // lbgiohientai.Text = aDateTime.ToString();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            thongKeUserControl11.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            DateTime aDateTime = DateTime.Now;
            lbNgayThang.Text = aDateTime.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDongHo.Text= DateTime.Now.ToLongTimeString();
        }

        public void PhanQuyen()
        {
            if (login.US_Lv.Equals("1"))
            {
              
                btnBanHang.Enabled = true;
                btnQuanLy.Enabled = true;
                btnTrangChu.Enabled = true;
                btnThongKe.Enabled = true;
                btnThietLap.Enabled = true;
            }
            else
            {
                btnBanHang.Enabled = true;
                btnQuanLy.Enabled = false;
                btnTrangChu.Enabled = true;
                btnThongKe.Enabled = false;
                btnThietLap.Enabled = true;
            }
        }

    }
}
