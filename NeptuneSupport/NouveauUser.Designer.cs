namespace NeptuneSupport
{
    partial class NouveauUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUserPw = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.cbTriton = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbOU = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.gbInfos = new System.Windows.Forms.GroupBox();
            this.btnGenerer = new System.Windows.Forms.Button();
            this.checkClients = new System.Windows.Forms.CheckBox();
            this.checkNEPTUNE = new System.Windows.Forms.CheckBox();
            this.checkPF = new System.Windows.Forms.CheckBox();
            this.checkUtilRDP = new System.Windows.Forms.CheckBox();
            this.checkUtilDomaine = new System.Windows.Forms.CheckBox();
            this.gbInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UTILISATEUR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Login session :";
            // 
            // lblUserPw
            // 
            this.lblUserPw.AutoSize = true;
            this.lblUserPw.Location = new System.Drawing.Point(26, 146);
            this.lblUserPw.Name = "lblUserPw";
            this.lblUserPw.Size = new System.Drawing.Size(77, 13);
            this.lblUserPw.TabIndex = 5;
            this.lblUserPw.Text = "Mot de passe :";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(109, 65);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(206, 20);
            this.tbPrenom.TabIndex = 3;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(109, 91);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(206, 20);
            this.tbNom.TabIndex = 4;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(109, 117);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(206, 20);
            this.tbLogin.TabIndex = 5;
            // 
            // tbMdp
            // 
            this.tbMdp.Cursor = System.Windows.Forms.Cursors.No;
            this.tbMdp.Location = new System.Drawing.Point(109, 143);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.ReadOnly = true;
            this.tbMdp.Size = new System.Drawing.Size(125, 20);
            this.tbMdp.TabIndex = 9;
            this.tbMdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbTriton
            // 
            this.cbTriton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTriton.FormattingEnabled = true;
            this.cbTriton.Location = new System.Drawing.Point(121, 40);
            this.cbTriton.Name = "cbTriton";
            this.cbTriton.Size = new System.Drawing.Size(206, 21);
            this.cbTriton.TabIndex = 1;
            this.cbTriton.SelectedIndexChanged += new System.EventHandler(this.cbTriton_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "OU principale :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sous-OU :";
            // 
            // cbOU
            // 
            this.cbOU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOU.FormattingEnabled = true;
            this.cbOU.Location = new System.Drawing.Point(109, 38);
            this.cbOU.Name = "cbOU";
            this.cbOU.Size = new System.Drawing.Size(206, 21);
            this.cbOU.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Groupe AD :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(134, 253);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // gbInfos
            // 
            this.gbInfos.Controls.Add(this.checkUtilDomaine);
            this.gbInfos.Controls.Add(this.checkUtilRDP);
            this.gbInfos.Controls.Add(this.checkPF);
            this.gbInfos.Controls.Add(this.checkNEPTUNE);
            this.gbInfos.Controls.Add(this.checkClients);
            this.gbInfos.Controls.Add(this.btnGenerer);
            this.gbInfos.Controls.Add(this.label6);
            this.gbInfos.Controls.Add(this.btnValider);
            this.gbInfos.Controls.Add(this.label2);
            this.gbInfos.Controls.Add(this.label7);
            this.gbInfos.Controls.Add(this.label3);
            this.gbInfos.Controls.Add(this.label4);
            this.gbInfos.Controls.Add(this.cbOU);
            this.gbInfos.Controls.Add(this.lblUserPw);
            this.gbInfos.Controls.Add(this.tbPrenom);
            this.gbInfos.Controls.Add(this.tbNom);
            this.gbInfos.Controls.Add(this.tbLogin);
            this.gbInfos.Controls.Add(this.tbMdp);
            this.gbInfos.Location = new System.Drawing.Point(12, 85);
            this.gbInfos.Name = "gbInfos";
            this.gbInfos.Size = new System.Drawing.Size(351, 282);
            this.gbInfos.TabIndex = 18;
            this.gbInfos.TabStop = false;
            this.gbInfos.Text = "Informations utilisateur :";
            // 
            // btnGenerer
            // 
            this.btnGenerer.Location = new System.Drawing.Point(240, 141);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(75, 23);
            this.btnGenerer.TabIndex = 6;
            this.btnGenerer.Text = "Générer";
            this.btnGenerer.UseVisualStyleBackColor = true;
            this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // checkClients
            // 
            this.checkClients.AutoSize = true;
            this.checkClients.Checked = true;
            this.checkClients.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkClients.Location = new System.Drawing.Point(109, 171);
            this.checkClients.Name = "checkClients";
            this.checkClients.Size = new System.Drawing.Size(56, 17);
            this.checkClients.TabIndex = 17;
            this.checkClients.Text = "clients";
            this.checkClients.UseVisualStyleBackColor = true;
            // 
            // checkNEPTUNE
            // 
            this.checkNEPTUNE.AutoSize = true;
            this.checkNEPTUNE.Checked = true;
            this.checkNEPTUNE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNEPTUNE.Location = new System.Drawing.Point(263, 171);
            this.checkNEPTUNE.Name = "checkNEPTUNE";
            this.checkNEPTUNE.Size = new System.Drawing.Size(78, 17);
            this.checkNEPTUNE.TabIndex = 18;
            this.checkNEPTUNE.Text = "NEPTUNE";
            this.checkNEPTUNE.UseVisualStyleBackColor = true;
            // 
            // checkPF
            // 
            this.checkPF.AutoSize = true;
            this.checkPF.Checked = true;
            this.checkPF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPF.Location = new System.Drawing.Point(263, 193);
            this.checkPF.Name = "checkPF";
            this.checkPF.Size = new System.Drawing.Size(39, 17);
            this.checkPF.TabIndex = 19;
            this.checkPF.Text = "PF";
            this.checkPF.UseVisualStyleBackColor = true;
            // 
            // checkUtilRDP
            // 
            this.checkUtilRDP.AutoSize = true;
            this.checkUtilRDP.Checked = true;
            this.checkUtilRDP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkUtilRDP.Location = new System.Drawing.Point(109, 216);
            this.checkUtilRDP.Name = "checkUtilRDP";
            this.checkUtilRDP.Size = new System.Drawing.Size(181, 17);
            this.checkUtilRDP.TabIndex = 20;
            this.checkUtilRDP.Text = "Utilisateurs du Bureau à distance";
            this.checkUtilRDP.UseVisualStyleBackColor = true;
            // 
            // checkUtilDomaine
            // 
            this.checkUtilDomaine.AutoSize = true;
            this.checkUtilDomaine.Checked = true;
            this.checkUtilDomaine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkUtilDomaine.Location = new System.Drawing.Point(109, 194);
            this.checkUtilDomaine.Name = "checkUtilDomaine";
            this.checkUtilDomaine.Size = new System.Drawing.Size(135, 17);
            this.checkUtilDomaine.TabIndex = 21;
            this.checkUtilDomaine.Text = "Utilisateurs du domaine";
            this.checkUtilDomaine.UseVisualStyleBackColor = true;
            // 
            // NouveauUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(374, 379);
            this.Controls.Add(this.gbInfos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTriton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NouveauUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvel Objet - Utilisateur";
            this.Load += new System.EventHandler(this.NouveauUser_Load);
            this.gbInfos.ResumeLayout(false);
            this.gbInfos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUserPw;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.ComboBox cbTriton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbOU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox gbInfos;
        private System.Windows.Forms.Button btnGenerer;
        private System.Windows.Forms.CheckBox checkUtilDomaine;
        private System.Windows.Forms.CheckBox checkUtilRDP;
        private System.Windows.Forms.CheckBox checkPF;
        private System.Windows.Forms.CheckBox checkNEPTUNE;
        private System.Windows.Forms.CheckBox checkClients;
    }
}