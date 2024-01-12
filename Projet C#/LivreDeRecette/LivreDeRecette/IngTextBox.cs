using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


// Useless Code
/*namespace LivreDeRecette
{
    internal class IngTextBox
    {
        public static TextBox CreateTxtIng()
        {
            System.Windows.Forms.TextBox txtIng = new System.Windows.Forms.TextBox();

            for (int i = 1; i <= 4; i++)
            {

                if (i / 3 == Int16.MinValue)
                {
                    txtIng.Location = new System.Drawing.Point(200, 200 * i);
                }
                else
                {
                    txtIng.Location = new System.Drawing.Point(200, 200 * i);
                }

                txtIng.AutoSize = false;
                txtIng.Name = "ListBox1";
                txtIng.Size = new System.Drawing.Size(600, 350);
                txtIng.BackColor = System.Drawing.Color.CadetBlue;
                txtIng.ForeColor = System.Drawing.Color.White;
                txtIng.Font = new Font("Bahnschrift", 25);
                txtIng.ReadOnly = true;

                frmShowRecipes.ActiveForm.Controls.Add(txtIng);

                txtIng.AppendText(Recipe.GetOne(i)[i].recipeName.ToString() + "\n");
                txtIng.AppendText(Recipe.GetOne(i)[i].vegetarian.ToString() + "\n");
                txtIng.AppendText(Recipe.GetOne(i)[i].preparationTime.ToString() + "\n");
                txtIng.AppendText(Recipe.GetOne(i)[i].recipeType.ToString() + "\n");
                txtIng.AppendText(Recipe.GetOne(i)[i].lvl.ToString() + "\n");

                
            }
            return txtIng;
        }
    }
}
*/