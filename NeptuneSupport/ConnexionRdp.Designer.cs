namespace NeptuneSupport
{
    partial class ConnexionRdp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnexionRdp));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbServeur = new System.Windows.Forms.TextBox();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.rdp = new AxMSTSCLib.AxMsTscAxNotSafeForScripting();
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 623);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mot de passe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 623);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nom d\'utilisateur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 623);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Serveur :";
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(555, 619);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.PasswordChar = '•';
            this.tbMdp.Size = new System.Drawing.Size(131, 20);
            this.tbMdp.TabIndex = 3;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(326, 619);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(140, 20);
            this.tbUser.TabIndex = 2;
            // 
            // tbServeur
            // 
            this.tbServeur.Location = new System.Drawing.Point(84, 620);
            this.tbServeur.Name = "tbServeur";
            this.tbServeur.Size = new System.Drawing.Size(140, 20);
            this.tbServeur.TabIndex = 1;
            this.tbServeur.Text = "localhost";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(818, 616);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(106, 23);
            this.btnDeconnexion.TabIndex = 5;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(703, 617);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(106, 23);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // rdp
            // 
            this.rdp.Enabled = true;
            this.rdp.Location = new System.Drawing.Point(12, 12);
            this.rdp.Name = "rdp";
            this.rdp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rdp.OcxState")));
            this.rdp.Size = new System.Drawing.Size(912, 600);
            this.rdp.TabIndex = 9;
            this.rdp.UseWaitCursor = true;
            // 
            // ConnexionRdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 651);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbServeur);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.rdp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ConnexionRdp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connexion RDP";
            this.Load += new System.EventHandler(this.ConnexionRdp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbServeur;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnConnexion;
        private AxMSTSCLib.AxMsTscAxNotSafeForScripting rdp;
    }
}