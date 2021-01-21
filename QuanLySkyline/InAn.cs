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
using Microsoft.Reporting.WinForms;
using QuanLySkyline.Controls;

namespace QuanLySkyline
{
    public partial class InAn : Form
    {
        public InAn()
        {
            InitializeComponent();
            txtMaHoaDon.Text = BanHangUserControl1.maHD.ToString();
            try
            {
                //txtMaHoaDon.Text = BanHangUserControl1.maHD.ToString();

                this.reportViewer1.LocalReport.DataSources.Clear();
                DuLieuHoaDon();
                DuLieuTenBan();
                DuLieuTongTien();
                this.reportViewer1.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Nhập sai kiểu dữ liệu !!!");
            }
        }

        private void InAn_Load(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = BanHangUserControl1.maHD.ToString();
            try
            {
                //txtMaHoaDon.Text = BanHangUserControl1.maHD.ToString();

                this.reportViewer1.LocalReport.DataSources.Clear();
                DuLieuHoaDon();
                DuLieuTenBan();
                DuLieuTongTien();
                this.reportViewer1.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Nhập sai kiểu dữ liệu !!!");
            }


        }
        SqlConnection conn = null;
        string sqlconn = @"server=DESKTOP-JRFV3IL\SQLEXPRESS;Database=QLCAFE;Integrated security=true";
        
        public void DuLieuHoaDon()
        {
           
                conn = new SqlConnection(sqlconn);
                SqlCommand command = new SqlCommand();

                SqlDataAdapter adapter = new SqlDataAdapter("select MON.TenMon,CHITIETHD.SoLuong,MON.DonGia, sum(MON.DonGia*CHITIETHD.SoLuong) as SoTien from HOADON, CHITIETHD, MON where HOADON.MaHoaDon = CHITIETHD.MaHoaDon and CHITIETHD.MaMon = MON.MaMon and HOADON.MaHoaDon = '" + txtMaHoaDon.Text + "' GROUP BY MON.TenMon, CHITIETHD.SoLuong, MON.DonGia", conn);
                DataSet ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds, "HoaDon");
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySkyline.ReportHoaDon.rdlc";
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ds.Tables[0];
                this.reportViewer1.LocalReport.DataSources.Add(rds);
        } 
           
        

        public void DuLieuTenBan()
        {
            
                conn = new SqlConnection(sqlconn);
                SqlCommand command = new SqlCommand();

                SqlDataAdapter adapter = new SqlDataAdapter("select TenBan from HOADON ,BAN where HOADON.MaBan=BAN.MaBan  and HOADON.MaHoaDon = '" + txtMaHoaDon.Text + "'", conn);
                DataSet ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds, "MaHoaDon");
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySkyline.ReportHoaDon.rdlc";
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet2";
                rds.Value = ds.Tables[0];
                this.reportViewer1.LocalReport.DataSources.Add(rds);
            
            

        }
        public void DuLieuTongTien()
        {
           

                conn = new SqlConnection(sqlconn);
                SqlCommand command = new SqlCommand();

                SqlDataAdapter adapter = new SqlDataAdapter("select TongTien from HOADON where HOADON.MaHoaDon = '" + txtMaHoaDon.Text + "'", conn);
                DataSet ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds, "TienHoaDon");
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySkyline.ReportHoaDon.rdlc";
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet3";
                rds.Value = ds.Tables[0];
                this.reportViewer1.LocalReport.DataSources.Add(rds);
           

        
         }

        private void btnInAn_Click(object sender, EventArgs e)
        {
            //txtMaHoaDon.Text = BanHangUserControl1.maHD.ToString();
            //try
            //{
            //    //txtMaHoaDon.Text = BanHangUserControl1.maHD.ToString();

            //    this.reportViewer1.LocalReport.DataSources.Clear();
            //    DuLieuHoaDon();
            //    DuLieuTenBan();
            //    DuLieuTongTien();
            //    this.reportViewer1.RefreshReport();
            //}
            //catch
            //{
            //    MessageBox.Show("Nhập sai kiểu dữ liệu !!!");
            //}
        }
    }
}

