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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmCookMode_Load(object sender, EventArgs e)
        {

            this.ActiveControl = null;
            txtIngredients.Text = ingredientText;

            List<Steps> recipeSteps = Steps.GetAll(recipeId);

            lblSteps.Text = recipeSteps[0].stepNumber + " - " + recipeSteps[0].stepName + "\r\n" + recipeSteps[0].content + "\r\n\r\n";
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
            this.TabStop = false;
            TabControl tabControl = null;
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
            TabControl tabControl = null;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmShowRecipes _frmShowRecipes = new frmShowRecipes();
            _frmShowRecipes.ShowDialog();
            this.Close();
            this.Hide();
        }

        private void txtIngredients_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
