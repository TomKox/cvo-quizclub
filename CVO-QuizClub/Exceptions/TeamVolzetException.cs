using System;

namespace CVO_QuizClub.Exceptions
{
    public class TeamVolzetException : Exception
    {
        public TeamVolzetException() : base("Het team is al volzet.")
        {
        }

        public TeamVolzetException(Team team) : base(CreateMessage(team))
        {
        }

        public TeamVolzetException(string message) : base(message)
        {
        }

        private static string CreateMessage(Team team)
        {
            return $"Het team '{team.Naam}' ({team.Id}) is al volzet.";
        }
    }
}
