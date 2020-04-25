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
    }
}
