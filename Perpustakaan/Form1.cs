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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var email = textBox1.Text;
            var password = textBox2.Text;
            bool isEmpty = Utils.isEmpty(
                    email,
                    password
                );

            if (!isEmpty)
            {
                try
                {
                    var user = Utils.db.Users.FirstOrDefault(it => it.email == email);
                    if (user == null)
                    {
                        Utils.message("Akun tidak ditemukan", false);
                        return;
                    }
                    if (user.password != password)
                    {
                        Utils.message("Terdapat kesalahan pada email atau password", false);
                        return;
                    }

                    Form2 fm = new Form2();
                    fm.Show();
                    this.Hide();


                }catch(Exception ex)
                {
                    Utils.message(ex.Message, false);
                }
            }
        }
    }
}
