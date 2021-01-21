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

namespace QuanLySkyline.Controls
{
    public partial class ThongKeUserControl1 : UserControl
    {
        public ThongKeUserControl1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string sqlconn = @"Data source = DESKTOP-JRFV3IL\SQLEXPRESS;Initial Catalog=QLCAFE;Integrated Security=SSPI";
        private void ThongKeUserControl1_Load(object sender, EventArgs e)
        {
           
        }

        public void ThongKeTheoHoaDon()
        {
           
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string date1 = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string date2 = dateTimePicker2.Value.ToString("dd/MM/yyyy");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select HOADON.MaHoaDon ,HOADON.GioDen,TenBan,HOADON.TongTien from BAN, HOADON where BAN.MaBan = HOADON.MaBan and HOADON.TrangThai = 1 and (HOADON.GioDen  Between Convert(Datetime, '" + date1+"', 105) And Convert(Datetime, '"+date2+"', 105))";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            lvThongKeTheoHoaDon.Items.Clear();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetValue(0) + "");
                liv.SubItems.Add(reader.GetValue(1) + "");
                liv.SubItems.Add(reader.GetValue(2) + "");
                liv.SubItems.Add(Convert.ToDecimal(reader.GetValue(3) + "").ToString("#,##0.00"));
                lvThongKeTheoHoaDon.Items.Add(liv);
            }
            reader.Close();
        }


        public void ThongKeTheoMon()
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string date1 = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string date2 = dateTimePicker2.Value.ToString("dd/MM/yyyy");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select mon.tenmon,mon.dvt, sum(chitiethd.soluong),sum(mon.dongia*chitiethd.soluong) from mon, chitiethd, hoadon where mon.mamon = chitiethd.mamon and chitiethd.mahoadon = hoadon.mahoadon and hoadon.trangthai=1 and(hoadon.gioden  between convert(datetime, '" + date1 + "', 105) and convert(datetime, '" + date2 + "', 105)) group by  mon.tenmon ,mon.dvt";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            lvThongKeTheoMon.Items.Clear();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetValue(0) + "");
                liv.SubItems.Add(reader.GetValue(1) + "");
                liv.SubItems.Add(reader.GetValue(2) + "");
                liv.SubItems.Add(Convert.ToDecimal(reader.GetValue(3) + "").ToString("#,##0.00"));
                lvThongKeTheoMon.Items.Add(liv);
            }
            reader.Close();

 
        }

        public void Tinhtongtienthuve()
        {
            
                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string date1 = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                string date2 = dateTimePicker2.Value.ToString("dd/MM/yyyy");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select Sum(MON.DonGia*CHITIETHD.SoLuong)  from MON, CHITIETHD, HOADON where MON.MaMon = CHITIETHD.MaMon and CHITIETHD.MaHoaDon = HOADON.MaHoaDon and(HOADON.GioDen  Between Convert(Datetime, '" + date1 + "', 105) And Convert(Datetime, '" + date2 + "', 105)) and HOADON.TrangThai = 1";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            lvThongKeTheoMon.Items.Clear();
            while (reader.Read())
            {
                if ((reader.GetValue(0) + "") == "")
                {
                    lbTongTien.Text = "0";

                }
                else
                    lbTongTien.Text = Convert.ToDecimal(reader.GetValue(0) + "").ToString("#,##0.00") + " " + "vnđ";
            }
            reader.Close();
        }
           
        



        
        public void TongSoHoaDonDaThanhToan()
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string date1 = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string date2 = dateTimePicker2.Value.ToString("dd/MM/yyyy");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select count(*) from hoadon where (hoadon.gioden  between convert(datetime, '" + date1 + "',105) and convert(datetime,'" + date2 + "',105) ) and trangthai = 1 ";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            lvThongKeTheoMon.Items.Clear();
            while (reader.Read())
            {
                lbTongSHDTT.Text = reader.GetValue(0) + "" + "  " + "hóa đơn";
            }
            reader.Close();

        }
        public void TongSoMonDaBan()
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string date1 = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string date2 = dateTimePicker2.Value.ToString("dd/MM/yyyy");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select count(mon.mamon) from mon, chitiethd, hoadon where mon.mamon = chitiethd.mamon and chitiethd.mahoadon = hoadon.mahoadon and(hoadon.gioden  between convert(datetime, '" + date1 + "', 105) and convert(datetime, '" + date2 + "', 105)) and hoadon.trangthai = 1 ";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            lvThongKeTheoMon.Items.Clear();
            while (reader.Read())
            {
                lbTongSMDB.Text = reader.GetValue(0) + "" + "  " + "món";
            }
            reader.Close();

        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            TongSoMonDaBan();
            TongSoHoaDonDaThanhToan();
            Tinhtongtienthuve();
            ThongKeTheoHoaDon();
            ThongKeTheoMon();
          
        }

        private void lvThongKeTheoHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvThongKeTheoHoaDon.SelectedItems.Count == 0) return;

            ListViewItem liv = lvThongKeTheoHoaDon.SelectedItems[0];
            string ma = liv.SubItems[0].Text;
            HienThiChiTietHoaDon(ma);
        }
        public void HienThiChiTietHoaDon(string MA)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select MON.TenMon,CHITIETHD.SoLuong,MON.DonGia from HOADON, CHITIETHD, MON where HOADON.MaHoaDon = CHITIETHD.MaHoaDon and CHITIETHD.MaMon = MON.MaMon and HOADON.MaHoaDon ='"+MA+"'";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            lvChiTietHoaDon.Items.Clear();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetValue(0) + "");
                liv.SubItems.Add(reader.GetValue(1) + "");               
                liv.SubItems.Add(Convert.ToDecimal(reader.GetValue(2) + "").ToString("#,##0.00"));
                lvChiTietHoaDon.Items.Add(liv);
            }
            reader.Close();
        }
    }
}
