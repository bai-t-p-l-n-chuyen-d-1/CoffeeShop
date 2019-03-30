using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTO;
using BUS;
using System.Data.SqlClient;

namespace CoffeeShop
{
    public partial class FrmEmployee : Form
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;

        public FrmEmployee()
        {
            InitializeComponent();
        }

        private List<DTO_Employee> GetEmployee()
        {
            try
            {
                return new BUS_Employee().GetEmployee();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string sql = " SELECT * FROM NhanVien ";
            dgvlistnv.DataSource = GetEmployee();
        }

        private void btnaddnv_Click(object sender, EventArgs e)
        {
            int pMaNV;
            string pHoNV, pTenNV, pGioiTinh, pSodienthoai, pSoCMND, pDiaChiThuongTru, pChucVu;
            DateTime pNgaySinh;

                pMaNV = Convert.ToInt32(txtmanv.Text);
            pHoNV = txthonv.Text.Trim();
            pTenNV = txttennv.Text.Trim();
            pGioiTinh = txtgtnv.Text.Trim();
            pSodienthoai = txtsdtnv.Text.Trim();
            pNgaySinh = Convert.ToDateTime(dtpnsnv.Text.ToString());
            pSoCMND = txtcmndnv.Text.Trim();
            pDiaChiThuongTru = txtdcnv.Text.Trim();
            pChucVu = txtchucvu.Text.Trim();

            DTO_Employee emp = new DTO_Employee(pMaNV, pHoNV, pTenNV, pGioiTinh, pSodienthoai, pNgaySinh, pSoCMND, pDiaChiThuongTru, pChucVu);
            try
            {
                int i = new BUS_Employee().Add(emp);
                if (i == -2)
                    throw new Exception();
                MessageBox.Show("Đã thêm thành công", "Xác nhận");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgvlistnv.DataSource = GetEmployee();
        }

       

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (grbTimKiem.Visible)
                grbTimKiem.Hide();
            else
                grbTimKiem.Show();
        }

        int typeCheck = 0;
        private void btnTimNV_Click(object sender, EventArgs e)
        {                      
                switch (typeCheck)
                {

                    case 1:
                        {
                            DTO_Employee emp = new DTO_Employee(Convert.ToInt32(txtbTimKiem.Text));
                            DataTable dt = new DataTable();
                            BUS_Employee em = new BUS_Employee();
                            dt = em.SearchByMaNV(emp);
                            dgvTimKiem.DataSource = dt;
                            break;
                        }                
            }            
        }

        private void rdbMaNV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMaNV.Checked)
            {
                typeCheck = 1;
            }
        }

        private void btnReFesh_Click(object sender, EventArgs e)
        {
            txtbTimKiem.Clear();
            rdbMaNV.Checked = false;
            dgvTimKiem.DataSource = false;
        }

        private void FrmEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Cancel)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void btndeletenv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá thật không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BUS_Employee dl = new BUS_Employee();
                DTO_Employee dt = new DTO_Employee(Convert.ToInt32(txtmanv.Text));
                dl.Delete(dt);
                dgvlistnv.DataSource = GetEmployee();

                MessageBox.Show(" BẠN ĐÃ XÓA NHÂN VIÊN THÀNH CÔNG", " Xác nhận");
            }
        }

        private void dgvlistnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvlistnv.Rows[e.RowIndex];
            txtmanv.Text = row.Cells[0].Value.ToString();
            txthonv.Text = row.Cells[1].Value.ToString();
            txttennv.Text = row.Cells[2].Value.ToString();
            txtgtnv.Text = row.Cells[3].Value.ToString();
            txtsdtnv.Text = row.Cells[4].Value.ToString();
            dtpnsnv.Text = row.Cells[5].Value.ToString();
            txtdcnv.Text = row.Cells[6].Value.ToString();
            txtcmndnv.Text = row.Cells[7].Value.ToString();
            txtchucvu.Text = row.Cells[8].Value.ToString();

        }

        private void btnrefeshnv_Click(object sender, EventArgs e)
        {
            txtmanv.Clear();
            txthonv.Clear();
            txttennv.Clear();
            txtgtnv.Clear();
            txtsdtnv.Clear();
            txtdcnv.Clear();
            txtcmndnv.Clear();
            dtpnsnv.Refresh();
            txtchucvu.Clear();
        }

        private void btneditnv_Click(object sender, EventArgs e)
        {

            int manv;
            string honv, tennv, sdt, chucvu, gioitinh, cmnd, diachithuongtru;
            DateTime ngaysinh;

            manv = int.Parse(txtmanv.Text.Trim());
                      
            honv = txthonv.Text.Trim();
            tennv = txttennv.Text.Trim();
            gioitinh = txtgtnv.Text.Trim();
            sdt = txtsdtnv.Text.Trim();
            ngaysinh = Convert.ToDateTime(dtpnsnv.Text.ToString());     
            cmnd = txtcmndnv.Text.Trim();
            diachithuongtru = txtdcnv.Text.Trim();
            chucvu = txtchucvu.Text.Trim();



            DTO_Employee emp = new DTO_Employee(manv, honv, tennv, gioitinh, sdt, ngaysinh, cmnd, diachithuongtru, chucvu);
            try
            {
                int i = new BUS_Employee().UpdateEmployee(emp);
                if (i == -2)
                    throw new Exception();
                MessageBox.Show("Đã sửa thành công", "Xác nhận");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            dgvlistnv.DataSource = GetEmployee();

        }
    }
}

