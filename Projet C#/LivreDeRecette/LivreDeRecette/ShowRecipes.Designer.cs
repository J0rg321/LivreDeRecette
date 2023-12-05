namespace LivreDeRecette
{
    partial class frmShowRecipes
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
            this.lblVeggies = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.chklstIng = new System.Windows.Forms.CheckedListBox();
            this.chkVeggies = new LivreDeRecette.VeggieCheckBox();
            this.vsbRecipes = new System.Windows.Forms.VScrollBar();
            this.flpRecipes = new System.Windows.Forms.FlowLayoutPanel();
            this.flpRecipes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVeggies
            // 
            this.lblVeggies.AutoSize = true;
            this.lblVeggies.Font = new System.Drawing.Font("Bahnschrift Condensed", 80F);
            this.lblVeggies.ForeColor = System.Drawing.Color.White;
            this.lblVeggies.Location = new System.Drawing.Point(50, 50);
            this.lblVeggies.Name = "lblVeggies";
            this.lblVeggies.Size = new System.Drawing.Size(578, 128);
            this.lblVeggies.TabIndex = 0;
            this.lblVeggies.Text = "Végétarienne ?";
            this.lblVeggies.Click += new System.EventHandler(this.label1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.exitBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(1755, 950);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(113, 54);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Quitter";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.UseWaitCursor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Bahnschrift Condensed", 80F);
            this.lblContent.ForeColor = System.Drawing.Color.White;
            this.lblContent.Location = new System.Drawing.Point(1108, 50);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(389, 128);
            this.lblContent.TabIndex = 6;
            this.lblContent.Text = "Contient :";
            // 
            // chklstIng
            // 
            this.chklstIng.BackColor = System.Drawing.Color.CadetBlue;
            this.chklstIng.Font = new System.Drawing.Font("Bahnschrift Condensed", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklstIng.ForeColor = System.Drawing.Color.White;
            this.chklstIng.FormattingEnabled = true;
            this.chklstIng.Items.AddRange(new object[] {
            "Chocolat",
            "Chocolat",
            "Chocolat",
            "Chocolat",
            "Chocolat",
            "Chocolat",
            "Chocolat",
            "Chocolat",
            "Chocolat",
            "Chocolat",
            "Chocolat",
            "Chocolat"});
            this.chklstIng.Location = new System.Drawing.Point(1503, 106);
            this.chklstIng.Name = "chklstIng";
            this.chklstIng.Size = new System.Drawing.Size(322, 46);
            this.chklstIng.TabIndex = 7;
            this.chklstIng.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // chkVeggies
            // 
            this.chkVeggies.BackColor = System.Drawing.Color.Transparent;
            this.chkVeggies.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVeggies.ForeColor = System.Drawing.Color.White;
            this.chkVeggies.Location = new System.Drawing.Point(643, 101);
            this.chkVeggies.Name = "chkVeggies";
            this.chkVeggies.Size = new System.Drawing.Size(329, 51);
            this.chkVeggies.TabIndex = 9;
            this.chkVeggies.Text = "Veuillez cocher si oui";
            this.chkVeggies.UseVisualStyleBackColor = false;
            this.chkVeggies.CheckedChanged += new System.EventHandler(this.chkVeggies_CheckedChanged);
            // 
            // vsbRecipes
            // 
            this.vsbRecipes.Location = new System.Drawing.Point(0, 0);
            this.vsbRecipes.Name = "vsbRecipes";
            this.vsbRecipes.Size = new System.Drawing.Size(18, 255);
            this.vsbRecipes.TabIndex = 10;
            // 
            // flpRecipes
            // 
            this.flpRecipes.Controls.Add(this.vsbRecipes);
            this.flpRecipes.Location = new System.Drawing.Point(99, 241);
            this.flpRecipes.Name = "flpRecipes";
            this.flpRecipes.Size = new System.Drawing.Size(613, 255);
            this.flpRecipes.TabIndex = 11;
            this.flpRecipes.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // frmShowRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1914, 1041);
            this.Controls.Add(this.flpRecipes);
            this.Controls.Add(this.chkVeggies);
            this.Controls.Add(this.chklstIng);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.lblVeggies);
            this.Name = "frmShowRecipes";
            this.Text = "ShowRecipes";
            this.Load += new System.EventHandler(this.ShowRecipes_Load);
            this.flpRecipes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVeggies;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.CheckedListBox chklstIng;
        private VeggieCheckBox chkVeggies;
        private System.Windows.Forms.VScrollBar vsbRecipes;
        private System.Windows.Forms.FlowLayoutPanel flpRecipes;
    }
}