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
    public partial class frmCreateDesign : Form
    {
        public frmCreateDesign()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void CreateRecipe_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chklstLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            /* protected void textBox1_KeyPress(object sender_, KeyPressEventArgs a)
            {
                if (!char.IsControl(a.KeyChar) && !char.IsDigit(a.KeyChar) && (a.KeyChar != '.'))
                {
                    a.Handled = true;
                }

                // only allow one decimal point
                if ((a.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    a.Handled = true;
                } */
        }

        private void lblMinutes_Click(object sender, EventArgs e)
        {

        }
    }
}
