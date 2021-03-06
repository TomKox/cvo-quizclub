﻿using CVO_QuizClub.Exceptions;
using System.Linq;
using System.Text;

namespace CVO_QuizClub
{
    public class Team
    {
        private readonly Lid[] _leden;
        private int _id;

        private static int _teller = 1;

        public Lid[] Leden { get => _leden; }
        public int Id
        {
            get => _id;
            set
            {
                if(value >= _teller)
                {
                    _teller = value;
                }
                _id = value;
            }
        }
        public string Naam { get; set; }

        public static int Teller { get => _teller; }

        public Team(string naam)
        {
            Naam = naam;
            _id = _teller++;
            _leden = new Lid[4];
        }

        public Team(string naam, int id)
        {
            Naam = naam;
            Id = id;
            _teller++;
            _leden = new Lid[4];
        }

        public void LidToevoegen(Lid lid)
        {
            if(_leden.Contains(lid))
            {
                throw new LidAlTeamlidException(lid,this);
            }

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
                throw new TeamVolzetException(this);
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

        public bool IsLid(Lid lid)
        {
            bool gevonden = false;
            foreach(Lid teamlid in _leden)
            {
                if(teamlid != null && lid.Nummer == teamlid.Nummer)
                {
                    gevonden = true;
                    break;
                }
            }
            return gevonden;
        }

        public static void ResetTeller()
        {
            _teller = 1;
        }

        public override string ToString()
        {
            return Naam;
        }

        public string ToLongString()
        {
            StringBuilder teamleden = new StringBuilder();
            foreach (Lid l in Leden)
            {
                if (l != null)
                {
                    teamleden.Append($"{l.VolledigeNaam} ({l.Specialisatie.GetDescription()}), ");
                }
            }
            if (teamleden.ToString().Length > 2)
            {
                teamleden.Remove(teamleden.Length - 2, 2);
            }
            return $"Team '{Naam}' ({Id}): " + teamleden.ToString();
        }
    }
}
