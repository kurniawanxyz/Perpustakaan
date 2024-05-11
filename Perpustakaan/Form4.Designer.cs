namespace Perpustakaan
{
    partial class Form4
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label authorLabel;
            this.perpustakaanDataSet = new Perpustakaan.perpustakaanDataSet();
            this.bukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bukuTableAdapter = new Perpustakaan.perpustakaanDataSetTableAdapters.BukuTableAdapter();
            this.tableAdapterManager = new Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager();
            this.bukuDataGridView = new System.Windows.Forms.DataGridView();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            titleLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(12, 269);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(26, 13);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "title:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(15, 312);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(51, 13);
            categoryLabel.TabIndex = 3;
            categoryLabel.Text = "category:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(245, 312);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(40, 13);
            authorLabel.TabIndex = 5;
            authorLabel.Text = "author:";
            // 
            // perpustakaanDataSet
            // 
            this.perpustakaanDataSet.DataSetName = "perpustakaanDataSet";
            this.perpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bukuBindingSource
            // 
            this.bukuBindingSource.DataMember = "Buku";
            this.bukuBindingSource.DataSource = this.perpustakaanDataSet;
            // 
            // bukuTableAdapter
            // 
            this.bukuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BukuTableAdapter = this.bukuTableAdapter;
            this.tableAdapterManager.PelangganTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Perpustakaan.perpustakaanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // bukuDataGridView
            // 
            this.bukuDataGridView.AllowUserToAddRows = false;
            this.bukuDataGridView.AllowUserToDeleteRows = false;
            this.bukuDataGridView.AutoGenerateColumns = false;
            this.bukuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bukuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bukuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.bukuDataGridView.DataSource = this.bukuBindingSource;
            this.bukuDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.bukuDataGridView.Location = new System.Drawing.Point(0, 0);
            this.bukuDataGridView.Name = "bukuDataGridView";
            this.bukuDataGridView.ReadOnly = true;
            this.bukuDataGridView.RowHeadersVisible = false;
            this.bukuDataGridView.Size = new System.Drawing.Size(590, 251);
            this.bukuDataGridView.TabIndex = 1;
            this.bukuDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bukuDataGridView_CellClick);
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource, "title", true));
            this.titleTextBox.Location = new System.Drawing.Point(72, 266);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(491, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource, "category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(72, 309);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(150, 20);
            this.categoryTextBox.TabIndex = 4;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource, "author", true));
            this.authorTextBox.Location = new System.Drawing.Point(291, 309);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(272, 20);
            this.authorTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn3.HeaderText = "Category";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "author";
            this.dataGridViewTextBoxColumn4.HeaderText = "Author";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Action";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Delete";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.bukuDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private perpustakaanDataSet perpustakaanDataSet;
        private System.Windows.Forms.BindingSource bukuBindingSource;
        private perpustakaanDataSetTableAdapters.BukuTableAdapter bukuTableAdapter;
        private perpustakaanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bukuDataGridView;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}