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
    public partial class QuestionModifyOrWatch : Form
    {
        public QuestionModifyOrWatch()
        {
            InitializeComponent();

        }

        private void QuestionModifyOrWatch_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VegegetarianOrNot vegetarianOrNot = new VegegetarianOrNot();
            vegetarianOrNot.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boutonCreer_Click(object sender, EventArgs e)
        {

        }
    }
}
