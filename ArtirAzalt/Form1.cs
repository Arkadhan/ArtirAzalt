using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtirAzalt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(tbSayi.Text);
            if (rbArtir.Checked)
            {
                tbSayi.Text = Convert.ToString(sayi + 10);
            }
            else if (rbAzalt.Checked)
            {
                tbSayi.Text = Convert.ToString(sayi - 10);
            }
           
      

        }

        private void btn20_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(tbSayi.Text);
            if (rbArtir.Checked)
            {
                tbSayi.Text = Convert.ToString(sayi + 20);
            }
            else if (rbAzalt.Checked)
            {
                tbSayi.Text = Convert.ToString(sayi - 20);
            }
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(tbSayi.Text);
            if (rbArtir.Checked)
            {
                tbSayi.Text = Convert.ToString(sayi + 30);
            }
            else if (rbAzalt.Checked)
            {
                tbSayi.Text = Convert.ToString(sayi - 30);
            }
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(tbSayi.Text);
            if (rbArtir.Checked)
            {
                tbSayi.Text = Convert.ToString(sayi + 40);
            }
            else if (rbAzalt.Checked)
            {
                tbSayi.Text = Convert.ToString(sayi - 40);
            }
        }
    }
}
