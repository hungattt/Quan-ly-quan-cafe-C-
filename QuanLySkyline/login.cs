using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySkyline
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc muốn thoát không  !!", "Thoát ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                System.Windows.Forms.Application.Exit();
            }
        }
        public static string US_Name = "";
        public static string US_Lv = "";
        private  void btnDangNhap_Click(object sender, EventArgs e)
        {
           
            string con_str = @"Data source = DESKTOP-JRFV3IL\SQLEXPRESS;Initial Catalog=QLCAFE;Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(con_str);
            conn.Open();
            string username = txtName.Text;
            string password = txtPass.Text;
            string query = "Select Username,Lv from TAIKHOAN Where Username='" + username + "' and Password='" + password + "' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                US_Name = reader.GetValue(0) + "";
                US_Lv = reader.GetValue(1) + "";
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            else
            {
                if (MessageBox.Show("đăng nhập thất bại , bạn có muốn đăng nhập lại không  !!", "Đăng Nhập", MessageBoxButtons.YesNo) == DialogResult.Yes)

                {
                    txtName.Focus();
                }
                else
                {
                    Close();
                    //System.Windows.Forms.Application.Exit();
                }
            }
            reader.Close();
           
        }
    }



}
