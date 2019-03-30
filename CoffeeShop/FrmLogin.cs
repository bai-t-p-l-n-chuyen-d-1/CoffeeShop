using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using BUS;
using DTO;

namespace CoffeeShop
{
    public partial class FrmLogin : Form
    {
        string userName = "";
        string passWord = "";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtid.Text = "User Name";
            txtid.ForeColor = Color.Gray;

            txtpw.PasswordChar = '\0';
            txtpw.Text = "Password";
            txtpw.ForeColor = Color.Gray;

            bool capsLock = Console.CapsLock;
            if (capsLock == true)
                lbcapslock.Text = "Bạn đang bật Capslock";
            else
                lbcapslock.Text = "";
        }

        private void txtid_Enter_1(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtid.ForeColor = Color.Black;
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                this.txtid.Focus();
                this.txtid.Select(0, this.txtid.Text.Length);
            }
            if (e.KeyCode == Keys.CapsLock)
            {
                bool capsLock = Console.CapsLock;
                if (capsLock == true)
                    lbcapslock.Text = "Bạn đang bật Capslock";
                else
                    lbcapslock.Text = "";
            }
        }

        private void txtid_Leave(object sender, EventArgs e)
        {
            userName = txtid.Text;
            if (userName.Equals("User Name"))
            {
                txtid.Text = "User Name";
                txtid.ForeColor = Color.Gray;
            }
            else
            {
                if (userName.Equals(""))
                {
                    txtid.Text = "User Name";
                    txtid.ForeColor = Color.Gray;
                }
                else
                {
                    txtid.Text = userName;
                    txtid.ForeColor = Color.Black;
                }
            }
        }

        private void txtpw_Enter(object sender, EventArgs e)
        {
            txtpw.Text = "";
            txtpw.ForeColor = Color.Black;
            txtpw.PasswordChar = '*';
        }

        private void txtpw_Leave(object sender, EventArgs e)
        {
            passWord = txtpw.Text;
            if (passWord.Equals("Password"))
            {
                txtpw.Text = "Password";
                txtpw.ForeColor = Color.Gray;
            }
            else
            {
                if (passWord.Equals(""))
                {
                    txtpw.PasswordChar = '\0';
                    txtpw.Text = "Password";
                    txtpw.ForeColor = Color.Gray;
                }
                else
                {
                    txtpw.PasswordChar = '*';
                    txtpw.Text = passWord;
                    txtpw.ForeColor = Color.Black;
                }
            }
        }

        private void txtpw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                this.txtpw.Focus();
                this.txtpw.Select(0, this.txtpw.Text.Length);
            }
            if (e.KeyCode == Keys.CapsLock)
            {
                bool capsLock = Console.CapsLock;
                if (capsLock == true)
                    lbcapslock.Text = "Bạn đang bật Capslock";
                else
                    lbcapslock.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click_2(object sender, EventArgs e)
        {
            BUS_Login login = new BUS_Login();
            DTO_Login lg = new DTO_Login(txtid.Text, txtpw.Text);
            int ketQua = login.IsLogin(lg);
            if (ketQua == 1)
            {
                this.Hide();
                FrmHome frmHome = new FrmHome();
                frmHome.ShowDialog();
                this.Close();

            }
            else if (ketQua == 2)
            {
                DialogResult dlr = MessageBox.Show("Bạn chưa nhập Username hoặc Password ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else if (ketQua == 0)
            {

                MessageBox.Show("Mật khẩu hoặc tài khoản không đúng!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Cancel)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }
}

