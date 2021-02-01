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
    public partial class daftarPeminjam : Form
    {
        public daftarPeminjam()
        {
            InitializeComponent();
        }
        DataTable dt;
        DataRow dr;
        bool o = true;
        string code, a;

        private void daftarPeminjam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perpustakaanDataSet.peminjaman' table. You can move, or remove it, as needed.
            this.peminjamanTableAdapter1.Fill(this.perpustakaanDataSet.peminjaman);
            // TODO: This line of code loads data into the 'peminjamDataSet.peminjaman' table. You can move, or remove it, as needed.
            this.peminjamanTableAdapter.Fill(this.peminjamDataSet.peminjaman);

            editIdPinjam.Enabled = false;
            editIdAnggota.Enabled = false;
            editNamaBuku.Enabled = false;
            editTglPinjam.Enabled = false;

            editSttsPinjam.Items.Add("Belum Dikembalikan");
            editSttsPinjam.Items.Add("Sudah Dikembalikan");

        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this.MdiParent;
            this.Close();
            f2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string code;
            code = editIdPinjam.Text;
            dr = perpustakaanDataSet.Tables["peminjaman"].Rows.Find(code);
            dr.Delete();
            this.peminjamanTableAdapter1.Fill(this.perpustakaanDataSet.peminjaman);
            MessageBox.Show("Data Berhasil Dihapus !!!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "Convert(id_anggota,'System.String') like '%" + searchTextBox.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code;
            code = editIdPinjam.Text;
            dr = perpustakaanDataSet.Tables["peminjaman"].Rows.Find(code);
            dr.EndEdit();
            dr[4] = pickerPengembalian.Text;
            dr[5] = editSttsPinjam.Text;
            peminjamanTableAdapter1.Update(perpustakaanDataSet);
            this.peminjamanTableAdapter1.Fill(this.perpustakaanDataSet.peminjaman);
        }
    }
}
