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

            // Recipe recipeInformations = Recipe.GetOne(recipeId);
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

            foreach (Steps step in recipeSteps)
            {
                lblSteps.Text += step.stepNumber + " - " + step.stepName + "\r\n" + step.content + "\r\n\r\n";
            }
        }
        private void lstPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmShowRecipeInformation_Load(sender, e);
        }

        private void txtIngredients_TextChanged(object sender, EventArgs e)
        {

        }


        private void pnlSteps_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lblSteps_Click(object sender, EventArgs e)
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
        }
    }
}

