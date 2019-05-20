using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVO_QuizClub
{
    public class DataModel
    {
        private readonly List<Lid> _leden;
        private readonly List<Team> _teams;

        public List<Lid> Leden { get => _leden; }
        public List<Team> Teams { get => _teams;  }

        public DataModel()
        {
            _leden = new List<Lid>();
            _teams = new List<Team>();
        }

        public void LidToevoegen(Lid lid)
        {
            _leden.Add(lid);
        }

        public void TeamToevoegen(Team team)
        {
            _teams.Add(team);
        }

        public void LidToevoegenAanTeam(Lid lid, Team team)
        {
            if (Leden.Contains(lid) && Teams.Contains(team))
            {
                team.LidToevoegen(lid);
            }
            else
            {
                throw new Exception("Lid of Team onbekend");
            }
        }

        public void LidVerwijderenUitTeam(Lid lid, Team team)
        {
            if (Leden.Contains(lid) && Teams.Contains(team))
            {
                team.LidVerwijderen(lid);
            }
            else
            {
                throw new Exception("Lid of Team onbekend");
            }
        }


    }
}
