using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string user = "cnttqn";
            string pass = "cnttqndotcom";
            if (user.Equals(txtdangnhap.Text) && pass.Equals(txtpass.Text))
            {
                MessageBox.Show("Dang nhap thanh cong");
            }
            else
                MessageBox.Show("Sai tai khoan hoac mat khau");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
