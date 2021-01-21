namespace QuanLySkyline
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbQTV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNgayThang = new System.Windows.Forms.Label();
            this.lbDongHo = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnThietLap = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.thongKeUserControl11 = new QuanLySkyline.Controls.ThongKeUserControl1();
            this.banHangUserControl11 = new QuanLySkyline.Controls.BanHangUserControl1();
            this.thietLapUserControl11 = new QuanLySkyline.Controls.ThietLapUserControl1();
            this.quanLyUserControl11 = new QuanLySkyline.QuanLyUserControl1();
            this.trangChuUserControl11 = new QuanLySkyline.Controls.TrangChuUserControl1();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.lbQTV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbNgayThang);
            this.panel1.Controls.Add(this.lbDongHo);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnThietLap);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnQuanLy);
            this.panel1.Controls.Add(this.btnBanHang);
            this.panel1.Controls.Add(this.btnTrangChu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1606, 102);
            this.panel1.TabIndex = 0;
            // 
            // lbQTV
            // 
            this.lbQTV.AutoSize = true;
            this.lbQTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQTV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbQTV.Location = new System.Drawing.Point(1157, 22);
            this.lbQTV.Name = "lbQTV";
            this.lbQTV.Size = new System.Drawing.Size(20, 18);
            this.lbQTV.TabIndex = 3;
            this.lbQTV.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1092, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "QTV :";
            // 
            // lbNgayThang
            // 
            this.lbNgayThang.AutoSize = true;
            this.lbNgayThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThang.ForeColor = System.Drawing.Color.Purple;
            this.lbNgayThang.Location = new System.Drawing.Point(1107, 51);
            this.lbNgayThang.Name = "lbNgayThang";
            this.lbNgayThang.Size = new System.Drawing.Size(46, 18);
            this.lbNgayThang.TabIndex = 1;
            this.lbNgayThang.Text = "label1";
            // 
            // lbDongHo
            // 
            this.lbDongHo.AutoSize = true;
            this.lbDongHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDongHo.ForeColor = System.Drawing.Color.Purple;
            this.lbDongHo.Location = new System.Drawing.Point(1107, 72);
            this.lbDongHo.Name = "lbDongHo";
            this.lbDongHo.Size = new System.Drawing.Size(46, 18);
            this.lbDongHo.TabIndex = 1;
            this.lbDongHo.Text = "label1";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Blue;
            this.btnDangXuat.Image = global::QuanLySkyline.Properties.Resources.Places_mail_folder_outbox_icon;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.Location = new System.Drawing.Point(1251, 22);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(154, 53);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Đăng Xuất ";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThietLap
            // 
            this.btnThietLap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThietLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThietLap.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnThietLap.Image = global::QuanLySkyline.Properties.Resources.Settings_L_icon;
            this.btnThietLap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThietLap.Location = new System.Drawing.Point(910, 20);
            this.btnThietLap.Name = "btnThietLap";
            this.btnThietLap.Size = new System.Drawing.Size(161, 53);
            this.btnThietLap.TabIndex = 0;
            this.btnThietLap.Text = "Thiết Lập";
            this.btnThietLap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThietLap.UseVisualStyleBackColor = false;
            this.btnThietLap.Click += new System.EventHandler(this.btnThietLap_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnThongKe.Image = global::QuanLySkyline.Properties.Resources.chart_icon;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(672, 20);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(161, 53);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnQuanLy.Image = global::QuanLySkyline.Properties.Resources.icon_hoc_nau_an_Huong_nghiep_a_au_2015;
            this.btnQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLy.Location = new System.Drawing.Point(445, 20);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(161, 53);
            this.btnQuanLy.TabIndex = 0;
            this.btnQuanLy.Text = "Quản Lý ";
            this.btnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLy.UseVisualStyleBackColor = false;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnBanHang.Image = global::QuanLySkyline.Properties.Resources.payment_icon;
            this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.Location = new System.Drawing.Point(233, 20);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(161, 53);
            this.btnBanHang.TabIndex = 0;
            this.btnBanHang.Text = "Bán Hàng ";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnTrangChu.Image = global::QuanLySkyline.Properties.Resources.home_icon;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(24, 17);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(156, 56);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "Trang Chủ ";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.thongKeUserControl11);
            this.panel2.Controls.Add(this.banHangUserControl11);
            this.panel2.Controls.Add(this.thietLapUserControl11);
            this.panel2.Controls.Add(this.quanLyUserControl11);
            this.panel2.Controls.Add(this.trangChuUserControl11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1606, 584);
            this.panel2.TabIndex = 1;
            // 
            // thongKeUserControl11
            // 
            this.thongKeUserControl11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.thongKeUserControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thongKeUserControl11.Location = new System.Drawing.Point(0, 0);
            this.thongKeUserControl11.Name = "thongKeUserControl11";
            this.thongKeUserControl11.Size = new System.Drawing.Size(1606, 584);
            this.thongKeUserControl11.TabIndex = 4;
            // 
            // banHangUserControl11
            // 
            this.banHangUserControl11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.banHangUserControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banHangUserControl11.Location = new System.Drawing.Point(0, 0);
            this.banHangUserControl11.Name = "banHangUserControl11";
            this.banHangUserControl11.Size = new System.Drawing.Size(1606, 584);
            this.banHangUserControl11.TabIndex = 3;
            // 
            // thietLapUserControl11
            // 
            this.thietLapUserControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thietLapUserControl11.Location = new System.Drawing.Point(0, 0);
            this.thietLapUserControl11.Name = "thietLapUserControl11";
            this.thietLapUserControl11.Size = new System.Drawing.Size(1606, 584);
            this.thietLapUserControl11.TabIndex = 2;
            // 
            // quanLyUserControl11
            // 
            this.quanLyUserControl11.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.quanLyUserControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyUserControl11.Location = new System.Drawing.Point(0, 0);
            this.quanLyUserControl11.Name = "quanLyUserControl11";
            this.quanLyUserControl11.Size = new System.Drawing.Size(1606, 584);
            this.quanLyUserControl11.TabIndex = 1;
            // 
            // trangChuUserControl11
            // 
            this.trangChuUserControl11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trangChuUserControl11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trangChuUserControl11.BackgroundImage")));
            this.trangChuUserControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trangChuUserControl11.Location = new System.Drawing.Point(0, 0);
            this.trangChuUserControl11.Name = "trangChuUserControl11";
            this.trangChuUserControl11.Size = new System.Drawing.Size(1606, 584);
            this.trangChuUserControl11.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 686);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThietLap;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Panel panel2;
        public Controls.TrangChuUserControl1 trangChuUserControl11;
        private QuanLyUserControl1 quanLyUserControl11;
        private Controls.ThietLapUserControl1 thietLapUserControl11;
        private Controls.BanHangUserControl1 banHangUserControl11;
        private Controls.ThongKeUserControl1 thongKeUserControl11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbDongHo;
        private System.Windows.Forms.Label lbNgayThang;
        private System.Windows.Forms.Label lbQTV;
        private System.Windows.Forms.Label label1;
    }
}

