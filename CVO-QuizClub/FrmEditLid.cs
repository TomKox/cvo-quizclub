﻿using System;
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
    public partial class FrmEditLid : Form
    {
        private Lid _lid;

        public Lid Lid { get => _lid; }

        public FrmEditLid(Boolean editMode)
        {
            InitializeComponent();
            _lid = null;

            foreach(Geslacht g in Enum.GetValues(typeof(Geslacht)))
            {
                cmbGeslacht.Items.Add(g.ToString());
            }

            foreach(Specialisatie s in Enum.GetValues(typeof(Specialisatie)))
            {
                cmbSpecialisatie.Items.Add(s.GetDescription());
            }

            if (editMode)
            {
                setEditMode();
            }
            else
            {
                setNewMode();
            }
        }

        public FrmEditLid() : this(true)
        {
        }

        public void setEditMode()
        {
            this.Text = "Lid bewerken";
            this.btnConfirm.Text = "Opslaan";
        }

        public void setNewMode()
        {
            this.Text = "Lid toevoegen";
            this.btnConfirm.Text = "Toevoegen";
            txtNummer.Text = Lid.Teller.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string nummer = txtNummer.Text;
            string voornaam = txtVoornaam.Text;
            string familienaam = txtFamilienaam.Text;
            string geboortedatum = txtGeboortedatum.Text;
            string geslachtString = cmbGeslacht.SelectedText;
            string specialisatieString = cmbSpecialisatie.SelectedText;

            _lid = new Lid(voornaam, 
                familienaam, 
                ParseGeslacht(geslachtString),
                ParseGeboortedatum(geboortedatum), 
                ParseSpecialisatie(specialisatieString));
        }

        private DateTime ParseGeboortedatum(string datumstring)
        {
            string[] fields = datumstring.Split('/');
            int day = Convert.ToInt32(fields[0]);
            int month = Convert.ToInt32(fields[1]);
            int year = Convert.ToInt32(fields[2]);
            return new DateTime(year, month, day);
        }

        private Specialisatie ParseSpecialisatie(string specstring)
        {
            Specialisatie spec = Specialisatie.Actualiteit;
            foreach(Specialisatie s in Enum.GetValues(typeof(Specialisatie)))
            {
                if(s.GetDescription() == specstring)
                {
                    spec = s;
                    break;
                }
            }
            return spec;
        }

        private Geslacht ParseGeslacht(string geslachtString)
        {
            Geslacht geslacht = Geslacht.M;
            foreach (Geslacht g in Enum.GetValues(typeof(Geslacht)))
            {
                if(g.ToString() == geslachtString)
                {
                    geslacht = g;
                }
            }
            return geslacht;
        }

        //private void lblGeboortedatum_Click(object sender, EventArgs e)
        //{

        //}
    }
}
