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

            InitializeComponent();

            UpdateLijsten();
        }

        public void UpdateLijsten()
        {
            DataModel.Refresh();
            lboxLeden.DataSource = DataModel.Leden;
            lboxTeams.DataSource = DataModel.Teams;
        }

        private void btnNieuwLid_Click(object sender, EventArgs e)
        {
            FrmEditLid editForm = new FrmEditLid();
            
            DialogResult result = editForm.ShowDialog(this);
            if(result == DialogResult.OK) {
                Lid nieuwLid = editForm.Lid;
                DataModel.LidToevoegen(nieuwLid);
                UpdateLijsten();
                foreach(object obj in lboxLeden.Items)
                {
                    Lid lid = (Lid)obj;
                    if (lid.Nummer == nieuwLid.Nummer)
                    {
                        lboxLeden.SelectedItem = lid;
                        break;
                    }
                }
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
            UpdateLijsten();
            foreach(object obj in lboxLeden.Items)
            {
                Lid lid = (Lid)obj;
                if(lid.Nummer == editLid.Nummer)
                {
                    lboxLeden.SelectedItem = lid;
                    break;
                }
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
    }
}
