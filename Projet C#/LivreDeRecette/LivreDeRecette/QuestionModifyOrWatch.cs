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
    public partial class frmQuestions : Form
    {
        public frmQuestions()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void QuestionModifyOrWatch_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmShowRecipes _showRecipes = new frmShowRecipes();
            _showRecipes.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boutonCreer_Click(object sender, EventArgs e)
        {
            frmCreateDesign _createRecipes = new frmCreateDesign();
            _createRecipes.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu _frmMenu = new frmMenu();
            _frmMenu.ShowDialog();
            this.Hide();
            this.Close();
        }
    }
}
