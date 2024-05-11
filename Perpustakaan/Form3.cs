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
    public partial class Form3 : Form
    {
        private int idPelanggan = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void pelangganBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pelangganBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perpustakaanDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perpustakaanDataSet.Pelanggan' table. You can move, or remove it, as needed.
            this.pelangganTableAdapter.Fill(this.perpustakaanDataSet.Pelanggan);

        }

        private void alamatLabel_Click(object sender, EventArgs e)
        {

        }

        private void alamatRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var alamat = alamatRichTextBox.Text;
            string gender = genderComboBox.Text;
            bool isEmpty = Utils.isEmpty(
                name,
                alamat,
                gender
                );

            if (!isEmpty)
            {
                if (this.idPelanggan == 0)
                {
                    DialogResult confirm = Utils.confirm("Apakah kamu yakin ingin manambahkan pelanggan");
                    if (confirm == DialogResult.OK)
                    {
                        this.pelangganTableAdapter.InsertQuery(
                            name,
                            alamat,
                            gender
                        );
                        Utils.message("Berhasil menambahkan pelanggan dengan nama " + name, true);
                    }
                }
                else
                {
                    DialogResult confirm = Utils.confirm("Apakah kamu yakin ingin memperbarui pelanggan");
                    if (confirm == DialogResult.OK)
                    {
                        this.pelangganTableAdapter.UpdateQuery(
                            name,
                            alamat,
                            gender,
                            this.idPelanggan,
                            this.idPelanggan
                        );

                        this.idPelanggan = 0;
                        Utils.message("Berhasil menambahkan memperbarui dengan nama " + name, true);
                    }
                }
                this.pelangganTableAdapter.Fill(this.perpustakaanDataSet.Pelanggan);
            }
        }

        private void pelangganDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pelangganDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var select = pelangganDataGridView;
            var id = select.Rows[e.RowIndex].Cells[0].Value;
            if (select.Columns[e.ColumnIndex].Name == "Column1")
            {
                DialogResult confirm = Utils.confirm("Yakin ining menghapus data");
                if (confirm == DialogResult.OK)
                {
                    this.pelangganTableAdapter.DeleteQuery(int.Parse(id.ToString()));
                    this.pelangganTableAdapter.Fill(this.perpustakaanDataSet.Pelanggan);
                }
            }
            else
            {
                this.idPelanggan = int.Parse(id.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            alamatRichTextBox.Text = "";
        }
    }
}
