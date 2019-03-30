namespace CoffeeShop
{
    partial class FrmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrder));
            this.dgvmenu = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tplau1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBan3Lau1 = new System.Windows.Forms.Button();
            this.btnBan2Lau1 = new System.Windows.Forms.Button();
            this.btnBan1Lau1 = new System.Windows.Forms.Button();
            this.tplau2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBan3Lau2 = new System.Windows.Forms.Button();
            this.btnBan2Lau2 = new System.Windows.Forms.Button();
            this.btnBan1Lau2 = new System.Windows.Forms.Button();
            this.tpsanthuong = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBan3SanThuong = new System.Windows.Forms.Button();
            this.btnBan2SanThuong = new System.Windows.Forms.Button();
            this.btnBan1SanThuong = new System.Windows.Forms.Button();
            this.grbThonTinOrder = new System.Windows.Forms.GroupBox();
            this.txtmaban = new System.Windows.Forms.TextBox();
            this.txtkhuvuc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvMonvaBan = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnTToan = new System.Windows.Forms.Button();
            this.txtbXoaMon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmenu)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tplau1.SuspendLayout();
            this.tplau2.SuspendLayout();
            this.tpsanthuong.SuspendLayout();
            this.grbThonTinOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonvaBan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmenu
            // 
            this.dgvmenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(204)))));
            this.dgvmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmenu.Location = new System.Drawing.Point(12, 130);
            this.dgvmenu.Name = "dgvmenu";
            this.dgvmenu.Size = new System.Drawing.Size(421, 380);
            this.dgvmenu.TabIndex = 0;
            this.dgvmenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmenu_CellClick);
            this.dgvmenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmenu_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tplau1);
            this.tabControl1.Controls.Add(this.tplau2);
            this.tabControl1.Controls.Add(this.tpsanthuong);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(479, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(346, 115);
            this.tabControl1.TabIndex = 1;
            // 
            // tplau1
            // 
            this.tplau1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.tplau1.Controls.Add(this.label3);
            this.tplau1.Controls.Add(this.label2);
            this.tplau1.Controls.Add(this.label1);
            this.tplau1.Controls.Add(this.btnBan3Lau1);
            this.tplau1.Controls.Add(this.btnBan2Lau1);
            this.tplau1.Controls.Add(this.btnBan1Lau1);
            this.tplau1.Location = new System.Drawing.Point(4, 24);
            this.tplau1.Name = "tplau1";
            this.tplau1.Padding = new System.Windows.Forms.Padding(3);
            this.tplau1.Size = new System.Drawing.Size(338, 87);
            this.tplau1.TabIndex = 0;
            this.tplau1.Text = "Lầu 1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bàn 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bàn 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bàn 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBan3Lau1
            // 
            this.btnBan3Lau1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.btnBan3Lau1.Image = ((System.Drawing.Image)(resources.GetObject("btnBan3Lau1.Image")));
            this.btnBan3Lau1.Location = new System.Drawing.Point(235, 12);
            this.btnBan3Lau1.Name = "btnBan3Lau1";
            this.btnBan3Lau1.Size = new System.Drawing.Size(82, 40);
            this.btnBan3Lau1.TabIndex = 0;
            this.btnBan3Lau1.Text = "Bàn 3";
            this.btnBan3Lau1.UseVisualStyleBackColor = false;
            this.btnBan3Lau1.Click += new System.EventHandler(this.btnBan3Lau1_Click);
            // 
            // btnBan2Lau1
            // 
            this.btnBan2Lau1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.btnBan2Lau1.Image = ((System.Drawing.Image)(resources.GetObject("btnBan2Lau1.Image")));
            this.btnBan2Lau1.Location = new System.Drawing.Point(126, 12);
            this.btnBan2Lau1.Name = "btnBan2Lau1";
            this.btnBan2Lau1.Size = new System.Drawing.Size(82, 40);
            this.btnBan2Lau1.TabIndex = 0;
            this.btnBan2Lau1.Text = "Bàn 2";
            this.btnBan2Lau1.UseVisualStyleBackColor = false;
            this.btnBan2Lau1.Click += new System.EventHandler(this.btnBan2Lau1_Click);
            // 
            // btnBan1Lau1
            // 
            this.btnBan1Lau1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.btnBan1Lau1.Image = ((System.Drawing.Image)(resources.GetObject("btnBan1Lau1.Image")));
            this.btnBan1Lau1.Location = new System.Drawing.Point(18, 12);
            this.btnBan1Lau1.Name = "btnBan1Lau1";
            this.btnBan1Lau1.Size = new System.Drawing.Size(82, 40);
            this.btnBan1Lau1.TabIndex = 0;
            this.btnBan1Lau1.Text = "Bàn 1";
            this.btnBan1Lau1.UseVisualStyleBackColor = false;
            this.btnBan1Lau1.Click += new System.EventHandler(this.btnBan1Lau1_Click);
            // 
            // tplau2
            // 
            this.tplau2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.tplau2.Controls.Add(this.label4);
            this.tplau2.Controls.Add(this.label5);
            this.tplau2.Controls.Add(this.label6);
            this.tplau2.Controls.Add(this.btnBan3Lau2);
            this.tplau2.Controls.Add(this.btnBan2Lau2);
            this.tplau2.Controls.Add(this.btnBan1Lau2);
            this.tplau2.Location = new System.Drawing.Point(4, 24);
            this.tplau2.Name = "tplau2";
            this.tplau2.Padding = new System.Windows.Forms.Padding(3);
            this.tplau2.Size = new System.Drawing.Size(338, 87);
            this.tplau2.TabIndex = 1;
            this.tplau2.Text = "Lầu 2";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bàn 3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bàn 2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bàn 1";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBan3Lau2
            // 
            this.btnBan3Lau2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.btnBan3Lau2.Image = ((System.Drawing.Image)(resources.GetObject("btnBan3Lau2.Image")));
            this.btnBan3Lau2.Location = new System.Drawing.Point(235, 12);
            this.btnBan3Lau2.Name = "btnBan3Lau2";
            this.btnBan3Lau2.Size = new System.Drawing.Size(82, 40);
            this.btnBan3Lau2.TabIndex = 2;
            this.btnBan3Lau2.Text = "Bàn 3";
            this.btnBan3Lau2.UseVisualStyleBackColor = false;
            this.btnBan3Lau2.Click += new System.EventHandler(this.btnBan3Lau2_Click);
            // 
            // btnBan2Lau2
            // 
            this.btnBan2Lau2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.btnBan2Lau2.Image = ((System.Drawing.Image)(resources.GetObject("btnBan2Lau2.Image")));
            this.btnBan2Lau2.Location = new System.Drawing.Point(126, 12);
            this.btnBan2Lau2.Name = "btnBan2Lau2";
            this.btnBan2Lau2.Size = new System.Drawing.Size(82, 40);
            this.btnBan2Lau2.TabIndex = 3;
            this.btnBan2Lau2.Text = "Bàn 2";
            this.btnBan2Lau2.UseVisualStyleBackColor = false;
            this.btnBan2Lau2.Click += new System.EventHandler(this.btnBan2Lau2_Click);
            // 
            // btnBan1Lau2
            // 
            this.btnBan1Lau2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.btnBan1Lau2.Image = ((System.Drawing.Image)(resources.GetObject("btnBan1Lau2.Image")));
            this.btnBan1Lau2.Location = new System.Drawing.Point(18, 12);
            this.btnBan1Lau2.Name = "btnBan1Lau2";
            this.btnBan1Lau2.Size = new System.Drawing.Size(82, 40);
            this.btnBan1Lau2.TabIndex = 4;
            this.btnBan1Lau2.Text = "Bàn 1";
            this.btnBan1Lau2.UseVisualStyleBackColor = false;
            this.btnBan1Lau2.Click += new System.EventHandler(this.btnBan1Lau2_Click_1);
            // 
            // tpsanthuong
            // 
            this.tpsanthuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.tpsanthuong.Controls.Add(this.label7);
            this.tpsanthuong.Controls.Add(this.label8);
            this.tpsanthuong.Controls.Add(this.label9);
            this.tpsanthuong.Controls.Add(this.btnBan3SanThuong);
            this.tpsanthuong.Controls.Add(this.btnBan2SanThuong);
            this.tpsanthuong.Controls.Add(this.btnBan1SanThuong);
            this.tpsanthuong.Location = new System.Drawing.Point(4, 24);
            this.tpsanthuong.Name = "tpsanthuong";
            this.tpsanthuong.Padding = new System.Windows.Forms.Padding(3);
            this.tpsanthuong.Size = new System.Drawing.Size(338, 87);
            this.tpsanthuong.TabIndex = 2;
            this.tpsanthuong.Text = "Sân Thượng";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "Bàn 3";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(134, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 27);
            this.label8.TabIndex = 6;
            this.label8.Text = "Bàn 2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 27);
            this.label9.TabIndex = 7;
            this.label9.Text = "Bàn 1";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBan3SanThuong
            // 
            this.btnBan3SanThuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.btnBan3SanThuong.Image = ((System.Drawing.Image)(resources.GetObject("btnBan3SanThuong.Image")));
            this.btnBan3SanThuong.Location = new System.Drawing.Point(235, 12);
            this.btnBan3SanThuong.Name = "btnBan3SanThuong";
            this.btnBan3SanThuong.Size = new System.Drawing.Size(82, 40);
            this.btnBan3SanThuong.TabIndex = 2;
            this.btnBan3SanThuong.Text = "Bàn 3";
            this.btnBan3SanThuong.UseVisualStyleBackColor = false;
            this.btnBan3SanThuong.Click += new System.EventHandler(this.btnBan3SanThuong_Click);
            // 
            // btnBan2SanThuong
            // 
            this.btnBan2SanThuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.btnBan2SanThuong.Image = ((System.Drawing.Image)(resources.GetObject("btnBan2SanThuong.Image")));
            this.btnBan2SanThuong.Location = new System.Drawing.Point(126, 12);
            this.btnBan2SanThuong.Name = "btnBan2SanThuong";
            this.btnBan2SanThuong.Size = new System.Drawing.Size(82, 40);
            this.btnBan2SanThuong.TabIndex = 3;
            this.btnBan2SanThuong.Text = "Bàn 2";
            this.btnBan2SanThuong.UseVisualStyleBackColor = false;
            this.btnBan2SanThuong.Click += new System.EventHandler(this.btnBan2SanThuong_Click);
            // 
            // btnBan1SanThuong
            // 
            this.btnBan1SanThuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.btnBan1SanThuong.Image = ((System.Drawing.Image)(resources.GetObject("btnBan1SanThuong.Image")));
            this.btnBan1SanThuong.Location = new System.Drawing.Point(18, 12);
            this.btnBan1SanThuong.Name = "btnBan1SanThuong";
            this.btnBan1SanThuong.Size = new System.Drawing.Size(82, 40);
            this.btnBan1SanThuong.TabIndex = 4;
            this.btnBan1SanThuong.Text = "Bàn 1";
            this.btnBan1SanThuong.UseVisualStyleBackColor = false;
            this.btnBan1SanThuong.Click += new System.EventHandler(this.btnBan1SanThuong_Click);
            // 
            // grbThonTinOrder
            // 
            this.grbThonTinOrder.Controls.Add(this.txtmaban);
            this.grbThonTinOrder.Controls.Add(this.txtkhuvuc);
            this.grbThonTinOrder.Controls.Add(this.label12);
            this.grbThonTinOrder.Controls.Add(this.label11);
            this.grbThonTinOrder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThonTinOrder.Location = new System.Drawing.Point(12, 12);
            this.grbThonTinOrder.Name = "grbThonTinOrder";
            this.grbThonTinOrder.Size = new System.Drawing.Size(421, 74);
            this.grbThonTinOrder.TabIndex = 2;
            this.grbThonTinOrder.TabStop = false;
            this.grbThonTinOrder.Text = "Thông Tin Order";
            // 
            // txtmaban
            // 
            this.txtmaban.Location = new System.Drawing.Point(283, 26);
            this.txtmaban.Name = "txtmaban";
            this.txtmaban.Size = new System.Drawing.Size(132, 22);
            this.txtmaban.TabIndex = 1;
            // 
            // txtkhuvuc
            // 
            this.txtkhuvuc.Location = new System.Drawing.Point(94, 28);
            this.txtkhuvuc.Name = "txtkhuvuc";
            this.txtkhuvuc.Size = new System.Drawing.Size(90, 22);
            this.txtkhuvuc.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(191, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 26);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã Bàn:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(8, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "Khu Vực:";
            // 
            // dgvMonvaBan
            // 
            this.dgvMonvaBan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(204)))));
            this.dgvMonvaBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonvaBan.Location = new System.Drawing.Point(466, 130);
            this.dgvMonvaBan.Name = "dgvMonvaBan";
            this.dgvMonvaBan.Size = new System.Drawing.Size(371, 286);
            this.dgvMonvaBan.TabIndex = 3;
            this.dgvMonvaBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonvaBan_CellClick);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 38);
            this.label10.TabIndex = 4;
            this.label10.Text = "Menu";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.btnXoaMon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMon.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaMon.Image")));
            this.btnXoaMon.Location = new System.Drawing.Point(565, 443);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(115, 65);
            this.btnXoaMon.TabIndex = 5;
            this.btnXoaMon.Text = "Xóa món";
            this.btnXoaMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaMon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaMon.UseVisualStyleBackColor = false;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnTToan
            // 
            this.btnTToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(215)))), ((int)(((byte)(194)))));
            this.btnTToan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTToan.Image = ((System.Drawing.Image)(resources.GetObject("btnTToan.Image")));
            this.btnTToan.Location = new System.Drawing.Point(690, 443);
            this.btnTToan.Name = "btnTToan";
            this.btnTToan.Size = new System.Drawing.Size(147, 65);
            this.btnTToan.TabIndex = 6;
            this.btnTToan.Text = "Thanh Toán";
            this.btnTToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTToan.UseVisualStyleBackColor = false;
            this.btnTToan.Click += new System.EventHandler(this.btnTToan_Click);
            // 
            // txtbXoaMon
            // 
            this.txtbXoaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbXoaMon.ForeColor = System.Drawing.Color.Red;
            this.txtbXoaMon.Location = new System.Drawing.Point(466, 457);
            this.txtbXoaMon.Multiline = true;
            this.txtbXoaMon.Name = "txtbXoaMon";
            this.txtbXoaMon.Size = new System.Drawing.Size(93, 31);
            this.txtbXoaMon.TabIndex = 7;
            this.txtbXoaMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(886, 520);
            this.Controls.Add(this.txtbXoaMon);
            this.Controls.Add(this.btnTToan);
            this.Controls.Add(this.btnXoaMon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvMonvaBan);
            this.Controls.Add(this.grbThonTinOrder);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvmenu);
            this.Name = "FrmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrdercs";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmenu)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tplau1.ResumeLayout(false);
            this.tplau2.ResumeLayout(false);
            this.tpsanthuong.ResumeLayout(false);
            this.grbThonTinOrder.ResumeLayout(false);
            this.grbThonTinOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonvaBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmenu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tplau1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBan3Lau1;
        private System.Windows.Forms.Button btnBan2Lau1;
        private System.Windows.Forms.Button btnBan1Lau1;
        private System.Windows.Forms.TabPage tplau2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBan3Lau2;
        private System.Windows.Forms.Button btnBan2Lau2;
        private System.Windows.Forms.Button btnBan1Lau2;
        private System.Windows.Forms.TabPage tpsanthuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBan3SanThuong;
        private System.Windows.Forms.Button btnBan2SanThuong;
        private System.Windows.Forms.Button btnBan1SanThuong;
        private System.Windows.Forms.GroupBox grbThonTinOrder;
        private System.Windows.Forms.DataGridView dgvMonvaBan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmaban;
        private System.Windows.Forms.TextBox txtkhuvuc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.Button btnTToan;
        private System.Windows.Forms.TextBox txtbXoaMon;
    }
}