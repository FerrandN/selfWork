namespace MonsieurJournée
{
    partial class Form1
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
            this.UserAnswerBox = new System.Windows.Forms.TextBox();
            this.DisplayBox = new System.Windows.Forms.TextBox();
            this.ValidButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserAnswerBox
            // 
            this.UserAnswerBox.Location = new System.Drawing.Point(12, 402);
            this.UserAnswerBox.Multiline = true;
            this.UserAnswerBox.Name = "UserAnswerBox";
            this.UserAnswerBox.Size = new System.Drawing.Size(776, 36);
            this.UserAnswerBox.TabIndex = 0;
            this.UserAnswerBox.TextChanged += new System.EventHandler(this.UserAnswerBox_TextChanged);
            // 
            // DisplayBox
            // 
            this.DisplayBox.Location = new System.Drawing.Point(12, 12);
            this.DisplayBox.Multiline = true;
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(776, 97);
            this.DisplayBox.TabIndex = 1;
            this.DisplayBox.TextChanged += new System.EventHandler(this.DisplayBox_TextChanged);
            // 
            // ValidButton
            // 
            this.ValidButton.Location = new System.Drawing.Point(12, 373);
            this.ValidButton.Name = "ValidButton";
            this.ValidButton.Size = new System.Drawing.Size(75, 23);
            this.ValidButton.TabIndex = 2;
            this.ValidButton.Text = "Valid";
            this.ValidButton.UseVisualStyleBackColor = true;
            this.ValidButton.Click += new System.EventHandler(this.ValidButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ValidButton);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.UserAnswerBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserAnswerBox;
        private System.Windows.Forms.TextBox DisplayBox;
        private System.Windows.Forms.Button ValidButton;
    }
}

