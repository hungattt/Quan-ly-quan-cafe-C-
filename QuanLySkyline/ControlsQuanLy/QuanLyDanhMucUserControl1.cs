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
    public partial class QuanLyDanhMucUserControl1 : UserControl
    {
        public QuanLyDanhMucUserControl1()
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
            adapter = new SqlDataAdapter("select * from DANHMUC", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "danhmuc");
        }

        public void HienThiDanhMuc()
        {
            TaoBuilder();
            dataGridViewDanhMuc.DataSource = ds.Tables["danhmuc"];
        }
        private void txtTimKiemDanhMuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuanLyDanhMucUserControl1_Load(object sender, EventArgs e)
        {
            HienThiDanhMuc();
        }

        private void btThemDM_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dataGridViewDanhMuc.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;    
            chuoi = Convert.ToString(dataGridViewDanhMuc.Rows[count-2].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi);
            if (chuoi2 + 1 < 10)
                txtMaDM.Text = (chuoi2 + 1).ToString();
            else if(chuoi2 +1<100)
                txtMaDM.Text = (chuoi2 + 1).ToString();
            try
            {
                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "Insert into DANHMUC(MaDM,TenDM,MauSac) VALUES('" + txtMaDM.Text + "', N'" + txtTenDM.Text + "',N'"+null + "')";

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = conn;

                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    HienThiDanhMuc();
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
        private void dataGridViewDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            
            if (idx >= 0)
            {

                txtMaDM.Text = dataGridViewDanhMuc.Rows[idx].Cells["MaDM"].Value.ToString();
                txtTenDM.Text = dataGridViewDanhMuc.Rows[idx].Cells["TenDM"].Value.ToString();
                
            }
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = "Delete from DANHMUC where MaDM = '" + txtMaDM.Text + "'";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
            if (ret > 0)
            {
                HienThiDanhMuc();
                MessageBox.Show("thim da xoa thanh cong ");

            }
            else
            {
                MessageBox.Show("thim da xoa that bai");
            }
        }

        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "Update DANHMUC set TenDM = N'" + txtTenDM.Text + "' where MaDM = '" + txtMaDM.Text + "'";

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = conn;
                int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
                if (ret > 0)
                {
                    HienThiDanhMuc();
                    MessageBox.Show("thim da cap nhat thanh cong ");

                }
                else
                {
                    MessageBox.Show("thim da cap nhat that bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ban nhap sai kieu du lieu !!!");
            }
        }

        private void bntTimKiemDM_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = "select * from DANHMUC where TenDM LIKE N'%" + txtTimKiemDanhMuc.Text + "%' ";

            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "danhmuc");
            dataGridViewDanhMuc.DataSource = ds.Tables["danhmuc"];
        }
    }
}
