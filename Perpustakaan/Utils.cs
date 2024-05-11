using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan
{
    public static class Utils
    {
        public static DataClasses1DataContext db = new DataClasses1DataContext();
        public static bool isEmpty(params string[] values)
        {
            foreach (string value in values)
            {
                if (value == null || value == "" || value == "0")
                {
                    message("Value tidak boleh kosong,null atau 0", false);
                    return true;
                }
            }
            return false;
        }

        public static void message(string messsage,bool isSuccess)
        {
            if(isSuccess)
            {
                MessageBox.Show(messsage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(messsage,"Error",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public static DialogResult confirm(string message)
        {
            return MessageBox.Show(message, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        public static void Link(Form form, Panel panel)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Show();
        }


    }
}
