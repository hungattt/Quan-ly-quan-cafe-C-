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
using QuanLySkyline.Model;
using System.Security.Cryptography;
using System.Globalization;

namespace QuanLySkyline.Controls
{
    public partial class BanHangUserControl1 : UserControl
    {
        private static LinkedListCafe<BAN> cSDL_BAN = new LinkedListCafe<BAN>();
        private static LinkedListCafe<DANHMUC> cSDL_DANHMUC = new LinkedListCafe<DANHMUC>();
        private static LinkedListCafe<MON> cSDL_MON = new LinkedListCafe<MON>();
        private static LinkedListCafe<MONOFBAN> cSDL_MONOFBAN = new LinkedListCafe<MONOFBAN>();
        private static LinkedListCafe<HOADON> cSDL_MAHOADON = new LinkedListCafe<HOADON>();

        public BanHangUserControl1()
        {
            InitializeComponent();
            NapDaTaBan();
            LoadListButtonBan();
            NapDaTaDanhMuc();
            LoadListButtonDanhMuc();
            btnThanhToan.Enabled = false;// moi them vao 
            btnDatCho.Enabled = false;// moi them vao 
            btnThemMon.Enabled = false;// moi them vao 
            btnSuaMon.Enabled = false;// moi them vao 
            btnXoaMon.Enabled = false;// moi them vao 
            txtSoLuong.Enabled = false;// moi them vao 
        }
        SqlConnection conn = null;
        string sqlconn = @"Data source = DESKTOP-JRFV3IL\SQLEXPRESS;Initial Catalog=QLCAFE;Integrated Security=SSPI";

        internal static LinkedListCafe<BAN> CSDL_BAN { get => cSDL_BAN; set => cSDL_BAN = value; }
        internal static LinkedListCafe<DANHMUC> CSDL_DANHMUC { get => cSDL_DANHMUC; set => cSDL_DANHMUC = value; }
        internal static LinkedListCafe<MON> CSDL_MON { get => cSDL_MON; set => cSDL_MON = value; }
        internal static LinkedListCafe<MONOFBAN> CSDL_MONOFBAN { get => cSDL_MONOFBAN; set => cSDL_MONOFBAN = value; }
        internal static LinkedListCafe<HOADON> CSDL_MAHOADON { get => cSDL_MAHOADON; set => cSDL_MAHOADON = value; }
        private void BanHangUserControl1_Load(object sender, EventArgs e)
        {
           
           // NapDaTaBan();
           //LoadListButtonBan();
           // NapDaTaDanhMuc();
           //LoadListButtonDanhMuc();
            

        }
        
        //---------------------------------------------BAN------------------------------------------------
        public void NapDaTaBan()
        {
            // SanPham x = new SanPham();
            CSDL_BAN.deleteAll();

            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select *from BAN ";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                BAN x = new BAN();

                x.MaBan = int.Parse(reader.GetValue(0) + "");
                x.TenBan = reader.GetValue(1) + "";
                x.TrangThai = reader.GetValue(2) + "";
               
                CSDL_BAN.AddHead(x);

            }
            //CSDL_SP01.AddHead(x);
            reader.Close();
        }

        
        void LoadListButtonBan()
        {
            flpTable.Controls.Clear();

          

            LinkedListCafe<BAN>.Node NodeBan = CSDL_BAN.pHead;

            while (NodeBan != null)
            {
                Button btn = new Button() { Width = 70, Height =50 };
                btn.Text = NodeBan.data.TenBan + Environment.NewLine + NodeBan.data.TrangThai;
               btn.Click += btnBAN_Click;
                btn.Tag = NodeBan.data.MaBan;
                

                switch (NodeBan.data.TrangThai)
                {
                    case "Trong":
                        btn.BackColor = Color.Green;
                        break;
                    case "Dang phuc vu":
                        btn.BackColor = Color.Pink;
                        break;
                    case "Da dat truoc":
                        btn.BackColor = Color.Blue;
                        break;
                }

                flpTable.Controls.Add(btn);
                NodeBan = NodeBan.pNext;
            }
        }
        
        public void HienThiMaHoaDon(int MaBan)
        {
            lbMaRaDom.Text = "";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select MaHoaDon from BAN ,HOADON where BAN.MaBan=HOADON.MaBan and   HOADON.MaBan='" + MaBan + "' and HOADON.TrangThai=0 ";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lbMaRaDom.Text = (reader.GetValue(0) + "");
                
            }

            reader.Close();
        }
        void btnBAN_Click(object sender, EventArgs e)
        {
            int banID = int.Parse((sender as Button).Tag.ToString());
            //flpMon.Tag = (sender as Button).Tag;          
            NapDaTaLISTMon(banID);
            HienThiTenBanMaBan(banID);
            HienThiMaHoaDon(banID);
            TinhTongTienHoaDonHienTai();
            capnhatphucvuthanhtrong();
            lbMaCTHD.Text = "";
            //btnThemMon.Enabled = true;// moi them vao
           // btnDatCho.Enabled = true;// moi them vao 
            LamMoiNhapLieu();// moi them vao 
        }

        public void HienThiTenBanMaBan(int MaBan)
        {
            //if (conn == null)
            //    conn = new SqlConnection(sqlconn);
            //if (conn.State == ConnectionState.Closed)
            //    conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select TenBan ,MaBan,TrangThai from BAN where MaBan='"+MaBan+"' ";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            { 
                    lbBan.Text =(reader.GetValue(0) + "");
                    lbMaBan.Text= (reader.GetValue(1) + "");
                    lbTrangThai.Text= (reader.GetValue(2) + "");
            }
            
            reader.Close();
        }
        //------------------------------------DANH MUC------------------------------------------------
        public void NapDaTaDanhMuc()
        {
            // SanPham x = new SanPham();
            CSDL_DANHMUC.deleteAll();
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select *from DANHMUC ";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();



            while (reader.Read())
            {
                DANHMUC m = new DANHMUC();

                m.MaDM = int.Parse(reader.GetValue(0) + "");
                m.TenDM = reader.GetValue(1) + "";
                m.MauSac = reader.GetValue(2) + "";

                CSDL_DANHMUC.AddHead(m);

            }
            //CSDL_SP01.AddHead(x);
            reader.Close();
        }

        void LoadListButtonDanhMuc()
        {
            flpDanhMuc.Controls.Clear();
            LinkedListCafe<DANHMUC>.Node NodeDM = CSDL_DANHMUC.pHead;

            while (NodeDM != null)
            {
                Button btn = new Button() { Width = 70, Height = 50 };
                btn.Text = NodeDM.data.TenDM;//+ Environment.NewLine + NodeDM.data.TrangThai;
                btn.Click += btnDANHMUC_Click;
                btn.Tag = NodeDM.data.MaDM;
                flpDanhMuc.Controls.Add(btn);
                NodeDM = NodeDM.pNext;
            }
        }
        void btnDANHMUC_Click(object sender, EventArgs e)
        {
            int danhmucID = int.Parse( (sender as Button).Tag.ToString());
           // flpMon.Tag = (sender as Button).Tag;
            NapDaTaMon(danhmucID);
        }

        //------------------------------------------------MON---------------------------------------------------------------------

        public void NapDaTaMon(int maDM)
        {
            CSDL_MON.deleteAll();
            // SanPham x = new SanPham();

            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select *from MON where MaDM='"+maDM+"' ";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();



            while (reader.Read())
            {
                MON m = new MON();

                m.MaMon = int.Parse(reader.GetValue(0) + "");
                m.TenMon = reader.GetValue(1) + "";
                m.MaDM = int.Parse(reader.GetValue(2) + "");
                m.DonGia= int.Parse(reader.GetValue(3) + "");
                m.DVT = reader.GetValue(4) + "";

                CSDL_MON.AddHead(m);

            }
            //CSDL_SP01.AddHead(x);
            reader.Close();
            LoadListButtonMon();
        }

        void LoadListButtonMon()
        {
            flpMon.Controls.Clear();



            LinkedListCafe<MON>.Node NodeMon = CSDL_MON.pHead;

            while (NodeMon != null)
            {
                Button btn = new Button() { Width = 70, Height = 50 };
                btn.Text = NodeMon.data.TenMon+ Environment.NewLine + NodeMon.data.DonGia+ "/"+ NodeMon.data.DVT;
                btn.Click += btnLoadBanLenText_Click;
                btn.Tag = NodeMon.data.MaMon;


                flpMon.Controls.Add(btn);
                NodeMon = NodeMon.pNext;
            }
        }

       

        //-----------------------------------------------Hien thi LIST mon goi---------------------------------------------------------------

        public void NapDaTaLISTMon(int maBAN)
        {
            try
            {
                CSDL_MONOFBAN.deleteAll();
                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select CHITIETHD.MaChiTietHD,MON.TenMon,CHITIETHD.Gia,MON.DVT,BAN.TenBan ,CHITIETHD.SoLuong from MON, HOADON, CHITIETHD, BAN where MON.MaMon = CHITIETHD.MaMon and CHITIETHD.MaHoaDon = HOADON.MaHoaDon and BAN.MaBan = HOADON.MaBan and HOADON.MaBan = '" + maBAN + "' and HOADON.TrangThai = 0";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();

               // if (reader.GetValue(0)+"" != null)
                {    //btnDatCho.Enabled = false;
                    while (reader.Read())
                    {
                        
                            MONOFBAN m = new MONOFBAN();

                            m.MaChiTietHD = int.Parse(reader.GetValue(0) + "");
                            m.TenMon = (reader.GetValue(1) + "");
                            m.DonGia = int.Parse(reader.GetValue(2) + "");
                            m.DVT = reader.GetValue(3) + "";
                            m.TenBan = (reader.GetValue(4) + "");
                            m.SoLuong = int.Parse(reader.GetValue(5) + "");

                            CSDL_MONOFBAN.AddHead(m);
                        
                    
                    }
                }             
                   // btnDatCho.Enabled = true; 
                
                reader.Close();
                LoadListButtonMonOfBan();
                //CSDL_MONOFBAN.deleteAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadListButtonMonOfBan()
        {
            flpMonOfBan.Controls.Clear();
            LinkedListCafe<MONOFBAN>.Node NodeMonOfBan = CSDL_MONOFBAN.pHead;

            while (NodeMonOfBan != null)
            {
                Button btn = new Button() { Width = 75, Height = 60 };
                btn.Text = NodeMonOfBan.data.TenMon + Environment.NewLine + NodeMonOfBan.data.DonGia + "/" + NodeMonOfBan.data.DVT + Environment.NewLine +"SL="+ NodeMonOfBan.data.SoLuong;
                btn.Click += btnMON123_Click;
                btn.Tag = NodeMonOfBan.data.MaChiTietHD;

                flpMonOfBan.Controls.Add(btn);
                NodeMonOfBan = NodeMonOfBan.pNext;
            }
            
        }
        //---------------------Hien Thi Thong Tin CHI TIET HOA DON ------------------------------
        void btnMON123_Click(object sender, EventArgs e)
        {
            txtSoLuong.Enabled = true;//moi them vao
            btnXoaMon.Enabled = true;//moi them vao
            btnSuaMon.Enabled = true;// moi them vao
            
            int cthdID = int.Parse((sender as Button).Tag.ToString());
            HienThiKhibtnMON123_Click(cthdID);
        }

        public void HienThiKhibtnMON123_Click(int MaCTHD)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select MON.MaMon,MON.TenMon,CHITIETHD.Gia, CHITIETHD.SoLuong ,CHITIETHD.MaChiTietHD from MON,  CHITIETHD where MON.MaMon = CHITIETHD.MaMon  and CHITIETHD.MaChiTietHD = '" + MaCTHD + "'";
            command.Connection = conn; 
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                MON m = new MON();

                txtMaMon.Text = reader.GetValue(0) + "";
                txtTenMon.Text = reader.GetValue(1) + "";
                txtDonGia.Text = reader.GetValue(2) + "";
                txtSoLuong.Text = (reader.GetValue(3) + "");
                lbMaCTHD.Text = (reader.GetValue(4) + "");
            }
            //CSDL_SP01.AddHead(x);
            reader.Close();
        }

        //---------------------END Hien Thi Thong Tin CHI TIET HOA DON ------------------------------

        void btnLoadBanLenText_Click(object sender, EventArgs e)
        {
            if (lbMaBan.Text == "...")
            {
                btnThemMon.Enabled = false;//moi them vao
            }
            else
            {
                btnThemMon.Enabled = true;
            }
            txtSoLuong.Enabled = true;//moi them vao
            
            int monID = int.Parse((sender as Button).Tag.ToString());
            NapDaTaMonLenTex(monID);
        }

       
        //----------------------------------------------------------Load Len TEXT BAN -------------------------------------------------------------------------------

        public void NapDaTaMonLenTex(int MaMon)
        {
            lbMaCTHD.Text = "";
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select *from MON where MaMon='" +MaMon+ "' ";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               
                txtMaMon.Text = reader.GetValue(0) + "";
                txtTenMon.Text = reader.GetValue(1) + "";
                txtDonGia.Text=reader.GetValue(3) + "";
            }
            reader.Close();
        }
        

        private void btnDatCho_Click(object sender, EventArgs e)
        {
            try
            {

                switch (lbTrangThai.Text)
                {
                    case "Trong":
                        lbTrangThai.Text = "Da dat truoc";
                        break;
                    case "Da dat truoc":
                        lbTrangThai.Text = "Trong";
                        break;
                    case "Dang phuc vu":
                        lbTrangThai.Text = "Trong";
                        break;
                }


                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "CapNhatTrangThaiBanTheoMaBan";
                command.Connection = conn;

                command.Parameters.Add("@maban", SqlDbType.Int).Value = int.Parse(lbMaBan.Text);
                command.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = lbTrangThai.Text;
                int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
                if (ret > 0)
                {
                    NapDaTaBan();
                    LoadListButtonBan();
                    MessageBox.Show("thim da cap nhat thanh cong ");

                }
                else
                {
                    MessageBox.Show("thim da cap nhat that bai");
                }

                XoaHoaDonKhiKhongConMon();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bạn chưa chọn bàn nào !!!");
            }
        }

        
        
        int number;
        public int TaoMaHoaDon()
        {

            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            //SqlCommand comm = new SqlCommand();
            //comm.CommandType = CommandType.Text;
            //comm.CommandText = "select MaHoaDon from HOADON ";
            //comm.Connection = conn;

            //SqlDataReader reader = comm.ExecuteReader();
            //while (reader.Read())
            //{
            //    int MaHOADONTUSINH;
            //    Random rd = new Random();
            //    number = rd.Next(1, 1000);
            //     HOADON x = new HOADON();
            //     x.MaHD = int.Parse(reader.GetValue(0) + "");
            //    if (number != int.Parse(reader.GetValue(0) + ""))
            //    {
            //        return number;

            //    }
            //    break;
            //}

            //reader.Close();
            //conn.Close();

            //return number;
           
            

                using (SqlCommand cmd = new SqlCommand("select MaHoaDon from HOADON", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {                             
                                Random rd = new Random();
                                number = rd.Next(1, 1000);
                                
                                if (number != int.Parse(reader.GetValue(0) + ""))
                                {
                                // return number;
                                    break;

                                }
                           
                            }
                            
                        }
                        reader.Close();
                    }
                   
                } // command disposed here
                
               // conn.Close();

                return number;

            //connection closed and disposed here



        }

        public int TaoMaChiTietHoaDon()
        {

            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            using (SqlCommand cmd = new SqlCommand("select MaChiTietHD from ChiTietHD", conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            Random rd = new Random();
                            number = rd.Next(1, 1000);

                            if (number != int.Parse(reader.GetValue(0) + ""))
                            {
                                return number;

                            }

                        }

                    }
                    reader.Close();
                }

            } // command disposed here

            conn.Close();

            return number;

            //connection closed and disposed here



        }



        public void UpdatTrangThaiKhiGoiMon()
        {
            switch (lbTrangThai.Text)
            {
                case "Trong":
                    lbTrangThai.Text = "Dang phuc vu";
                    break;
                case "Da dat truoc":
                    lbTrangThai.Text = "Dang phuc vu";
                    break;
            }

            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "CapNhatTrangThaiBanTheoMaBan";
            command.Connection = conn;

            command.Parameters.Add("@maban", SqlDbType.Int).Value = int.Parse(lbMaBan.Text);
            command.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = lbTrangThai.Text;
            int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
            if (ret > 0)
            {
                NapDaTaBan();
                LoadListButtonBan();
                MessageBox.Show("Da cho phep goi mon !!!! ");

            }
            else
            {
                MessageBox.Show("thim da cap nhat that bai");
            }

        }
        //------------------------------Loa List mon khi Click btn Them Mon----------------

        public void NapDaTaLISTMon1(int maBAN)
        {
            try
            {
                CSDL_MONOFBAN.deleteAll();
                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select MON.TenMon,MON.DonGia,MON.DVT,BAN.TenBan ,CHITIETHD.SoLuong from MON, HOADON, CHITIETHD, BAN where MON.MaMon = CHITIETHD.MaMon and CHITIETHD.MaHoaDon = HOADON.MaHoaDon and BAN.MaBan = HOADON.MaBan and HOADON.MaBan = '" + maBAN + "' and HOADON.TrangThai = 0";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                // while (true)
                {
                    //if (reader.Read())
                    {
                        //btnDatCho.Enabled = false;
                        while (reader.Read())
                        {
                            MONOFBAN m = new MONOFBAN();

                            m.TenMon = (reader.GetValue(0) + "");
                            m.DonGia = int.Parse(reader.GetValue(1) + "");
                            m.DVT = reader.GetValue(2) + "";
                            m.TenBan = (reader.GetValue(3) + "");
                            m.SoLuong = int.Parse(reader.GetValue(4) + "");

                            CSDL_MONOFBAN.AddHead(m);
                        }

                    }
                   // else
                    {
                        //btnDatCho.Enabled = true;
                    }
                    // break;
                }
                reader.Close();
                LoadListButtonMonOfBan1();
                //CSDL_MONOFBAN.deleteAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadListButtonMonOfBan1()
        {
            flpMonOfBan.Controls.Clear();
            LinkedListCafe<MONOFBAN>.Node NodeMonOfBan = CSDL_MONOFBAN.pHead;

            while (NodeMonOfBan != null)
            {
                Button btn = new Button() { Width = 73, Height = 50 };
                btn.Text = NodeMonOfBan.data.TenMon + Environment.NewLine + NodeMonOfBan.data.DonGia + "/" + NodeMonOfBan.data.DVT + Environment.NewLine + "SL=" + NodeMonOfBan.data.SoLuong;
                // btn.Click += btnLoadBanLenText_Click;
                // btn.Tag = NodeMonOfBan.data.MaBan;

                flpMonOfBan.Controls.Add(btn);
                NodeMonOfBan = NodeMonOfBan.pNext;
            }

        }
        //-----------------------------------Lam Moi O NHap Lieu

        public void LamMoiNhapLieu()
        {
            txtMaMon.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtTenMon.Text = "";
           
        }

        //--------------------------------------------------THÊM MÓN ------------------------------------------------------

        public void TaoMoiVaUpDateCTHD()
        {
            try
            {
                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "insert into CHITIETHD (MaCHiTietHD,MaHoaDon,MaMon,SoLuong,Gia) values ( '" + TaoMaChiTietHoaDon().ToString() + "' ,'" + lbMaRaDom.Text + "','" +txtMaMon.Text+ "', '" + txtSoLuong.Text + "','" + txtDonGia.Text + "')";

               // string query = "insert into CHITIETHD (MaCHiTietHD,MaHoaDon,MaMon,SoLuong,Gia) values ( '" + TaoMaChiTietHoaDon().ToString() + "' ,'" + TaoMaHoaDon().ToString()+ "','" + txtMaMon.Text + "', '" + txtSoLuong.Text + "','" + txtDonGia.Text + "')";


                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = conn;

                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    NapDaTaLISTMon1(int.Parse(lbMaBan.Text));
                    MessageBox.Show("thim da them thanh cong ");
                    //LamMoiNhapLieu();
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
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            try
            {
                string giohientai;
                DateTime aDateTime = DateTime.Now;
                giohientai = aDateTime.ToString("yyyy/M/d HH:mm:ss");


                //lbMaRaDom.Text = TaoMaHoaDon().ToString();
                 if (conn == null)
                     conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "Select Count(MaHoaDon) From HOADON , BAN Where HOADON.MaBan = BAN.MaBan  and  HOADON.MaBan = '" + lbMaBan.Text + "' AND HOADON.TrangThai =0 ";
                SqlCommand cmd = new SqlCommand(query, conn);
                int soluong = int.Parse(cmd.ExecuteScalar().ToString());

            
                if (soluong == 0)
                {

                    if (lbMaBan.Text != "...")//moi them vao
                    {
                        UpdatTrangThaiKhiGoiMon();
                        SqlCommand command = new SqlCommand();
                        command.CommandType = CommandType.Text;
                        command.CommandText = "insert into HOADON (MaHoaDon,MaBan,GioDen,TrangThai) values ( '" + TaoMaHoaDon().ToString() + "' ,'" + lbMaBan.Text + "','" + (giohientai) + "', 0)";
                        command.Connection = conn;
                        command.ExecuteNonQuery();
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Close();
                    }
                    
                   
                }
                

            
             if(lbMaRaDom.Text!="" )//moi them vao
                TaoMoiVaUpDateCTHD();
                NapDaTaLISTMon(int.Parse(lbMaBan.Text));
                TinhTongTienHoaDonHienTai();
                capnhatphucvuthanhtrong();
                LamMoiNhapLieu();
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
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
                string query = "Update CHITIETHD set SoLuong = " + txtSoLuong.Text + " where MaChiTietHD = '" +lbMaCTHD.Text+ "'";

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = conn;
                int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
                if (ret > 0)
                {
                   
                    NapDaTaLISTMon(int.Parse(lbMaBan.Text));
                    MessageBox.Show("thim da sua thanh cong ");
                    LamMoiNhapLieu();
                    TinhTongTienHoaDonHienTai();
                    capnhatphucvuthanhtrong();//Moi them vao

                }
                else
                {
                    MessageBox.Show("thim da cap nhat that bai");
                }
            }
            catch 
            {
                MessageBox.Show("Ban nhap sai kieu du lieu !!!");
                
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = "Delete from CHITIETHD where MaChiTietHD = '" + lbMaCTHD.Text + "'";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
            if (ret > 0)
            {
                
                NapDaTaLISTMon(int.Parse(lbMaBan.Text));
               
                LamMoiNhapLieu();
                TinhTongTienHoaDonHienTai();
                lbMaCTHD.Text = "";
                capnhatphucvuthanhtrong();// Moi them vao
                MessageBox.Show("thim da xoa thanh cong ");
            }
            else
            {
                MessageBox.Show("thim da xoa that bai");
            }
        }

        public void TinhTongTienHoaDonHienTai()
        {
            
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();           
            using (SqlCommand cmd = new SqlCommand("select SUM(CHITIETHD.SoLuong * CHITIETHD.Gia) from CHITIETHD, HOADON where CHITIETHD.MaHoaDon = HOADON.MaHoaDon and HOADON.MaHoaDon = '"+lbMaRaDom.Text+"'", conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                   
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            if((reader.GetValue(0) + "")=="")
                            {
                                lbTongTien.Text ="0";
                                 
                            }
                           else
                            lbTongTien.Text = Convert.ToDecimal(reader.GetValue(0) + "").ToString("#,##0.00");
                            lbTienSQL.Text = reader.GetValue(0) + "";
                            
                        }
                       
                    }

                   
                   
                }

            } // command disposed here

           
        }
        //---------------------------cập nhật lại trạng thái từ đang phục vụ thành trong-------------------
        public void capnhatphucvuthanhtrong()
        {
            try
            {
                CSDL_MONOFBAN.deleteAll();
                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select CHITIETHD.MaChiTietHD,MON.TenMon,CHITIETHD.Gia,MON.DVT,BAN.TenBan ,CHITIETHD.SoLuong from MON, HOADON, CHITIETHD, BAN where MON.MaMon = CHITIETHD.MaMon and CHITIETHD.MaHoaDon = HOADON.MaHoaDon and BAN.MaBan = HOADON.MaBan and HOADON.MaBan = '" + lbMaBan.Text + "' and HOADON.TrangThai = 0";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        btnDatCho.Enabled = false;
                        btnThanhToan.Enabled = true;
                       btnSuaMon.Enabled = false;
                       btnXoaMon.Enabled = false;
                        btnThemMon.Enabled= false;
                        txtSoLuong.Enabled = false;//moi them vao
                    }
                    else
                    {
                        txtSoLuong.Enabled = false;//moi them vao
                        btnDatCho.Enabled = true;
                        btnThanhToan.Enabled = false;
                        lbTongTien.Text = "0";
                        btnSuaMon.Enabled = false;
                        btnXoaMon.Enabled = false;
                        btnThemMon.Enabled = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //----------------------------------------Thanh toan -------------------------------------------------

        public void TongTienTrongHoaDon()
        {
            try
            {
                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "Update HOADON set  TongTien= '" + lbTienSQL.Text + "' , TrangThai=1 where MaHoaDon = '" + lbMaRaDom.Text + "'";

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = conn;
                int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
                if (ret > 0)
                {
                   
                    MessageBox.Show("thim da thanh toan thanh cong ");

                }
                else
                {
                    MessageBox.Show("thim da thanh toan that bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ban nhap sai kieu du lieu !!!");
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
           // TongTienTrongHoaDon();
            switch (lbTrangThai.Text)
            {
                
                case "Dang phuc vu":
                    lbTrangThai.Text = "Trong";
                    break;
            }
            

            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "CapNhatTrangThaiBanTheoMaBan";
            command.Connection = conn;

            command.Parameters.Add("@maban", SqlDbType.Int).Value = int.Parse(lbMaBan.Text);
            command.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = lbTrangThai.Text;
            int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
            if (ret > 0)
            {
                NapDaTaBan();
                LoadListButtonBan();
                TongTienTrongHoaDon();
                //NapDaTaLISTMon(lbMaBan.Text);
                NapDaTaLISTMon(int.Parse(lbMaBan.Text));
                //MessageBox.Show("thim da cap nhat thanh cong ");
                LamMoiNhapLieu();
               
               // lbMaRaDom.Text = "";
                lbMaCTHD.Text = "";
                lbTienSQL.Text = "";
                lbTongTien.Text = "";
                capnhatphucvuthanhtrong();
            }
            else
            {
                MessageBox.Show("thim da cap nhat that bai");
            }
            maHD = lbMaRaDom.Text;
        }

        public void XoaHoaDonKhiKhongConMon()
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = "Delete from HOADON where MaHoaDon = '" + lbMaRaDom.Text + "'";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
            if (ret > 0)
            { 
               // MessageBox.Show("thim da xoa Hoa Don thanh cong "); //Moi them vao
            }
            else
            {
               // MessageBox.Show("thim da xoa Hoa Don that bai");// Moi them vao
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            NapDaTaBan();
            LoadListButtonBan();
            NapDaTaDanhMuc();
            LoadListButtonDanhMuc();
        }
        public static string maHD = "";
        private void btinhoadon_Click(object sender, EventArgs e)
        {
            InAn inan = new InAn();
            inan.Show();
            // inan.Hide();
            maHD = lbMaRaDom.Text;
           
        }

        private void lbMaBan_Click(object sender, EventArgs e)
        {

        }
    }
}  
