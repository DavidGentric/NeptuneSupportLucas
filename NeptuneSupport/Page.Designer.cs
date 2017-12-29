namespace NeptuneSupport
{
    partial class Page
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page));
            this.tbRetour = new System.Windows.Forms.TextBox();
            this.hébergementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDutilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caisseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acquisitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installationToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.installationServeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installationClientTSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installationClientLourdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.caisseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.téléchargementFichiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelUser = new System.Windows.Forms.Label();
            this.progressBarPrincipale = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRetour
            // 
            this.tbRetour.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbRetour.Location = new System.Drawing.Point(13, 27);
            this.tbRetour.Multiline = true;
            this.tbRetour.Name = "tbRetour";
            this.tbRetour.ReadOnly = true;
            this.tbRetour.Size = new System.Drawing.Size(476, 246);
            this.tbRetour.TabIndex = 1;
            // 
            // hébergementToolStripMenuItem
            // 
            this.hébergementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDutilisateurToolStripMenuItem,
            this.installationToolStripMenuItem,
            this.miseÀJourToolStripMenuItem,
            this.caisseToolStripMenuItem1});
            this.hébergementToolStripMenuItem.Name = "hébergementToolStripMenuItem";
            this.hébergementToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.hébergementToolStripMenuItem.Text = "Hébergement";
            // 
            // ajoutDutilisateurToolStripMenuItem
            // 
            this.ajoutDutilisateurToolStripMenuItem.Name = "ajoutDutilisateurToolStripMenuItem";
            this.ajoutDutilisateurToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ajoutDutilisateurToolStripMenuItem.Text = "Ajout d\'utilisateur";
            this.ajoutDutilisateurToolStripMenuItem.Click += new System.EventHandler(this.ajoutDutilisateurToolStripMenuItem_Click);
            // 
            // installationToolStripMenuItem
            // 
            this.installationToolStripMenuItem.Name = "installationToolStripMenuItem";
            this.installationToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.installationToolStripMenuItem.Text = "Installation";
            this.installationToolStripMenuItem.Click += new System.EventHandler(this.installationToolStripMenuItem_Click);
            // 
            // miseÀJourToolStripMenuItem
            // 
            this.miseÀJourToolStripMenuItem.Name = "miseÀJourToolStripMenuItem";
            this.miseÀJourToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.miseÀJourToolStripMenuItem.Text = "Mise à jour";
            // 
            // caisseToolStripMenuItem1
            // 
            this.caisseToolStripMenuItem1.Name = "caisseToolStripMenuItem1";
            this.caisseToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.caisseToolStripMenuItem1.Text = "Caisse";
            this.caisseToolStripMenuItem1.Click += new System.EventHandler(this.caisseToolStripMenuItem1_Click);
            // 
            // acquisitionToolStripMenuItem
            // 
            this.acquisitionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installationToolStripMenuItem2,
            this.miseÀJourToolStripMenuItem1,
            this.caisseToolStripMenuItem});
            this.acquisitionToolStripMenuItem.Name = "acquisitionToolStripMenuItem";
            this.acquisitionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.acquisitionToolStripMenuItem.Text = "Acquisition";
            // 
            // installationToolStripMenuItem2
            // 
            this.installationToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installationServeurToolStripMenuItem,
            this.installationClientTSEToolStripMenuItem,
            this.installationClientLourdToolStripMenuItem});
            this.installationToolStripMenuItem2.Name = "installationToolStripMenuItem2";
            this.installationToolStripMenuItem2.Size = new System.Drawing.Size(132, 22);
            this.installationToolStripMenuItem2.Text = "Installation";
            // 
            // installationServeurToolStripMenuItem
            // 
            this.installationServeurToolStripMenuItem.Name = "installationServeurToolStripMenuItem";
            this.installationServeurToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.installationServeurToolStripMenuItem.Text = "Installation serveur";
            this.installationServeurToolStripMenuItem.Click += new System.EventHandler(this.installationServeurToolStripMenuItem_Click);
            // 
            // installationClientTSEToolStripMenuItem
            // 
            this.installationClientTSEToolStripMenuItem.Name = "installationClientTSEToolStripMenuItem";
            this.installationClientTSEToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.installationClientTSEToolStripMenuItem.Text = "Installation client TSE";
            this.installationClientTSEToolStripMenuItem.Click += new System.EventHandler(this.installationClientTSEToolStripMenuItem_Click);
            // 
            // installationClientLourdToolStripMenuItem
            // 
            this.installationClientLourdToolStripMenuItem.Name = "installationClientLourdToolStripMenuItem";
            this.installationClientLourdToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.installationClientLourdToolStripMenuItem.Text = "Installation client lourd";
            this.installationClientLourdToolStripMenuItem.Click += new System.EventHandler(this.installationClientLourdToolStripMenuItem_Click);
            // 
            // miseÀJourToolStripMenuItem1
            // 
            this.miseÀJourToolStripMenuItem1.Name = "miseÀJourToolStripMenuItem1";
            this.miseÀJourToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.miseÀJourToolStripMenuItem1.Text = "Mise à jour";
            // 
            // caisseToolStripMenuItem
            // 
            this.caisseToolStripMenuItem.Name = "caisseToolStripMenuItem";
            this.caisseToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.caisseToolStripMenuItem.Text = "Caisse";
            this.caisseToolStripMenuItem.Click += new System.EventHandler(this.caisseToolStripMenuItem_Click);
            // 
            // téléchargementFichiersToolStripMenuItem
            // 
            this.téléchargementFichiersToolStripMenuItem.Name = "téléchargementFichiersToolStripMenuItem";
            this.téléchargementFichiersToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.téléchargementFichiersToolStripMenuItem.Text = "Téléchargement fichiers";
            this.téléchargementFichiersToolStripMenuItem.Click += new System.EventHandler(this.telechargementFichiersToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hébergementToolStripMenuItem,
            this.acquisitionToolStripMenuItem,
            this.téléchargementFichiersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(410, 11);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(52, 13);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "Nom user";
            // 
            // progressBarPrincipale
            // 
            this.progressBarPrincipale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBarPrincipale.Location = new System.Drawing.Point(13, 279);
            this.progressBarPrincipale.Name = "progressBarPrincipale";
            this.progressBarPrincipale.Size = new System.Drawing.Size(476, 23);
            this.progressBarPrincipale.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarPrincipale.TabIndex = 3;
            // 
            // Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(501, 314);
            this.Controls.Add(this.progressBarPrincipale);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.tbRetour);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neptune Support";
            this.Load += new System.EventHandler(this.Page_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbRetour;
        private System.Windows.Forms.ToolStripMenuItem hébergementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDutilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acquisitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installationToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem installationServeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installationClientTSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installationClientLourdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem téléchargementFichiersToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem caisseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caisseToolStripMenuItem1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ProgressBar progressBarPrincipale;
    }
}

