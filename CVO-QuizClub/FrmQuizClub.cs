﻿using CVO_QuizClub.Exceptions;
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
            try
            {
                DataModel = new DataModel();
            }
            catch (Exception ex)
            {
                string message = ex.Message + Environment.NewLine + "U moet deze fouten eerst corrigeren, voordat u de toepassing kunt starten.";
                MessageBox.Show(message,"Fout bij inlezen gegevens", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(13); // Invalid data: https://docs.microsoft.com/en-gb/windows/desktop/Debug/system-error-codes--0-499-
            }

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
                try
                { 
                    DataModel.TeamToevoegen(newTeam);
                }
                catch(TeamNaamAlGebruiktException ex)
                {
                    MessageBox.Show(ex.Message, "Teamnaam al gebruikt!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
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

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            TeamlidToevoegen();
        }

        private void btnTeamLidVerwijderen_Click(object sender, EventArgs e)
        {
            TeamlidVerwijderen();
        }

        private void TeamlidToevoegen()
        {
            //Lid lid = (Lid)lboxLeden.SelectedItem;
            //Team team = (Team)lboxTeams.SelectedItem;
            SelectedLid = (Lid)lboxLeden.SelectedItem;
            SelectedTeam = (Team)lboxTeams.SelectedItem;

            try
            {
                DataModel.LidToevoegenAanTeam(SelectedLid, SelectedTeam);
            }
            catch(LidAlTeamlidException ex)
            {
                MessageBox.Show(ex.Message, "Al teamlid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(TeamVolzetException ex)
            {
                MessageBox.Show(ex.Message, "Team volzet!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateLijsten();
        }

        private void TeamlidVerwijderen()
        {
            SelectedTeam = (Team)lboxTeams.SelectedItem;
            Lid teamlid = (Lid)lboxTeamLeden.SelectedItem;

            DataModel.LidVerwijderenUitTeam(teamlid, SelectedTeam);

            UpdateLijsten();
        }


    }
}
