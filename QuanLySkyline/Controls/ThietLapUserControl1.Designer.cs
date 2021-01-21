namespace QuanLySkyline.Controls
{
    partial class ThietLapUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userControlDoiMatKhau1 = new QuanLySkyline.ControlsThietLap.UserControlDoiMatKhau();
            this.thongTinUserControl11 = new QuanLySkyline.ControlsThietLap.ThongTinUserControl1();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnDoiMatKhau);
            this.panel1.Controls.Add(this.btnThongTin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 711);
            this.panel1.TabIndex = 0;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Image = global::QuanLySkyline.Properties.Resources.update;
            this.btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(18, 162);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(185, 50);
            this.btnDoiMatKhau.TabIndex = 0;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.Image = global::QuanLySkyline.Properties.Resources.info;
            this.btnThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTin.Location = new System.Drawing.Point(18, 82);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(185, 50);
            this.btnThongTin.TabIndex = 0;
            this.btnThongTin.Text = "Thông Tin ";
            this.btnThongTin.UseVisualStyleBackColor = true;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 711);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::QuanLySkyline.Properties.Resources.logo;
            this.panel4.Location = new System.Drawing.Point(26, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(85, 80);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.userControlDoiMatKhau1);
            this.panel3.Controls.Add(this.thongTinUserControl11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(337, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(942, 711);
            this.panel3.TabIndex = 2;
            // 
            // userControlDoiMatKhau1
            // 
            this.userControlDoiMatKhau1.BackColor = System.Drawing.Color.Silver;
            this.userControlDoiMatKhau1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDoiMatKhau1.Location = new System.Drawing.Point(0, 0);
            this.userControlDoiMatKhau1.Name = "userControlDoiMatKhau1";
            this.userControlDoiMatKhau1.Size = new System.Drawing.Size(942, 711);
            this.userControlDoiMatKhau1.TabIndex = 2;
            // 
            // thongTinUserControl11
            // 
            this.thongTinUserControl11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.thongTinUserControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thongTinUserControl11.Location = new System.Drawing.Point(0, 0);
            this.thongTinUserControl11.Name = "thongTinUserControl11";
            this.thongTinUserControl11.Size = new System.Drawing.Size(942, 711);
            this.thongTinUserControl11.TabIndex = 1;
            // 
            // ThietLapUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ThietLapUserControl1";
            this.Size = new System.Drawing.Size(1279, 711);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private ControlsThietLap.ThongTinUserControl1 thongTinUserControl11;
        private ControlsThietLap.UserControlDoiMatKhau userControlDoiMatKhau1;
    }
}
