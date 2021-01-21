using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySkyline.Controls
{
    public partial class ThietLapUserControl1 : UserControl
    {
        public ThietLapUserControl1()
        {
            InitializeComponent();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            thongTinUserControl11.BringToFront();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            userControlDoiMatKhau1.BringToFront();
        }
    }
}
