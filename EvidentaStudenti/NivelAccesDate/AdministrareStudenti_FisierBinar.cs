using LibrarieModele;
using System;
using System.Collections.Generic;
using System.IO;

namespace NivelAccesDate
{
    //clasa AdministrareStudenti_FisierBinar implementeaza interfata IStocareData
    public class AdministrareStudenti_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrareStudenti_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public Student GetStudent(int index)
        {

            List<Student> studenti = new List<Student>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    int nrStudenti = 0;
                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Student s = new Student(line);
                        studenti.Add(s);
                        if (nrStudenti == index)
                        {
                            return s;
                        }
                        nrStudenti++;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return null;
        }

        public void AddStudent(Student s)
        {
            throw new Exception("Optiunea AddStudent nu este implementata");
        }

        public List<Student> GetStudenti()
        {
            throw new Exception("Optiunea GetStudenti nu este implementata");
        }

        public List<Student> GetStudent(string nume, string prenume)
        {
            throw new Exception("Optiunea GetStudent nu este implementata");
        }

        public bool UpdateStudent(Student s)
        {
            throw new Exception("Optiunea UpdateStudent nu este implementata");
        }
    }
}
