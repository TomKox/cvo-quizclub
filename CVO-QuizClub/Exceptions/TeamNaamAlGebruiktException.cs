using System;

namespace CVO_QuizClub.Exceptions
{
    class TeamNaamAlGebruiktException : Exception
    {
        public TeamNaamAlGebruiktException() : base("Er bestaat al een team met deze of een gelijkaardige naam.")
        {
        }

        public TeamNaamAlGebruiktException(string message) : base(message)
        {
        }

        public TeamNaamAlGebruiktException(Team team1, Team team2) : base(CreateMessage(team1, team2))
        {
        }

        private static string CreateMessage(Team team1, Team team2)
        {
            return $"'{team1.Naam}' ({team1.Id}) en '{team2.Naam}' ({team2.Id}) hebben dezelfde of een gelijkaardige naam.";
        }
    }
}
