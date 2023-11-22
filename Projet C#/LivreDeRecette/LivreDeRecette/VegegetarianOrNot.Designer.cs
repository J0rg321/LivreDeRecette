namespace LivreDeRecette
{
    partial class VegegetarianOrNot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VegegetarianOrNot));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.boutonCreer = new System.Windows.Forms.Button();
            this.boutonChercher = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 29F, System.Drawing.FontStyle.Italic);
            this.textBox1.Location = new System.Drawing.Point(610, 341);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(703, 51);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Souhaitez-vous des recettes végetariennes ou non ?";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // boutonCreer
            // 
            this.boutonCreer.Font = new System.Drawing.Font("Monotype Corsiva", 26.75F, System.Drawing.FontStyle.Italic);
            this.boutonCreer.Location = new System.Drawing.Point(973, 429);
            this.boutonCreer.Name = "boutonCreer";
            this.boutonCreer.Size = new System.Drawing.Size(224, 59);
            this.boutonCreer.TabIndex = 4;
            this.boutonCreer.Text = "Non";
            this.boutonCreer.UseVisualStyleBackColor = true;
            this.boutonCreer.Click += new System.EventHandler(this.boutonCreer_Click);
            // 
            // boutonChercher
            // 
            this.boutonChercher.Font = new System.Drawing.Font("Monotype Corsiva", 26.75F, System.Drawing.FontStyle.Italic);
            this.boutonChercher.Location = new System.Drawing.Point(725, 431);
            this.boutonChercher.Name = "boutonChercher";
            this.boutonChercher.Size = new System.Drawing.Size(224, 57);
            this.boutonChercher.TabIndex = 3;
            this.boutonChercher.Text = "Oui";
            this.boutonChercher.UseVisualStyleBackColor = true;
            this.boutonChercher.Click += new System.EventHandler(this.boutonChercher_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Khaki;
            this.exitBtn.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(1687, 936);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(201, 75);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Quitter";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // VegegetarianOrNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1914, 1041);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.boutonCreer);
            this.Controls.Add(this.boutonChercher);
            this.Name = "VegegetarianOrNot";
            this.Text = "VegegetatianOrNot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button boutonCreer;
        private System.Windows.Forms.Button boutonChercher;
        private System.Windows.Forms.Button exitBtn;
    }
}