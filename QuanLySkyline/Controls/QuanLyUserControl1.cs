using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySkyline
{
    public partial class QuanLyUserControl1 : UserControl
    {
        public QuanLyUserControl1()
        {
            InitializeComponent();
        }

        private void btnQuanLyMon_Click(object sender, EventArgs e)
        {
            quanLyMonUserControl11.BringToFront();
        }

        private void btnQuanLyDanhMuc_Click(object sender, EventArgs e)
        {
            quanLyDanhMucUserControl11.BringToFront();
        }

        private void btnQuanLyBan_Click(object sender, EventArgs e)
        {
            quanLyBanUserControl11.BringToFront();
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            quanLyTaiKhoanUserControl11.BringToFront();
        }
    }
}
