using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using BUS;
using DTO;
using System.Data.SqlClient;

namespace CoffeeShop
{
    public partial class FrmOrder : Form
    {
        public int tablenumbercurrently;
        public int mamonnuoc; //x
        public decimal giatien;
        public string tenmon;
        public string note;
        //private int maban;
        private int khuvuc;
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            dgvmenu.DataSource = new BUS.BUS_Order().GetMenu();        
            dgvMonvaBan.DataSource = GetInvoice_GUI();
        }

        private void khuvuc1()
        {
            khuvuc = 1;
        }

        private List<DTO_Invoice> GetInvoice_GUI()
        {
            string sql = "SELECT * FROM HoaDon";
            return new BUS_Invoice().GetInvoiceBUS(sql);
        }
       

        //----------Bàn1 Lầu1
        private List<DTO_Invoice> GetMaBan_GUI11(int tablenumbercurrently)
        {
            string sql = "SELECT * FROM HoaDon WHERE MaBan = " + tablenumbercurrently;
            return new BUS_Invoice().GetInvoiceBUS(sql);
        }
        private void btnBan1Lau1_Click(object sender, EventArgs e)
        {
            tablenumbercurrently = 11;
            txtmaban.Text = btnBan1Lau1.Text;
            txtkhuvuc.Text = tplau1.Text;
            dgvMonvaBan.DataSource = GetMaBan_GUI11(tablenumbercurrently);
            khuvuc1();
        }


        //----------Bàn2 Lầu1
        private List<DTO_Invoice> GetMaBan_GUI21(int tablenumbercurrently)
        {
            string sql = "SELECT * FROM HoaDon WHERE MaBan = N'21'";
            return new BUS_Invoice().GetInvoiceBUS(sql);
        }
        private void btnBan2Lau1_Click(object sender, EventArgs e)
        {
            tablenumbercurrently = 21; // => mã bàn!            
            txtmaban.Text = btnBan2Lau1.Text;
            txtkhuvuc.Text = tplau1.Text;
            dgvMonvaBan.DataSource = GetMaBan_GUI21(tablenumbercurrently);
            khuvuc1();
        }


        //----------Bàn3 Lầu1
        private List<DTO_Invoice> GetMaBan_GUI31(int tablenumbercurrently)
        {
            string sql = "SELECT * FROM HoaDon WHERE MaBan = N'31'";
            return new BUS_Invoice().GetInvoiceBUS(sql);
        }
        private void btnBan3Lau1_Click(object sender, EventArgs e)
        {
            tablenumbercurrently = 31; // => mã bàn!            
            txtmaban.Text = btnBan3Lau1.Text;
            txtkhuvuc.Text = tplau1.Text;
            dgvMonvaBan.DataSource = GetMaBan_GUI31(tablenumbercurrently);
            khuvuc1();
        }


        //----------Bàn1 Lầu2
        private List<DTO_Invoice> GetMaBan_GUI12(int tablenumbercurrently)
        {
            string sql = "SELECT * FROM HoaDon WHERE MaBan = N'12'";
            return new BUS_Invoice().GetInvoiceBUS(sql);
        }
        private void btnBan1Lau2_Click_1(object sender, EventArgs e)
        {
            tablenumbercurrently = 12; // => mã bàn!            
            txtmaban.Text = btnBan1Lau2.Text;
            txtkhuvuc.Text = tplau2.Text;
            dgvMonvaBan.DataSource = GetMaBan_GUI12(tablenumbercurrently);
            khuvuc1();
        }

        //----------Bàn2 Lầu2
        private List<DTO_Invoice> GetMaBan_GUI22(int tablenumbercurrently)
        {
            string sql = "SELECT * FROM HoaDon WHERE MaBan = N'22'";
            return new BUS_Invoice().GetInvoiceBUS(sql);
        }
        private void btnBan2Lau2_Click(object sender, EventArgs e)
        {
            tablenumbercurrently = 22; // => mã bàn!            
            txtmaban.Text = btnBan2Lau2.Text;
            txtkhuvuc.Text = tplau2.Text;
            dgvMonvaBan.DataSource = GetMaBan_GUI22(tablenumbercurrently);
            khuvuc1();
        }

        //----------Bàn3 Lầu2
        private List<DTO_Invoice> GetMaBan_GUI32(int tablenumbercurrently)
        {
            string sql = "SELECT * FROM HoaDon WHERE MaBan = N'32'";
            return new BUS_Invoice().GetInvoiceBUS(sql);
        }
        private void btnBan3Lau2_Click(object sender, EventArgs e)
        {
            tablenumbercurrently = 32; // => mã bàn!            
            txtmaban.Text = btnBan3Lau2.Text;
            txtkhuvuc.Text = tplau2.Text;
            dgvMonvaBan.DataSource = GetMaBan_GUI32(tablenumbercurrently);
            khuvuc1();
        }

        //----------Bàn1 SânThượng
        private List<DTO_Invoice> GetMaBan_GUI13(int tablenumbercurrently)
        {
            string sql = "SELECT * FROM HoaDon WHERE MaBan = N'13'";
            return new BUS_Invoice().GetInvoiceBUS(sql);
        }
        private void btnBan1SanThuong_Click(object sender, EventArgs e)
        {
            tablenumbercurrently = 13; // => mã bàn!            
            txtmaban.Text = btnBan1SanThuong.Text;
            txtkhuvuc.Text = tpsanthuong.Text;
            dgvMonvaBan.DataSource = GetMaBan_GUI13(tablenumbercurrently);
            khuvuc1();
        }

        //----------Bàn2 SânThượng
        private List<DTO_Invoice> GetMaBan_GUI23(int tablenumbercurrently)
        {
            string sql = "SELECT * FROM HoaDon WHERE MaBan = N'23'";
            return new BUS_Invoice().GetInvoiceBUS(sql);
        }
        private void btnBan2SanThuong_Click(object sender, EventArgs e)
        {
            tablenumbercurrently = 23; // => mã bàn!            
            txtmaban.Text = btnBan2SanThuong.Text;
            txtkhuvuc.Text = tpsanthuong.Text;
            dgvMonvaBan.DataSource = GetMaBan_GUI23(tablenumbercurrently);
            khuvuc1();
        }

        //----------Bàn3 SânThượng
        private List<DTO_Invoice> GetMaBan_GUI33(int tablenumbercurrently)
        {
            string sql = "SELECT * FROM HoaDon WHERE MaBan = N'33'";
            return new BUS_Invoice().GetInvoiceBUS(sql);
        }
        private void btnBan3SanThuong_Click(object sender, EventArgs e)
        {
            tablenumbercurrently = 33; // => mã bàn!            
            txtmaban.Text = btnBan3SanThuong.Text;
            txtkhuvuc.Text = tpsanthuong.Text;
            dgvMonvaBan.DataSource = GetMaBan_GUI33(tablenumbercurrently);
            khuvuc1();
        }
        //--------------------------------------------------
        private void dgvmenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvmenu.CurrentCell.RowIndex;
            mamonnuoc = Convert.ToInt32(dgvmenu.Rows[index].Cells[0].Value.ToString()); // => mã món!
            Getmoney();
        }

        private void Getmoney()
        {
            giatien = new BUS_Order().GetMoney(mamonnuoc);
        }

        private void dgvmenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tablenumbercurrently == 0 || tablenumbercurrently == null)
                {
                    MessageBox.Show("Không thêm được !!! Phải chọn bàn ăn trước khi đặt món !!!");
                }
                else
                {
                    int index = dgvmenu.CurrentCell.RowIndex;
                    mamonnuoc = Convert.ToInt32(dgvmenu.Rows[index].Cells[0].Value.ToString().Trim()); // Ma4 mon1 an

                    tenmon = dgvmenu.Rows[index].Cells[1].Value.ToString().Trim();
                    MessageBox.Show(tenmon);

                    BUS.BUS_Invoice AddMonNuoc = new BUS_Invoice();

                    DateTime realtime = System.DateTime.Now;

                    AddMonNuoc.Add_MonNuoc(mamonnuoc, tablenumbercurrently);

                    DataTable dt = new DataTable();
                    BUS_Invoice mon = new BUS_Invoice();
                    string sql = "select * from HoaDon where MaBan = " + tablenumbercurrently;
                    dt = mon.GetTheoSoBan(sql);
                    dgvMonvaBan.DataSource = dt;
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("FAIL");
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvMonvaBan.CurrentRow.Index;
                int maban = Convert.ToInt32(dgvMonvaBan.Rows[index].Cells[2].Value.ToString().Trim());
                DTO_Order monan = new DTO_Order(Convert.ToInt32(txtbXoaMon.Text));

                BUS_Order ma = new BUS_Order();
                ma.XoaMon(monan, maban);

                dgvMonvaBan.DataSource = GetInvoice_GUI();
                dgvMonvaBan.DataSource = GetMaBan_GUI11(maban);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("FAIL");
            }
        }

        private void dgvMonvaBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvMonvaBan.CurrentCell.RowIndex;
            txtbXoaMon.Text = dgvMonvaBan.Rows[index].Cells[1].Value.ToString().Trim();
        }

        private void btnTToan_Click(object sender, EventArgs e)
        {
            FrmHoaDon frmHoaDon = new FrmHoaDon();
            frmHoaDon.ShowDialog();
            
        }

        
    }
}

