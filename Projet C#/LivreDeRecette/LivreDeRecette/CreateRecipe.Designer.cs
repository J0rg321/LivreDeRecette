namespace LivreDeRecette
{
    partial class frmCreateDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateDesign));
            this.lblCreate = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.chklstType = new System.Windows.Forms.CheckedListBox();
            this.chklstLevel = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picLemonLeft = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLemonLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Bahnschrift Condensed", 100F);
            this.lblCreate.ForeColor = System.Drawing.Color.White;
            this.lblCreate.Location = new System.Drawing.Point(511, 40);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(967, 161);
            this.lblCreate.TabIndex = 0;
            this.lblCreate.Text = "Création de recettes";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.exitBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(1755, 950);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(113, 54);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Quitter";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.UseWaitCursor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bahnschrift Condensed", 70F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(143, 317);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(556, 112);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Nom de recette :";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 70F);
            this.lblTime.ForeColor = System.Drawing.Color.Transparent;
            this.lblTime.Location = new System.Drawing.Point(143, 419);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(755, 112);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Temps de préparation :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Bahnschrift Condensed", 70F);
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(143, 537);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(558, 112);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Type de recette :";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Bahnschrift Condensed", 70F);
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(143, 656);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(685, 112);
            this.lblLevel.TabIndex = 10;
            this.lblLevel.Text = "Niveau de difficulté :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.CadetBlue;
            this.txtName.Font = new System.Drawing.Font("Bahnschrift Condensed", 35F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(705, 352);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(337, 64);
            this.txtName.TabIndex = 11;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.CadetBlue;
            this.txtTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 35F);
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(893, 451);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(210, 64);
            this.txtTime.TabIndex = 12;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Bahnschrift Condensed", 28F);
            this.lblMinutes.ForeColor = System.Drawing.Color.Transparent;
            this.lblMinutes.Location = new System.Drawing.Point(1109, 469);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(122, 46);
            this.lblMinutes.TabIndex = 13;
            this.lblMinutes.Text = "minutes";
            this.lblMinutes.Click += new System.EventHandler(this.lblMinutes_Click);
            // 
            // chklstType
            // 
            this.chklstType.BackColor = System.Drawing.Color.CadetBlue;
            this.chklstType.Font = new System.Drawing.Font("Bahnschrift Condensed", 35F);
            this.chklstType.ForeColor = System.Drawing.Color.White;
            this.chklstType.FormattingEnabled = true;
            this.chklstType.Items.AddRange(new object[] {
            "Entrée",
            "Plat principal",
            "Dessert"});
            this.chklstType.Location = new System.Drawing.Point(707, 574);
            this.chklstType.Name = "chklstType";
            this.chklstType.Size = new System.Drawing.Size(271, 63);
            this.chklstType.TabIndex = 14;
            this.chklstType.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // chklstLevel
            // 
            this.chklstLevel.BackColor = System.Drawing.Color.CadetBlue;
            this.chklstLevel.Font = new System.Drawing.Font("Bahnschrift Condensed", 35F);
            this.chklstLevel.ForeColor = System.Drawing.Color.White;
            this.chklstLevel.FormattingEnabled = true;
            this.chklstLevel.Items.AddRange(new object[] {
            "Débutant",
            "Intermédiaire",
            "Expert"});
            this.chklstLevel.Location = new System.Drawing.Point(834, 692);
            this.chklstLevel.Name = "chklstLevel";
            this.chklstLevel.Size = new System.Drawing.Size(269, 63);
            this.chklstLevel.TabIndex = 15;
            this.chklstLevel.SelectedIndexChanged += new System.EventHandler(this.chklstLevel_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(470, 814);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 89);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ajouter la recette";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            // 
            // picLemonLeft
            // 
            this.picLemonLeft.Image = ((System.Drawing.Image)(resources.GetObject("picLemonLeft.Image")));
            this.picLemonLeft.Location = new System.Drawing.Point(1340, 317);
            this.picLemonLeft.Name = "picLemonLeft";
            this.picLemonLeft.Size = new System.Drawing.Size(501, 500);
            this.picLemonLeft.TabIndex = 17;
            this.picLemonLeft.TabStop = false;
            this.picLemonLeft.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(893, 201);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(259, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Eazy Peazy Lemon Squeezy";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 975);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(252, 54);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Revenir en arrière";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmCreateDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1914, 1041);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLemonLeft);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chklstLevel);
            this.Controls.Add(this.chklstType);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.lblCreate);
            this.Name = "frmCreateDesign";
            this.Text = "CreateRecipe";
            this.Load += new System.EventHandler(this.CreateRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLemonLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.CheckedListBox chklstType;
        private System.Windows.Forms.CheckedListBox chklstLevel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picLemonLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}