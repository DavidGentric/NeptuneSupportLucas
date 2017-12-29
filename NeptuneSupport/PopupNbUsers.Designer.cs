namespace NeptuneSupport
{
    partial class PopupNbUsers
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
            this.numUD_nbUsers = new System.Windows.Forms.NumericUpDown();
            this.btnValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_nbUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Combien d\'utilisateurs voulez-vous créer ?";
            // 
            // numUD_nbUsers
            // 
            this.numUD_nbUsers.Location = new System.Drawing.Point(70, 25);
            this.numUD_nbUsers.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUD_nbUsers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_nbUsers.Name = "numUD_nbUsers";
            this.numUD_nbUsers.Size = new System.Drawing.Size(75, 20);
            this.numUD_nbUsers.TabIndex = 1;
            this.numUD_nbUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUD_nbUsers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(70, 51);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // PopupNbUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 76);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.numUD_nbUsers);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopupNbUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopupNbUsers";
            this.Load += new System.EventHandler(this.PopupNbUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUD_nbUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUD_nbUsers;
        private System.Windows.Forms.Button btnValider;
    }
}