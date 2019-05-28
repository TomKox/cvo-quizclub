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
    public partial class FrmEditTeam : Form
    {
        private Team _team;

        public Team Team { get => _team; }
        public bool EditMode { get; set; }

        private FrmEditTeam(bool editMode)
        {
            _team = null;
            InitializeComponent();
            EditMode = editMode;

            if (EditMode)
            {
                SetEditMode();
            }
            else
            {
                SetNewMode();
            }
        }

        private void SetEditMode()
        {
            this.Text = "Team bewerken";
            btnConfirm.Text = "Opslaan";
        }

        private void SetNewMode()
        {
            this.Text = "Team toevoegen";
            btnConfirm.Text = "Toevoegen";
            txtId.Text = Team.Teller.ToString();
        }

        public FrmEditTeam() : this(false)
        {
        }

        public FrmEditTeam(Team team) : this(true)
        {
            _team = team;
            txtId.Text = _team.Id.ToString();
            txtNaam.Text = _team.Naam;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string naam = txtNaam.Text.Trim();

            if(EditMode)
            {
                _team.Naam = naam;
            }
            else
            {
                _team = new Team(naam);
            }
        }
    }
}
