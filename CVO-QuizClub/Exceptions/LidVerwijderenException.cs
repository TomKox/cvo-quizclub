using System;

namespace CVO_QuizClub.Exceptions
{
    public class LidVerwijderenException : Exception
    {
        public LidVerwijderenException() : base("Het lid kan niet verwijderd worden uit het datamodel.")
        {
        }
        
        public LidVerwijderenException(string message) : base(message)
        {
        }
    }
}
