using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivreDeRecette
{
    public partial class frmCookMode : Form
    {
        public int stepNumber = 0;
        public string ingredientText;
        public int recipeId;

        public frmCookMode()
        {
            InitializeComponent();
        }

        private void frmCookMode_Load(object sender, EventArgs e)
        {

            this.ActiveControl = null;
            MessageBox.Show(ingredientText);
            lblQuantIng.Text = ingredientText;

            List<Steps> recipeSteps = Steps.GetAll(recipeId);

            
                
                

            lblSteps.Text = recipeSteps[0].stepNumber + " - " + recipeSteps[0].stepName + "\r\n" + recipeSteps[0].content + "\r\n\r\n";
        }



        private void lblQuantIng_Click(object sender, EventArgs e)
        {

        }

        private void btnRignt_Click(object sender, EventArgs e)
        {
            List<Steps> steps = Steps.GetAll(recipeId);

            foreach (Steps step in steps)
            {
                for (int i = 0; i < steps.Count; i++)
                {
                    if (i > steps.Count)
                    {
                        i = 0;
                        btnRignt_Click(sender, e);
                    }
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

            if (stepNumber < 0)
            {
                stepNumber = 0;
            }

            if (stepNumber > 0)
            {
                stepNumber--;
                lblSteps.Text = steps[stepNumber].stepNumber + " - " + steps[stepNumber].stepName + "\r\n" + steps[stepNumber].content + "\r\n\r\n";
            }
        }

        private void frmShowRecipeInformation_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                btnLeft_Click(sender, e);
            }
            if (e.KeyCode == Keys.D)
            {
                btnRignt_Click(sender, e);
            }
        }
    }
}
