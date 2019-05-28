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
        private Lid SelectedLid { get; set; }
        private Team SelectedTeam { get; set; }

        public FrmQuizClub()
        {
            DataModel = new DataModel();

            InitializeComponent();

            UpdateLijsten();
        }

        public void UpdateLijsten()
        {
            DataModel.Refresh();
            lboxLeden.DataSource = DataModel.Leden;
            lboxTeams.DataSource = DataModel.Teams;

            if(SelectedLid != null)
            { 
                foreach(Object obj in lboxLeden.Items)
                {
                    Lid lid = (Lid)obj;
                    if(lid.Nummer == SelectedLid.Nummer)
                    {
                        lboxLeden.SelectedItem = lid;
                        break;
                    }
                }
            }
            else
            {
                lboxLeden.SelectedIndex = 0;
            }

            if(SelectedTeam != null)
            {
                foreach (Object obj in lboxTeams.Items)
                {
                    Team team = (Team)obj;
                    if(team.Id == SelectedTeam.Id)
                    {
                        lboxTeams.SelectedItem = team;
                        break;
                    }
                }
            }
            else
            {
                lboxTeams.SelectedIndex = 0;
            }
        }

        private void btnNieuwLid_Click(object sender, EventArgs e)
        {
            FrmEditLid editForm = new FrmEditLid();
            
            DialogResult result = editForm.ShowDialog(this);
            if(result == DialogResult.OK) {
                Lid nieuwLid = editForm.Lid;
                DataModel.LidToevoegen(nieuwLid);
                SelectedLid = nieuwLid;
                UpdateLijsten();
            }
        }

        private void lboxLeden_SelectedValueChanged(object sender, EventArgs e)
        {
            Lid selectie = (Lid)lboxLeden.SelectedItem;
            txtLidNaam.Text = selectie.VolledigeNaam;
            txtLidSpecialisatie.Text = selectie.Specialisatie.GetDescription();
            txtLidNummer.Text = selectie.Nummer.ToString();
            txtLidLeeftijd.Text = selectie.Leeftijd.ToString();
        }

        private void btnLidBewerken_Click(object sender, EventArgs e)
        {
            Lid editLid = (Lid)lboxLeden.SelectedItem;
            FrmEditLid editForm = new FrmEditLid(editLid);

            DialogResult result = editForm.ShowDialog(this);
            if(result == DialogResult.OK) {
                SelectedLid = editForm.Lid;
                lboxLeden.SelectedItem = editLid;
                UpdateLijsten();
            }
        }

        private void btnLidVerwijderen_Click(object sender, EventArgs e)
        {
            Lid lid = (Lid)lboxLeden.SelectedItem;
            string message = $"Lid '{lid.VolledigeNaam}' ({lid.Nummer}) zal verwijderd worden." + Environment.NewLine
                + "Wilt u hiermee doorgaan?";
            DialogResult result = MessageBox.Show(
                message, "Bent u zeker?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result==DialogResult.Yes)
            {
                DataModel.LidVerwijderen(lid);
                SelectedLid = null;
                UpdateLijsten();
            }
        }

        private void btnNieuwTeam_Click(object sender, EventArgs e)
        {
            FrmEditTeam editTeam = new FrmEditTeam();
            DialogResult result = editTeam.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                Team newTeam = editTeam.Team;
                DataModel.TeamToevoegen(newTeam);
                UpdateLijsten();
            }

        }

        private void btnTeamBewerken_Click(object sender, EventArgs e)
        {
            Team editTeam = (Team)lboxTeams.SelectedItem;
            FrmEditTeam editForm = new FrmEditTeam(editTeam);
            DialogResult result = editForm.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                SelectedTeam = editForm.Team;
                lboxTeams.SelectedItem = editTeam;
                UpdateLijsten();
            }
        }

        private void lboxTeams_SelectedValueChanged(object sender, EventArgs e)
        {
            //txtLidNaam.Text = selectie.VolledigeNaam;
            //txtLidSpecialisatie.Text = selectie.Specialisatie.GetDescription();
            //txtLidNummer.Text = selectie.Nummer.ToString();
            //txtLidLeeftijd.Text = selectie.Leeftijd.ToString();

            Team selectie = (Team)lboxTeams.SelectedItem;
            txtTeamNaam.Text = selectie.Naam;
            txtTeamId.Text = selectie.Id.ToString();

            lboxTeamLeden.Items.Clear();
            foreach(Lid teamlid in selectie.Leden)
            {
                if(teamlid != null) { 
                    lboxTeamLeden.Items.Add(teamlid);
                }
            }
        }

        private void btnTeamVerwijderen_Click(object sender, EventArgs e)
        {
            Team team = (Team)lboxTeams.SelectedItem;
            string message = $"Team '{team.Naam}' ({team.Id}) zal verwijderd worden." + Environment.NewLine
                + "Wilt u hiermee doorgaan?";
            DialogResult result = MessageBox.Show(
                message, "Bent u zeker?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataModel.TeamVerwijderen(team);
                SelectedTeam = null;
                UpdateLijsten();
            }

        }
    }
}
