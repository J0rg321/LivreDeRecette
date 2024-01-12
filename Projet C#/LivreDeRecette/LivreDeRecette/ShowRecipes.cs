using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public List<string> checkedItems = new List<string>();

        private void chklstIngr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowRecipes_Load(object sender, EventArgs e)
        {
            // Add the items to the checkList chklstIngr

            List<Ingredients> ingredients = Ingredients.GetAll();
            foreach (var ingredient in ingredients)
            {
                chklstIngr.Items.Add(ingredient.ingredientName);
            }
            FillTheRecipes(Recipe.GetAll(checkedItems));

        }

        private void FillTheRecipes(List<Recipe> recipes)
        {
            // Fill the recipe panel with all the different recipes from the SQL Data Base and their basic information

            pnlRecipe.Controls.Clear();

            int i = 0;
            int j = 1;

            // If thère's no displayed recipe, show this message.

            if (recipes.Count == 0)
            {
                System.Windows.Forms.Label lblNoRecipe = new System.Windows.Forms.Label();
                lblNoRecipe.Text = "Il n'y a pas de recettes végétariennes qui contiennent ces ingrédients.";
                lblNoRecipe.Location = new System.Drawing.Point(465, 90);
                lblNoRecipe.AutoSize = true;
                lblNoRecipe.Font = new Font("Bahnschrift", 25);
                lblNoRecipe.ForeColor = System.Drawing.Color.PowderBlue;

                pnlRecipe.Controls.Add(lblNoRecipe);

            }

            // Show the recipes with their basic information +  a button to show the steps and ingredients

            foreach (var recipe in recipes)
            {
                System.Windows.Forms.TextBox txtRecipe = new System.Windows.Forms.TextBox();
                System.Windows.Forms.Button btnRecipe = new System.Windows.Forms.Button();

                btnRecipe.Text = "Voir les informations de la recette";
                btnRecipe.Font = new Font("Bahnschrift", 25);
                btnRecipe.Size = new System.Drawing.Size(275, 125);
                btnRecipe.Dock = DockStyle.Bottom;
                btnRecipe.BackColor = Color.Teal;
                btnRecipe.Click += BtnRecipe_Click;
                btnRecipe.Cursor = Cursors.Default;
                btnRecipe.Tag = recipe.recipeID;

                if (j % 2 != 0)
                {
                    txtRecipe.Location = new System.Drawing.Point( 200, (10 + (250 * i)));
                }
                else
                {
                    txtRecipe.Location = new System.Drawing.Point( 1100, 10 + (250 * i));
                    i += 2;
                }

                j++;

                txtRecipe.AutoSize = false;
                txtRecipe.Size = new System.Drawing.Size(600, 425);
                txtRecipe.BackColor = System.Drawing.Color.CadetBlue;
                txtRecipe.ForeColor = System.Drawing.Color.White;
                txtRecipe.Font = new Font("Bahnschrift", 25);
                txtRecipe.ReadOnly = true;
                txtRecipe.Multiline = true;
                txtRecipe.Cursor = Cursors.Default;



                pnlRecipe.Controls.Add(txtRecipe);
                txtRecipe.Controls.Add(btnRecipe);

                txtRecipe.Text += recipe.recipeName.ToString() + "\r\n\r\n" + "Cette recette est : ";
                if (recipe.vegetarian == true)
                {
                    txtRecipe.Text += "Végetarienne";
                }
                else
                {
                    txtRecipe.Text += "Non-végetarienne";
                }

                txtRecipe.Text += "\r\n" + "Temps de préparation : " + recipe.preparationTime.ToString() + " minutes" + "\r\n" + "Cette recette est un : " + recipe.recipeType +
                "\r\n" + "Niveau : " + recipe.lvl;

            }
        }

        public void BtnRecipe_Click(object sender, EventArgs e)
        {
            int id = (int)((System.Windows.Forms.Control)sender).Tag;

            frmShowRecipeInformation showRecipeInformation = new frmShowRecipeInformation();
            showRecipeInformation.recipeId = id;
            showRecipeInformation.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void chkVeggies_CheckedChanged(object sender, EventArgs e)
        {
            // If the checkBox is clicked, thes the background is on DarkCyan, else, it's transparent

            if (chkVeggies.Checked)
            {
                chkVeggies.BackColor = Color.DarkCyan;
                FillTheRecipes(Recipe.GetAllVeggies(checkedItems));
                
            }
            else
            {
                chkVeggies.BackColor = Color.Transparent;
                FillTheRecipes(Recipe.GetAll(checkedItems));
            }
        }


        private void pnlRecipe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmQuestions questions = new frmQuestions();
            questions.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void chklstIngr_MouseUp(object sender, MouseEventArgs e)
        {
            // Add a part to the SQL request to show the recipes who contain the selected ingredients

            int checkedIngredientCount = chklstIngr.CheckedItems.Count;
            checkedItems.Clear();

            if (chkVeggies.Checked)
            {
                for (int j = 0; j < checkedIngredientCount; j++)
                {
                    if (j == 0)
                    {
                            if (!checkedItems.Contains(" AND "))
                            {
                                checkedItems.Insert(0, " AND ");
                                checkedItems.Insert(1, " ingredientName = \"" + chklstIngr.CheckedItems[j].ToString() + "\" ");
                            }
                    }
                    else
                    {
                        if (!checkedItems.Contains(" ingredientName = \"" + chklstIngr.CheckedItems[j].ToString() + "\" "))
                        {
                            if (j != 0)
                            {
                                checkedItems.Add(" OR ");
                                checkedItems.Add(" ingredientName = \"" + chklstIngr.CheckedItems[j].ToString() + "\" ");
                            }
                        }
                    }
                    


                    if (chklstIngr.CheckedItems.Count == 0)
                    {
                        checkedItems.Clear();
                        checkedItems.Add(" ");
                    }

                    FillTheRecipes(Recipe.GetAllVeggies(checkedItems));
                }
            }
            else
            {
                // Add a part to the SQL request to show the recipes who are vegertarian and contain the selected ingredients

                for (int j = 0; j < checkedIngredientCount; j++)
                {
                    if (!checkedItems.Contains(" ingredientName = \"" + chklstIngr.CheckedItems[j].ToString() + "\" "))
                    {
                        if (j == 0)
                        {
                            if (!checkedItems.Contains(" And "))
                            {
                                checkedItems.Insert(0, " And");
                                checkedItems.Insert(1," ingredientName = \"" + chklstIngr.CheckedItems[j].ToString() + "\" ");
                            }
                        }
                        if (!checkedItems.Contains(" ingredientName = \"" + chklstIngr.CheckedItems[j].ToString() + "\" "))
                        {
                            if (j != 0)
                            {
                                checkedItems.Add(" OR ");
                                checkedItems.Add(" ingredientName = \"" + chklstIngr.CheckedItems[j].ToString() + "\" ");
                            }
                        }
                    }

                }


                if (chklstIngr.CheckedItems.Count == 0)
                {
                    checkedItems.Clear();
                    checkedItems.Add(" ");
                }
                
                FillTheRecipes(Recipe.GetAll(checkedItems));
            }
            }
        }
    } 

