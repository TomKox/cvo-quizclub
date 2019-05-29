namespace CVO_QuizClub
{
    partial class FrmEditLid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNummer = new System.Windows.Forms.Label();
            this.txtNummer = new System.Windows.Forms.TextBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.txtFamilienaam = new System.Windows.Forms.TextBox();
            this.lblFamilienaam = new System.Windows.Forms.Label();
            this.lblGeboortedatum = new System.Windows.Forms.Label();
            this.txtGeboortedatum = new System.Windows.Forms.MaskedTextBox();
            this.cmbGeslacht = new System.Windows.Forms.ComboBox();
            this.lblGeslacht = new System.Windows.Forms.Label();
            this.cmbSpecialisatie = new System.Windows.Forms.ComboBox();
            this.lblSpecialisatie = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNummer
            // 
            this.lblNummer.AutoSize = true;
            this.lblNummer.Location = new System.Drawing.Point(102, 14);
            this.lblNummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNummer.Name = "lblNummer";
            this.lblNummer.Size = new System.Drawing.Size(25, 20);
            this.lblNummer.TabIndex = 0;
            this.lblNummer.Text = "Nr";
            // 
            // txtNummer
            // 
            this.txtNummer.Location = new System.Drawing.Point(138, 9);
            this.txtNummer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNummer.Name = "txtNummer";
            this.txtNummer.ReadOnly = true;
            this.txtNummer.Size = new System.Drawing.Size(85, 26);
            this.txtNummer.TabIndex = 1;
            this.txtNummer.TabStop = false;
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(138, 49);
            this.txtVoornaam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(148, 26);
            this.txtVoornaam.TabIndex = 0;
            this.txtVoornaam.TextChanged += new System.EventHandler(this.txtVoornaam_TextChanged);
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(46, 54);
            this.lblVoornaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(83, 20);
            this.lblVoornaam.TabIndex = 2;
            this.lblVoornaam.Text = "Voornaam";
            // 
            // txtFamilienaam
            // 
            this.txtFamilienaam.Location = new System.Drawing.Point(138, 89);
            this.txtFamilienaam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFamilienaam.Name = "txtFamilienaam";
            this.txtFamilienaam.Size = new System.Drawing.Size(148, 26);
            this.txtFamilienaam.TabIndex = 1;
            this.txtFamilienaam.TextChanged += new System.EventHandler(this.txtFamilienaam_TextChanged);
            // 
            // lblFamilienaam
            // 
            this.lblFamilienaam.AutoSize = true;
            this.lblFamilienaam.Location = new System.Drawing.Point(32, 94);
            this.lblFamilienaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFamilienaam.Name = "lblFamilienaam";
            this.lblFamilienaam.Size = new System.Drawing.Size(99, 20);
            this.lblFamilienaam.TabIndex = 4;
            this.lblFamilienaam.Text = "Familienaam";
            // 
            // lblGeboortedatum
            // 
            this.lblGeboortedatum.AutoSize = true;
            this.lblGeboortedatum.Location = new System.Drawing.Point(9, 134);
            this.lblGeboortedatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeboortedatum.Name = "lblGeboortedatum";
            this.lblGeboortedatum.Size = new System.Drawing.Size(122, 20);
            this.lblGeboortedatum.TabIndex = 6;
            this.lblGeboortedatum.Text = "Geboortedatum";
            // 
            // txtGeboortedatum
            // 
            this.txtGeboortedatum.Location = new System.Drawing.Point(138, 129);
            this.txtGeboortedatum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGeboortedatum.Mask = "00/00/0000";
            this.txtGeboortedatum.Name = "txtGeboortedatum";
            this.txtGeboortedatum.Size = new System.Drawing.Size(108, 26);
            this.txtGeboortedatum.TabIndex = 2;
            this.txtGeboortedatum.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtGeboortedatum_MaskInputRejected);
            this.txtGeboortedatum.TextChanged += new System.EventHandler(this.txtGeboortedatum_TextChanged);
            // 
            // cmbGeslacht
            // 
            this.cmbGeslacht.FormattingEnabled = true;
            this.cmbGeslacht.Location = new System.Drawing.Point(138, 169);
            this.cmbGeslacht.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbGeslacht.Name = "cmbGeslacht";
            this.cmbGeslacht.Size = new System.Drawing.Size(85, 28);
            this.cmbGeslacht.TabIndex = 3;
            this.cmbGeslacht.SelectedIndexChanged += new System.EventHandler(this.cmbGeslacht_SelectedIndexChanged);
            // 
            // lblGeslacht
            // 
            this.lblGeslacht.AutoSize = true;
            this.lblGeslacht.Location = new System.Drawing.Point(56, 174);
            this.lblGeslacht.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeslacht.Name = "lblGeslacht";
            this.lblGeslacht.Size = new System.Drawing.Size(73, 20);
            this.lblGeslacht.TabIndex = 9;
            this.lblGeslacht.Text = "Geslacht";
            // 
            // cmbSpecialisatie
            // 
            this.cmbSpecialisatie.FormattingEnabled = true;
            this.cmbSpecialisatie.Location = new System.Drawing.Point(138, 211);
            this.cmbSpecialisatie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSpecialisatie.Name = "cmbSpecialisatie";
            this.cmbSpecialisatie.Size = new System.Drawing.Size(204, 28);
            this.cmbSpecialisatie.TabIndex = 4;
            this.cmbSpecialisatie.SelectedIndexChanged += new System.EventHandler(this.cmbSpecialisatie_SelectedIndexChanged);
            // 
            // lblSpecialisatie
            // 
            this.lblSpecialisatie.AutoSize = true;
            this.lblSpecialisatie.Location = new System.Drawing.Point(30, 215);
            this.lblSpecialisatie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecialisatie.Name = "lblSpecialisatie";
            this.lblSpecialisatie.Size = new System.Drawing.Size(98, 20);
            this.lblSpecialisatie.TabIndex = 11;
            this.lblSpecialisatie.Text = "Specialisatie";
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Location = new System.Drawing.Point(81, 277);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 35);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Toevoegen";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(202, 277);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmEditLid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 335);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblSpecialisatie);
            this.Controls.Add(this.cmbSpecialisatie);
            this.Controls.Add(this.lblGeslacht);
            this.Controls.Add(this.cmbGeslacht);
            this.Controls.Add(this.txtGeboortedatum);
            this.Controls.Add(this.lblGeboortedatum);
            this.Controls.Add(this.txtFamilienaam);
            this.Controls.Add(this.lblFamilienaam);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.txtNummer);
            this.Controls.Add(this.lblNummer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditLid";
            this.Text = "FrmEditLid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNummer;
        private System.Windows.Forms.TextBox txtNummer;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.TextBox txtFamilienaam;
        private System.Windows.Forms.Label lblFamilienaam;
        private System.Windows.Forms.Label lblGeboortedatum;
        private System.Windows.Forms.MaskedTextBox txtGeboortedatum;
        private System.Windows.Forms.ComboBox cmbGeslacht;
        private System.Windows.Forms.Label lblGeslacht;
        private System.Windows.Forms.ComboBox cmbSpecialisatie;
        private System.Windows.Forms.Label lblSpecialisatie;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}