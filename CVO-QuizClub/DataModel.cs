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


    }
}
