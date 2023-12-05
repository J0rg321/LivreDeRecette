namespace LivreDeRecette
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblEazy = new System.Windows.Forms.Label();
            this.picLemonRight = new System.Windows.Forms.PictureBox();
            this.picLemonLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLemonRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLemonLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.CadetBlue;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnNext.Font = new System.Drawing.Font("Bahnschrift Condensed", 50F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.Location = new System.Drawing.Point(1123, 843);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(211, 94);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Suivant";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.UseWaitCursor = true;
            this.btnNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExit.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1740, 964);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 54);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.UseWaitCursor = true;
            this.btnExit.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Bahnschrift Condensed", 120F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(263, 197);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(911, 192);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Bienvenue dans";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.UseWaitCursor = true;
            this.lblWelcome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblEazy
            // 
            this.lblEazy.AutoSize = true;
            this.lblEazy.Font = new System.Drawing.Font("Bahnschrift Condensed", 95F, System.Drawing.FontStyle.Underline);
            this.lblEazy.ForeColor = System.Drawing.Color.White;
            this.lblEazy.Location = new System.Drawing.Point(617, 644);
            this.lblEazy.Name = "lblEazy";
            this.lblEazy.Size = new System.Drawing.Size(1204, 152);
            this.lblEazy.TabIndex = 6;
            this.lblEazy.Text = "Easy Peazy Lemon Squeezy";
            this.lblEazy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEazy.UseWaitCursor = true;
            // 
            // picLemonRight
            // 
            this.picLemonRight.Image = ((System.Drawing.Image)(resources.GetObject("picLemonRight.Image")));
            this.picLemonRight.Location = new System.Drawing.Point(1352, 41);
            this.picLemonRight.Name = "picLemonRight";
            this.picLemonRight.Size = new System.Drawing.Size(501, 500);
            this.picLemonRight.TabIndex = 8;
            this.picLemonRight.TabStop = false;
            this.picLemonRight.UseWaitCursor = true;
            // 
            // picLemonLeft
            // 
            this.picLemonLeft.Image = ((System.Drawing.Image)(resources.GetObject("picLemonLeft.Image")));
            this.picLemonLeft.Location = new System.Drawing.Point(46, 518);
            this.picLemonLeft.Name = "picLemonLeft";
            this.picLemonLeft.Size = new System.Drawing.Size(501, 500);
            this.picLemonLeft.TabIndex = 7;
            this.picLemonLeft.TabStop = false;
            this.picLemonLeft.UseWaitCursor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1911, 1057);
            this.Controls.Add(this.picLemonRight);
            this.Controls.Add(this.picLemonLeft);
            this.Controls.Add(this.lblEazy);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLemonRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLemonLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblEazy;
        private System.Windows.Forms.PictureBox picLemonLeft;
        private System.Windows.Forms.PictureBox picLemonRight;
    }
}

