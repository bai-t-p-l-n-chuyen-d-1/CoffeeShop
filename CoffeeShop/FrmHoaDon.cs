using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

using DAO;
using BUS;
using DTO;
using System.Data.SqlClient;

namespace CoffeeShop
{
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }

        private void FrmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Cancel)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void _TongTien()
        {
            try
            {
                if (lbxTongTien.Items.Count == 0)
                    return;

                float ThanhTien = 0;
                float TongTien = 0;
                for (int i = 0; i < lbxTongTien.Items.Count; i++)
                {
                    ThanhTien = Convert.ToSingle(lbxTongTien.Items[i].ToString().Replace(",", ""));
                    TongTien = TongTien + ThanhTien;
                }
                nudTongTien.Value = Convert.ToDecimal(TongTien);

                //nudTienMat_ValueChanged(null, null);
            }
            catch (Exception)
            {

            }
        }

        public static string _DoiSoSangDonViTienTe(object _object)
        {
            try
            {
                if (_object.ToString().Trim().Length == 0)
                { return " "; }

                if (_object.ToString() == "0")
                {
                    return "0,000";
                }

                decimal dThanhTien = Convert.ToDecimal(_object);
                string strThanhTien = string.Format("{0:#,#.}", dThanhTien);
                return strThanhTien;
            }
            catch (Exception)
            {

            }
            return "0.000";
        }



        private void btnThanhToan_Click(object sender, EventArgs e)
        {        
            try
            {
                int index = dgvMonvaBan.RowCount;//dem so dong trong datagrid view

                for (int i = 0; i <= index; i++)
                {
                    string TenMon = dgvMonvaBan.Rows[i].Cells[1].Value.ToString().Trim();
                    string GiaTien = dgvMonvaBan.Rows[i].Cells[2].Value.ToString().Trim();
                    lbxTenMon.Items.Add(TenMon);
                    string Tam = _DoiSoSangDonViTienTe(GiaTien);
                    lbxTongTien.Items.Add(Tam);
                    _TongTien();
                }
            }
            catch (Exception)
            {
            }
        
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int Index = lbxTenMon.SelectedIndex;
                lbxTenMon.Items.RemoveAt(Index);
                lbxTongTien.Items.RemoveAt(Index);
                _TongTien();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có thông tin để xóa", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbxTenMon.Items.Count != 0) // kiểm tra listView có giá trị hay không == 0 có nghĩa là ko có giá trị nào
                {
                    PrintDialog PrintDialog = new PrintDialog();
                    PrintDocument PrintDocument = new PrintDocument();

                    PrintDialog.Document = PrintDocument; //add the document to the dialog box

                    PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing                                                                                                                //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                    DialogResult result = PrintDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        PrintDocument.Print();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin để in", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float FontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;
            graphic.DrawString("Hóa đơn thanh toán", new Font("Courier New", 17), new SolidBrush(Color.Black), startX + 60, startY);
            string top = "Tên Sản Phẩm".PadRight(24) + "Thành Tiền";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent

            int index = 0;
            foreach (string item in lbxTenMon.Items)
            {
                graphic.DrawString(item, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(lbxTongTien.Items[index++].ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            }

            offset = offset + 20; //make some room so that the total stands out.

            graphic.DrawString("TỔNG TIỀN TRẢ ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(_DoiSoSangDonViTienTe(nudTongTien.Value), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("TIỀN MẶT ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(_DoiSoSangDonViTienTe(nudTienMat.Value), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("TIỀN TRẢ ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(_DoiSoSangDonViTienTe(nudTienTra.Value), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Xin chân thành cảm ơn quý khách!", font, new SolidBrush(Color.Black), startX + 10, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent    
            graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent
            graphic.DrawString("HẸN GẶP LẠI!", font, new SolidBrush(Color.Black), startX + 110, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent                                
            index = dgvMonvaBan.RowCount;//dem so dong trong datagrid view

        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btnThemThanhToan_Click(object sender, EventArgs e)
        {
            try
            {

                int index = dgvMonvaBan.RowCount;//dem so dong trong datagrid view

                for (int i = 0; i <= index; i++)
                {
                    string TenMon = dgvMonvaBan.Rows[i].Cells[1].Value.ToString().Trim();
                    string GiaTien = dgvMonvaBan.Rows[i].Cells[2].Value.ToString().Trim();
                    lbxTenMon.Items.Add(TenMon);
                    string Tam = _DoiSoSangDonViTienTe(GiaTien);
                    lbxTongTien.Items.Add(Tam);
                    _TongTien();
                }
            }
            catch (Exception)
            {
            }
        }

        private void lbxTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxTenMon.SelectedIndex = lbxTongTien.SelectedIndex;
        }

        private void lbxTongTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxTongTien.SelectedIndex = lbxTenMon.SelectedIndex;
        }

        private void getdanhsach() //Ham nay de hien thi bang len datagrid view
        {
            DataSet ds = getMonAnVaBan();
            dgvMonvaBan.DataSource = ds.Tables[0];// bang ao nay duoc do vao dgvDanhMuc
        }

        public DataSet getMonAnVaBan()
        {
            DataProvider dp = new DataProvider();
            SqlConnection cnn = dp.getConnect();//Ham nay tra ve 1 chuoi ket noi
            string sqlMonAn = "SELECT * FROM HoaDon";
            SqlDataAdapter da = new SqlDataAdapter(sqlMonAn, cnn);// van chuyen du lieu
            DataSet ds = new DataSet();//Tao 1 bang ao
            da.Fill(ds);//do du lieu vao bang ao
            return ds;
        }

        public DataSet timMonAnVaBan()
        {
            int MaBan = int.Parse(cbbMonvaBan.SelectedValue.ToString().Trim());
            DataProvider dp = new DataProvider();
            SqlConnection cnn = dp.getConnect();//Ham nay tra ve 1 chuoi ket noi
            string sqlMonAn = "SELECT MaBan,TenMonAn,MonAn.GiaTien,ThoiGian FROM ChiTietHoaDon,HoaDon,MonAn where ChiTietHoaDon.MaMonAn = MonAn.MaMonAn and ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon AND MaBan = '" + MaBan + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlMonAn, cnn);// van chuyen du lieu
            DataSet ds = new DataSet();//Tao 1 bang ao
            da.Fill(ds);//do du lieu vao bang ao
            return ds;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = timMonAnVaBan();
                dgvMonvaBan.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hiện tại chưa có món ăn nào được đặt tại bàn này", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
