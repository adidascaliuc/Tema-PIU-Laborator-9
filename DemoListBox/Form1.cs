using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoListe
{
    public partial class Form1 : Form
    {
        public const int NESELECTAT = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbNume.Text))
            {
                MessageBox.Show("Introdu un nume");
            }
            else
            {
                //se adauga un element in lista
                lstNume.Items.Add(cmbNume.Text);
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if(lstNume.SelectedIndex == NESELECTAT)
            {
                MessageBox.Show("Selectati un nume pentru stergere");
            }
            else
            {
                //se sterge un element din lista
                lstNume.Items.RemoveAt(lstNume.SelectedIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
