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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_barangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_barangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_penjualanDataSet);

        }

        private void tb_barangBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_barangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_penjualanDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_penjualanDataSet.tb_barang' table. You can move, or remove it, as needed.
            this.tb_barangTableAdapter.Fill(this.db_penjualanDataSet.tb_barang);

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
