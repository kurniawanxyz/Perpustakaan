namespace Perpustakaan
{
    partial class Form5
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
            System.Windows.Forms.Label total_bukuLabel;
            System.Windows.Forms.Label lama_pinjamLabel;
            this.perpustakaanDataSet = new Perpustakaan.perpustakaanDataSet();
            this.sewaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sewaTableAdapter = new Perpustakaan.perpustakaanDataSetTableAdapters.SewaTableAdapter();
            this.tableAdapterManager = new Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager();
            this.bukuTableAdapter = new Perpustakaan.perpustakaanDataSetTableAdapters.BukuTableAdapter();
            this.pelangganTableAdapter = new Perpustakaan.perpustakaanDataSetTableAdapters.PelangganTableAdapter();
            this.userTableAdapter = new Perpustakaan.perpustakaanDataSetTableAdapters.UserTableAdapter();
            this.sewaDataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.total_bukuNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lama_pinjamNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            total_bukuLabel = new System.Windows.Forms.Label();
            lama_pinjamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sewaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sewaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_bukuNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lama_pinjamNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // total_bukuLabel
            // 
            total_bukuLabel.AutoSize = true;
            total_bukuLabel.Location = new System.Drawing.Point(333, 261);
            total_bukuLabel.Name = "total_bukuLabel";
            total_bukuLabel.Size = new System.Drawing.Size(57, 13);
            total_bukuLabel.TabIndex = 5;
            total_bukuLabel.Text = "total buku:";
            // 
            // lama_pinjamLabel
            // 
            lama_pinjamLabel.AutoSize = true;
            lama_pinjamLabel.Location = new System.Drawing.Point(325, 297);
            lama_pinjamLabel.Name = "lama_pinjamLabel";
            lama_pinjamLabel.Size = new System.Drawing.Size(65, 13);
            lama_pinjamLabel.TabIndex = 7;
            lama_pinjamLabel.Text = "lama pinjam:";
            // 
            // perpustakaanDataSet
            // 
            this.perpustakaanDataSet.DataSetName = "perpustakaanDataSet";
            this.perpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sewaBindingSource
            // 
            this.sewaBindingSource.DataMember = "Sewa";
            this.sewaBindingSource.DataSource = this.perpustakaanDataSet;
            // 
            // sewaTableAdapter
            // 
            this.sewaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BukuTableAdapter = this.bukuTableAdapter;
            this.tableAdapterManager.PelangganTableAdapter = this.pelangganTableAdapter;
            this.tableAdapterManager.UpdateOrder = Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // bukuTableAdapter
            // 
            this.bukuTableAdapter.ClearBeforeFill = true;
            // 
            // pelangganTableAdapter
            // 
            this.pelangganTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // sewaDataGridView
            // 
            this.sewaDataGridView.AllowUserToAddRows = false;
            this.sewaDataGridView.AllowUserToDeleteRows = false;
            this.sewaDataGridView.AutoGenerateColumns = false;
            this.sewaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sewaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column1});
            this.sewaDataGridView.DataSource = this.sewaBindingSource;
            this.sewaDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.sewaDataGridView.Location = new System.Drawing.Point(0, 0);
            this.sewaDataGridView.Name = "sewaDataGridView";
            this.sewaDataGridView.ReadOnly = true;
            this.sewaDataGridView.RowHeadersVisible = false;
            this.sewaDataGridView.Size = new System.Drawing.Size(606, 220);
            this.sewaDataGridView.TabIndex = 1;
            this.sewaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sewaDataGridView_CellClick);
            this.sewaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sewaDataGridView_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pelangganBindingSource, "Id", true));
            this.comboBox1.DataSource = this.pelangganBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Id";
            // 
            // pelangganBindingSource
            // 
            this.pelangganBindingSource.DataMember = "Pelanggan";
            this.pelangganBindingSource.DataSource = this.perpustakaanDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pelanggan:";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.perpustakaanDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Judul Buku:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bukuBindingSource, "Id", true));
            this.comboBox2.DataSource = this.bukuBindingSource;
            this.comboBox2.DisplayMember = "title";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(79, 298);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "Id";
            // 
            // bukuBindingSource
            // 
            this.bukuBindingSource.DataMember = "Buku";
            this.bukuBindingSource.DataSource = this.perpustakaanDataSet;
            // 
            // total_bukuNumericUpDown
            // 
            this.total_bukuNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sewaBindingSource, "total_buku", true));
            this.total_bukuNumericUpDown.Location = new System.Drawing.Point(396, 261);
            this.total_bukuNumericUpDown.Name = "total_bukuNumericUpDown";
            this.total_bukuNumericUpDown.Size = new System.Drawing.Size(183, 20);
            this.total_bukuNumericUpDown.TabIndex = 6;
            // 
            // lama_pinjamNumericUpDown
            // 
            this.lama_pinjamNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sewaBindingSource, "lama_pinjam", true));
            this.lama_pinjamNumericUpDown.Location = new System.Drawing.Point(396, 297);
            this.lama_pinjamNumericUpDown.Name = "lama_pinjamNumericUpDown";
            this.lama_pinjamNumericUpDown.Size = new System.Drawing.Size(183, 20);
            this.lama_pinjamNumericUpDown.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(409, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_pelanggan";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_pelanggan";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_buku";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_buku";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Pelanggan";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn8.HeaderText = "Judul Buku";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "total_buku";
            this.dataGridViewTextBoxColumn4.HeaderText = "Total buku";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "lama_pinjam";
            this.dataGridViewTextBoxColumn5.HeaderText = "Lama pinjam";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "denda";
            this.dataGridViewTextBoxColumn6.HeaderText = "Denda";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Action";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Delete";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(lama_pinjamLabel);
            this.Controls.Add(this.lama_pinjamNumericUpDown);
            this.Controls.Add(total_bukuLabel);
            this.Controls.Add(this.total_bukuNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sewaDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sewaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sewaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_bukuNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lama_pinjamNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private perpustakaanDataSet perpustakaanDataSet;
        private System.Windows.Forms.BindingSource sewaBindingSource;
        private perpustakaanDataSetTableAdapters.SewaTableAdapter sewaTableAdapter;
        private perpustakaanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sewaDataGridView;
        private perpustakaanDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private perpustakaanDataSetTableAdapters.PelangganTableAdapter pelangganTableAdapter;
        private System.Windows.Forms.BindingSource pelangganBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private perpustakaanDataSetTableAdapters.BukuTableAdapter bukuTableAdapter;
        private System.Windows.Forms.BindingSource bukuBindingSource;
        private System.Windows.Forms.NumericUpDown total_bukuNumericUpDown;
        private System.Windows.Forms.NumericUpDown lama_pinjamNumericUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}