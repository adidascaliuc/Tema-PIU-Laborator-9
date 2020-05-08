using System;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class FormaSursa : Form
    {
        public Persoana persoanaCurenta;
        public FormaSursa()
        {
            InitializeComponent();
        }

        private void btnTrimite_Click(object sender, EventArgs e)
        {
            persoanaCurenta = new Persoana(txtNume.Text);

            //Pas2 : se apeleaza noul constructor al formei FormaDestinatie
            using (FormaDestinatie frmDest = new FormaDestinatie(persoanaCurenta))
            {
                var dr = frmDest.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    txtNume.Text = persoanaCurenta.Nume;
                }
                frmDest.Close();
            }
        }
    }
}
