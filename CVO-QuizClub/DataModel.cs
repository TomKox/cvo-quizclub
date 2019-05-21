using CVO_QuizClub.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVO_QuizClub
{
    public class DataModel
    {
        private readonly List<Lid> _leden;
        private readonly List<Team> _teams;

        private const string DataFile = "datafile";
        private const string LidPrefix = "LID:";
        private const string TeamPrefix = "TEAM:";

        public List<Lid> Leden { get => _leden; }
        public List<Team> Teams { get => _teams;  }

        
        /* CONSTRUCTORS */ 
        public DataModel()
        {
            _leden = new List<Lid>();
            _teams = new List<Team>();
            ReadFromDataFile();
        }

        /* PRIVATE METHODS */
        private void ReadFromDataFile()
        {
            if(File.Exists(DataFile))
            {
                string[] lines = File.ReadAllLines(DataFile);

                foreach(string line in lines)
                {
                    if(line.StartsWith(LidPrefix))
                    {
                        AddLidFromDataLine(line);
                    }
                    if(line.StartsWith(TeamPrefix))
                    {
                        AddTeamFromDataLine(line);
                    }
                }
            }
        }

        private void AddLidFromDataLine(string line)
        {
            line = line.Substring(LidPrefix.Length);
            string[] fields = line.Split(';');

            string nummer = fields[0];
            string voornaam = fields[1];
            string familienaam = fields[2];
            string geslachtString = fields[3];
            string geboortedatumString = fields[4];
            string specialisatieString = fields[5];

            Geslacht geslacht = Geslacht.M;
            if (geslachtString == "M") geslacht = Geslacht.M;
            if (geslachtString == "V") geslacht = Geslacht.V;
            if (geslachtString == "X") geslacht = Geslacht.X;

            string[] dateFields = geboortedatumString.Split('/');
            int day = Convert.ToInt32(dateFields[0]);
            int month = Convert.ToInt32(dateFields[1]);
            int year = Convert.ToInt32(dateFields[2]);
            DateTime geboortedatum = new DateTime(year, month, day);

            Specialisatie specialisatie = Specialisatie.Actualiteit;
            foreach(Specialisatie s in Enum.GetValues(typeof(Specialisatie))) 
            {
                if(s.GetDescription() == specialisatieString)
                {
                    specialisatie = s;
                }
            }
            Lid lid = new Lid(voornaam, familienaam, geslacht, geboortedatum, specialisatie)
            {
                Nummer = Convert.ToInt32(nummer)
            };

            _leden.Add(lid);
        }

        private void AddTeamFromDataLine(string line)
        {
            line = line.Substring(TeamPrefix.Length);
            string[] fields = line.Split(';');

            int id = Convert.ToInt32(fields[0]);
            string naam = fields[1];

            Team team = new Team(naam, id);

            if(Int32.TryParse(fields[2], out int lid0)) team.LidToevoegen(GetLidFromNummer(lid0));
            if(Int32.TryParse(fields[3], out int lid1)) team.LidToevoegen(GetLidFromNummer(lid1));
            if(Int32.TryParse(fields[4], out int lid2)) team.LidToevoegen(GetLidFromNummer(lid2));
            if(Int32.TryParse(fields[5], out int lid3)) team.LidToevoegen(GetLidFromNummer(lid3));

            _teams.Add(team);
        }

        private void WriteDataFile()
        {
            List<string> datalines = new List<string>();

            foreach(Lid lid in _leden)
            {
                datalines.Add(LidToDataLine(lid));
            }

            foreach(Team team in _teams)
            {
                datalines.Add(TeamToDataLine(team));
            }

            File.WriteAllLines(DataFile, datalines.ToArray());
        }

        private string LidToDataLine(Lid lid)
        {
            string nummer = lid.Nummer.ToString();
            string voornaam = lid.Voornaam;
            string familienaam = lid.Familienaam;
            string geslacht = lid.Geslacht.ToString();
            string geboortedatum = lid.Geboortedatum.ToString("d");
            string specialisatie = lid.Specialisatie.GetDescription();

            return $"{LidPrefix}{nummer};{voornaam};{familienaam};{geslacht};{geboortedatum};{specialisatie}";
        }

        private string TeamToDataLine(Team team)
        {
            Lid[] leden = team.Leden;
            string id = team.Id.ToString();
            string naam = team.Naam;
            string lid0 = "";
            string lid1 = "";
            string lid2 = "";
            string lid3 = "";

            if (leden[0] != null) lid0 = leden[0].Nummer.ToString();
            if (leden[1] != null) lid1 = leden[1].Nummer.ToString();
            if (leden[2] != null) lid2 = leden[2].Nummer.ToString();
            if (leden[3] != null) lid3 = leden[3].Nummer.ToString();
            
            return $"{TeamPrefix}{id};{naam};{lid0};{lid1};{lid2};{lid3}";
        }

        private Lid GetLidFromNummer(int nummer)
        {
            foreach(Lid lid in _leden)
            {
                if(lid.Nummer == nummer)
                {
                    return lid;
                }
            }
            return null;
        }

        /* PUBLIC METHODS */
        public void LidToevoegen(Lid lid)
        {
            _leden.Add(lid);
            WriteDataFile();
        }

        public void TeamToevoegen(Team team)
        {
            foreach(Team bestaandTeam in _teams)
            {
                if(team.Naam.ToLower() == bestaandTeam.Naam.ToLower())
                {
                    throw new TeamNaamAlGebruiktException(team, bestaandTeam);
                }
            }

            _teams.Add(team);
            WriteDataFile();
        }

        public void LidToevoegenAanTeam(Lid lid, Team team)
        {
            if (Leden.Contains(lid) && Teams.Contains(team))
            {
                team.LidToevoegen(lid);
                WriteDataFile();
            }
            else
            {
                if(!Leden.Contains(lid))
                {
                    throw new LidOnbekendException(lid);
                }
                if(!Teams.Contains(team))
                {
                    throw new TeamOnbekendException(team);
                }
            }
        }

        public void LidVerwijderenUitTeam(Lid lid, Team team)
        {
            if (Leden.Contains(lid) && Teams.Contains(team))
            {
                team.LidVerwijderen(lid);
                WriteDataFile();
            }
            else
            {
                if (!Leden.Contains(lid))
                {
                    throw new LidOnbekendException(lid);
                }
                if (!Teams.Contains(team))
                {
                    throw new TeamOnbekendException(team);
                }
            }
        }
    }
}
