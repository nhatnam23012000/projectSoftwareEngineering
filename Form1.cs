using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFCS
{
    public partial class Form1 : Form
    {
        private AccountDatabase accountDatabase;
        public Form1(AccountDatabase accountDatabase)
        {
            InitializeComponent();
            this.accountDatabase = accountDatabase;
            lblNotification.Text = "";
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (accountDatabase.checkInfo(txtName.Text, txtPass.Text))
            {
                switch (accountDatabase.getAuthorization(txtName.Text))
                {
                    case Authorization.CUSTOMER:
                        Form3 f3 = new Form3();
                        this.Hide();
                        f3.ShowDialog();
                        txtName.Text = "";
                        txtPass.Text = "";
                        lblNotification.Text = "";
                        this.Show();
                        break;
                    case Authorization.ITSTAFF:
                    case Authorization.MASTERITSTAFF:
                        Form4 f4 = new Form4(txtName.Text, accountDatabase, (StaffAccount)accountDatabase.getAccount(txtName.Text));
                        this.Hide();
                        f4.ShowDialog();
                        txtName.Text = "";
                        txtPass.Text = "";
                        lblNotification.Text = "";
                        this.Show();
                        if (f4.maintenance)
                        {
                            this.Close();
                        }
                        break;
                }
            }
            else
            {
                lblNotification.ForeColor = Color.Red;
                lblNotification.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
            }
        }

        private void lbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2(accountDatabase);
            this.Hide();
            f2.ShowDialog();
            this.Show();
            txtName.Text = "";
            txtPass.Text = "";
            lblNotification.Text = "";
            if (f2.success)
            {
                lblNotification.ForeColor = Color.Green;
                lblNotification.Text = "Đăng ký tài khoản thành công!";
            }
        }
    }
}
