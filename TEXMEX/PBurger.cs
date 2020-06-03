using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TEXMEX.Models;

namespace TEXMEX
{
    public partial class PBurger : Form
    {
        public PBurger()
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
            if (lblPersonalizado.Text == "Hamburmexa con")
            {
                lblPersonalizado.Text += burro.ToString();
            }
            else if (lblPersonalizado.Text == "Hamburmexa con cebolla" || lblPersonalizado.Text == "Hamburmexa con tocino")
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
            ingredientes.Add(Ingredientes.cebolla);
            var burro = new Burromexa(ingredientes);
            if (lblPersonalizado.Text == "Hamburmexa con")
            {
                lblPersonalizado.Text += burro.ToString();
            }
            else if (lblPersonalizado.Text == "Hamburmexa con jitomate" || lblPersonalizado.Text == "Hamburmexa con tocino")
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
            ingredientes.Add(Ingredientes.tocino);
            var burro = new Burromexa(ingredientes);
            if (lblPersonalizado.Text == "Hamburmexa con")
            {
                lblPersonalizado.Text += burro.ToString();
            }
            else if (lblPersonalizado.Text == "Hamburmexa con cebolla" || lblPersonalizado.Text == "Hamburmexa con jitomate")
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
            frm.total3.Text = lblPersonalizado.Text;
            this.Close();
        }
    }
}
