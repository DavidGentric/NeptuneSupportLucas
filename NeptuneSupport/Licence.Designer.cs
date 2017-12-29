namespace NeptuneSupport
{
    partial class Licence
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAlias = new System.Windows.Forms.TextBox();
            this.tbCompta = new System.Windows.Forms.TextBox();
            this.tbInvent = new System.Windows.Forms.TextBox();
            this.tbSerial = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.dtpValidite = new System.Windows.Forms.DateTimePicker();
            this.nudNbLic = new System.Windows.Forms.NumericUpDown();
            this.btnRecharger = new System.Windows.Forms.Button();
            this.btnGenerer = new System.Windows.Forms.Button();
            this.btnEnreg = new System.Windows.Forms.Button();
            this.ckbActiverInvent = new System.Windows.Forms.CheckBox();
            this.ckbActiverCompta = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbLic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alias TRITON :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom / Société :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fin de validité :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Module inventaire :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Clé de sérialisation :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nombre de licence(s) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Module comptabilité :";
            // 
            // tbAlias
            // 
            this.tbAlias.Location = new System.Drawing.Point(122, 22);
            this.tbAlias.Name = "tbAlias";
            this.tbAlias.Size = new System.Drawing.Size(194, 20);
            this.tbAlias.TabIndex = 1;
            this.tbAlias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCompta
            // 
            this.tbCompta.Location = new System.Drawing.Point(122, 330);
            this.tbCompta.Name = "tbCompta";
            this.tbCompta.Size = new System.Drawing.Size(194, 20);
            this.tbCompta.TabIndex = 8;
            this.tbCompta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbInvent
            // 
            this.tbInvent.Location = new System.Drawing.Point(122, 278);
            this.tbInvent.Name = "tbInvent";
            this.tbInvent.Size = new System.Drawing.Size(194, 20);
            this.tbInvent.TabIndex = 6;
            this.tbInvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSerial
            // 
            this.tbSerial.Location = new System.Drawing.Point(122, 226);
            this.tbSerial.Name = "tbSerial";
            this.tbSerial.Size = new System.Drawing.Size(194, 20);
            this.tbSerial.TabIndex = 5;
            this.tbSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(122, 74);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(194, 20);
            this.tbNom.TabIndex = 2;
            this.tbNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpValidite
            // 
            this.dtpValidite.Location = new System.Drawing.Point(122, 122);
            this.dtpValidite.Name = "dtpValidite";
            this.dtpValidite.Size = new System.Drawing.Size(194, 20);
            this.dtpValidite.TabIndex = 3;
            this.dtpValidite.Value = new System.DateTime(2100, 1, 1, 1, 0, 0, 0);
            // 
            // nudNbLic
            // 
            this.nudNbLic.Location = new System.Drawing.Point(122, 174);
            this.nudNbLic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNbLic.Name = "nudNbLic";
            this.nudNbLic.Size = new System.Drawing.Size(194, 20);
            this.nudNbLic.TabIndex = 4;
            this.nudNbLic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNbLic.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRecharger
            // 
            this.btnRecharger.Location = new System.Drawing.Point(353, 40);
            this.btnRecharger.Name = "btnRecharger";
            this.btnRecharger.Size = new System.Drawing.Size(75, 23);
            this.btnRecharger.TabIndex = 10;
            this.btnRecharger.Text = "Recharger";
            this.btnRecharger.UseVisualStyleBackColor = true;
            this.btnRecharger.Click += new System.EventHandler(this.btnRecharger_Click);
            // 
            // btnGenerer
            // 
            this.btnGenerer.Location = new System.Drawing.Point(353, 92);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(75, 23);
            this.btnGenerer.TabIndex = 11;
            this.btnGenerer.Text = "Générer";
            this.btnGenerer.UseVisualStyleBackColor = true;
            this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // btnEnreg
            // 
            this.btnEnreg.Location = new System.Drawing.Point(353, 143);
            this.btnEnreg.Name = "btnEnreg";
            this.btnEnreg.Size = new System.Drawing.Size(75, 23);
            this.btnEnreg.TabIndex = 12;
            this.btnEnreg.Text = "Enregistrer";
            this.btnEnreg.UseVisualStyleBackColor = true;
            this.btnEnreg.Click += new System.EventHandler(this.btnEnreg_Click);
            // 
            // ckbActiverInvent
            // 
            this.ckbActiverInvent.AutoSize = true;
            this.ckbActiverInvent.Location = new System.Drawing.Point(353, 280);
            this.ckbActiverInvent.Name = "ckbActiverInvent";
            this.ckbActiverInvent.Size = new System.Drawing.Size(59, 17);
            this.ckbActiverInvent.TabIndex = 7;
            this.ckbActiverInvent.Text = "Activer";
            this.ckbActiverInvent.UseVisualStyleBackColor = true;
            // 
            // ckbActiverCompta
            // 
            this.ckbActiverCompta.AutoSize = true;
            this.ckbActiverCompta.Location = new System.Drawing.Point(353, 332);
            this.ckbActiverCompta.Name = "ckbActiverCompta";
            this.ckbActiverCompta.Size = new System.Drawing.Size(59, 17);
            this.ckbActiverCompta.TabIndex = 9;
            this.ckbActiverCompta.Text = "Activer";
            this.ckbActiverCompta.UseVisualStyleBackColor = true;
            // 
            // Licence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(440, 373);
            this.Controls.Add(this.ckbActiverCompta);
            this.Controls.Add(this.ckbActiverInvent);
            this.Controls.Add(this.btnEnreg);
            this.Controls.Add(this.btnGenerer);
            this.Controls.Add(this.btnRecharger);
            this.Controls.Add(this.nudNbLic);
            this.Controls.Add(this.dtpValidite);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbSerial);
            this.Controls.Add(this.tbInvent);
            this.Controls.Add(this.tbCompta);
            this.Controls.Add(this.tbAlias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Licence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licence";
            this.Load += new System.EventHandler(this.Licence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNbLic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAlias;
        private System.Windows.Forms.TextBox tbCompta;
        private System.Windows.Forms.TextBox tbInvent;
        private System.Windows.Forms.TextBox tbSerial;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.DateTimePicker dtpValidite;
        private System.Windows.Forms.NumericUpDown nudNbLic;
        private System.Windows.Forms.Button btnRecharger;
        private System.Windows.Forms.Button btnGenerer;
        private System.Windows.Forms.Button btnEnreg;
        private System.Windows.Forms.CheckBox ckbActiverInvent;
        private System.Windows.Forms.CheckBox ckbActiverCompta;
    }
}