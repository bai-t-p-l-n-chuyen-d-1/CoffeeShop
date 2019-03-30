namespace CoffeeShop
{
    partial class FrmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDon));
            this.lbxTenMon = new System.Windows.Forms.ListBox();
            this.lbxTongTien = new System.Windows.Forms.ListBox();
            this.dgvMonvaBan = new System.Windows.Forms.DataGridView();
            this.lbMaBan = new System.Windows.Forms.Label();
            this.cbbMonvaBan = new System.Windows.Forms.ComboBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.nudTongTien = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTienMat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTienTra = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonvaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienTra)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxTenMon
            // 
            this.lbxTenMon.FormattingEnabled = true;
            this.lbxTenMon.Location = new System.Drawing.Point(458, 64);
            this.lbxTenMon.Name = "lbxTenMon";
            this.lbxTenMon.Size = new System.Drawing.Size(128, 264);
            this.lbxTenMon.TabIndex = 0;
            this.lbxTenMon.SelectedIndexChanged += new System.EventHandler(this.lbxTenMon_SelectedIndexChanged);
            // 
            // lbxTongTien
            // 
            this.lbxTongTien.FormattingEnabled = true;
            this.lbxTongTien.Location = new System.Drawing.Point(592, 64);
            this.lbxTongTien.Name = "lbxTongTien";
            this.lbxTongTien.Size = new System.Drawing.Size(123, 264);
            this.lbxTongTien.TabIndex = 0;
            this.lbxTongTien.SelectedIndexChanged += new System.EventHandler(this.lbxTongTien_SelectedIndexChanged);
            // 
            // dgvMonvaBan
            // 
            this.dgvMonvaBan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.dgvMonvaBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonvaBan.Location = new System.Drawing.Point(19, 64);
            this.dgvMonvaBan.Name = "dgvMonvaBan";
            this.dgvMonvaBan.Size = new System.Drawing.Size(316, 264);
            this.dgvMonvaBan.TabIndex = 2;
            // 
            // lbMaBan
            // 
            this.lbMaBan.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaBan.ForeColor = System.Drawing.Color.Red;
            this.lbMaBan.Location = new System.Drawing.Point(12, 15);
            this.lbMaBan.Name = "lbMaBan";
            this.lbMaBan.Size = new System.Drawing.Size(120, 28);
            this.lbMaBan.TabIndex = 2;
            this.lbMaBan.Text = "Mã Bàn";
            this.lbMaBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbMonvaBan
            // 
            this.cbbMonvaBan.FormattingEnabled = true;
            this.cbbMonvaBan.Location = new System.Drawing.Point(139, 20);
            this.cbbMonvaBan.Name = "cbbMonvaBan";
            this.cbbMonvaBan.Size = new System.Drawing.Size(70, 21);
            this.cbbMonvaBan.TabIndex = 0;
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(228, 20);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 1;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(355, 169);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(86, 70);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(474, 415);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 46);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnInHD
            // 
            this.btnInHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.btnInHD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.Image = ((System.Drawing.Image)(resources.GetObject("btnInHD.Image")));
            this.btnInHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHD.Location = new System.Drawing.Point(601, 375);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(114, 86);
            this.btnInHD.TabIndex = 5;
            this.btnInHD.Text = "IN HÓA ĐƠN";
            this.btnInHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInHD.UseVisualStyleBackColor = false;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // nudTongTien
            // 
            this.nudTongTien.Location = new System.Drawing.Point(171, 356);
            this.nudTongTien.Name = "nudTongTien";
            this.nudTongTien.Size = new System.Drawing.Size(164, 20);
            this.nudTongTien.TabIndex = 8;
            this.nudTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(31, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tổng Tiền: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudTienMat
            // 
            this.nudTienMat.Location = new System.Drawing.Point(171, 398);
            this.nudTienMat.Name = "nudTienMat";
            this.nudTienMat.Size = new System.Drawing.Size(164, 20);
            this.nudTienMat.TabIndex = 8;
            this.nudTienMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(31, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tiền Mặt:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudTienTra
            // 
            this.nudTienTra.Location = new System.Drawing.Point(171, 441);
            this.nudTienTra.Name = "nudTienTra";
            this.nudTienTra.Size = new System.Drawing.Size(164, 20);
            this.nudTienTra.TabIndex = 8;
            this.nudTienTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(31, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tiền Trả ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThemThanhToan
            // 
            this.btnThemThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.btnThemThanhToan.Location = new System.Drawing.Point(474, 375);
            this.btnThemThanhToan.Name = "btnThemThanhToan";
            this.btnThemThanhToan.Size = new System.Drawing.Size(94, 34);
            this.btnThemThanhToan.TabIndex = 10;
            this.btnThemThanhToan.Text = "Thêm";
            this.btnThemThanhToan.UseVisualStyleBackColor = false;
            this.btnThemThanhToan.Click += new System.EventHandler(this.btnThemThanhToan_Click);
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(727, 495);
            this.Controls.Add(this.btnThemThanhToan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudTienTra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudTienMat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudTongTien);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.cbbMonvaBan);
            this.Controls.Add(this.lbMaBan);
            this.Controls.Add(this.dgvMonvaBan);
            this.Controls.Add(this.lbxTongTien);
            this.Controls.Add(this.lbxTenMon);
            this.Name = "FrmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHoaDon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonvaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxTenMon;
        private System.Windows.Forms.ListBox lbxTongTien;
        private System.Windows.Forms.DataGridView dgvMonvaBan;
        private System.Windows.Forms.Label lbMaBan;
        private System.Windows.Forms.ComboBox cbbMonvaBan;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.NumericUpDown nudTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTienMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTienTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemThanhToan;
    }
}