using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekz
{
   
    public partial class Ekz : Form
    {
        public Ekz()
        {
            InitializeComponent();

            labelnapr.Visible = false;
            labelprod.Visible = false;
            labelcena.Visible = false;
            f1txtNaprav.Visible = false;
            f1txtProdolz.Visible = false;
            f1txtCena.Visible = false;
            f1btnSave.Visible = false;

            int n = Convert.ToInt32(f1nudRazm.Value);
        }

        private void f1btnOk_Click(object sender, EventArgs e)
        {
            labelnapr.Visible = true;
            labelprod.Visible = true;
            labelcena.Visible = true;
            f1txtNaprav.Visible = true;
            f1txtProdolz.Visible = true;
            f1txtCena.Visible = true;
            f1btnSave.Visible = true;

            labelrazm.Visible = false;
            f1nudRazm.Visible = false;
            f1btnOk.Visible = false;
        }

        private void f1btnOpenfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files(.txt)|.txt| All files(.)|.";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    f1txtputfile.Text = ofd.FileName;
                    FileWork.FilePath = ofd.FileName;


                }
                catch
                {
                    MessageBox.Show("Формат не соответсвует требуемому.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
