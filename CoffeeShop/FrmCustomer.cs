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
    public partial class FrmCustomer : Form
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private List<DTO_Customer> GetCustomer()
        {
            try
            {
                return new BUS_Customer().GetCustomer();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string sql = " SELECT * FROM KhachHang ";
            dgvkh.DataSource = GetCustomer();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            int pMaKH;
            string pHoKH, pTenKH, pGioiTinh, pSDT, pDiaChiThuongTru, pEmail;
            DateTime pNgaySinh;

            pMaKH = Convert.ToInt32(txtmakh.Text);
            pHoKH = txthokh.Text.Trim();
            pTenKH = txttenkh.Text.Trim();
            pGioiTinh = txtgioittinhkh.Text.Trim();
            pSDT = txtsdtkh.Text.Trim();
            pNgaySinh = Convert.ToDateTime(dtpngaysinhkh.Text.ToString());
            pDiaChiThuongTru = txtdiachickh.Text.Trim();
            pEmail = txtemailkh.Text.Trim();

            DTO_Customer emp = new DTO_Customer(pMaKH, pHoKH, pTenKH, pGioiTinh, pSDT, pNgaySinh, pDiaChiThuongTru, pEmail);
            try
            {
                int i = new BUS_Customer().AddCustomer(emp);
                if (i == -2)
                    throw new Exception();
                MessageBox.Show(" Bạn đã thêm thành công", " Xác nhận");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgvkh.DataSource = GetCustomer();
        }

        private void FrmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Cancel)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (grbTimKiem.Visible)
                grbTimKiem.Hide();
            else
                grbTimKiem.Show();
        }

        private void btnrefesh_Click(object sender, EventArgs e)
        {
            txtmakh.Clear();
            txthokh.Clear();
            txttenkh.Clear();
            txtgioittinhkh.Clear();
            txtsdtkh.Clear();
            txtdiachickh.Clear();
            txtemailkh.Clear();
            dtpngaysinhkh.Refresh();
        }

        private void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvkh.Rows[e.RowIndex];
            txtmakh.Text = row.Cells[0].Value.ToString();
            txthokh.Text = row.Cells[1].Value.ToString();
            txttenkh.Text = row.Cells[2].Value.ToString();
            txtgioittinhkh.Text = row.Cells[3].Value.ToString();
            txtsdtkh.Text = row.Cells[4].Value.ToString();
            dtpngaysinhkh.Text = row.Cells[5].Value.ToString();
            txtdiachickh.Text = row.Cells[6].Value.ToString();
            txtemailkh.Text = row.Cells[7].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá thật không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BUS_Customer DL = new BUS_Customer();
                DTO_Customer DT = new DTO_Customer(Convert.ToInt32(txtmakh.Text));

                DL.DeleteCustomer(DT);
                dgvkh.DataSource = GetCustomer();

                MessageBox.Show(" BẠN ĐÃ XÓA KHÁCH HÀNG THÀNH CÔNG", " Xác nhận");
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            {
                int makh;
                string hokh, tenkh, sdt, gioitinh, diachithuongtru, email;
                DateTime ngaysinh;

                makh = int.Parse(txtmakh.Text.Trim());

                hokh = txthokh.Text.Trim();
                tenkh = txttenkh.Text.Trim();
                gioitinh = txtgioittinhkh.Text.Trim();
                sdt = txtsdtkh.Text.Trim();
                ngaysinh = Convert.ToDateTime(dtpngaysinhkh.Text.ToString());
                diachithuongtru = txtdiachickh.Text.Trim();
                email = txtemailkh.Text.Trim();
                

                DTO_Customer emp = new DTO_Customer(makh, hokh, tenkh, gioitinh, sdt, ngaysinh, diachithuongtru, email);
                try
                {
                    int i = new BUS_Customer().UpdateCustomer(emp);
                    if (i == -2)
                        throw new Exception();
                    MessageBox.Show("ĐÃ SỬA THÀNH CÔNG", "Xác nhận");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dgvkh.DataSource = GetCustomer();
            }
        }



        private void rdbMaKH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMaKH.Checked)
            {
                typeCheck = 1;
            }
        }

        int typeCheck = 0;
        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            switch (typeCheck)
            {

                case 1:
                    {
                        DTO_Customer emp = new DTO_Customer(Convert.ToInt32(txtbtimkiemkh.Text));
                        DataTable dt = new DataTable();
                        BUS_Customer em = new BUS_Customer();
                        dt = em.SearchByMaKH(emp);
                        dgvtimkiem.DataSource = dt;
                        break;
                    }
            }
        }

        private void btnReFeshKH_Click(object sender, EventArgs e)
        {
            txtbtimkiemkh.Clear();
            rdbMaKH.Checked = false;
            dgvtimkiem.DataSource = false;
        }
    }
}
