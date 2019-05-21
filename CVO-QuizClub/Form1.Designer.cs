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
            this.pnlTeams = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLeden = new System.Windows.Forms.Label();
            this.lblTeams = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.pnlLedenControls = new System.Windows.Forms.Panel();
            this.pnlTeamsControls = new System.Windows.Forms.Panel();
            this.tblMain.SuspendLayout();
            this.pnlLeden.SuspendLayout();
            this.pnlTeams.SuspendLayout();
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
            this.tblMain.Size = new System.Drawing.Size(912, 495);
            this.tblMain.TabIndex = 0;
            // 
            // pnlLeden
            // 
            this.pnlLeden.Controls.Add(this.pnlLedenControls);
            this.pnlLeden.Controls.Add(this.listBox1);
            this.pnlLeden.Controls.Add(this.lblLeden);
            this.pnlLeden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeden.Location = new System.Drawing.Point(3, 3);
            this.pnlLeden.Name = "pnlLeden";
            this.pnlLeden.Padding = new System.Windows.Forms.Padding(30, 0, 15, 0);
            this.pnlLeden.Size = new System.Drawing.Size(450, 489);
            this.pnlLeden.TabIndex = 0;
            // 
            // pnlTeams
            // 
            this.pnlTeams.Controls.Add(this.pnlTeamsControls);
            this.pnlTeams.Controls.Add(this.listBox2);
            this.pnlTeams.Controls.Add(this.lblTeams);
            this.pnlTeams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTeams.Location = new System.Drawing.Point(459, 3);
            this.pnlTeams.Name = "pnlTeams";
            this.pnlTeams.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.pnlTeams.Size = new System.Drawing.Size(450, 489);
            this.pnlTeams.TabIndex = 1;
            // 
            // menuStrip1
            // 
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
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
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
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(405, 438);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(15, 51);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(405, 438);
            this.listBox2.TabIndex = 2;
            // 
            // pnlLedenControls
            // 
            this.pnlLedenControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLedenControls.Location = new System.Drawing.Point(30, 389);
            this.pnlLedenControls.Name = "pnlLedenControls";
            this.pnlLedenControls.Size = new System.Drawing.Size(405, 100);
            this.pnlLedenControls.TabIndex = 2;
            // 
            // pnlTeamsControls
            // 
            this.pnlTeamsControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTeamsControls.Location = new System.Drawing.Point(15, 389);
            this.pnlTeamsControls.Name = "pnlTeamsControls";
            this.pnlTeamsControls.Size = new System.Drawing.Size(405, 100);
            this.pnlTeamsControls.TabIndex = 3;
            // 
            // FrmQuizClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 519);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmQuizClub";
            this.Text = "QuizClub Beheer";
            this.tblMain.ResumeLayout(false);
            this.pnlLeden.ResumeLayout(false);
            this.pnlLeden.PerformLayout();
            this.pnlTeams.ResumeLayout(false);
            this.pnlTeams.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Panel pnlLeden;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblLeden;
        private System.Windows.Forms.Panel pnlTeams;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.Panel pnlLedenControls;
        private System.Windows.Forms.Panel pnlTeamsControls;
    }
}

