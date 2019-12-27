using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            TB_kode.Enabled = false;
            TB_jenis.Enabled = false;
            BTN_Visible();

        }

        
        private void ButtonTambahJenis_Click(object sender, EventArgs e)
        {
            TB_kode.Enabled = true;
            TB_jenis.Enabled = true;
            ButtonSimpanJenis.Visible = true;
            ButtonDeleteJenis.Visible = true;
            BTN_EditJenis.Visible = true;
            ButtonTambahJenis.Visible = false;
        }

        private void ButtonSimpanJenis_Click(object sender, EventArgs e)
        {
            TB_kode.Enabled = false;
            TB_jenis.Enabled = false;
            ButtonTambahJenis.Visible = true;
            ButtonSimpanJenis.Visible = false;
            ButtonDeleteJenis.Visible = false;
            BTN_EditJenis.Visible = false;
        }
        public void BTN_Visible()
        {
            ButtonSimpanJenis.Visible = false;
            ButtonDeleteJenis.Visible = false;
            BTN_EditJenis.Visible = false;
        }
    }
}
