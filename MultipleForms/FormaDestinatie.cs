using System;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class FormaDestinatie : Form
    {
        public Persoana persFormaSursa;

        public FormaDestinatie()
        {
            InitializeComponent();
        }

        //Pas 1: se declara un nou constructor pentru FormaDestinatie care primeste prin referinta un obiect de la forma initiala
        public FormaDestinatie(Persoana pers) : this()
        {
            persFormaSursa = pers;
        }

        private void FormaDestinatie_Load(object sender, EventArgs e)
        {
            //utilizare valori primite de la FormaSursa prin obiectul persFormaSursa
            lblAfisare.Text = persFormaSursa.ToString();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            //modificare valori primite de la FormaSursa prin obiectul persFormaSursa
            persFormaSursa.Nume += " modificat";
            DialogResult = DialogResult.OK;
        }
    }
}
