using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhir_20170140112_C_2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user1, pass1;
            user1 = txtUser.Text;
            pass1 = txtPass.Text;
            if (user1 == "admin" && pass1 == "admin")
            {
                Form1 f1 = new Form1();
                Form2 f2 = new Form2();
                f2.MdiParent = this.MdiParent;
                txtUser.Text = "";
                txtPass.Text = "";
                this.Hide();
                f2.Show();
                
                
            }
            else {
                MessageBox.Show("Username or password incorrect!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
