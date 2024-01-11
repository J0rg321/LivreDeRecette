namespace LivreDeRecette
{
    partial class frmQuestions
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWish = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSearch.Font = new System.Drawing.Font("Bahnschrift Condensed", 45F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(775, 524);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(461, 91);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Chercher une recette";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCreate.Font = new System.Drawing.Font("Bahnschrift Condensed", 45F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(775, 647);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(461, 91);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Créer une recette";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.boutonCreer_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExit.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(949, 762);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 54);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lblWish
            // 
            this.lblWish.AutoSize = true;
            this.lblWish.Font = new System.Drawing.Font("Bahnschrift Condensed", 80F);
            this.lblWish.ForeColor = System.Drawing.Color.White;
            this.lblWish.Location = new System.Drawing.Point(512, 224);
            this.lblWish.Name = "lblWish";
            this.lblWish.Size = new System.Drawing.Size(938, 128);
            this.lblWish.TabIndex = 9;
            this.lblWish.Text = "Que souhaitez-vous faire";
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Bahnschrift Condensed", 80F);
            this.lblToday.ForeColor = System.Drawing.Color.White;
            this.lblToday.Location = new System.Drawing.Point(737, 352);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(508, 128);
            this.lblToday.TabIndex = 10;
            this.lblToday.Text = "aujourd\'hui ?";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 975);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(252, 54);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Revenir en arrière";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1914, 1041);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.lblWish);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSearch);
            this.Name = "frmQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions";
            this.Load += new System.EventHandler(this.QuestionModifyOrWatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWish;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Button btnBack;
    }
}