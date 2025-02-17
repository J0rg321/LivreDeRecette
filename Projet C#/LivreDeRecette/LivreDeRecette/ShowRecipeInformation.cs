﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.AxHost;
using System.Windows.Media.Media3D;

namespace LivreDeRecette
{
    public partial class frmShowRecipeInformation : Form
    {

        public int recipeId;


        public frmShowRecipeInformation()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmShowRecipeInformation_Load(object sender, EventArgs e)
        {
            Recipe recipeInformations = Recipe.GetOne(recipeId);

            lblRecipeName.Text = recipeInformations.recipeName;

            for (int j = 2; j <= 100; j++)
            {
                lstPerson.Items.Add(j);
            }

            txtIngredients.Text = string.Empty;
            this.ActiveControl = null;

            int personCount = lstPerson.SelectedIndex + 1;

            if(personCount == 0 || personCount == null)
            {
                personCount = 1;
            }

            List<Quantities> recipeQuantities = Quantities.GetAll(recipeId);
            List<Steps> recipeSteps = Steps.GetAll(recipeId);
            int i = 1;

            // Show the informations from the recipe by his ID

            foreach (Quantities ingredientQuantity in recipeQuantities)
            {
                txtIngredients.Text += "- " + ingredientQuantity.ingredientName.ToString() + " : ";
                if(ingredientQuantity.ingredientQuantities == 0) 
                {if(ingredientQuantity.measurement == "")
                    {
                        txtIngredients.Text += "un peu";
                    }
                    else
                    {
                        txtIngredients.Text += "quelques";
                    }
                }
                else
                {
                    txtIngredients.Text += (ingredientQuantity.ingredientQuantities * personCount);
                }
                if (i == recipeQuantities.Count())
                {
                    txtIngredients.Text += " " + ingredientQuantity.measurement;
                }
                else
                {
                    txtIngredients.Text += " " + ingredientQuantity.measurement +"\r\n\r\n";
                }
                i++;
            }

            // Refresh and show all the steps from the selected recipe by his ID

            txtSteps.Text = null;
            foreach (Steps step in recipeSteps)
            {
                txtSteps.Text += step.stepNumber + " - " + step.stepName + "\r\n" + step.content + "\r\n\r\n";
            }
        }
        private void lstPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmShowRecipeInformation_Load(sender, e);
        }

        private void txtIngredients_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCookMode_Click(object sender, EventArgs e)
        {
            int id = recipeId;
            string ingredientText = txtIngredients.Text;

            frmCookMode _frmCookMode = new frmCookMode();
            _frmCookMode.recipeId = id;
            _frmCookMode.ingredientText = ingredientText.ToString();
            _frmCookMode.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmShowRecipes _frmShowRecipes = new frmShowRecipes();
            _frmShowRecipes.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void txtSteps_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombrePers_Click(object sender, EventArgs e)
        {

        }

        private void lblRecipeName_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

