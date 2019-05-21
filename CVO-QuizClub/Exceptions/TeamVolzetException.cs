using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVO_QuizClub.Exceptions
{
    public class TeamVolzetException : Exception
    {
        public TeamVolzetException() : base("Het team is al volzet.")
        {
        }

        public TeamVolzetException(string message) : base(message)
        {
        }
    }
}
