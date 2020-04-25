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
            labelputkfailu.Visible = false;
            f1txtputfile.Visible = false;
            f1btnOpenfile.Visible = false;

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
            labelputkfailu.Visible = true;
            f1txtputfile.Visible = true;
            f1btnOpenfile.Visible = true;

            labelrazm.Visible = false;
            f1nudRazm.Visible = false;
            f1btnOk.Visible = false;
        }

        private void FillData()
        {
            dataGridView1.DataSource = FileWork.ReadTable();
        }

        private void f1btnOpenfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
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

        private void f1btnSave_Click(object sender, EventArgs e)
        {

        }

        private void f1btnadd_Click(object sender, EventArgs e)
        {
            if (f1txtNaprav.Text != "" && f1txtProdolz.Text != "" && f1txtCena.Text != "")
            {
                Tour cll = new Tour();
                cll.Napravlenie = f1txtNaprav.Text;
                cll.Prodolzitelnost = f1txtProdolz.Text;
                cll.Cena = f1txtCena.Text;
                cll.Save();
            }
            else { MessageBox.Show("Все поля обязательны к заполнению!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
