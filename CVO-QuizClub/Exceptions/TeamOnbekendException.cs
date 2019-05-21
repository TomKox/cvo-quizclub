using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVO_QuizClub.Exceptions
{
    public class TeamOnbekendException : Exception
    {
        public TeamOnbekendException() : base("Het team is onbekend.")
        {
        }

        public TeamOnbekendException(Team team) : base(CreateMessage(team))
        {
        }

        public TeamOnbekendException(string message) : base(message)
        {
        }

        private static string CreateMessage(Team team)
        {
            return $"Het team '{team.Naam}' ({team.Id}) is onbekend in het datamodel.";
        }

    }
}
