using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Titanic_infographic
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("..\\..\\TrajanPro-Regular.ttf");
            label1.Font = new Font(pfc.Families[0], 10, FontStyle.Bold);
        }

        private void Intro_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            //this.Close();
        }
    }
}
