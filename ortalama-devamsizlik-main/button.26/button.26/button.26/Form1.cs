using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float ortalama,devamsizlik;

            ortalama=Convert.ToSingle(txtort.Text);
            devamsizlik=Convert.ToSingle(txtDevamsizlik.Text);

            if(ortalama>=50 && devamsizlik < 10)
            {
                lblSonuc.Text = "GEÇTİ.";
            }

            else
            {
                lblSonuc.Text = "KALDIN.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
