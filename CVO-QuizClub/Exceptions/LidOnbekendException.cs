using System;

namespace CVO_QuizClub.Exceptions
{
    public class LidOnbekendException : Exception
    {
        public LidOnbekendException() : base("Het lid is onbekend.")
        {
        }

        public LidOnbekendException(Lid lid) : base(CreateMessage(lid))
        {
        }

        public LidOnbekendException(string message) : base(message)
        {
        }

        private static string CreateMessage(Lid lid)
        {
            return $"Het lid '{lid.VolledigeNaam}' ({lid.Nummer}) is onbekend in het datamodel.";
        }
    }
}
