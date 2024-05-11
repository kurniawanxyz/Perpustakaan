using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Perpustakaan
{
    public partial class Form5 : Form
    {
        private int idSewa = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perpustakaanDataSet.Buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.perpustakaanDataSet.Buku);
            // TODO: This line of code loads data into the 'perpustakaanDataSet.Pelanggan' table. You can move, or remove it, as needed.
            this.pelangganTableAdapter.Fill(this.perpustakaanDataSet.Pelanggan);
            // TODO: This line of code loads data into the 'perpustakaanDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.perpustakaanDataSet.User);
            // TODO: This line of code loads data into the 'perpustakaanDataSet.Sewa' table. You can move, or remove it, as needed.
            this.sewaTableAdapter.Fill(this.perpustakaanDataSet.Sewa);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var idPelanggan = comboBox1.SelectedValue.ToString();
            var idBuku = comboBox2.SelectedValue.ToString();
            int totalBuku = (int) total_bukuNumericUpDown.Value;
            int lamaPinjam = (int)lama_pinjamNumericUpDown.Value;
            var denda = 0;

            bool isEmpty = Utils.isEmpty(
               idPelanggan.ToString(),
               idBuku.ToString(),
               totalBuku.ToString(),
               lamaPinjam.ToString()
               );

            if (lamaPinjam >= 7)
            {
                denda = totalBuku * 7000;
            }
            if (lamaPinjam >= 14)
            {
                denda = totalBuku * 14000;
            }

            if (!isEmpty)
            {
                if (this.idSewa == 0)
                {
                    DialogResult confirm = Utils.confirm("Apakah kamu yakin ingin manambahkan data sewa");
                    if (confirm == DialogResult.OK)
                    {
                        this.sewaTableAdapter.InsertQuery(
                            int.Parse(idPelanggan),
                            int.Parse(idBuku),
                            totalBuku,
                            lamaPinjam,
                            denda
                        );
                        Utils.message("Berhasil menambahkan data sewa", true);
                    }
                }
                else
                {
                    DialogResult confirm = Utils.confirm("Apakah kamu yakin ingin memperbarui pelanggan");
                    if (confirm == DialogResult.OK)
                    {
                        this.sewaTableAdapter.UpdateQuery(
                            int.Parse(idPelanggan),
                            int.Parse(idBuku),
                            totalBuku,
                            lamaPinjam,
                            denda,
                            this.idSewa
                        );

                        this.idSewa = 0;
                        Utils.message("Berhasil menambahkan memperbarui data sewa ",true);
                    }
                }
                this.sewaTableAdapter.Fill(this.perpustakaanDataSet.Sewa);
            }
        }

        private void sewaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sewaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var select = sewaDataGridView;
            var id = select.Rows[e.RowIndex].Cells[0].Value;
            if (select.Columns[e.ColumnIndex].Name == "Column1")
            {
                DialogResult confirm = Utils.confirm("Yakin ining menghapus data");
                if (confirm == DialogResult.OK)
                {
                    this.sewaTableAdapter.DeleteQuery(int.Parse(id.ToString()));
                    this.sewaTableAdapter.Fill(this.perpustakaanDataSet.Sewa);
                }
            }
            else
            {
                this.idSewa = int.Parse(id.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total_bukuNumericUpDown.Value = 0;
            lama_pinjamNumericUpDown.Value = 0;
        }
    }
}
