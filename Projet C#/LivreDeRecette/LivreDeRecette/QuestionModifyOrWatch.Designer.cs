namespace LivreDeRecette
{
    partial class QuestionModifyOrWatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionModifyOrWatch));
            this.boutonChercher = new System.Windows.Forms.Button();
            this.boutonCreer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boutonChercher
            // 
            this.boutonChercher.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonChercher.Location = new System.Drawing.Point(172, 170);
            this.boutonChercher.Name = "boutonChercher";
            this.boutonChercher.Size = new System.Drawing.Size(291, 43);
            this.boutonChercher.TabIndex = 0;
            this.boutonChercher.Text = "Chercher une recette";
            this.boutonChercher.UseVisualStyleBackColor = true;
            this.boutonChercher.Click += new System.EventHandler(this.button1_Click);
            // 
            // boutonCreer
            // 
            this.boutonCreer.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonCreer.Location = new System.Drawing.Point(208, 251);
            this.boutonCreer.Name = "boutonCreer";
            this.boutonCreer.Size = new System.Drawing.Size(217, 45);
            this.boutonCreer.TabIndex = 1;
            this.boutonCreer.Text = "Créer une recette";
            this.boutonCreer.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(55, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(526, 49);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Que souhaitez-vous faire aujourd\'hui ?";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // QuestionModifyOrWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(630, 388);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.boutonCreer);
            this.Controls.Add(this.boutonChercher);
            this.Name = "QuestionModifyOrWatch";
            this.Text = "QuestionModifyOrWatch";
            this.Load += new System.EventHandler(this.QuestionModifyOrWatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonChercher;
        private System.Windows.Forms.Button boutonCreer;
        private System.Windows.Forms.TextBox textBox1;
    }
}