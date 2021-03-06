﻿using CVO_QuizClub.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CVO_QuizClub
{
    /* DataModel is verantwoordelijk voor alle leden, teams en de
     * onderlinge relaties tussen beide.Alle bewerkingen in de GUI
     * van de leden en de teams van de quizvereniging verlopen via DataModel.
     * DataModel houdt automatisch alle wijziging bij in het bestand
     * DataFile. 
     */
    public class DataModel
    {
        private readonly List<Lid> _leden;
        private readonly List<Team> _teams;

        private const string DataFile = "datafile";
        private const string LidPrefix = "LID:";
        private const string TeamPrefix = "TEAM:";

        public Lid[] Leden {
            get
            {
                return _leden.ToArray();
            }
        }
        public Team[] Teams
        {
            get
            {
                return _teams.ToArray();
            }
        }

        /* CONSTRUCTORS */
        #region constructors
        public DataModel()
        {
            _leden = new List<Lid>();
            _teams = new List<Team>();
            ReadFromDataFile();
        }
        #endregion

        /* PRIVATE METHODS */
        #region private methods
        private void ReadFromDataFile()
        {
            if(File.Exists(DataFile))
            {
                string[] lines = File.ReadAllLines(DataFile);
                int lineNr = 0;
                List<string> errors = new List<string>();

                foreach(string line in lines)
                {
                    lineNr++;
                    if(line.StartsWith(LidPrefix))
                    {
                        try
                        { 
                            AddLidFromDataLine(line);
                        }
                        catch (Exception ex)
                        {
                            string message = $"Fout bij inlezen '{DataFile}' op lijn {lineNr}: " + ex.Message;
                            errors.Add(message);
                        }

                    }
                    if(line.StartsWith(TeamPrefix))
                    {
                        try
                        { 
                            AddTeamFromDataLine(line);
                        }
                        catch(Exception ex)
                        {
                            string message = $"Fout bij inlezen '{DataFile}' op lijn {lineNr}: " + ex.Message;
                            errors.Add(message);
                        }
                    }
                }

                if(errors.Count > 0)
                {
                    StringBuilder message = new StringBuilder($"Er waren fouten bij het inlezen van '{DataFile}':");
                    message.Append(Environment.NewLine);
                    foreach(string error in errors)
                    {
                        message.Append(error);
                        message.Append(Environment.NewLine);
                    }
                    throw new Exception(message.ToString());
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
            string voornaam = Sanitize(lid.Voornaam);
            string familienaam = Sanitize(lid.Familienaam);
            string geslacht = lid.Geslacht.ToString();
            string geboortedatum = lid.Geboortedatum.ToString("dd/MM/yyyy");
            string specialisatie = Sanitize(lid.Specialisatie.GetDescription());

            return $"{LidPrefix}{nummer};{voornaam};{familienaam};{geslacht};{geboortedatum};{specialisatie}";
        }

        private string TeamToDataLine(Team team)
        {
            Lid[] leden = team.Leden;
            string id = team.Id.ToString();
            string naam = Sanitize(team.Naam);
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

        // Verwijder ';' uit strings en vervang door ','
        // (';' wordt als separator in datafile gebruikt.)
        private string Sanitize(string s)
        {
            return s.Replace(';', ',');
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
        #endregion

        /* PUBLIC METHODS */
        #region public methods
        public void LidToevoegen(Lid lid)
        {
            _leden.Add(lid);
            WriteDataFile();
        }

        public void LidVerwijderen(Lid lid)
        {
            List<string> lidInTeams = new List<string>();
            if(_leden.Contains(lid))
            {
                foreach(Team team in _teams)
                {
                    if(team.IsLid(lid))
                    {
                        lidInTeams.Add($"{team.Naam} ({team.Id})");
                    }
                }

                if (lidInTeams.Count > 0)
                {
                    StringBuilder message = new StringBuilder("Het lid kan niet verwijderd worden, omdat het teamlid is bij volgende teams:"
                        + Environment.NewLine);
                    foreach(string s in lidInTeams)
                    {
                        message.Append(s + Environment.NewLine);
                    }
                    throw new LidVerwijderenException(message.ToString());

                }
                else
                {
                    _leden.Remove(lid);
                }
            }
            else
            {
                throw new LidOnbekendException(lid);
            }
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

        public void TeamVerwijderen(Team team)
        {
            if(_teams.Contains(team))
            {
                _teams.Remove(team);
            }
            else
            {
                throw new TeamOnbekendException(team);
            }
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
                if(lid==null)
                {
                    throw new LidOnbekendException("Geen lid geselecteerd.");
                }
                else if(!Leden.Contains(lid))
                {
                    throw new LidOnbekendException(lid);
                }
                if(team==null)
                {
                    throw new TeamOnbekendException("Geen team geselecteerd.");
                }
                else if(!Teams.Contains(team))
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

        public void Refresh()
        {
            WriteDataFile();
            _leden.Clear();
            _teams.Clear();
            Lid.ResetTeller();
            Team.ResetTeller();
            ReadFromDataFile();
        }
        #endregion
    }
}
