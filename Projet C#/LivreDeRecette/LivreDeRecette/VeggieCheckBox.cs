using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LivreDeRecette
{
    public class VeggieCheckBox : CheckBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Font f = new Font(new FontFamily("Bahnschrift"), 10);
            string choice = "Veuillez cocher si oui";
            e.Graphics.DrawString(choice, f, new SolidBrush(ForeColor), ClientRectangle);
            base.OnPaint(e);

        }

    }
}
