using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Kasir
{
    public partial class Barang : Form
    {
        public Barang()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_penjualanDataSet.tb_barang' table. You can move, or remove it, as needed.
            // this.tb_barangTableAdapter.Fill(this.db_penjualanDataSet.tb_barang);
            // this.tb_jenisTableAdapter.Fill(this.db_penjualanDataSet.tb_jenis);

            Tampil_false();
            Tampil_semua();

        }

        public void Tampil_semua()
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\db_penjualan.accdb";
                con.Open();
                 string sql = "select kode_barang as [KODE BARANG], kode_jenis as [KODE JENIS], nama_barang as [NAMA BARANG], kode_merk as [KODE MERK], harga_jual as [HARGA JUAL], harga_beli as [HARGA BELI], stok_barang as [STOK BARANG], kode_satuan as [KODE SATUAN], keterangan as [KETERANGAN] from tb_barang";
                // string sql = "select * from tb_barang";
                OleDbDataAdapter add = new OleDbDataAdapter(sql, con);
                add.SelectCommand.ExecuteNonQuery();

                DataTable dt = new DataTable();
                add.Fill(dt);
                tb_barangDataGridView.DataSource = dt;


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        private void Tampil_false()
        {
                kode_barangTextBox.Enabled = false;
                kode_jenisTextBox.Enabled = false;
                nama_barangTextBox.Enabled = false;
                kode_merkTextBox.Enabled = false;
                harga_jualTextBox.Enabled = false;
                harga_beliTextBox.Enabled = false;
                stok_barangTextBox.Enabled = false;
                keteranganTextBox.Enabled = false;
                kode_satuanTextBox.Enabled = false;

                ButtonSimpanBarang.Visible = false;
                ButtonEditBarang.Visible = false;
                ButtonHapusBarang.Visible = false;
        }

        private void tb_barangDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow ambil = this.tb_barangDataGridView.Rows[e.RowIndex];
            kode_barangTextBox.Text = ambil.Cells[0].Value.ToString();
            kode_jenisTextBox.Text = ambil.Cells[1].Value.ToString();
            nama_barangTextBox.Text = ambil.Cells[2].Value.ToString();
            kode_merkTextBox.Text = ambil.Cells[3].Value.ToString();
            harga_jualTextBox.Text = ambil.Cells[4].Value.ToString();
            harga_beliTextBox.Text = ambil.Cells[5].Value.ToString();
            stok_barangTextBox.Text = ambil.Cells[6].Value.ToString();
            keteranganTextBox.Text = ambil.Cells[8].Value.ToString();
            kode_satuanTextBox.Text = ambil.Cells[7].Value.ToString();
           
            ButtonSimpanBarang.Visible = true;
            ButtonTambahBarang.Visible = true;
            ButtonEditBarang.Visible = true;
            ButtonHapusBarang.Visible = true;

            kode_barangTextBox.Enabled = false;
        }

        private void ButtonTambahBarang_Click(object sender, EventArgs e)
        {
            Tampil_true_tambah();
        }

        private void Tampil_true_tambah()
        {
            kode_barangTextBox.Enabled = true;
            kode_jenisTextBox.Enabled = true;
            nama_barangTextBox.Enabled = true;
            kode_merkTextBox.Enabled = true;
            harga_jualTextBox.Enabled = true;
            harga_beliTextBox.Enabled = true;
            stok_barangTextBox.Enabled = true;
            keteranganTextBox.Enabled = true;
            kode_satuanTextBox.Enabled = true;

            ButtonTambahBarang.Visible = false;
            ButtonSimpanBarang.Visible = true;

        }

        private void Tampil_true_edit()
        {
            kode_barangTextBox.Enabled = false;
            kode_jenisTextBox.Enabled = true;
            nama_barangTextBox.Enabled = true;
            kode_merkTextBox.Enabled = true;
            harga_jualTextBox.Enabled = true;
            harga_beliTextBox.Enabled = true;
            stok_barangTextBox.Enabled = true;
            keteranganTextBox.Enabled = true;
            kode_satuanTextBox.Enabled = true;
        }


        private void ButtonEditBarang_Click(object sender, EventArgs e)
        {
            if (kode_barangTextBox.Text == "")
            {
                MessageBox.Show("Data Belum Di Pilih", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Tampil_true_edit();
            }
        }

        private void ButtonSimpanBarang_Click(object sender, EventArgs e)
        {
            if (kode_barangTextBox.Text == "")
            {
                MessageBox.Show("Data Belum Di Input!!!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Tampil_false();
                ButtonTambahBarang.Visible = true;

                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\db_penjualan.accdb";
                con.Open();
                string sql = "insert into tb_barang values" + "('" + kode_barangTextBox.Text + "','" + kode_jenisTextBox.Text + "','" + nama_barangTextBox.Text + "','" + kode_merkTextBox.Text + "','" + harga_jualTextBox.Text + "','" + harga_beliTextBox.Text + "','" + stok_barangTextBox.Text + "','" + keteranganTextBox.Text + "','" + kode_satuanTextBox.Text + "')";

                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Di Simpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

                clear();

            }
        }

        private void clear()
        {
            kode_barangTextBox.Enabled = true;
            kode_jenisTextBox.Enabled = true;
            nama_barangTextBox.Enabled = true;
            kode_merkTextBox.Enabled = true;
            harga_jualTextBox.Enabled = true;
            harga_beliTextBox.Enabled = true;
            stok_barangTextBox.Enabled = true;
            keteranganTextBox.Enabled = true;
            kode_satuanTextBox.Enabled = true;
        }

    }
}
