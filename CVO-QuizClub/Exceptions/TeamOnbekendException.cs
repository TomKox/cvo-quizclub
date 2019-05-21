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

        public TeamOnbekendException(string message) : base(message)
        {
        }

    }
}
