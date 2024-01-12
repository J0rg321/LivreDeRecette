namespace LivreDeRecette
{
    partial class frmCookMode
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
            this.lblCookingMode = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRignt = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtIngredients = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCookingMode
            // 
            this.lblCookingMode.AutoSize = true;
            this.lblCookingMode.BackColor = System.Drawing.Color.DarkCyan;
            this.lblCookingMode.Font = new System.Drawing.Font("Bahnschrift Condensed", 80F);
            this.lblCookingMode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCookingMode.Location = new System.Drawing.Point(758, 18);
            this.lblCookingMode.Name = "lblCookingMode";
            this.lblCookingMode.Size = new System.Drawing.Size(518, 128);
            this.lblCookingMode.TabIndex = 0;
            this.lblCookingMode.Text = "Mode Cuisine";
            // 
            // lblSteps
            // 
            this.lblSteps.BackColor = System.Drawing.Color.CadetBlue;
            this.lblSteps.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.lblSteps.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSteps.Location = new System.Drawing.Point(548, 375);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(1184, 225);
            this.lblSteps.TabIndex = 2;
            this.lblSteps.Text = "Steps";
            this.lblSteps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLeft.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLeft.Location = new System.Drawing.Point(729, 753);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(337, 53);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.TabStop = false;
            this.btnLeft.Text = "Etape précédente";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRignt
            // 
            this.btnRignt.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRignt.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRignt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRignt.Location = new System.Drawing.Point(1227, 753);
            this.btnRignt.Name = "btnRignt";
            this.btnRignt.Size = new System.Drawing.Size(337, 53);
            this.btnRignt.TabIndex = 8;
            this.btnRignt.TabStop = false;
            this.btnRignt.Text = "Prochaine étape";
            this.btnRignt.UseVisualStyleBackColor = false;
            this.btnRignt.Click += new System.EventHandler(this.btnRignt_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 1017);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(310, 54);
            this.btnBack.TabIndex = 13;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Retourner aux recettes";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtIngredients
            // 
            this.txtIngredients.BackColor = System.Drawing.Color.CadetBlue;
            this.txtIngredients.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredients.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtIngredients.Location = new System.Drawing.Point(75, 225);
            this.txtIngredients.Multiline = true;
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.ReadOnly = true;
            this.txtIngredients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIngredients.Size = new System.Drawing.Size(423, 564);
            this.txtIngredients.TabIndex = 14;
            this.txtIngredients.TabStop = false;
            this.txtIngredients.TextChanged += new System.EventHandler(this.txtIngredients_TextChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.exitBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(1789, 1017);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(113, 54);
            this.exitBtn.TabIndex = 15;
            this.exitBtn.TabStop = false;
            this.exitBtn.Text = "Quitter";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.UseWaitCursor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // frmCookMode
            // 
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1914, 1041);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.txtIngredients);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRignt);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.lblCookingMode);
            this.Name = "frmCookMode";
            this.Load += new System.EventHandler(this.frmCookMode_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmShowRecipeInformation_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCookMode;
        private System.Windows.Forms.Label lblIngQuant;
        private System.Windows.Forms.Label lblCookingMode;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRignt;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtIngredients;
        private System.Windows.Forms.Button exitBtn;
    }
}