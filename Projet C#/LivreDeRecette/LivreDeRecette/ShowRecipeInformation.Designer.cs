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
            this.pnlSteps = new System.Windows.Forms.Panel();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRignt = new System.Windows.Forms.Button();
            this.lblSteps = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSteps.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPerson
            // 
            this.lstPerson.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPerson.FormattingEnabled = true;
            this.lstPerson.ItemHeight = 25;
            this.lstPerson.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lstPerson.Location = new System.Drawing.Point(251, 81);
            this.lstPerson.Name = "lstPerson";
            this.lstPerson.Size = new System.Drawing.Size(42, 29);
            this.lstPerson.TabIndex = 0;
            this.lstPerson.TabStop = false;
            this.lstPerson.UseTabStops = false;
            this.lstPerson.SelectedIndexChanged += new System.EventHandler(this.lstPerson_SelectedIndexChanged);
            // 
            // txtIngredients
            // 
            this.txtIngredients.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredients.Location = new System.Drawing.Point(2, 121);
            this.txtIngredients.Multiline = true;
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.ReadOnly = true;
            this.txtIngredients.Size = new System.Drawing.Size(423, 845);
            this.txtIngredients.TabIndex = 2;
            this.txtIngredients.TabStop = false;
            this.txtIngredients.TextChanged += new System.EventHandler(this.txtIngredients_TextChanged);
            // 
            // pnlSteps
            // 
            this.pnlSteps.AutoScroll = true;
            this.pnlSteps.Controls.Add(this.btnLeft);
            this.pnlSteps.Controls.Add(this.btnRignt);
            this.pnlSteps.Controls.Add(this.lblSteps);
            this.pnlSteps.Location = new System.Drawing.Point(431, 121);
            this.pnlSteps.Name = "pnlSteps";
            this.pnlSteps.Size = new System.Drawing.Size(1346, 845);
            this.pnlSteps.TabIndex = 4;
            this.pnlSteps.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSteps_Paint);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(376, 708);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(337, 53);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.TabStop = false;
            this.btnLeft.Text = "Etape précédente";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRignt
            // 
            this.btnRignt.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRignt.Location = new System.Drawing.Point(840, 708);
            this.btnRignt.Name = "btnRignt";
            this.btnRignt.Size = new System.Drawing.Size(337, 53);
            this.btnRignt.TabIndex = 6;
            this.btnRignt.TabStop = false;
            this.btnRignt.Text = "Prochaine étape";
            this.btnRignt.UseVisualStyleBackColor = true;
            this.btnRignt.Click += new System.EventHandler(this.btnRignt_Click);
            // 
            // lblSteps
            // 
            this.lblSteps.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.lblSteps.Location = new System.Drawing.Point(3, 0);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(1340, 672);
            this.lblSteps.TabIndex = 0;
            this.lblSteps.Click += new System.EventHandler(this.lblSteps_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de personnes :";
            // 
            // frmShowRecipeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1914, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlSteps);
            this.Controls.Add(this.txtIngredients);
            this.Controls.Add(this.lstPerson);
            this.Name = "frmShowRecipeInformation";
            this.Text = "ShowRecipeInformation";
            this.Load += new System.EventHandler(this.frmShowRecipeInformation_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmShowRecipeInformation_KeyUp);
            this.pnlSteps.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPerson;
        private System.Windows.Forms.TextBox txtIngredients;
        private System.Windows.Forms.Panel pnlSteps;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Button btnRignt;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label label1;
    }
}