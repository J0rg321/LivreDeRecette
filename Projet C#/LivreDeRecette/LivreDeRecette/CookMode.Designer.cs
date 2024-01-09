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
            this.lblQuantIng = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRignt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCookingMode
            // 
            this.lblCookingMode.AutoSize = true;
            this.lblCookingMode.Font = new System.Drawing.Font("Bahnschrift Condensed", 80F);
            this.lblCookingMode.Location = new System.Drawing.Point(758, 18);
            this.lblCookingMode.Name = "lblCookingMode";
            this.lblCookingMode.Size = new System.Drawing.Size(518, 128);
            this.lblCookingMode.TabIndex = 0;
            this.lblCookingMode.Text = "Mode Cuisine";
            // 
            // lblQuantIng
            // 
            this.lblQuantIng.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.lblQuantIng.Location = new System.Drawing.Point(21, 146);
            this.lblQuantIng.Name = "lblQuantIng";
            this.lblQuantIng.Size = new System.Drawing.Size(516, 526);
            this.lblQuantIng.TabIndex = 1;
            this.lblQuantIng.Text = "quant";
            this.lblQuantIng.Click += new System.EventHandler(this.lblQuantIng_Click);
            // 
            // lblSteps
            // 
            this.lblSteps.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.lblSteps.Location = new System.Drawing.Point(561, 146);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(1184, 610);
            this.lblSteps.TabIndex = 2;
            this.lblSteps.Text = "Steps";
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(559, 864);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(337, 53);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.TabStop = false;
            this.btnLeft.Text = "Etape précédente";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRignt
            // 
            this.btnRignt.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRignt.Location = new System.Drawing.Point(1023, 864);
            this.btnRignt.Name = "btnRignt";
            this.btnRignt.Size = new System.Drawing.Size(337, 53);
            this.btnRignt.TabIndex = 8;
            this.btnRignt.TabStop = false;
            this.btnRignt.Text = "Prochaine étape";
            this.btnRignt.UseVisualStyleBackColor = true;
            this.btnRignt.Click += new System.EventHandler(this.btnRignt_Click);
            // 
            // frmCookMode
            // 
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1914, 1041);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRignt);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.lblQuantIng);
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
        private System.Windows.Forms.Label lblQuantIng;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRignt;
    }
}