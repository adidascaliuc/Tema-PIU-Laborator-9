﻿using System;
using System.Drawing;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate;
using System.Collections.Generic;
using System.Linq;

namespace InterfataUtilizator
{
    public partial class FormularStudent : Form
    {
        IStocareData adminStudenti;
        List<string> disciplineSelectate = new List<string>();

        public FormularStudent()
        {
            InitializeComponent();
            adminStudenti = StocareFactory.GetAdministratorStocare(); 
        }
        
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            ResetCuloareEtichete();

            CodEroare codValidare = Validare(txtNume.Text, txtPrenume.Text, txtNote.Text);

            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
            }
            else
            {
                Student s = new Student(txtNume.Text, txtPrenume.Text);
                s.SetNote(txtNote.Text);

                //set program studiu
                //verificare radioButton selectat
                s.ProgramSTD = GetProgramStudiuSelectat();
                //set Discipline
                s.Discipline = new List<string>();
                s.Discipline.AddRange(disciplineSelectate);
                s.AnStudiu = Convert.ToInt32( cmbAnStudiu.Text );

                adminStudenti.AddStudent(s);
                lblMesaj.Text = "Studentul a fost adaugat";

                //resetarea controalelor pentru a introduce datele unui student nou
                ResetareControale();
            }

        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            lstAfisare.Items.Clear();
            var antetTabel = String.Format("{0,-5}{1,-35}{2,20}{3,10}\n", "Id", "Nume Prenume", "ProgramStudiu", "Medie");
            lstAfisare.Items.Add(antetTabel);

            List<Student> studenti = adminStudenti.GetStudenti();
            foreach(Student s in studenti)
            {
                var linieTabel = String.Format("{0,-5}{1,-35}{2,20}{3,10}\n", s.IdStudent, s.NumeComplet, s.ProgramSTD.ToString(), s.Media.ToString());
                lstAfisare.Items.Add(linieTabel);
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            List<Student> s = adminStudenti.GetStudent(txtNume.Text, txtPrenume.Text);

            if (s[0] != null)
            {
                lblMesaj.Text = s[0].ConversieLaSir();
                foreach (var disciplina in gpbDiscipline.Controls)
                {
                    if (disciplina is CheckBox)
                    {
                        var disciplinaBox = disciplina as CheckBox;
                        foreach (String dis in s[0].Discipline)
                            if (disciplinaBox.Text.Equals(dis))
                                disciplinaBox.Checked = true;
                    }
                }

            }
            else
                lblMesaj.Text = "Nu s-a gasit studentul";
            

            if (txtNume.Enabled == true && txtPrenume.Enabled==true)
            {
                txtNume.Enabled = false;
                txtPrenume.Enabled = false;
                //dezactivare butoane radio
                foreach (var button in gpbProgrameStudiu.Controls)
                {
                    if (button is RadioButton)
                    {
                        var radioButton = button as RadioButton;
                        radioButton.Enabled = false;
                    }
                }
            }
            else
            {
                txtNume.Enabled = true;
                txtPrenume.Enabled = true;
                //activare butoane radio
                foreach (var button in gpbProgrameStudiu.Controls)
                {
                    if (button is RadioButton)
                    {
                        var radioButton = button as RadioButton;
                        radioButton.Enabled = true;
                    }
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            List<Student> studenti = adminStudenti.GetStudent(txtNume.Text, txtPrenume.Text);
            var s = studenti[0];
            if (s != null)
            {
                s.AnStudiu = Convert.ToInt32( cmbAnStudiu.Text );
                int nrNoteVechi = s.GetNote().Length;
                s.SetNote(txtNote.Text);
                int nrNoteNoi = s.GetNote().Length;
                if (nrNoteNoi == nrNoteVechi)
                {
                    adminStudenti.UpdateStudent(s);
                    lblMesaj.Text = "Modificare efectuata";
                    txtNume.Enabled = true;
                    txtPrenume.Enabled = true;
                }
                else
                {
                    lblMesaj.Text = "Numarul de note nu corespunde cu notele anterioare ale studentului";
                }
            }
            else
            {
                lblMesaj.Text = "Student inexistent";
            }
        }

        private void ckbDiscipline_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
            //sau
            //CheckBox checkBoxControl = (CheckBox)sender;  //operator cast

            string disciplinaSelectata = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                disciplineSelectate.Add(disciplinaSelectata);
            else
                disciplineSelectate.Remove(disciplinaSelectata);
        }

        private void ResetareControale()
        {
            txtNume.Text = txtPrenume.Text = txtNote.Text = string.Empty;
            rdbCalculatoare.Checked = false;
            rdbAutomatica.Checked = false;
            rdbElectronica.Checked = false;
            rdbElectrotehnica.Checked = false;
            rdbInginerieE.Checked = false;
            ckbPCLP.Checked = false;
            ckbPOO.Checked = false;
            ckbPIU.Checked = false;
            ckbDEEA2.Checked = false;
            ckbED.Checked = false;
            ckbMEST.Checked = false;
            disciplineSelectate.Clear();
            lblMesaj.Text = string.Empty; 
        }

        private CodEroare Validare(string nume, string prenume, string sirNote)
        {
            CodEroare rezultatValidare = CodEroare.CORECT;
            if (nume == string.Empty)
            {
                rezultatValidare |= CodEroare.NUME_INCORECT;
            }
            if (prenume == string.Empty)
            {
                rezultatValidare |= CodEroare.PRENUME_INCORECT;
            }
            if (sirNote == string.Empty)
            {
                rezultatValidare |= CodEroare.NOTE_INCORECTE;
            }
            // verificare ca este cel putin un program studiu selectat
            int programStudiuSelectat = 0;
            foreach (var control in gpbProgrameStudiu.Controls)
            {
                RadioButton rdb = null;
                try
                {
                    rdb = (RadioButton)control;
                }
                catch { }

                if (rdb != null && rdb.Checked == true)
                    programStudiuSelectat = 1;
            }
            if (programStudiuSelectat == 0)
                rezultatValidare |= CodEroare.NO_PROGRAM_STUDIU;

            // verificarea numarului de note valide sa fie egal cu numarul de discipline selectate
            int[] note = Note.ExtrageNoteDinSir(sirNote);
            if (disciplineSelectate.Count != note.Length)
                rezultatValidare |= CodEroare.DISCIPLINE_NOTE;
            return rezultatValidare;
        }

        private void MarcheazaControaleCuDateIncorecte(CodEroare codValidare)
        {
            if ((codValidare & CodEroare.NUME_INCORECT) == CodEroare.NUME_INCORECT)
            {
                lblNume.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.PRENUME_INCORECT) == CodEroare.PRENUME_INCORECT)
            {
                lblPrenume.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.NOTE_INCORECTE) == CodEroare.NOTE_INCORECTE)
            {
                lblNote.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.NO_PROGRAM_STUDIU) == CodEroare.NO_PROGRAM_STUDIU)
            {
                lblSpecializare.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.DISCIPLINE_NOTE) == CodEroare.DISCIPLINE_NOTE)
            {
                lblDiscipline.ForeColor = Color.Red;
                lblNote.ForeColor = Color.Red;
            }
        }

        private void ResetCuloareEtichete()
        {
            lblNume.ForeColor = Color.Black;
            lblPrenume.ForeColor = Color.Black;
            lblNote.ForeColor = Color.Black;
            lblSpecializare.ForeColor = Color.Black;
            lblDiscipline.ForeColor = Color.Black;
        }

        private ProgramStudiu GetProgramStudiuSelectat()
        {
            if (rdbCalculatoare.Checked)
                return ProgramStudiu.Calculatoare;
            if (rdbAutomatica.Checked)
                return ProgramStudiu.Automatica;
            if (rdbElectronica.Checked)
                return ProgramStudiu.Electronica;
            if (rdbElectrotehnica.Checked)
                return ProgramStudiu.Electronica;
            if (rdbInginerieE.Checked)
                return ProgramStudiu.InginerieEconomica;
            return ProgramStudiu.Program_Inexistent;
        }

        private void FormularStudent_Load(object sender, EventArgs e)
        {

        }
        
        private void lstAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student s = adminStudenti.GetStudent(lstAfisare.SelectedIndex - 1);

            txtNume.Text =  s.Nume ;
            txtPrenume.Text = s.Prenume;
            txtNote.Text = string.Join(",", s.GetNote());

            cmbAnStudiu.Text = Convert.ToString( s.AnStudiu );
            
        }
    }
}
