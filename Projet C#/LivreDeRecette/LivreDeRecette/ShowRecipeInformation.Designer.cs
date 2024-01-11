namespace LivreDeRecette
{
    partial class frmShowRecipeInformation
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
            this.lstPerson = new System.Windows.Forms.ListBox();
            this.txtIngredients = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCookMode = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstPerson
            // 
            this.lstPerson.BackColor = System.Drawing.Color.CadetBlue;
            this.lstPerson.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPerson.ForeColor = System.Drawing.SystemColors.Menu;
            this.lstPerson.FormattingEnabled = true;
            this.lstPerson.ItemHeight = 25;
            this.lstPerson.Items.AddRange(new object[] {
            ""});
            this.lstPerson.Location = new System.Drawing.Point(314, 185);
            this.lstPerson.Name = "lstPerson";
            this.lstPerson.Size = new System.Drawing.Size(42, 29);
            this.lstPerson.TabIndex = 0;
            this.lstPerson.TabStop = false;
            this.lstPerson.UseTabStops = false;
            this.lstPerson.SelectedIndexChanged += new System.EventHandler(this.lstPerson_SelectedIndexChanged);
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
            this.txtIngredients.TabIndex = 2;
            this.txtIngredients.TabStop = false;
            this.txtIngredients.TextChanged += new System.EventHandler(this.txtIngredients_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(75, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de personnes :";
            // 
            // btnCookMode
            // 
            this.btnCookMode.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCookMode.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCookMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCookMode.Location = new System.Drawing.Point(1094, 856);
            this.btnCookMode.Name = "btnCookMode";
            this.btnCookMode.Size = new System.Drawing.Size(306, 61);
            this.btnCookMode.TabIndex = 7;
            this.btnCookMode.Text = "🍽 Mode Cuisine";
            this.btnCookMode.UseVisualStyleBackColor = false;
            this.btnCookMode.Click += new System.EventHandler(this.btnCookMode_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 975);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(252, 54);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Revenir en arrière";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSteps
            // 
            this.txtSteps.BackColor = System.Drawing.Color.CadetBlue;
            this.txtSteps.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.txtSteps.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtSteps.Location = new System.Drawing.Point(524, 272);
            this.txtSteps.Multiline = true;
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.ReadOnly = true;
            this.txtSteps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSteps.Size = new System.Drawing.Size(1184, 480);
            this.txtSteps.TabIndex = 14;
            this.txtSteps.TextChanged += new System.EventHandler(this.txtSteps_TextChanged);
            // 
            // frmShowRecipeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1914, 1041);
            this.Controls.Add(this.txtSteps);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCookMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIngredients);
            this.Controls.Add(this.lstPerson);
            this.Name = "frmShowRecipeInformation";
            this.Load += new System.EventHandler(this.frmShowRecipeInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPerson;
        private System.Windows.Forms.TextBox txtIngredients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCookMode;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSteps;
    }
}