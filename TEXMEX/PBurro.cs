using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEXMEX.Models;

namespace TEXMEX
{
    public partial class PBurro : Form
    { 
        public PBurro()
        {
            InitializeComponent();
        }

        public string DemoText
        {
            get { return lblPersonalizado.Text; }
            set { lblPersonalizado.Text = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox per = (PictureBox)sender;
            var ingredientes = new List<Ingredientes>();
            ingredientes.Add(Ingredientes.jitomate);
            var burro = new Burromexa(ingredientes);
            if (lblPersonalizado.Text == "Burromexa con")
            {
                lblPersonalizado.Text += burro.ToString();
            }
            else if (lblPersonalizado.Text == "Burromexa con cebolla" || lblPersonalizado.Text == "Burromexa con chile")
            {
                lblPersonalizado.Text = lblPersonalizado.Text + "," + burro.ToString();
            }
            else if (lblPersonalizado.Text != String.Empty)
            {
                lblPersonalizado.Text += " y" + burro.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox per = (PictureBox)sender;
            var ingredientes = new List<Ingredientes>();
            ingredientes.Add(Ingredientes.chile);
            var burro = new Burromexa(ingredientes);
            if (lblPersonalizado.Text == "Burromexa con")
            {
                lblPersonalizado.Text += burro.ToString();
            }
            else if (lblPersonalizado.Text == "Burromexa con cebolla" || lblPersonalizado.Text == "Burromexa con jitomate")
            {
                lblPersonalizado.Text = lblPersonalizado.Text + "," + burro.ToString();
            }
            else if (lblPersonalizado.Text != String.Empty)
            {
                lblPersonalizado.Text += " y" + burro.ToString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox per = (PictureBox)sender;
            var ingredientes = new List<Ingredientes>();
            ingredientes.Add(Ingredientes.cebolla);
            var burro = new Burromexa(ingredientes);
            if (lblPersonalizado.Text == "Burromexa con")
            {
                lblPersonalizado.Text += burro.ToString();
            }
            else if (lblPersonalizado.Text == "Burromexa con jitomate" || lblPersonalizado.Text == "Burromexa con chile")
            {
                lblPersonalizado.Text = lblPersonalizado.Text + "," + burro.ToString();
            }
            else if (lblPersonalizado.Text != String.Empty)
            {
                lblPersonalizado.Text += " y" + burro.ToString();
            }
        }

        private void labelCloseR_Click(object sender, EventArgs e)
        {
            BILL frm = (BILL)this.Owner;
            frm.total1.Text = lblPersonalizado.Text;
            this.Close();
        }
    }
}
