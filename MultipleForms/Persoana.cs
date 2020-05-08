
namespace MultipleForms
{
    public class Persoana
    {
        public string Nume { get; set; }

        public Persoana(string _nume)
        {
            Nume = _nume;
        }

        public override string ToString()
        {
            return "Nume: " + Nume;
        }
    }
}
