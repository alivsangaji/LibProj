namespace TugasAkhir_20170140112_C_2017
{
    partial class daftarPeminjam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(daftarPeminjam));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpeminjamanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idanggotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglpinjamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglbalikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuspinjamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peminjamanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.perpustakaanDataSet = new TugasAkhir_20170140112_C_2017.perpustakaanDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.editTglPinjam = new System.Windows.Forms.TextBox();
            this.editNamaBuku = new System.Windows.Forms.TextBox();
            this.editIdAnggota = new System.Windows.Forms.TextBox();
            this.editIdPinjam = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pickerPengembalian = new System.Windows.Forms.DateTimePicker();
            this.editSttsPinjam = new System.Windows.Forms.ComboBox();
            this.peminjamanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peminjamDataSet = new TugasAkhir_20170140112_C_2017.peminjamDataSet();
            this.peminjamanTableAdapter = new TugasAkhir_20170140112_C_2017.peminjamDataSetTableAdapters.peminjamanTableAdapter();
            this.peminjamanTableAdapter1 = new TugasAkhir_20170140112_C_2017.perpustakaanDataSetTableAdapters.peminjamanTableAdapter();
            this.searchButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peminjamanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peminjamanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peminjamDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpeminjamanDataGridViewTextBoxColumn,
            this.idanggotaDataGridViewTextBoxColumn,
            this.namabukuDataGridViewTextBoxColumn,
            this.tglpinjamDataGridViewTextBoxColumn,
            this.tglbalikDataGridViewTextBoxColumn,
            this.statuspinjamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.peminjamanBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 680);
            this.dataGridView1.TabIndex = 0;
            // 
            // idpeminjamanDataGridViewTextBoxColumn
            // 
            this.idpeminjamanDataGridViewTextBoxColumn.DataPropertyName = "id_peminjaman";
            this.idpeminjamanDataGridViewTextBoxColumn.HeaderText = "id_peminjaman";
            this.idpeminjamanDataGridViewTextBoxColumn.Name = "idpeminjamanDataGridViewTextBoxColumn";
            this.idpeminjamanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idanggotaDataGridViewTextBoxColumn
            // 
            this.idanggotaDataGridViewTextBoxColumn.DataPropertyName = "id_anggota";
            this.idanggotaDataGridViewTextBoxColumn.HeaderText = "id_anggota";
            this.idanggotaDataGridViewTextBoxColumn.Name = "idanggotaDataGridViewTextBoxColumn";
            // 
            // namabukuDataGridViewTextBoxColumn
            // 
            this.namabukuDataGridViewTextBoxColumn.DataPropertyName = "namabuku";
            this.namabukuDataGridViewTextBoxColumn.HeaderText = "namabuku";
            this.namabukuDataGridViewTextBoxColumn.Name = "namabukuDataGridViewTextBoxColumn";
            // 
            // tglpinjamDataGridViewTextBoxColumn
            // 
            this.tglpinjamDataGridViewTextBoxColumn.DataPropertyName = "tglpinjam";
            this.tglpinjamDataGridViewTextBoxColumn.HeaderText = "tglpinjam";
            this.tglpinjamDataGridViewTextBoxColumn.Name = "tglpinjamDataGridViewTextBoxColumn";
            // 
            // tglbalikDataGridViewTextBoxColumn
            // 
            this.tglbalikDataGridViewTextBoxColumn.DataPropertyName = "tglbalik";
            this.tglbalikDataGridViewTextBoxColumn.HeaderText = "tglbalik";
            this.tglbalikDataGridViewTextBoxColumn.Name = "tglbalikDataGridViewTextBoxColumn";
            // 
            // statuspinjamDataGridViewTextBoxColumn
            // 
            this.statuspinjamDataGridViewTextBoxColumn.DataPropertyName = "statuspinjam";
            this.statuspinjamDataGridViewTextBoxColumn.HeaderText = "statuspinjam";
            this.statuspinjamDataGridViewTextBoxColumn.Name = "statuspinjamDataGridViewTextBoxColumn";
            // 
            // peminjamanBindingSource1
            // 
            this.peminjamanBindingSource1.DataMember = "peminjaman";
            this.peminjamanBindingSource1.DataSource = this.perpustakaanDataSet;
            // 
            // perpustakaanDataSet
            // 
            this.perpustakaanDataSet.DataSetName = "perpustakaanDataSet";
            this.perpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Blacklisted", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(793, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 51);
            this.label2.TabIndex = 6;
            this.label2.Text = "PEMINJAM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Blacklisted", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(793, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "DAFTAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(701, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.peminjamanBindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(999, 25);
            this.bindingNavigator1.TabIndex = 7;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
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
            // editTglPinjam
            // 
            this.editTglPinjam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peminjamanBindingSource1, "tglpinjam", true));
            this.editTglPinjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTglPinjam.Location = new System.Drawing.Point(701, 422);
            this.editTglPinjam.Name = "editTglPinjam";
            this.editTglPinjam.Size = new System.Drawing.Size(259, 38);
            this.editTglPinjam.TabIndex = 27;
            // 
            // editNamaBuku
            // 
            this.editNamaBuku.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peminjamanBindingSource1, "namabuku", true));
            this.editNamaBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editNamaBuku.Location = new System.Drawing.Point(702, 357);
            this.editNamaBuku.Name = "editNamaBuku";
            this.editNamaBuku.Size = new System.Drawing.Size(259, 38);
            this.editNamaBuku.TabIndex = 26;
            // 
            // editIdAnggota
            // 
            this.editIdAnggota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peminjamanBindingSource1, "id_anggota", true));
            this.editIdAnggota.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editIdAnggota.Location = new System.Drawing.Point(701, 294);
            this.editIdAnggota.Name = "editIdAnggota";
            this.editIdAnggota.Size = new System.Drawing.Size(259, 38);
            this.editIdAnggota.TabIndex = 25;
            // 
            // editIdPinjam
            // 
            this.editIdPinjam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peminjamanBindingSource1, "id_peminjaman", true));
            this.editIdPinjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editIdPinjam.Location = new System.Drawing.Point(701, 233);
            this.editIdPinjam.Name = "editIdPinjam";
            this.editIdPinjam.Size = new System.Drawing.Size(259, 38);
            this.editIdPinjam.TabIndex = 24;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(701, 172);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(213, 38);
            this.searchTextBox.TabIndex = 30;
            this.searchTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(701, 663);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 48);
            this.button3.TabIndex = 33;
            this.button3.Text = "KEMBALI";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(843, 609);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 48);
            this.button2.TabIndex = 32;
            this.button2.Text = "HAPUS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(701, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 48);
            this.button1.TabIndex = 31;
            this.button1.Text = "EDIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(698, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "ID Anggota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(699, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nama Buku";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(699, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tgl Peminjaman";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(699, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Tgl Pengembalian";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(699, 533);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Status Peminjaman";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(698, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "ID Peminjaman";
            // 
            // pickerPengembalian
            // 
            this.pickerPengembalian.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peminjamanBindingSource1, "tglbalik", true));
            this.pickerPengembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerPengembalian.Location = new System.Drawing.Point(702, 492);
            this.pickerPengembalian.Name = "pickerPengembalian";
            this.pickerPengembalian.Size = new System.Drawing.Size(259, 38);
            this.pickerPengembalian.TabIndex = 40;
            // 
            // editSttsPinjam
            // 
            this.editSttsPinjam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peminjamanBindingSource1, "statuspinjam", true));
            this.editSttsPinjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSttsPinjam.FormattingEnabled = true;
            this.editSttsPinjam.Location = new System.Drawing.Point(702, 553);
            this.editSttsPinjam.Name = "editSttsPinjam";
            this.editSttsPinjam.Size = new System.Drawing.Size(259, 39);
            this.editSttsPinjam.TabIndex = 41;
            // 
            // peminjamanBindingSource
            // 
            this.peminjamanBindingSource.DataMember = "peminjaman";
            this.peminjamanBindingSource.DataSource = this.peminjamDataSet;
            // 
            // peminjamDataSet
            // 
            this.peminjamDataSet.DataSetName = "peminjamDataSet";
            this.peminjamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peminjamanTableAdapter
            // 
            this.peminjamanTableAdapter.ClearBeforeFill = true;
            // 
            // peminjamanTableAdapter1
            // 
            this.peminjamanTableAdapter1.ClearBeforeFill = true;
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(920, 172);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(44, 38);
            this.searchButton.TabIndex = 42;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(699, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Masukkan ID Anggota yang akan dicari";
            // 
            // daftarPeminjam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(999, 723);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.editSttsPinjam);
            this.Controls.Add(this.pickerPengembalian);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.editTglPinjam);
            this.Controls.Add(this.editNamaBuku);
            this.Controls.Add(this.editIdAnggota);
            this.Controls.Add(this.editIdPinjam);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "daftarPeminjam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "daftarPeminjam";
            this.Load += new System.EventHandler(this.daftarPeminjam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peminjamanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peminjamanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peminjamDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.TextBox editTglPinjam;
        private System.Windows.Forms.TextBox editNamaBuku;
        private System.Windows.Forms.TextBox editIdAnggota;
        private System.Windows.Forms.TextBox editIdPinjam;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private peminjamDataSet peminjamDataSet;
        private System.Windows.Forms.BindingSource peminjamanBindingSource;
        private peminjamDataSetTableAdapters.peminjamanTableAdapter peminjamanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpeminjamanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idanggotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglpinjamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglbalikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuspinjamDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker pickerPengembalian;
        private System.Windows.Forms.ComboBox editSttsPinjam;
        private perpustakaanDataSet perpustakaanDataSet;
        private System.Windows.Forms.BindingSource peminjamanBindingSource1;
        private perpustakaanDataSetTableAdapters.peminjamanTableAdapter peminjamanTableAdapter1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label9;
    }
}