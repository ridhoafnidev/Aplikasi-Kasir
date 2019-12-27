using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;


namespace Aplikasi_Kasir
{
    public partial class Jenis : Form
    {
        

        public Jenis()
        {
            InitializeComponent();
        } 

        private void tb_jenisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_jenisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_penjualanDataSet);

        }

        private void Jenis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_penjualanDataSet.tb_jenis' table. You can move, or remove it, as needed.
        //this.tb_jenisTableAdapter.Fill(this.db_penjualanDataSet.tb_jenis);
            
            Tampil_false();
            Tampil_semua();
            

        }

        private void ButtonTambahJenis_Click(object sender, EventArgs e)
        {
            Tampil_true();
            ButtonTambahJenis.Visible = false;

        }

        private void ButtonSimpanJenis_Click(object sender, EventArgs e)
        {
            if (TB_kode.Text == "")
            {
                MessageBox.Show("Data Belum Di Input!!!","INFORMASI",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                Tampil_false();
                ButtonTambahJenis.Visible = true;

                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ali\Aplikasi Destop\Aplikasi Kasir\bin\Debug\Database\db_penjualan.accdb";
                con.Open();
                string sql = "insert into tb_jenis values" + "('" + TB_kode.Text + "','" + TB_jenis.Text + "')";

                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Di Simpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

                clear();

            }

        }
        public void Tampil_false()
        {
            TB_kode.Enabled = false;
            TB_jenis.Enabled = false;
            ButtonSimpanJenis.Visible = false;
            ButtonDeleteJenis.Visible = false;
            BTN_EditJenis.Visible = false;
            BTN_Ubah.Visible = false;
        }
        public void Tampil_true()
        {
            TB_kode.Enabled = true;
            TB_jenis.Enabled = true;
            ButtonSimpanJenis.Visible = true;
            ButtonDeleteJenis.Visible = true;
            BTN_EditJenis.Visible = true;
        }

        public void Tampil_semua()
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ali\Aplikasi Destop\Aplikasi Kasir\bin\Debug\Database\db_penjualan.accdb";
                con.Open();
                string sql = "select kode_jenis as [KODE JENIS], nama_jenis as [NAMA JENIS] from tb_jenis";

                OleDbDataAdapter ad = new OleDbDataAdapter(sql, con);
                ad.SelectCommand.ExecuteNonQuery();


                DataTable dt = new DataTable();
                ad.Fill(dt);
                DGV_jenis.DataSource = dt;


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        public void clear()
        {
            TB_kode.Text = "";
            TB_jenis.Text = "";
        }

        private void Jenis_Activated(object sender, EventArgs e)
        {
            Tampil_semua();
        }

        private void ButtonDeleteJenis_Click(object sender, EventArgs e)
        {
            if (TB_kode.Text == "")
            {
                MessageBox.Show("Data Belum Di Pilih","INFORMASI",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                
                DialogResult result = MessageBox.Show("Yakin Ingin Menghapus Data " + TB_jenis.Text, "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ali\Aplikasi Destop\Aplikasi Kasir\bin\Debug\Database\db_penjualan.accdb";
                    con.Open();
                    string sql = "delete from tb_jenis where kode_jenis ='" + TB_kode.Text + "'";

                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    clear();
                    Tampil_semua();
                    ButtonTambahJenis.Visible = true;
                }
                else
                {
                    MessageBox.Show("Data Gagal Dihapus","INFORMASI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ButtonTambahJenis.Visible = true;
                    clear();
                }
                
            }
            
        }

        private void DGV_jenis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow ambil = this.DGV_jenis.Rows[e.RowIndex];
            TB_kode.Text = ambil.Cells[0].Value.ToString();
            TB_jenis.Text = ambil.Cells[1].Value.ToString();
            ButtonSimpanJenis.Visible = false;
            ButtonTambahJenis.Visible = false;
            BTN_EditJenis.Visible = true;
            ButtonDeleteJenis.Visible = true;

            TB_jenis.Enabled = false;
            TB_kode.Enabled = false;


        }

        private void BTN_EditJenis_Click(object sender, EventArgs e)
        {
            if(TB_kode.Text == "")
            {
                MessageBox.Show("Data Belum Di Pilih","INFORMASI",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                TB_jenis.Enabled = true;
                TB_kode.Enabled = false;
                BTN_Ubah.Visible = true;

                
            }
        }

        private void BTN_Ubah_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ali\Aplikasi Destop\Aplikasi Kasir\bin\Debug\Database\db_penjualan.accdb";
            con.Open();
            string sql = "update tb_jenis set nama_jenis='" + TB_jenis.Text + "' where kode_jenis='" + TB_kode.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Di Ubah","INFORMASI", MessageBoxButtons.OK,MessageBoxIcon.Information);

            Tampil_false();
            ButtonTambahJenis.Visible = true;
            clear();
        }

    }
}
