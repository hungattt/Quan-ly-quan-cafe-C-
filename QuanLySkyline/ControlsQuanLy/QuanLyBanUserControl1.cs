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
    public partial class QuanLyBanUserControl1 : UserControl
    {
        public QuanLyBanUserControl1()
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
                conn.Open();
            adapter = new SqlDataAdapter("select * from BAN", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "ban");
        }

        public void HienThiBan()
        {
            TaoBuilder();
            dataGridViewBan.DataSource = ds.Tables["ban"];
        }
        private void QuanLyBanUserControl1_Load(object sender, EventArgs e)
        {
            HienThiBan();
            TaoTrangThai();
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dataGridViewBan.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dataGridViewBan.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi);
            if (chuoi2 + 1 < 10)
                txtMaBan.Text = (chuoi2 + 1).ToString();
            else if (chuoi2 + 1 < 100)
                txtMaBan.Text = (chuoi2 + 1).ToString();
            try
            {
                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "Insert into BAN VALUES('" + txtMaBan.Text + "', N'" + txtTenBan.Text + "', '" +cbxTrangThai.Text + "')";

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = conn;

                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    HienThiBan();
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
        int idx = -1;
        public void TaoTrangThai()
        {
            adapter = new SqlDataAdapter("select DISTINCT TrangThai from BAN", conn);
            ds = new DataSet();
            adapter.Fill(ds, "trangthai");

            cbxTrangThai.DataSource = ds.Tables["trangthai"];
           
            cbxTrangThai.ValueMember = "TrangThai";
        }
        private void dataGridViewBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            if (idx >= 0)
            {

                txtMaBan.Text = dataGridViewBan.Rows[idx].Cells["MaBan"].Value.ToString();
                txtTenBan.Text = dataGridViewBan.Rows[idx].Cells["TenBan"].Value.ToString();
                cbxTrangThai.SelectedValue = dataGridViewBan.Rows[idx].Cells["TrangThai"].Value.ToString();
                
            }
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "Update BAN set TenBan = N'" + txtTenBan.Text + "',TrangThai=N'" + cbxTrangThai.SelectedValue.ToString() + "' where MaBan = '" + txtMaBan.Text + "'";

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = conn;
                int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
                if (ret > 0)
                {
                    HienThiBan();
                    MessageBox.Show("thim da cap nhat thanh cong ");

                }
                else
                {
                    MessageBox.Show("thim da cap nhat that bai");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ban nhap sai kieu du lieu !!!");
            }
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = "Delete from BAN where MaBan = '" + txtMaBan.Text + "'";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
            if (ret > 0)
            {
                HienThiBan();
                MessageBox.Show("thim da xoa thanh cong ");

            }
            else
            {
                MessageBox.Show("thim da xoa that bai");
            }
        }

        private void btnTimKiemBan_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = "select * from BAN where TenBan LIKE N'%" + txtTimKiemBan.Text + "%' ";

            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "ban");
            dataGridViewBan.DataSource = ds.Tables["ban"];
        }
    }
}
