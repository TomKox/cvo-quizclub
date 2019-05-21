using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVO_QuizClub.Exceptions
{
    public class LidOnbekendException : Exception
    {
        public LidOnbekendException() : base("Het lid is onbekend.")
        {
        }

        public LidOnbekendException(string message) : base(message)
        {
        }
    }
}
