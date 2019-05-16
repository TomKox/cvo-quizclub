using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVO_QuizClub
{
    public class Team
    {
        private readonly Lid[] _leden;
        private readonly int _id;

        private static int _teller = 1;

        public Lid[] Leden { get => _leden; }
        public int Id { get => _id; }
        public string Naam { get; set; }

        public Team(string naam)
        {
            Naam = naam;
            _id = _teller++;
            _leden = new Lid[4];
        }

        public void LidToevoegen(Lid lid)
        {
            bool toegevoegd = false;
            for(int i = 0; i < Leden.Length; i++)
            {
                if(_leden[i] == null)
                {
                    _leden[i] = lid;
                    toegevoegd = true;
                    break;
                }
            }

            if(!toegevoegd)
            {
                throw new Exception("Team volzet");
            }
        }

        public bool LidVerwijderen(Lid lid)
        {
            bool verwijderd = false;
            for (int i = 0; i < Leden.Length; i++)
            {
                if (_leden[i] == lid)
                {
                    _leden[i] = null;
                    verwijderd = true;
                    break;
                }
            }
            return verwijderd;
        }
    }
}
