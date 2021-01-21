using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLySkyline.Controls;
using System.Runtime.InteropServices;

namespace QuanLySkyline.ControlsThietLap
{
    public partial class UserControlDoiMatKhau : UserControl
    {
        public UserControlDoiMatKhau()
        {
            InitializeComponent();
           
        }
        SqlConnection conn = null;
        string sqlconn = @"Data source = DESKTOP-JRFV3IL\SQLEXPRESS;Initial Catalog=QLCAFE;Integrated Security=SSPI";
        private void btnDongY_Click(object sender, EventArgs e)
        {


            if (txtPassword1.Text.Equals(txtPassword2.Text))
            {
                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
               
                string username = lbUserName.Text;
                string password = txtPassword2.Text;
                string query = "Update TAIKHOAN set Password ='"+password+"' where Username = '" + username + "'and Password='" +txtPasswordOld.Text+ "'";

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = conn;
                int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
                if (ret > 0)
                {
                    MessageBox.Show("thim da doi mat khau thanh cong ");
                    txtPassword2.Text = "";
                    txtPassword1.Text = "";
                    txtPasswordOld.Text = "";
                }
                else
                {
                    MessageBox.Show("thim da doi mat khau that bai");
                }
              }
           else
           {
                  MessageBox.Show("Mat Khau Khong Khop ");
            }



            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void UserControlDoiMatKhau_Load(object sender, EventArgs e)
        {
            lbUserName.Text = login.US_Name.ToString();
        }
    }
}
