using System;
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
        public int stepNumber = 0;
        public frmShowRecipeInformation()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            frmShowRecipeInformation frmShowRecipeInformation;
        }

        private void frmShowRecipeInformation_Load(object sender, EventArgs e)
        {
            txtIngredients.Text = string.Empty;
            this.ActiveControl = null;

            int personCount = lstPerson.SelectedIndex+2; 
            txtIngredients.ScrollBars = ScrollBars.Both;

            Recipe recipeInformations = Recipe.GetOne(recipeId);
            List<Quantities> recipeQuantities = Quantities.GetAll(recipeId);
            List<Steps> recipeSteps = Steps.GetAll(recipeId);
            

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
                txtIngredients.Text += " " +ingredientQuantity.measurement + " " + "\r\n\r\n";
            }

            lblSteps.Text = recipeSteps[0].stepNumber + " - " + recipeSteps[0].stepName + "\r\n" + recipeSteps[0].content + "\r\n\r\n";


        }
        private void lstPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmShowRecipeInformation_Load(sender, e);
        }

        private void txtIngredients_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSteps_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRignt_Click(object sender, EventArgs e)
        {
            List<Steps> steps = Steps.GetAll(recipeId);

            foreach (Steps step in steps)
            {
                for (int i = 0; i< steps.Count; i++)
                {
                    if (step.stepNumber == i)
                    {
                        if (stepNumber < steps.Count)
                        {
                            lblSteps.Text = steps[stepNumber].stepNumber + " - " + steps[stepNumber].stepName + "\r\n" + steps[stepNumber].content + "\r\n\r\n";
                            stepNumber++;
                        }
                    }
                }
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            List<Steps> steps = Steps.GetAll(recipeId);

             if (stepNumber > 0)
             {
                stepNumber--;
                lblSteps.Text = steps[stepNumber].stepNumber + " - " + steps[stepNumber].stepName + "\r\n" + steps[stepNumber ].content + "\r\n\r\n";
             }
        }

        private void lblSteps_Click(object sender, EventArgs e)
        {
            
        }

        private void frmShowRecipeInformation_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                btnLeft_Click (sender, e);
            }
            if (e.KeyCode == Keys.D)
            {
                btnRignt_Click (sender, e);
            }
        }
    }
}

