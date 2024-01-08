using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace LivreDeRecette
{
    public partial class frmShowRecipes : Form
    {
        public object FlatAppearance { get; private set; }

        public frmShowRecipes()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                List<String> ingredients = new List<String>();
                ingredients.Add(chklstIng.CheckedItems.ToString());
        }

        private void ShowRecipes_Load(object sender, EventArgs e)
        {
            pnlRecipe.Location = new System.Drawing.Point(
            this.ClientSize.Width / 2 - pnlRecipe.Size.Width / 2, 300);
            FillTheRecipes(Recipe.GetAll());
            
        }

        private void FillTheRecipes(List<Recipe> recipes)
        {

            int i = 0;

            List<Ingredients> ingredients = Ingredients.GetAll();

            foreach (Ingredients ingredient in ingredients)
            {
                chklstIng.Items.Add(ingredient.ingredientName);
            }

            foreach (var recipe in recipes) 
                {
                System.Windows.Forms.TextBox txtRecipe = new System.Windows.Forms.TextBox();
                System.Windows.Forms.Button btnRecipe = new System.Windows.Forms.Button();

                btnRecipe.Text = "Voir les informations de la recette";
                btnRecipe.Font = new Font("Bahnschrift", 25);
                btnRecipe.Size = new System.Drawing.Size(275, 125);
                btnRecipe.Dock = DockStyle.Bottom;
                btnRecipe.BackColor = Color.FromArgb(0, 97, 97);
                btnRecipe.Click += BtnRecipe_Click;
                btnRecipe.Cursor = Cursors.Default;
                btnRecipe.Tag = recipe.id;

                if (recipe.id % 2 != 0)
                {
                    txtRecipe.Location = new System.Drawing.Point(
                    this.ClientSize.Width / 2 - pnlRecipe.Size.Width / 2, (10 + (200 * i)));
                }
                else
                {
                   txtRecipe.Location = new System.Drawing.Point(
                   this.ClientSize.Width * 3 - pnlRecipe.Size.Width * 3, 10 + (200 * i));
                    i += 2;
                }

                txtRecipe.AutoSize = false;
                txtRecipe.Size = new System.Drawing.Size(600, 350);
                txtRecipe.BackColor = System.Drawing.Color.CadetBlue;
                txtRecipe.ForeColor = System.Drawing.Color.White;
                txtRecipe.Font = new Font("Bahnschrift", 25);
                txtRecipe.ReadOnly = true;
                txtRecipe.Multiline = true;
                txtRecipe.Cursor = Cursors.Default;

                pnlRecipe.Controls.Add(txtRecipe);
                txtRecipe.Controls.Add(btnRecipe);

                
                txtRecipe.Text += recipe.recipeName.ToString() + "\r\n";
                if(recipe.vegetarian == true)
                {
                    txtRecipe.Text += "Végetarien";
                }
                else
                {
                    txtRecipe.Text += "Non-végetarien";
                }
                
                txtRecipe.Text += "\r\n" + recipe.preparationTime.ToString() + "\r\n" + recipe.recipeType.ToString() +
                "\r\n" + recipe.lvl.ToString();

            }
        }
         
        public void BtnRecipe_Click(object sender, EventArgs e)
        {
            int id = (int)((System.Windows.Forms.Control)sender).Tag;

            frmShowRecipeInformation showRecipeInformation = new frmShowRecipeInformation();
            showRecipeInformation.recipeId = id;
            showRecipeInformation.ShowDialog();
        }

        private void chkVeggies_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVeggies.Checked)
            { 
                FillTheRecipes(Recipe.GetAllVeggies());
            }
            else
            {
                FillTheRecipes(Recipe.GetAll());
            }
        }

        private void programBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void pnlRecipe_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
