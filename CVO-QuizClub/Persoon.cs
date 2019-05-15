using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVO_QuizClub
{
    public enum Geslacht { M, V, X }

    public class Persoon
    {
        private DateTime _geboortedatum;

        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public Geslacht Geslacht { get; set; }

        public DateTime Geboortedatum { get => _geboortedatum; set => _geboortedatum = value; }
        public int Leeftijd
        {
            get
            {
                DateTime nu = DateTime.Now;
                int leeftijd = nu.Year - Geboortedatum.Year;
                if (nu.Month < Geboortedatum.Month || (nu.Month == Geboortedatum.Month && nu.Day < Geboortedatum.Day))
                    leeftijd--;
                return leeftijd;
            }
        }
    }
}
