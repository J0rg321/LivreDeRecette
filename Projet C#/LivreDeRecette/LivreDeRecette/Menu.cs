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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            Application.UseWaitCursor = false;
            Cursor = Cursors.Default;
        }


        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmQuestions questions = new frmQuestions();
            questions.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void btnNext_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
