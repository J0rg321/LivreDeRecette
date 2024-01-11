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
            this.pnlRecipe = new System.Windows.Forms.Panel();
            this.chklstIngr = new System.Windows.Forms.CheckedListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.chkVeggies = new LivreDeRecette.VeggieCheckBox();
            this.SuspendLayout();
            // 
            // lblVeggies
            // 
            this.lblVeggies.AutoSize = true;
            this.lblVeggies.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeggies.ForeColor = System.Drawing.Color.White;
            this.lblVeggies.Location = new System.Drawing.Point(322, 136);
            this.lblVeggies.Name = "lblVeggies";
            this.lblVeggies.Size = new System.Drawing.Size(446, 77);
            this.lblVeggies.TabIndex = 0;
            this.lblVeggies.Text = "Option végétarien ?";
            this.lblVeggies.Click += new System.EventHandler(this.ShowRecipes_Load);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.exitBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(1789, 975);
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
            this.lblContent.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.ForeColor = System.Drawing.Color.White;
            this.lblContent.Location = new System.Drawing.Point(969, 136);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(234, 77);
            this.lblContent.TabIndex = 6;
            this.lblContent.Text = "Contient :";
            // 
            // pnlRecipe
            // 
            this.pnlRecipe.AutoScroll = true;
            this.pnlRecipe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRecipe.Location = new System.Drawing.Point(138, 282);
            this.pnlRecipe.Margin = new System.Windows.Forms.Padding(20);
            this.pnlRecipe.Name = "pnlRecipe";
            this.pnlRecipe.Size = new System.Drawing.Size(1626, 600);
            this.pnlRecipe.TabIndex = 11;
            this.pnlRecipe.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRecipe_Paint);
            // 
            // chklstIngr
            // 
            this.chklstIngr.BackColor = System.Drawing.Color.CadetBlue;
            this.chklstIngr.Font = new System.Drawing.Font("Bahnschrift Condensed", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklstIngr.ForeColor = System.Drawing.Color.White;
            this.chklstIngr.FormattingEnabled = true;
            this.chklstIngr.Location = new System.Drawing.Point(1235, 136);
            this.chklstIngr.Name = "chklstIngr";
            this.chklstIngr.Size = new System.Drawing.Size(322, 88);
            this.chklstIngr.Sorted = true;
            this.chklstIngr.TabIndex = 13;
            this.chklstIngr.SelectedIndexChanged += new System.EventHandler(this.chklstIngr_SelectedIndexChanged);
            this.chklstIngr.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chklstIngr_MouseUp);
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
            // chkVeggies
            // 
            this.chkVeggies.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkVeggies.BackColor = System.Drawing.Color.Transparent;
            this.chkVeggies.Checked = true;
            this.chkVeggies.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkVeggies.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVeggies.ForeColor = System.Drawing.Color.CadetBlue;
            this.chkVeggies.Location = new System.Drawing.Point(762, 169);
            this.chkVeggies.Name = "chkVeggies";
            this.chkVeggies.Size = new System.Drawing.Size(29, 31);
            this.chkVeggies.TabIndex = 9;
            this.chkVeggies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkVeggies.UseVisualStyleBackColor = false;
            this.chkVeggies.CheckedChanged += new System.EventHandler(this.chkVeggies_CheckedChanged);
            // 
            // frmShowRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1914, 1041);
            this.Controls.Add(this.chklstIngr);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlRecipe);
            this.Controls.Add(this.chkVeggies);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblVeggies);
            this.Controls.Add(this.exitBtn);
            this.Name = "frmShowRecipes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ShowRecipes";
            this.Load += new System.EventHandler(this.ShowRecipes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVeggies;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label lblContent;
        private VeggieCheckBox chkVeggies;
        private System.Windows.Forms.Panel pnlRecipe;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckedListBox chklstIngr;
    }
}