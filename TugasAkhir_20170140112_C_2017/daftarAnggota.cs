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
    public partial class daftarAnggota : Form
    {
        public daftarAnggota()
        {
            InitializeComponent();
        }
        DataTable dt;
        DataRow dr;
        bool o = true;
        string code, a;
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this.MdiParent;
            this.Close();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string code;
            code = editId.Text;
            dr = perpustakaanDataSet.Tables["anggota"].Rows.Find(code);
            dr.Delete();
            editTanggal.ResetText();
            this.anggotaTableAdapter2.Fill(this.perpustakaanDataSet.anggota);

            MessageBox.Show("Data Berhasil Dihapus !!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code;
            code = editId.Text;
            dr = perpustakaanDataSet.Tables["anggota"].Rows.Find(code);
            dr.EndEdit();
            dr[1] = editNama.Text;
            dr[2] = editStatus.Text;
            dr[3] = editAlamat.Text;
            dr[4] = editTanggal.Text;
            dr[5] = editTelp.Text;
            anggotaTableAdapter2.Update(perpustakaanDataSet);
            this.anggotaTableAdapter2.Fill(this.perpustakaanDataSet.anggota);
        }

        private void editId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "nama like '%" + searchtb.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void daftarAnggota_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perpustakaanDataSet.anggota' table. You can move, or remove it, as needed.
            this.anggotaTableAdapter2.Fill(this.perpustakaanDataSet.anggota);
            // TODO: This line of code loads data into the 'anggotaperpusanyarDataSet.anggota' table. You can move, or remove it, as needed.
            this.anggotaTableAdapter1.Fill(this.anggotaperpusanyarDataSet.anggota);
            // TODO: This line of code loads data into the 'anggotaDataSet.anggota' table. You can move, or remove it, as needed.
            this.anggotaTableAdapter.Fill(this.anggotaDataSet.anggota);
            editId.Enabled = false;
            dataGridView1.Enabled = false;

        }
    }
}
