using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVO_QuizClub
{
    public enum Specialisatie
    {
        [Description("Film en Muziek")]
        FilmEnMuziek,
        Sport,
        Actualiteit,
        Wetenschappen,
        Cultuur
    }
   

    public class Lid : Persoon
    {
        private static int _teller = 1;
        private int _nummer;
        public int Nummer
        {
            get => _nummer;
            set
            {
                if (value >= _teller)
                {
                    _teller = value+1;
                }
                _nummer = value;
            }
                
        }
        public Specialisatie Specialisatie { get; set; }
        public static int Teller { get { return _teller; } }

        public Lid(string voornaam, string familienaam, Geslacht geslacht, DateTime geboortedatum, Specialisatie specialisatie) : base (voornaam, familienaam, geslacht, geboortedatum)
        {
            Specialisatie = specialisatie;
            Nummer = _teller++;
        }

        public override string ToString()
        {
            return $"{base.ToString()} ({Specialisatie.GetDescription()})" ;
        }

        public static void ResetTeller()
        {
            _teller = 1;
        }
    }
}
