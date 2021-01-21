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

namespace QuanLySkyline.ControlsQuanLy
{
    public partial class QuanLyTaiKhoanUserControl1 : UserControl
    {
        public QuanLyTaiKhoanUserControl1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string sqlconn = @"Data source = DESKTOP-JRFV3IL\SQLEXPRESS;Initial Catalog=QLCAFE;Integrated Security=SSPI";
        SqlDataAdapter adapter = null;
        DataSet ds = null;

        public void TaoBuilder()
        {
            if (conn == null)
            {
                conn = new SqlConnection(sqlconn);
            }
            if (conn.State == ConnectionState.Closed)
            { 
                conn.Open();
            }
            adapter = new SqlDataAdapter("select * from TAIKHOAN", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "user");
        }

        public void HienThiTaiKhoan()
        {
            TaoBuilder();
            dataGridViewTaiKhoan.DataSource = ds.Tables["user"];
        }

        private void QuanLyTaiKhoanUserControl1_Load(object sender, EventArgs e)
        {
            HienThiTaiKhoan();
        }
        int idx = -1;
        private void dataGridViewTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            if (idx >= 0)
            {

                //txtIdTK.Text = dataGridViewTaiKhoan.Rows[idx].Cells["Id"].Value.ToString();
                txtUsername.Text = dataGridViewTaiKhoan.Rows[idx].Cells["Username"].Value.ToString();
                txtPassword.Text = dataGridViewTaiKhoan.Rows[idx].Cells["Password"].Value.ToString();
                txtLv.Text = dataGridViewTaiKhoan.Rows[idx].Cells["lv"].Value.ToString();

            }
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            //int count = 0;
            //count = dataGridViewTaiKhoan.Rows.Count;
            //string chuoi = "";
            //int chuoi2 = 0;
            //chuoi = Convert.ToString(dataGridViewTaiKhoan.Rows[count - 2].Cells[0].Value);
            //chuoi2 = Convert.ToInt32(chuoi);
            //if (chuoi2 + 1 < 10)
            //    txtIdTK.Text = (chuoi2 + 1).ToString();
            //else if (chuoi2 + 1 < 100)
            //    txtIdTK.Text = (chuoi2 + 1).ToString();
            try
            {
                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "Insert into TAIKHOAN (Username, Password, Lv)VALUES( '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtLv.Text + "')";

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = conn;

                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    HienThiTaiKhoan();
                    MessageBox.Show("thim da them thanh cong ");


                }
                else
                {
                    MessageBox.Show("thim da them that bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ban nhap sai kieu du lieu !!!");
            }
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "Update TAIKHOAN set Password='" + txtPassword.Text + "', Lv='" + txtLv.Text + "'  where Username = '" + txtUsername.Text + "' ";

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = conn;
                int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
                if (ret > 0)
                {
                    HienThiTaiKhoan();
                    MessageBox.Show("thim da cap nhat thanh cong ");

                }
                else
                {
                    MessageBox.Show("thim da cap nhat that bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ban nhap sai kieu du lieu !!! ");
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = "Delete from TAIKHOAN where Username = '" + txtUsername.Text + "'";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
            if (ret > 0)
            {
                HienThiTaiKhoan();
                MessageBox.Show("thim da xoa thanh cong ");

            }
            else
            {
                MessageBox.Show("thim da xoa that bai");
            }
        }
    }
}
