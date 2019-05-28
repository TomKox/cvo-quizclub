namespace CVO_QuizClub
{
    partial class FrmQuizClub
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeden = new System.Windows.Forms.Panel();
            this.pnlLedenList = new System.Windows.Forms.Panel();
            this.lboxLeden = new System.Windows.Forms.ListBox();
            this.pnlLedenControls = new System.Windows.Forms.Panel();
            this.btnNieuwLid = new System.Windows.Forms.Button();
            this.btnLidBewerken = new System.Windows.Forms.Button();
            this.btnLidVerwijderen = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.lblLeeftijd = new System.Windows.Forms.Label();
            this.txtLidLeeftijd = new System.Windows.Forms.TextBox();
            this.lblSpecialisatie = new System.Windows.Forms.Label();
            this.txtLidSpecialisatie = new System.Windows.Forms.TextBox();
            this.txtLidNummer = new System.Windows.Forms.TextBox();
            this.lblLidNummer = new System.Windows.Forms.Label();
            this.txtLidNaam = new System.Windows.Forms.TextBox();
            this.lblLidNaam = new System.Windows.Forms.Label();
            this.lblLeden = new System.Windows.Forms.Label();
            this.pnlTeams = new System.Windows.Forms.Panel();
            this.pnlTeamsList = new System.Windows.Forms.Panel();
            this.lboxTeams = new System.Windows.Forms.ListBox();
            this.pnlTeamsControls = new System.Windows.Forms.Panel();
            this.btnNieuwTeam = new System.Windows.Forms.Button();
            this.lblTeamId = new System.Windows.Forms.Label();
            this.btnTeamBewerken = new System.Windows.Forms.Button();
            this.txtTeamId = new System.Windows.Forms.TextBox();
            this.btnTeamVerwijderen = new System.Windows.Forms.Button();
            this.btnTeamLidVerwijderen = new System.Windows.Forms.Button();
            this.txtTeamNaam = new System.Windows.Forms.TextBox();
            this.lblTeamNaam = new System.Windows.Forms.Label();
            this.pnlTeamLeden = new System.Windows.Forms.Panel();
            this.lboxTeamLeden = new System.Windows.Forms.ListBox();
            this.lblTeamLeden = new System.Windows.Forms.Label();
            this.lblTeams = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblMain.SuspendLayout();
            this.pnlLeden.SuspendLayout();
            this.pnlLedenList.SuspendLayout();
            this.pnlLedenControls.SuspendLayout();
            this.pnlTeams.SuspendLayout();
            this.pnlTeamsList.SuspendLayout();
            this.pnlTeamsControls.SuspendLayout();
            this.pnlTeamLeden.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.pnlLeden, 0, 0);
            this.tblMain.Controls.Add(this.pnlTeams, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 24);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(912, 611);
            this.tblMain.TabIndex = 0;
            // 
            // pnlLeden
            // 
            this.pnlLeden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeden.Controls.Add(this.pnlLedenList);
            this.pnlLeden.Controls.Add(this.pnlLedenControls);
            this.pnlLeden.Controls.Add(this.lblLeden);
            this.pnlLeden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeden.Location = new System.Drawing.Point(3, 3);
            this.pnlLeden.Name = "pnlLeden";
            this.pnlLeden.Padding = new System.Windows.Forms.Padding(30, 0, 15, 0);
            this.pnlLeden.Size = new System.Drawing.Size(450, 605);
            this.pnlLeden.TabIndex = 0;
            // 
            // pnlLedenList
            // 
            this.pnlLedenList.Controls.Add(this.lboxLeden);
            this.pnlLedenList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLedenList.Location = new System.Drawing.Point(30, 51);
            this.pnlLedenList.Name = "pnlLedenList";
            this.pnlLedenList.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlLedenList.Size = new System.Drawing.Size(403, 451);
            this.pnlLedenList.TabIndex = 3;
            // 
            // lboxLeden
            // 
            this.lboxLeden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxLeden.FormattingEnabled = true;
            this.lboxLeden.Location = new System.Drawing.Point(0, 0);
            this.lboxLeden.Name = "lboxLeden";
            this.lboxLeden.Size = new System.Drawing.Size(403, 441);
            this.lboxLeden.TabIndex = 1;
            this.lboxLeden.SelectedValueChanged += new System.EventHandler(this.lboxLeden_SelectedValueChanged);
            // 
            // pnlLedenControls
            // 
            this.pnlLedenControls.Controls.Add(this.btnNieuwLid);
            this.pnlLedenControls.Controls.Add(this.btnLidBewerken);
            this.pnlLedenControls.Controls.Add(this.btnLidVerwijderen);
            this.pnlLedenControls.Controls.Add(this.btnToevoegen);
            this.pnlLedenControls.Controls.Add(this.lblLeeftijd);
            this.pnlLedenControls.Controls.Add(this.txtLidLeeftijd);
            this.pnlLedenControls.Controls.Add(this.lblSpecialisatie);
            this.pnlLedenControls.Controls.Add(this.txtLidSpecialisatie);
            this.pnlLedenControls.Controls.Add(this.txtLidNummer);
            this.pnlLedenControls.Controls.Add(this.lblLidNummer);
            this.pnlLedenControls.Controls.Add(this.txtLidNaam);
            this.pnlLedenControls.Controls.Add(this.lblLidNaam);
            this.pnlLedenControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLedenControls.Location = new System.Drawing.Point(30, 502);
            this.pnlLedenControls.Name = "pnlLedenControls";
            this.pnlLedenControls.Size = new System.Drawing.Size(403, 101);
            this.pnlLedenControls.TabIndex = 2;
            // 
            // btnNieuwLid
            // 
            this.btnNieuwLid.Location = new System.Drawing.Point(6, 58);
            this.btnNieuwLid.Name = "btnNieuwLid";
            this.btnNieuwLid.Size = new System.Drawing.Size(75, 23);
            this.btnNieuwLid.TabIndex = 13;
            this.btnNieuwLid.Text = "Nieuw";
            this.btnNieuwLid.UseVisualStyleBackColor = true;
            this.btnNieuwLid.Click += new System.EventHandler(this.btnNieuwLid_Click);
            // 
            // btnLidBewerken
            // 
            this.btnLidBewerken.Location = new System.Drawing.Point(87, 58);
            this.btnLidBewerken.Name = "btnLidBewerken";
            this.btnLidBewerken.Size = new System.Drawing.Size(75, 23);
            this.btnLidBewerken.TabIndex = 12;
            this.btnLidBewerken.Text = "Bewerken";
            this.btnLidBewerken.UseVisualStyleBackColor = true;
            this.btnLidBewerken.Click += new System.EventHandler(this.btnLidBewerken_Click);
            // 
            // btnLidVerwijderen
            // 
            this.btnLidVerwijderen.Location = new System.Drawing.Point(168, 58);
            this.btnLidVerwijderen.Name = "btnLidVerwijderen";
            this.btnLidVerwijderen.Size = new System.Drawing.Size(75, 23);
            this.btnLidVerwijderen.TabIndex = 11;
            this.btnLidVerwijderen.Text = "Verwijderen";
            this.btnLidVerwijderen.UseVisualStyleBackColor = true;
            this.btnLidVerwijderen.Click += new System.EventHandler(this.btnLidVerwijderen_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(270, 58);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(133, 23);
            this.btnToevoegen.TabIndex = 10;
            this.btnToevoegen.Text = "Toevoegen aan team";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            // 
            // lblLeeftijd
            // 
            this.lblLeeftijd.AutoSize = true;
            this.lblLeeftijd.Location = new System.Drawing.Point(296, 35);
            this.lblLeeftijd.Name = "lblLeeftijd";
            this.lblLeeftijd.Size = new System.Drawing.Size(41, 13);
            this.lblLeeftijd.TabIndex = 9;
            this.lblLeeftijd.Text = "Leeftijd";
            // 
            // txtLidLeeftijd
            // 
            this.txtLidLeeftijd.Location = new System.Drawing.Point(343, 32);
            this.txtLidLeeftijd.Name = "txtLidLeeftijd";
            this.txtLidLeeftijd.ReadOnly = true;
            this.txtLidLeeftijd.Size = new System.Drawing.Size(59, 20);
            this.txtLidLeeftijd.TabIndex = 8;
            // 
            // lblSpecialisatie
            // 
            this.lblSpecialisatie.AutoSize = true;
            this.lblSpecialisatie.Location = new System.Drawing.Point(3, 35);
            this.lblSpecialisatie.Name = "lblSpecialisatie";
            this.lblSpecialisatie.Size = new System.Drawing.Size(66, 13);
            this.lblSpecialisatie.TabIndex = 7;
            this.lblSpecialisatie.Text = "Specialisatie";
            // 
            // txtLidSpecialisatie
            // 
            this.txtLidSpecialisatie.Location = new System.Drawing.Point(75, 32);
            this.txtLidSpecialisatie.Name = "txtLidSpecialisatie";
            this.txtLidSpecialisatie.ReadOnly = true;
            this.txtLidSpecialisatie.Size = new System.Drawing.Size(215, 20);
            this.txtLidSpecialisatie.TabIndex = 6;
            // 
            // txtLidNummer
            // 
            this.txtLidNummer.Location = new System.Drawing.Point(343, 6);
            this.txtLidNummer.Name = "txtLidNummer";
            this.txtLidNummer.ReadOnly = true;
            this.txtLidNummer.Size = new System.Drawing.Size(59, 20);
            this.txtLidNummer.TabIndex = 5;
            // 
            // lblLidNummer
            // 
            this.lblLidNummer.AutoSize = true;
            this.lblLidNummer.Location = new System.Drawing.Point(319, 9);
            this.lblLidNummer.Name = "lblLidNummer";
            this.lblLidNummer.Size = new System.Drawing.Size(18, 13);
            this.lblLidNummer.TabIndex = 4;
            this.lblLidNummer.Text = "Nr";
            // 
            // txtLidNaam
            // 
            this.txtLidNaam.Location = new System.Drawing.Point(75, 6);
            this.txtLidNaam.Name = "txtLidNaam";
            this.txtLidNaam.ReadOnly = true;
            this.txtLidNaam.Size = new System.Drawing.Size(215, 20);
            this.txtLidNaam.TabIndex = 3;
            // 
            // lblLidNaam
            // 
            this.lblLidNaam.AutoSize = true;
            this.lblLidNaam.Location = new System.Drawing.Point(34, 9);
            this.lblLidNaam.Name = "lblLidNaam";
            this.lblLidNaam.Size = new System.Drawing.Size(35, 13);
            this.lblLidNaam.TabIndex = 2;
            this.lblLidNaam.Text = "Naam";
            // 
            // lblLeden
            // 
            this.lblLeden.AutoSize = true;
            this.lblLeden.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLeden.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeden.Location = new System.Drawing.Point(30, 0);
            this.lblLeden.Name = "lblLeden";
            this.lblLeden.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblLeden.Size = new System.Drawing.Size(94, 51);
            this.lblLeden.TabIndex = 0;
            this.lblLeden.Text = "Leden";
            // 
            // pnlTeams
            // 
            this.pnlTeams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTeams.Controls.Add(this.pnlTeamsList);
            this.pnlTeams.Controls.Add(this.pnlTeamsControls);
            this.pnlTeams.Controls.Add(this.lblTeams);
            this.pnlTeams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTeams.Location = new System.Drawing.Point(459, 3);
            this.pnlTeams.Name = "pnlTeams";
            this.pnlTeams.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.pnlTeams.Size = new System.Drawing.Size(450, 605);
            this.pnlTeams.TabIndex = 1;
            // 
            // pnlTeamsList
            // 
            this.pnlTeamsList.Controls.Add(this.lboxTeams);
            this.pnlTeamsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTeamsList.Location = new System.Drawing.Point(15, 51);
            this.pnlTeamsList.Name = "pnlTeamsList";
            this.pnlTeamsList.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlTeamsList.Size = new System.Drawing.Size(403, 357);
            this.pnlTeamsList.TabIndex = 4;
            // 
            // lboxTeams
            // 
            this.lboxTeams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxTeams.FormattingEnabled = true;
            this.lboxTeams.Location = new System.Drawing.Point(0, 0);
            this.lboxTeams.Name = "lboxTeams";
            this.lboxTeams.Size = new System.Drawing.Size(403, 347);
            this.lboxTeams.TabIndex = 2;
            this.lboxTeams.SelectedValueChanged += new System.EventHandler(this.lboxTeams_SelectedValueChanged);
            // 
            // pnlTeamsControls
            // 
            this.pnlTeamsControls.Controls.Add(this.btnNieuwTeam);
            this.pnlTeamsControls.Controls.Add(this.lblTeamId);
            this.pnlTeamsControls.Controls.Add(this.btnTeamBewerken);
            this.pnlTeamsControls.Controls.Add(this.txtTeamId);
            this.pnlTeamsControls.Controls.Add(this.btnTeamVerwijderen);
            this.pnlTeamsControls.Controls.Add(this.btnTeamLidVerwijderen);
            this.pnlTeamsControls.Controls.Add(this.txtTeamNaam);
            this.pnlTeamsControls.Controls.Add(this.lblTeamNaam);
            this.pnlTeamsControls.Controls.Add(this.pnlTeamLeden);
            this.pnlTeamsControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTeamsControls.Location = new System.Drawing.Point(15, 408);
            this.pnlTeamsControls.Name = "pnlTeamsControls";
            this.pnlTeamsControls.Size = new System.Drawing.Size(403, 195);
            this.pnlTeamsControls.TabIndex = 3;
            // 
            // btnNieuwTeam
            // 
            this.btnNieuwTeam.Location = new System.Drawing.Point(6, 152);
            this.btnNieuwTeam.Name = "btnNieuwTeam";
            this.btnNieuwTeam.Size = new System.Drawing.Size(75, 23);
            this.btnNieuwTeam.TabIndex = 17;
            this.btnNieuwTeam.Text = "Nieuw";
            this.btnNieuwTeam.UseVisualStyleBackColor = true;
            this.btnNieuwTeam.Click += new System.EventHandler(this.btnNieuwTeam_Click);
            // 
            // lblTeamId
            // 
            this.lblTeamId.AutoSize = true;
            this.lblTeamId.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTeamId.Location = new System.Drawing.Point(320, 3);
            this.lblTeamId.Name = "lblTeamId";
            this.lblTeamId.Size = new System.Drawing.Size(18, 13);
            this.lblTeamId.TabIndex = 14;
            this.lblTeamId.Text = "ID";
            // 
            // btnTeamBewerken
            // 
            this.btnTeamBewerken.Location = new System.Drawing.Point(87, 152);
            this.btnTeamBewerken.Name = "btnTeamBewerken";
            this.btnTeamBewerken.Size = new System.Drawing.Size(75, 23);
            this.btnTeamBewerken.TabIndex = 16;
            this.btnTeamBewerken.Text = "Bewerken";
            this.btnTeamBewerken.UseVisualStyleBackColor = true;
            this.btnTeamBewerken.Click += new System.EventHandler(this.btnTeamBewerken_Click);
            // 
            // txtTeamId
            // 
            this.txtTeamId.Location = new System.Drawing.Point(344, 0);
            this.txtTeamId.Name = "txtTeamId";
            this.txtTeamId.ReadOnly = true;
            this.txtTeamId.Size = new System.Drawing.Size(59, 20);
            this.txtTeamId.TabIndex = 14;
            // 
            // btnTeamVerwijderen
            // 
            this.btnTeamVerwijderen.Location = new System.Drawing.Point(168, 152);
            this.btnTeamVerwijderen.Name = "btnTeamVerwijderen";
            this.btnTeamVerwijderen.Size = new System.Drawing.Size(75, 23);
            this.btnTeamVerwijderen.TabIndex = 15;
            this.btnTeamVerwijderen.Text = "Verwijderen";
            this.btnTeamVerwijderen.UseVisualStyleBackColor = true;
            this.btnTeamVerwijderen.Click += new System.EventHandler(this.btnTeamVerwijderen_Click);
            // 
            // btnTeamLidVerwijderen
            // 
            this.btnTeamLidVerwijderen.Location = new System.Drawing.Point(270, 152);
            this.btnTeamLidVerwijderen.Name = "btnTeamLidVerwijderen";
            this.btnTeamLidVerwijderen.Size = new System.Drawing.Size(133, 23);
            this.btnTeamLidVerwijderen.TabIndex = 14;
            this.btnTeamLidVerwijderen.Text = "Teamlid verwijderen";
            this.btnTeamLidVerwijderen.UseVisualStyleBackColor = true;
            // 
            // txtTeamNaam
            // 
            this.txtTeamNaam.Location = new System.Drawing.Point(63, 0);
            this.txtTeamNaam.Name = "txtTeamNaam";
            this.txtTeamNaam.ReadOnly = true;
            this.txtTeamNaam.Size = new System.Drawing.Size(251, 20);
            this.txtTeamNaam.TabIndex = 14;
            // 
            // lblTeamNaam
            // 
            this.lblTeamNaam.AutoSize = true;
            this.lblTeamNaam.Location = new System.Drawing.Point(22, 3);
            this.lblTeamNaam.Name = "lblTeamNaam";
            this.lblTeamNaam.Size = new System.Drawing.Size(35, 13);
            this.lblTeamNaam.TabIndex = 2;
            this.lblTeamNaam.Text = "Naam";
            // 
            // pnlTeamLeden
            // 
            this.pnlTeamLeden.Controls.Add(this.lboxTeamLeden);
            this.pnlTeamLeden.Controls.Add(this.lblTeamLeden);
            this.pnlTeamLeden.Location = new System.Drawing.Point(3, 26);
            this.pnlTeamLeden.Name = "pnlTeamLeden";
            this.pnlTeamLeden.Size = new System.Drawing.Size(400, 117);
            this.pnlTeamLeden.TabIndex = 0;
            // 
            // lboxTeamLeden
            // 
            this.lboxTeamLeden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxTeamLeden.FormattingEnabled = true;
            this.lboxTeamLeden.Location = new System.Drawing.Point(60, 0);
            this.lboxTeamLeden.Name = "lboxTeamLeden";
            this.lboxTeamLeden.Size = new System.Drawing.Size(340, 117);
            this.lboxTeamLeden.TabIndex = 1;
            // 
            // lblTeamLeden
            // 
            this.lblTeamLeden.AutoSize = true;
            this.lblTeamLeden.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTeamLeden.Location = new System.Drawing.Point(0, 0);
            this.lblTeamLeden.Name = "lblTeamLeden";
            this.lblTeamLeden.Size = new System.Drawing.Size(60, 13);
            this.lblTeamLeden.TabIndex = 0;
            this.lblTeamLeden.Text = "Teamleden";
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeams.Location = new System.Drawing.Point(15, 0);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblTeams.Size = new System.Drawing.Size(102, 51);
            this.lblTeams.TabIndex = 1;
            this.lblTeams.Text = "Teams";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicatieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicatieToolStripMenuItem
            // 
            this.applicatieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.afsluitenToolStripMenuItem});
            this.applicatieToolStripMenuItem.Name = "applicatieToolStripMenuItem";
            this.applicatieToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.applicatieToolStripMenuItem.Text = "Applicatie";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            // 
            // FrmQuizClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 635);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmQuizClub";
            this.Text = "QuizClub Beheer";
            this.tblMain.ResumeLayout(false);
            this.pnlLeden.ResumeLayout(false);
            this.pnlLeden.PerformLayout();
            this.pnlLedenList.ResumeLayout(false);
            this.pnlLedenControls.ResumeLayout(false);
            this.pnlLedenControls.PerformLayout();
            this.pnlTeams.ResumeLayout(false);
            this.pnlTeams.PerformLayout();
            this.pnlTeamsList.ResumeLayout(false);
            this.pnlTeamsControls.ResumeLayout(false);
            this.pnlTeamsControls.PerformLayout();
            this.pnlTeamLeden.ResumeLayout(false);
            this.pnlTeamLeden.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Panel pnlLeden;
        private System.Windows.Forms.ListBox lboxLeden;
        private System.Windows.Forms.Label lblLeden;
        private System.Windows.Forms.Panel pnlTeams;
        private System.Windows.Forms.ListBox lboxTeams;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.Panel pnlLedenControls;
        private System.Windows.Forms.Panel pnlTeamsControls;
        private System.Windows.Forms.Panel pnlTeamLeden;
        private System.Windows.Forms.ListBox lboxTeamLeden;
        private System.Windows.Forms.Label lblTeamLeden;
        private System.Windows.Forms.Panel pnlLedenList;
        private System.Windows.Forms.Panel pnlTeamsList;
        private System.Windows.Forms.TextBox txtLidNummer;
        private System.Windows.Forms.Label lblLidNummer;
        private System.Windows.Forms.TextBox txtLidNaam;
        private System.Windows.Forms.Label lblLidNaam;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Label lblLeeftijd;
        private System.Windows.Forms.TextBox txtLidLeeftijd;
        private System.Windows.Forms.Label lblSpecialisatie;
        private System.Windows.Forms.TextBox txtLidSpecialisatie;
        private System.Windows.Forms.Button btnNieuwLid;
        private System.Windows.Forms.Button btnLidBewerken;
        private System.Windows.Forms.Button btnLidVerwijderen;
        private System.Windows.Forms.Button btnNieuwTeam;
        private System.Windows.Forms.Label lblTeamId;
        private System.Windows.Forms.Button btnTeamBewerken;
        private System.Windows.Forms.TextBox txtTeamId;
        private System.Windows.Forms.Button btnTeamVerwijderen;
        private System.Windows.Forms.Button btnTeamLidVerwijderen;
        private System.Windows.Forms.TextBox txtTeamNaam;
        private System.Windows.Forms.Label lblTeamNaam;
    }
}

