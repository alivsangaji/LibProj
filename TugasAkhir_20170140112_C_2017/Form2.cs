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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tambahAnggota move = new tambahAnggota();
            move.MdiParent = this.MdiParent;
            this.Close();
            move.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            daftarAnggota move2 = new daftarAnggota();
            move2.MdiParent = this.MdiParent;
            this.Close();
            move2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tambahPeminjam move3 = new tambahPeminjam();
            move3.MdiParent = this.MdiParent;
            this.Close();
            move3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            daftarPeminjam move4 = new daftarPeminjam();
            move4.MdiParent = this.MdiParent;
            this.Close();
            move4.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            daftarAnggota move2 = new daftarAnggota();
            move2.MdiParent = this.MdiParent;
            this.Close();
            move2.Show();
        }
    }
}
