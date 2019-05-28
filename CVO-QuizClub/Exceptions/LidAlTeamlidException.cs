using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVO_QuizClub.Exceptions
{
    public class LidAlTeamlidException : Exception
    {
        public LidAlTeamlidException() : base("Het lid is al teamlid van dit team.")
        {
        }

        public LidAlTeamlidException(Lid lid, Team team) : base(CreateMessage(lid, team))
        {
        }

        public LidAlTeamlidException(string message) : base(message)
        {
        }

        private static string CreateMessage(Lid lid, Team team)
        {
            return $"Het lid '{lid.VolledigeNaam}' ({lid.Nummer}) is al teamlid van '{team.Naam}' ({team.Id}).";
        }
    }
}
