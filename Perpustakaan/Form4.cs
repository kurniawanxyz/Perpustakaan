using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan
{
    public partial class Form4 : Form
    {
        private int idBuku = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void bukuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bukuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perpustakaanDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perpustakaanDataSet.Buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.perpustakaanDataSet.Buku);

        }

        private void bukuDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var select = bukuDataGridView;
            var id = select.Rows[e.RowIndex].Cells[0].Value;
            if (select.Columns[e.ColumnIndex].Name == "Column1")
            {
                DialogResult confirm = Utils.confirm("Yakin ining menghapus data");
                if (confirm == DialogResult.OK)
                {
                    this.bukuTableAdapter.DeleteQuery(int.Parse(id.ToString()));
                    this.bukuTableAdapter.Fill(this.perpustakaanDataSet.Buku);
                }
            }
            else
            {
                this.idBuku = int.Parse(id.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var title = titleTextBox.Text;
            var category = categoryTextBox.Text;
            string author = authorTextBox.Text;
            bool isEmpty = Utils.isEmpty(
                title,
                category,
                author
                );

            if (!isEmpty)
            {
                if (this.idBuku == 0)
                {
                    DialogResult confirm = Utils.confirm("Apakah kamu yakin ingin manambahkan pelanggan");
                    if (confirm == DialogResult.OK)
                    {
                        this.bukuTableAdapter.InsertQuery(
                            title,
                            category,
                            author
                        );
                        Utils.message("Berhasil menambahkan pelanggan dengan nama " + title, true);
                    }
                }
                else
                {
                    DialogResult confirm = Utils.confirm("Apakah kamu yakin ingin memperbarui pelanggan");
                    if (confirm == DialogResult.OK)
                    {
                        this.bukuTableAdapter.UpdateQuery(
                            title,
                            category,
                            author,
                            this.idBuku
                        );

                        this.idBuku = 0;
                        Utils.message("Berhasil menambahkan memperbarui dengan nama " + title, true);
                    }
                }
                this.bukuTableAdapter.Fill(this.perpustakaanDataSet.Buku);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            authorTextBox.Text = "";
            categoryTextBox.Text = "";
        }
    }
}
