﻿using CVO_QuizClub.Exceptions;
using System;
using System.Windows.Forms;

namespace CVO_QuizClub
{
    public partial class FrmQuizClub : Form
    {
        /* PRIVATE PROPERTIES */
        #region private properties
        private DataModel DataModel { get; set; }
        private Lid SelectedLid { get; set; }
        private Team SelectedTeam { get; set; }
        #endregion


        /* CONSTRUCTOR */
        #region constructors
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
        #endregion

        /* PRIVATE METHODS */
        #region private methods
        private void UpdateLijsten()
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
                if(lboxLeden.Items.Count != 0) 
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
                if(lboxTeams.Items.Count != 0)
                    lboxTeams.SelectedIndex = 0;
            }
        }

        private void TeamlidToevoegen()
        {
            SelectedLid = (Lid)lboxLeden.SelectedItem;
            SelectedTeam = (Team)lboxTeams.SelectedItem;

            try
            {
                DataModel.LidToevoegenAanTeam(SelectedLid, SelectedTeam);
            }
            catch (LidAlTeamlidException ex)
            {
                MessageBox.Show(ex.Message, "Al teamlid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TeamVolzetException ex)
            {
                MessageBox.Show(ex.Message, "Team volzet!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TeamOnbekendException ex)
            {
                MessageBox.Show(ex.Message, "Geen team geselecteerd!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            catch (LidOnbekendException ex)
            {
                MessageBox.Show(ex.Message, "Geen lid geselecteerd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateLijsten();
        }

        private void TeamlidVerwijderen()
        {
            SelectedTeam = (Team)lboxTeams.SelectedItem;
            Lid teamlid = (Lid)lboxTeamLeden.SelectedItem;

            try
            {
                DataModel.LidVerwijderenUitTeam(teamlid, SelectedTeam);
            }
            catch(NullReferenceException ex)
            {
                // teamlid == null --> Do nothing.
            }

            UpdateLijsten();
        }

        private void NieuwLid()
        {
            FrmEditLid editForm = new FrmEditLid();

            DialogResult result = editForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                Lid nieuwLid = editForm.Lid;
                DataModel.LidToevoegen(nieuwLid);
                SelectedLid = nieuwLid;
                UpdateLijsten();
            }
        }

        private void LidBewerken()
        {
            Lid editLid = (Lid)lboxLeden.SelectedItem;
            if (editLid == null) return; // Stoppen indien niets geselecteerd.
            FrmEditLid editForm = new FrmEditLid(editLid);

            DialogResult result = editForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                SelectedLid = editForm.Lid;
                SelectedTeam = (Team)lboxTeams.SelectedItem;
                lboxLeden.SelectedItem = editLid;
                UpdateLijsten();
            }
        }

        private void LidVerwijderen()
        {
            Lid lid = (Lid)lboxLeden.SelectedItem;
            if (lid == null) return; // Stoppen indien geen lid geselecteerd.
            string message = $"Lid '{lid.VolledigeNaam}' ({lid.Nummer}) zal verwijderd worden." + Environment.NewLine
                + "Wilt u hiermee doorgaan?";
            DialogResult result = MessageBox.Show(
                message, "Bent u zeker?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DataModel.LidVerwijderen(lid);
                }
                catch (LidVerwijderenException ex)
                {
                    string errorMessage = ex.Message + Environment.NewLine
                        + "Verwijderen het teamlid uit deze teams en probeer opnieuw.";
                    MessageBox.Show(errorMessage, "Kan lid niet verwijderen!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SelectedLid = null;
                ClearLidFields();
                UpdateLijsten();
            }
        }

        private void NieuwTeam()
        {
            FrmEditTeam editTeam = new FrmEditTeam();
            DialogResult result = editTeam.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                Team newTeam = editTeam.Team;
                try
                {
                    DataModel.TeamToevoegen(newTeam);
                }
                catch (TeamNaamAlGebruiktException ex)
                {
                    MessageBox.Show(ex.Message, "Teamnaam al gebruikt!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SelectedTeam = newTeam;
                UpdateLijsten();
            }
        }

        private void TeamBewerken()
        {
            Team editTeam = (Team)lboxTeams.SelectedItem;
            if (editTeam == null) return; // Stoppen indien niets geselecteerd.
            FrmEditTeam editForm = new FrmEditTeam(editTeam);
            DialogResult result = editForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                SelectedTeam = editForm.Team;
                SelectedLid = (Lid)lboxLeden.SelectedItem; 
                lboxTeams.SelectedItem = editTeam;
                UpdateLijsten();
            }
        }

        private void TeamVerwijderen()
        {
            Team team = (Team)lboxTeams.SelectedItem;
            if (team == null) return; // Stoppen indien geen team geselecteerd.
            string message = $"Team '{team.Naam}' ({team.Id}) zal verwijderd worden." + Environment.NewLine
                + "Wilt u hiermee doorgaan?";
            DialogResult result = MessageBox.Show(
                message, "Bent u zeker?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataModel.TeamVerwijderen(team);
                SelectedTeam = null;
                SelectedLid = (Lid)lboxLeden.SelectedItem;
                ClearTeamFields();
                UpdateLijsten();
            }
        }

        private void ClearTeamFields()
        {
            txtTeamId.Text = "";
            txtTeamNaam.Text = "";
            lboxTeamLeden.Items.Clear();
        }

        private void ClearLidFields()
        {
            txtLidLeeftijd.Text = "";
            txtLidNaam.Text = "";
            txtLidNummer.Text = "";
            txtLidSpecialisatie.Text = "";
        }

        private void ShowInfo()
        {
            string info = "QuizClub Beheer" + Environment.NewLine
                + Environment.NewLine
                + "Evaluatieopdracht C# 2e semester" + Environment.NewLine
                + "CVO Hageland" + Environment.NewLine
                + "2019 - Tom Kox";

            MessageBox.Show(info, "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        /* GUI EVENTS */
        #region gui events
        private void btnNieuwLid_Click(object sender, EventArgs e)
        {
            NieuwLid();
        }

        private void btnLidBewerken_Click(object sender, EventArgs e)
        {
            LidBewerken();
        }

        private void btnLidVerwijderen_Click(object sender, EventArgs e)
        {
            LidVerwijderen();
        }

        private void btnNieuwTeam_Click(object sender, EventArgs e)
        {
            NieuwTeam();
        }

        private void btnTeamBewerken_Click(object sender, EventArgs e)
        {
            TeamBewerken();
        }

        private void btnTeamVerwijderen_Click(object sender, EventArgs e)
        {
            TeamVerwijderen();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            TeamlidToevoegen();
        }

        private void btnTeamLidVerwijderen_Click(object sender, EventArgs e)
        {
            TeamlidVerwijderen();
        }

        private void lboxLeden_SelectedValueChanged(object sender, EventArgs e)
        {
            Lid selectie = (Lid)lboxLeden.SelectedItem;
            txtLidNaam.Text = selectie.VolledigeNaam;
            txtLidSpecialisatie.Text = selectie.Specialisatie.GetDescription();
            txtLidNummer.Text = selectie.Nummer.ToString();
            txtLidLeeftijd.Text = selectie.Leeftijd.ToString();
        }

        private void lboxTeams_SelectedValueChanged(object sender, EventArgs e)
        {
            Team selectie = (Team)lboxTeams.SelectedItem;
            txtTeamNaam.Text = selectie.Naam;
            txtTeamId.Text = selectie.Id.ToString();

            lboxTeamLeden.Items.Clear();
            foreach (Lid teamlid in selectie.Leden)
            {
                if (teamlid != null)
                {
                    lboxTeamLeden.Items.Add(teamlid);
                }
            }
        }

        private void lboxLeden_MouseDown(object sender, MouseEventArgs e)
        {
            lboxLeden_SelectedValueChanged(sender, e);

            if (lboxLeden.Items.Count == 0)
                return;

            int index = lboxLeden.IndexFromPoint(e.X, e.Y);
            if(index >= 0) { 
                Lid lid = (Lid)lboxLeden.Items[index];
                DragDropEffects dde1 = DoDragDrop(lid, DragDropEffects.Copy);
            }
        }
        
        private void lboxTeamLeden_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lboxTeamLeden_DragDrop(object sender, DragEventArgs e)
        {
                Lid lid = (Lid)e.Data.GetData(typeof(Lid));
                TeamlidToevoegen();
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void nieuwLidAanmakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NieuwLid();
        }

        private void lidBewerkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LidBewerken();
        }

        private void lidVerwijderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LidVerwijderen();
        }

        private void lidToevoegenAanTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamlidToevoegen();
        }

        private void nieuwLidToevoegenAanTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NieuwLid();
            TeamlidToevoegen();
        }

        private void nieuwTeamAanmakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NieuwTeam();
        }

        private void teamBewerkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamBewerken();
        }

        private void teamVerwijderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamVerwijderen();
        }

        private void teamlidVerwijderenUitTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamlidVerwijderen();
        }
    }
}
