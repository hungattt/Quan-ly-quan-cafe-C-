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
using System.Runtime.Serialization.Formatters;


namespace QuanLySkyline.ControlsQuanLy
{
    public partial class QuanLyMonUserControl1 : UserControl
    {
        public QuanLyMonUserControl1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string sqlconn= @"Data source = DESKTOP-JRFV3IL\SQLEXPRESS;Initial Catalog=QLCAFE;Integrated Security=SSPI";
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
            adapter = new SqlDataAdapter("select * from MON", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "mon");
        }

        public void HienThiMon()
        {
            TaoBuilder();
            dataGridViewMon.DataSource = ds.Tables["mon"];
           
        }
        bool finished = false;
        public void TaoCombboxTimKiem()
        {
            adapter = new SqlDataAdapter("select MaDM,TenDM from DANHMUC", conn);
            ds = new DataSet();
            adapter.Fill(ds, "madm");
            finished = false;
            CbxDMTimKiem.DataSource = ds.Tables["madm"];
            CbxDMTimKiem.DisplayMember = "TenDM";
            CbxDMTimKiem.ValueMember = "MaDm";
            finished = true;
        }
       
        public void TaoMaDM()
        {
            adapter = new SqlDataAdapter("select MaDM,TenDM from DANHMUC", conn);
            ds = new DataSet();
            adapter.Fill(ds, "madm");
            
            cbxDanhMuc.DataSource = ds.Tables["madm"];
            cbxDanhMuc.DisplayMember = "TenDM";
            cbxDanhMuc.ValueMember = "MaDm";
           
        }
        private void QuanLyMonUserControl1_Load(object sender, EventArgs e)
        {
            HienThiMon();
            TaoMaDM();
            TaoCombboxTimKiem();
        }
       
        int idx = -1;
       
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dataGridViewMon.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dataGridViewMon.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi);
            if (chuoi2 + 1 < 10)
                txtMaMon.Text = (chuoi2 + 1).ToString();
            else if (chuoi2 + 1 < 100)
                txtMaMon.Text = (chuoi2 + 1).ToString();
            try
            {
                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "Insert into MON (MaMon,TenMon,MaDM,DonGia,DVT)VALUES('" + txtMaMon.Text + "', N'" + txtTenMon.Text + "', '" + cbxDanhMuc.SelectedValue.ToString() + "', " + txtDonGia.Text + ",'" + txtDonViTinh.Text + "')";

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = conn;

                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    HienThiMon();
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



        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "Update MON set TenMon = N'" + txtTenMon.Text + "', MaDM = '" + cbxDanhMuc.SelectedValue.ToString() + "', DonGia = '" + txtDonGia.Text + "', DVT = '" + txtDonViTinh.Text + "' where MaMon = '" + txtMaMon.Text + "'";

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = conn;
                int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
                if (ret > 0)
                {
                    HienThiMon();
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
        

        private void CbxDMTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxDMTimKiem.SelectedIndex == -1) return;
            if (finished == false) return;

            string madm = CbxDMTimKiem.SelectedValue.ToString();

            adapter = new SqlDataAdapter("Select * from MON where MaDM=" + madm, conn);
            ds = new DataSet();
            adapter.Fill(ds, "mon");

            dataGridViewMon.DataSource = ds.Tables["mon"];
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = "Delete from MON where MaMon = '" + txtMaMon.Text + "'";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
            if (ret > 0)
            {
                HienThiMon();
                MessageBox.Show("thim da xoa thanh cong ");

            }
            else
            {
                MessageBox.Show("thim da xoa that bai");
            }
        }

        private void btnTimTen_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = "select * from MON where TenMon LIKE N'%" + txtTimTheoTen.Text + "%' ";

            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "mon");
            dataGridViewMon.DataSource = ds.Tables["mon"];
        }

        private void dataGridViewMon_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                idx = e.RowIndex;
                if (idx >= 0)
                {

                    txtMaMon.Text = dataGridViewMon.Rows[idx].Cells["MaMon"].Value.ToString();
                    txtTenMon.Text = dataGridViewMon.Rows[idx].Cells["TenMon"].Value.ToString();
                    cbxDanhMuc.SelectedValue = dataGridViewMon.Rows[idx].Cells["MaDM"].Value.ToString();

                    //adapter = new SqlDataAdapter("select TenDM from DANHMUC where MaDM='" + dataGridViewMon.Rows[idx].Cells["MaDM"].Value.ToString() + "" + "' ", conn);
                    //ds = new DataSet();
                    //adapter.Fill(ds, "tendm");
                    //cbxDanhMuc.DataSource = ds.Tables["tendm"];
                    //cbxDanhMuc.DisplayMember = "TenDM";

                    txtDonGia.Text = dataGridViewMon.Rows[idx].Cells["DonGia"].Value.ToString();
                    txtDonViTinh.Text = dataGridViewMon.Rows[idx].Cells["DVT"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("chon sai muc");
            }
        }
    }
}
