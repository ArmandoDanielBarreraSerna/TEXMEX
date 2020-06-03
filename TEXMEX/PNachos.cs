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
    public partial class PNachos : Form
    {
        public PNachos()
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
            ingredientes.Add(Ingredientes.queso);
            var burro = new Burromexa(ingredientes);
            if (lblPersonalizado.Text == "Nachos con")
            {
                lblPersonalizado.Text += burro.ToString();
            }
            else if (lblPersonalizado.Text == "Nachos con jalapeños" || lblPersonalizado.Text == "Nachos con tocino")
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
            ingredientes.Add(Ingredientes.jalapeños);
            var burro = new Burromexa(ingredientes);
            if (lblPersonalizado.Text == "Nachos con")
            {
                lblPersonalizado.Text += burro.ToString();
            }
            else if (lblPersonalizado.Text == "Nachos con queso" || lblPersonalizado.Text == "Nachos con tocino")
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
            if (lblPersonalizado.Text == "Nachos con")
            {
                lblPersonalizado.Text += burro.ToString();
            }
            else if (lblPersonalizado.Text == "Nachos con queso" || lblPersonalizado.Text == "Nachos con jalapeños")
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
            frm.total4.Text = lblPersonalizado.Text;
            this.Close();
        }

        private void lblPersonalizado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
