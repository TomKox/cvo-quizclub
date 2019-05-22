using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVO_QuizClub
{
    public partial class FrmQuizClub : Form
    {
        private DataModel DataModel { get; set; }

        public FrmQuizClub()
        {
            DataModel = new DataModel();

            //TESTDATA
            /* Lid lid1 = new Lid("Tom", "Kox", Geslacht.M, new DateTime(1981, 03, 12), Specialisatie.FilmEnMuziek);
            Lid lid2 = new Lid("Harry", "Peters", Geslacht.M, new DateTime(1979, 1, 2), Specialisatie.Actualiteit);
            Lid lid3 = new Lid("Sara", "Janssens", Geslacht.V, new DateTime(1985, 11, 17), Specialisatie.Cultuur);
            Lid lid4 = new Lid("Chris", "Aers", Geslacht.X, new DateTime(1980, 2, 24), Specialisatie.Wetenschappen);
            Lid lid5 = new Lid("Annie", "De Kock", Geslacht.V, new DateTime(1960, 4, 12), Specialisatie.Sport);

            Team team1 = new Team("De prutsers");
            Team team2 = new Team("Witte geit?");

            DataModel.LidToevoegen(lid1);
            DataModel.LidToevoegen(lid2);
            DataModel.LidToevoegen(lid3);
            DataModel.LidToevoegen(lid4);
            DataModel.LidToevoegen(lid5);
            DataModel.TeamToevoegen(team1);
            DataModel.TeamToevoegen(team2);
            DataModel.LidToevoegenAanTeam(lid1, team1);
            DataModel.LidToevoegenAanTeam(lid2, team1);
            DataModel.LidToevoegenAanTeam(lid3, team1);
            DataModel.LidToevoegenAanTeam(lid4, team1);
            DataModel.LidToevoegenAanTeam(lid5, team2); */
            

            InitializeComponent();

        }

        public void Update()
        {
            lboxLeden.DataSource = DataModel.Leden;
            lboxTeams.DataSource = DataModel.Teams;
            
        }
    }
}
