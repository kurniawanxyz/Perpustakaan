namespace Perpustakaan
{
    partial class Form3
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label alamatLabel;
            System.Windows.Forms.Label genderLabel;
            this.pelangganDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perpustakaanDataSet = new Perpustakaan.perpustakaanDataSet();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.alamatRichTextBox = new System.Windows.Forms.RichTextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pelangganTableAdapter = new Perpustakaan.perpustakaanDataSetTableAdapters.PelangganTableAdapter();
            this.tableAdapterManager = new Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager();
            nameLabel = new System.Windows.Forms.Label();
            alamatLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(17, 258);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "name:";
            // 
            // alamatLabel
            // 
            alamatLabel.AutoSize = true;
            alamatLabel.Location = new System.Drawing.Point(12, 295);
            alamatLabel.Name = "alamatLabel";
            alamatLabel.Size = new System.Drawing.Size(41, 13);
            alamatLabel.TabIndex = 3;
            alamatLabel.Text = "alamat:";
            alamatLabel.Click += new System.EventHandler(this.alamatLabel_Click);
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(400, 258);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(43, 13);
            genderLabel.TabIndex = 5;
            genderLabel.Text = "gender:";
            // 
            // pelangganDataGridView
            // 
            this.pelangganDataGridView.AllowUserToAddRows = false;
            this.pelangganDataGridView.AllowUserToDeleteRows = false;
            this.pelangganDataGridView.AutoGenerateColumns = false;
            this.pelangganDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pelangganDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pelangganDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.gender,
            this.Column1});
            this.pelangganDataGridView.DataSource = this.pelangganBindingSource;
            this.pelangganDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pelangganDataGridView.Location = new System.Drawing.Point(0, 0);
            this.pelangganDataGridView.Name = "pelangganDataGridView";
            this.pelangganDataGridView.ReadOnly = true;
            this.pelangganDataGridView.RowHeadersVisible = false;
            this.pelangganDataGridView.Size = new System.Drawing.Size(606, 220);
            this.pelangganDataGridView.TabIndex = 1;
            this.pelangganDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pelangganDataGridView_CellClick);
            this.pelangganDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pelangganDataGridView_CellContentClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "alamat";
            this.dataGridViewTextBoxColumn3.HeaderText = "Alamat";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Action";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Text = "Delete";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // pelangganBindingSource
            // 
            this.pelangganBindingSource.DataMember = "Pelanggan";
            this.pelangganBindingSource.DataSource = this.perpustakaanDataSet;
            // 
            // perpustakaanDataSet
            // 
            this.perpustakaanDataSet.DataSetName = "perpustakaanDataSet";
            this.perpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pelangganBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(59, 255);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(322, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // alamatRichTextBox
            // 
            this.alamatRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pelangganBindingSource, "alamat", true));
            this.alamatRichTextBox.Location = new System.Drawing.Point(59, 292);
            this.alamatRichTextBox.Name = "alamatRichTextBox";
            this.alamatRichTextBox.Size = new System.Drawing.Size(535, 96);
            this.alamatRichTextBox.TabIndex = 4;
            this.alamatRichTextBox.Text = "";
            this.alamatRichTextBox.TextChanged += new System.EventHandler(this.alamatRichTextBox_TextChanged);
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pelangganBindingSource, "gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.genderComboBox.Location = new System.Drawing.Point(452, 255);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(142, 21);
            this.genderComboBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pelangganTableAdapter
            // 
            this.pelangganTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BukuTableAdapter = null;
            this.tableAdapterManager.PelangganTableAdapter = this.pelangganTableAdapter;
            this.tableAdapterManager.UpdateOrder = Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(alamatLabel);
            this.Controls.Add(this.alamatRichTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.pelangganDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pelangganDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private perpustakaanDataSet perpustakaanDataSet;
        private System.Windows.Forms.BindingSource pelangganBindingSource;
        private perpustakaanDataSetTableAdapters.PelangganTableAdapter pelangganTableAdapter;
        private perpustakaanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pelangganDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RichTextBox alamatRichTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}