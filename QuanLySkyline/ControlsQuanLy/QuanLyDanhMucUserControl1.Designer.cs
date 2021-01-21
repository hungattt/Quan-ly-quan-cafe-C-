namespace QuanLySkyline.ControlsQuanLy
{
    partial class QuanLyDanhMucUserControl1
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
            this.bntTimKiemDM = new System.Windows.Forms.Button();
            this.txtTimKiemDanhMuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnSuaDM = new System.Windows.Forms.Button();
            this.btThemDM = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewDanhMuc = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.bntTimKiemDM);
            this.panel1.Controls.Add(this.txtTimKiemDanhMuc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 134);
            this.panel1.TabIndex = 0;
            // 
            // bntTimKiemDM
            // 
            this.bntTimKiemDM.Image = global::QuanLySkyline.Properties.Resources.Zoom_icon2;
            this.bntTimKiemDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntTimKiemDM.Location = new System.Drawing.Point(530, 18);
            this.bntTimKiemDM.Name = "bntTimKiemDM";
            this.bntTimKiemDM.Size = new System.Drawing.Size(177, 43);
            this.bntTimKiemDM.TabIndex = 2;
            this.bntTimKiemDM.Text = "Tìm Kiếm ";
            this.bntTimKiemDM.UseVisualStyleBackColor = true;
            this.bntTimKiemDM.Click += new System.EventHandler(this.bntTimKiemDM_Click);
            // 
            // txtTimKiemDanhMuc
            // 
            this.txtTimKiemDanhMuc.Location = new System.Drawing.Point(275, 26);
            this.txtTimKiemDanhMuc.Name = "txtTimKiemDanhMuc";
            this.txtTimKiemDanhMuc.Size = new System.Drawing.Size(194, 22);
            this.txtTimKiemDanhMuc.TabIndex = 1;
            this.txtTimKiemDanhMuc.TextChanged += new System.EventHandler(this.txtTimKiemDanhMuc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm Danh Mục  : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnXoaDM);
            this.panel2.Controls.Add(this.btnSuaDM);
            this.panel2.Controls.Add(this.btThemDM);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1051, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 543);
            this.panel2.TabIndex = 1;
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.Image = global::QuanLySkyline.Properties.Resources.file_delete1;
            this.btnXoaDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDM.Location = new System.Drawing.Point(18, 272);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(179, 46);
            this.btnXoaDM.TabIndex = 0;
            this.btnXoaDM.Text = "Xóa DM";
            this.btnXoaDM.UseVisualStyleBackColor = true;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.Image = global::QuanLySkyline.Properties.Resources.document_edit1;
            this.btnSuaDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDM.Location = new System.Drawing.Point(18, 189);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.Size = new System.Drawing.Size(179, 46);
            this.btnSuaDM.TabIndex = 0;
            this.btnSuaDM.Text = "Sửa DM";
            this.btnSuaDM.UseVisualStyleBackColor = true;
            this.btnSuaDM.Click += new System.EventHandler(this.btnSuaDM_Click);
            // 
            // btThemDM
            // 
            this.btThemDM.Image = global::QuanLySkyline.Properties.Resources.file_add1;
            this.btThemDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemDM.Location = new System.Drawing.Point(18, 113);
            this.btThemDM.Name = "btThemDM";
            this.btThemDM.Size = new System.Drawing.Size(179, 46);
            this.btThemDM.TabIndex = 0;
            this.btThemDM.Text = "Thêm DM";
            this.btThemDM.UseVisualStyleBackColor = true;
            this.btThemDM.Click += new System.EventHandler(this.btThemDM_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtTenDM);
            this.panel3.Controls.Add(this.txtMaDM);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 537);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1051, 140);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm Kiếm Danh Mục  : ";
            // 
            // txtTenDM
            // 
            this.txtTenDM.Location = new System.Drawing.Point(570, 47);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(148, 22);
            this.txtTenDM.TabIndex = 1;
            this.txtTenDM.TextChanged += new System.EventHandler(this.txtTimKiemDanhMuc_TextChanged);
            // 
            // txtMaDM
            // 
            this.txtMaDM.Enabled = false;
            this.txtMaDM.Location = new System.Drawing.Point(216, 47);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(148, 22);
            this.txtMaDM.TabIndex = 1;
            this.txtMaDM.TextChanged += new System.EventHandler(this.txtTimKiemDanhMuc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên danh mục : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã danh mục : ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Olive;
            this.panel4.Controls.Add(this.dataGridViewDanhMuc);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1051, 403);
            this.panel4.TabIndex = 3;
            // 
            // dataGridViewDanhMuc
            // 
            this.dataGridViewDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhMuc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhMuc.GridColor = System.Drawing.Color.Blue;
            this.dataGridViewDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDanhMuc.Name = "dataGridViewDanhMuc";
            this.dataGridViewDanhMuc.RowHeadersWidth = 51;
            this.dataGridViewDanhMuc.RowTemplate.Height = 24;
            this.dataGridViewDanhMuc.Size = new System.Drawing.Size(1051, 403);
            this.dataGridViewDanhMuc.TabIndex = 0;
            this.dataGridViewDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhMuc_CellClick);
            // 
            // QuanLyDanhMucUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyDanhMucUserControl1";
            this.Size = new System.Drawing.Size(1238, 677);
            this.Load += new System.EventHandler(this.QuanLyDanhMucUserControl1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntTimKiemDM;
        private System.Windows.Forms.TextBox txtTimKiemDanhMuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewDanhMuc;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnSuaDM;
        private System.Windows.Forms.Button btThemDM;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenDM;
    }
}
