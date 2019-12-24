namespace Aplikasi_Kasir
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label kode_barangLabel;
            System.Windows.Forms.Label kode_jenisLabel;
            System.Windows.Forms.Label nama_barangLabel;
            System.Windows.Forms.Label kode_merkLabel;
            System.Windows.Forms.Label harga_jualLabel;
            System.Windows.Forms.Label harga_beliLabel;
            System.Windows.Forms.Label stok_barangLabel;
            System.Windows.Forms.Label keteranganLabel;
            System.Windows.Forms.Label kode_satuanLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.db_penjualanDataSet = new Aplikasi_Kasir.db_penjualanDataSet();
            this.tb_barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_barangTableAdapter = new Aplikasi_Kasir.db_penjualanDataSetTableAdapters.tb_barangTableAdapter();
            this.tableAdapterManager = new Aplikasi_Kasir.db_penjualanDataSetTableAdapters.TableAdapterManager();
            this.tb_barangBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_barangBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kode_barangTextBox = new System.Windows.Forms.TextBox();
            this.kode_jenisTextBox = new System.Windows.Forms.TextBox();
            this.nama_barangTextBox = new System.Windows.Forms.TextBox();
            this.kode_merkTextBox = new System.Windows.Forms.TextBox();
            this.harga_jualTextBox = new System.Windows.Forms.TextBox();
            this.harga_beliTextBox = new System.Windows.Forms.TextBox();
            this.stok_barangTextBox = new System.Windows.Forms.TextBox();
            this.keteranganTextBox = new System.Windows.Forms.TextBox();
            this.kode_satuanTextBox = new System.Windows.Forms.TextBox();
            this.tb_barangDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonTambahBarang = new System.Windows.Forms.Button();
            this.ButtonSimpanBarang = new System.Windows.Forms.Button();
            this.ButtonEditBarang = new System.Windows.Forms.Button();
            this.ButtonHapusBarang = new System.Windows.Forms.Button();
            this.ButtonCariButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            kode_barangLabel = new System.Windows.Forms.Label();
            kode_jenisLabel = new System.Windows.Forms.Label();
            nama_barangLabel = new System.Windows.Forms.Label();
            kode_merkLabel = new System.Windows.Forms.Label();
            harga_jualLabel = new System.Windows.Forms.Label();
            harga_beliLabel = new System.Windows.Forms.Label();
            stok_barangLabel = new System.Windows.Forms.Label();
            keteranganLabel = new System.Windows.Forms.Label();
            kode_satuanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_penjualanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_barangBindingNavigator)).BeginInit();
            this.tb_barangBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_barangDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kode_barangLabel
            // 
            kode_barangLabel.AutoSize = true;
            kode_barangLabel.Location = new System.Drawing.Point(40, 60);
            kode_barangLabel.Name = "kode_barangLabel";
            kode_barangLabel.Size = new System.Drawing.Size(72, 13);
            kode_barangLabel.TabIndex = 1;
            kode_barangLabel.Text = "Kode Barang:";
            // 
            // kode_jenisLabel
            // 
            kode_jenisLabel.AutoSize = true;
            kode_jenisLabel.Location = new System.Drawing.Point(40, 86);
            kode_jenisLabel.Name = "kode_jenisLabel";
            kode_jenisLabel.Size = new System.Drawing.Size(62, 13);
            kode_jenisLabel.TabIndex = 3;
            kode_jenisLabel.Text = "Kode Jenis:";
            // 
            // nama_barangLabel
            // 
            nama_barangLabel.AutoSize = true;
            nama_barangLabel.Location = new System.Drawing.Point(40, 112);
            nama_barangLabel.Name = "nama_barangLabel";
            nama_barangLabel.Size = new System.Drawing.Size(75, 13);
            nama_barangLabel.TabIndex = 5;
            nama_barangLabel.Text = "Nama Barang:";
            // 
            // kode_merkLabel
            // 
            kode_merkLabel.AutoSize = true;
            kode_merkLabel.Location = new System.Drawing.Point(40, 138);
            kode_merkLabel.Name = "kode_merkLabel";
            kode_merkLabel.Size = new System.Drawing.Size(34, 13);
            kode_merkLabel.TabIndex = 7;
            kode_merkLabel.Text = "Merk:";
            // 
            // harga_jualLabel
            // 
            harga_jualLabel.AutoSize = true;
            harga_jualLabel.Location = new System.Drawing.Point(303, 57);
            harga_jualLabel.Name = "harga_jualLabel";
            harga_jualLabel.Size = new System.Drawing.Size(61, 13);
            harga_jualLabel.TabIndex = 9;
            harga_jualLabel.Text = "Harga Jual:";
            // 
            // harga_beliLabel
            // 
            harga_beliLabel.AutoSize = true;
            harga_beliLabel.Location = new System.Drawing.Point(303, 83);
            harga_beliLabel.Name = "harga_beliLabel";
            harga_beliLabel.Size = new System.Drawing.Size(59, 13);
            harga_beliLabel.TabIndex = 11;
            harga_beliLabel.Text = "Harga Beli:";
            // 
            // stok_barangLabel
            // 
            stok_barangLabel.AutoSize = true;
            stok_barangLabel.Location = new System.Drawing.Point(303, 109);
            stok_barangLabel.Name = "stok_barangLabel";
            stok_barangLabel.Size = new System.Drawing.Size(69, 13);
            stok_barangLabel.TabIndex = 13;
            stok_barangLabel.Text = "Stok Barang:";
            // 
            // keteranganLabel
            // 
            keteranganLabel.AutoSize = true;
            keteranganLabel.Location = new System.Drawing.Point(545, 54);
            keteranganLabel.Name = "keteranganLabel";
            keteranganLabel.Size = new System.Drawing.Size(65, 13);
            keteranganLabel.TabIndex = 15;
            keteranganLabel.Text = "Keterangan:";
            // 
            // kode_satuanLabel
            // 
            kode_satuanLabel.AutoSize = true;
            kode_satuanLabel.Location = new System.Drawing.Point(303, 137);
            kode_satuanLabel.Name = "kode_satuanLabel";
            kode_satuanLabel.Size = new System.Drawing.Size(72, 13);
            kode_satuanLabel.TabIndex = 17;
            kode_satuanLabel.Text = "Kode Satuan:";
            // 
            // db_penjualanDataSet
            // 
            this.db_penjualanDataSet.DataSetName = "db_penjualanDataSet";
            this.db_penjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_barangBindingSource
            // 
            this.tb_barangBindingSource.DataMember = "tb_barang";
            this.tb_barangBindingSource.DataSource = this.db_penjualanDataSet;
            // 
            // tb_barangTableAdapter
            // 
            this.tb_barangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_barangTableAdapter = this.tb_barangTableAdapter;
            this.tableAdapterManager.tb_detail_penjualanTableAdapter = null;
            this.tableAdapterManager.tb_jenisTableAdapter = null;
            this.tableAdapterManager.tb_merkTableAdapter = null;
            this.tableAdapterManager.tb_penggunaTableAdapter = null;
            this.tableAdapterManager.tb_penjualanTableAdapter = null;
            this.tableAdapterManager.tb_satuanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aplikasi_Kasir.db_penjualanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_barangBindingNavigator
            // 
            this.tb_barangBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_barangBindingNavigator.BindingSource = this.tb_barangBindingSource;
            this.tb_barangBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_barangBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_barangBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tb_barangBindingNavigatorSaveItem});
            this.tb_barangBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_barangBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_barangBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_barangBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_barangBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_barangBindingNavigator.Name = "tb_barangBindingNavigator";
            this.tb_barangBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_barangBindingNavigator.Size = new System.Drawing.Size(840, 25);
            this.tb_barangBindingNavigator.TabIndex = 0;
            this.tb_barangBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_barangBindingNavigatorSaveItem
            // 
            this.tb_barangBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_barangBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_barangBindingNavigatorSaveItem.Image")));
            this.tb_barangBindingNavigatorSaveItem.Name = "tb_barangBindingNavigatorSaveItem";
            this.tb_barangBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tb_barangBindingNavigatorSaveItem.Text = "Save Data";
            this.tb_barangBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_barangBindingNavigatorSaveItem_Click_1);
            // 
            // kode_barangTextBox
            // 
            this.kode_barangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_barangBindingSource, "kode_barang", true));
            this.kode_barangTextBox.Location = new System.Drawing.Point(118, 57);
            this.kode_barangTextBox.Name = "kode_barangTextBox";
            this.kode_barangTextBox.Size = new System.Drawing.Size(126, 20);
            this.kode_barangTextBox.TabIndex = 2;
            // 
            // kode_jenisTextBox
            // 
            this.kode_jenisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_barangBindingSource, "kode_jenis", true));
            this.kode_jenisTextBox.Location = new System.Drawing.Point(118, 83);
            this.kode_jenisTextBox.Name = "kode_jenisTextBox";
            this.kode_jenisTextBox.Size = new System.Drawing.Size(126, 20);
            this.kode_jenisTextBox.TabIndex = 4;
            // 
            // nama_barangTextBox
            // 
            this.nama_barangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_barangBindingSource, "nama_barang", true));
            this.nama_barangTextBox.Location = new System.Drawing.Point(118, 109);
            this.nama_barangTextBox.Name = "nama_barangTextBox";
            this.nama_barangTextBox.Size = new System.Drawing.Size(126, 20);
            this.nama_barangTextBox.TabIndex = 6;
            // 
            // kode_merkTextBox
            // 
            this.kode_merkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_barangBindingSource, "kode_merk", true));
            this.kode_merkTextBox.Location = new System.Drawing.Point(118, 135);
            this.kode_merkTextBox.Name = "kode_merkTextBox";
            this.kode_merkTextBox.Size = new System.Drawing.Size(126, 20);
            this.kode_merkTextBox.TabIndex = 8;
            // 
            // harga_jualTextBox
            // 
            this.harga_jualTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_barangBindingSource, "harga_jual", true));
            this.harga_jualTextBox.Location = new System.Drawing.Point(381, 54);
            this.harga_jualTextBox.Name = "harga_jualTextBox";
            this.harga_jualTextBox.Size = new System.Drawing.Size(142, 20);
            this.harga_jualTextBox.TabIndex = 10;
            // 
            // harga_beliTextBox
            // 
            this.harga_beliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_barangBindingSource, "harga_beli", true));
            this.harga_beliTextBox.Location = new System.Drawing.Point(381, 80);
            this.harga_beliTextBox.Name = "harga_beliTextBox";
            this.harga_beliTextBox.Size = new System.Drawing.Size(142, 20);
            this.harga_beliTextBox.TabIndex = 12;
            // 
            // stok_barangTextBox
            // 
            this.stok_barangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_barangBindingSource, "stok_barang", true));
            this.stok_barangTextBox.Location = new System.Drawing.Point(381, 106);
            this.stok_barangTextBox.Name = "stok_barangTextBox";
            this.stok_barangTextBox.Size = new System.Drawing.Size(142, 20);
            this.stok_barangTextBox.TabIndex = 14;
            // 
            // keteranganTextBox
            // 
            this.keteranganTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_barangBindingSource, "keterangan", true));
            this.keteranganTextBox.Location = new System.Drawing.Point(610, 51);
            this.keteranganTextBox.Multiline = true;
            this.keteranganTextBox.Name = "keteranganTextBox";
            this.keteranganTextBox.Size = new System.Drawing.Size(181, 50);
            this.keteranganTextBox.TabIndex = 16;
            // 
            // kode_satuanTextBox
            // 
            this.kode_satuanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_barangBindingSource, "kode_satuan", true));
            this.kode_satuanTextBox.Location = new System.Drawing.Point(381, 134);
            this.kode_satuanTextBox.Name = "kode_satuanTextBox";
            this.kode_satuanTextBox.Size = new System.Drawing.Size(142, 20);
            this.kode_satuanTextBox.TabIndex = 18;
            // 
            // tb_barangDataGridView
            // 
            this.tb_barangDataGridView.AutoGenerateColumns = false;
            this.tb_barangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_barangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.tb_barangDataGridView.DataSource = this.tb_barangBindingSource;
            this.tb_barangDataGridView.Location = new System.Drawing.Point(27, 240);
            this.tb_barangDataGridView.Name = "tb_barangDataGridView";
            this.tb_barangDataGridView.Size = new System.Drawing.Size(776, 185);
            this.tb_barangDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kode_barang";
            this.dataGridViewTextBoxColumn1.HeaderText = "kode_barang";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "kode_jenis";
            this.dataGridViewTextBoxColumn2.HeaderText = "kode_jenis";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nama_barang";
            this.dataGridViewTextBoxColumn3.HeaderText = "nama_barang";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "kode_merk";
            this.dataGridViewTextBoxColumn4.HeaderText = "kode_merk";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "harga_jual";
            this.dataGridViewTextBoxColumn5.HeaderText = "harga_jual";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "harga_beli";
            this.dataGridViewTextBoxColumn6.HeaderText = "harga_beli";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "stok_barang";
            this.dataGridViewTextBoxColumn7.HeaderText = "stok_barang";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "keterangan";
            this.dataGridViewTextBoxColumn8.HeaderText = "keterangan";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "kode_satuan";
            this.dataGridViewTextBoxColumn9.HeaderText = "kode_satuan";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // ButtonTambahBarang
            // 
            this.ButtonTambahBarang.Location = new System.Drawing.Point(27, 188);
            this.ButtonTambahBarang.Name = "ButtonTambahBarang";
            this.ButtonTambahBarang.Size = new System.Drawing.Size(75, 23);
            this.ButtonTambahBarang.TabIndex = 20;
            this.ButtonTambahBarang.Text = "Tambah";
            this.ButtonTambahBarang.UseVisualStyleBackColor = true;
            // 
            // ButtonSimpanBarang
            // 
            this.ButtonSimpanBarang.Location = new System.Drawing.Point(130, 188);
            this.ButtonSimpanBarang.Name = "ButtonSimpanBarang";
            this.ButtonSimpanBarang.Size = new System.Drawing.Size(75, 23);
            this.ButtonSimpanBarang.TabIndex = 21;
            this.ButtonSimpanBarang.Text = "Simpan";
            this.ButtonSimpanBarang.UseVisualStyleBackColor = true;
            // 
            // ButtonEditBarang
            // 
            this.ButtonEditBarang.Location = new System.Drawing.Point(232, 188);
            this.ButtonEditBarang.Name = "ButtonEditBarang";
            this.ButtonEditBarang.Size = new System.Drawing.Size(75, 23);
            this.ButtonEditBarang.TabIndex = 22;
            this.ButtonEditBarang.Text = "Edit";
            this.ButtonEditBarang.UseVisualStyleBackColor = true;
            // 
            // ButtonHapusBarang
            // 
            this.ButtonHapusBarang.Location = new System.Drawing.Point(332, 188);
            this.ButtonHapusBarang.Name = "ButtonHapusBarang";
            this.ButtonHapusBarang.Size = new System.Drawing.Size(75, 23);
            this.ButtonHapusBarang.TabIndex = 23;
            this.ButtonHapusBarang.Text = "Hapus";
            this.ButtonHapusBarang.UseVisualStyleBackColor = true;
            // 
            // ButtonCariButton
            // 
            this.ButtonCariButton.Location = new System.Drawing.Point(464, 187);
            this.ButtonCariButton.Name = "ButtonCariButton";
            this.ButtonCariButton.Size = new System.Drawing.Size(87, 23);
            this.ButtonCariButton.TabIndex = 24;
            this.ButtonCariButton.Text = "Cari";
            this.ButtonCariButton.UseVisualStyleBackColor = true;
            this.ButtonCariButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(585, 186);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 25);
            this.textBox1.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(26, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 132);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Barang";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(287, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 132);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info Harga";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 569);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonCariButton);
            this.Controls.Add(this.ButtonHapusBarang);
            this.Controls.Add(this.ButtonEditBarang);
            this.Controls.Add(this.ButtonSimpanBarang);
            this.Controls.Add(this.ButtonTambahBarang);
            this.Controls.Add(this.tb_barangDataGridView);
            this.Controls.Add(kode_barangLabel);
            this.Controls.Add(this.kode_barangTextBox);
            this.Controls.Add(kode_jenisLabel);
            this.Controls.Add(this.kode_jenisTextBox);
            this.Controls.Add(nama_barangLabel);
            this.Controls.Add(this.nama_barangTextBox);
            this.Controls.Add(kode_merkLabel);
            this.Controls.Add(this.kode_merkTextBox);
            this.Controls.Add(harga_jualLabel);
            this.Controls.Add(this.harga_jualTextBox);
            this.Controls.Add(harga_beliLabel);
            this.Controls.Add(this.harga_beliTextBox);
            this.Controls.Add(stok_barangLabel);
            this.Controls.Add(this.stok_barangTextBox);
            this.Controls.Add(keteranganLabel);
            this.Controls.Add(this.keteranganTextBox);
            this.Controls.Add(kode_satuanLabel);
            this.Controls.Add(this.kode_satuanTextBox);
            this.Controls.Add(this.tb_barangBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_penjualanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_barangBindingNavigator)).EndInit();
            this.tb_barangBindingNavigator.ResumeLayout(false);
            this.tb_barangBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_barangDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_penjualanDataSet db_penjualanDataSet;
        private System.Windows.Forms.BindingSource tb_barangBindingSource;
        private db_penjualanDataSetTableAdapters.tb_barangTableAdapter tb_barangTableAdapter;
        private db_penjualanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_barangBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tb_barangBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox kode_barangTextBox;
        private System.Windows.Forms.TextBox kode_jenisTextBox;
        private System.Windows.Forms.TextBox nama_barangTextBox;
        private System.Windows.Forms.TextBox kode_merkTextBox;
        private System.Windows.Forms.TextBox harga_jualTextBox;
        private System.Windows.Forms.TextBox harga_beliTextBox;
        private System.Windows.Forms.TextBox stok_barangTextBox;
        private System.Windows.Forms.TextBox keteranganTextBox;
        private System.Windows.Forms.TextBox kode_satuanTextBox;
        private System.Windows.Forms.DataGridView tb_barangDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button ButtonTambahBarang;
        private System.Windows.Forms.Button ButtonSimpanBarang;
        private System.Windows.Forms.Button ButtonEditBarang;
        private System.Windows.Forms.Button ButtonHapusBarang;
        private System.Windows.Forms.Button ButtonCariButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

