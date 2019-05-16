﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVO_QuizClub
{
    public enum Specialisatie
    {
        FilmEnMuziek,
        Sport,
        Actualiteit,
        Wetenschappen,
        Cultuur
    }
   

    public class Lid : Persoon
    {
        private static int _teller = 0;
        public int Nummer { get; set; }
        public Specialisatie Specialisatie { get; set; }
        public int Teller { get { return _teller; } }

        public Lid(string voornaam, string familienaam, Geslacht geslacht, DateTime geboortedatum, Specialisatie specialisatie) : base (voornaam, familienaam, geslacht, geboortedatum)
        {
            Specialisatie = specialisatie;
            _teller++;
        }

        public override string ToString()
        {
            return $"{base.ToString()} ({Specialisatie})" ;
        }
    }
}
