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
    public partial class PDogo : Form
    {
        public PDogo()
        {
            InitializeComponent();
        }

        public string DemoText
        {
            get { return lblPersonalizado2.Text; }
            set { lblPersonalizado2.Text = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox per = (PictureBox)sender;
            var ingredientes = new List<Ingredientes>();
            ingredientes.Add(Ingredientes.ruffles);
            var burro = new HotDog(ingredientes);
            if (lblPersonalizado2.Text == "Dogo con")
            {
                lblPersonalizado2.Text += burro.ToString();
            }
            else if (lblPersonalizado2.Text == "Dogo con tocino" || lblPersonalizado2.Text == "Dogo con chilliebeans" )
            {
                lblPersonalizado2.Text = lblPersonalizado2.Text + "," + burro.ToString();
            }
            else if (lblPersonalizado2.Text != String.Empty)
            {
                lblPersonalizado2.Text += " y" + burro.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox per = (PictureBox)sender;
            var ingredientes = new List<Ingredientes>();
            ingredientes.Add(Ingredientes.tocino);
            var burro = new HotDog(ingredientes);
            if (lblPersonalizado2.Text == "Dogo con")
            {
                lblPersonalizado2.Text += burro.ToString();
            }
            else if (lblPersonalizado2.Text == "Dogo con ruffles" || lblPersonalizado2.Text == "Dogo con chilliebeans")
            {
                lblPersonalizado2.Text = lblPersonalizado2.Text + "," + burro.ToString();
            }
            else if (lblPersonalizado2.Text != String.Empty)
            {
                lblPersonalizado2.Text += " y" + burro.ToString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox per = (PictureBox)sender;
            var ingredientes = new List<Ingredientes>();
            ingredientes.Add(Ingredientes.chillibeans);
            var burro = new HotDog(ingredientes);
            if (lblPersonalizado2.Text == "Dogo con")
            {
                lblPersonalizado2.Text += burro.ToString();
            }
            else if (lblPersonalizado2.Text == "Dogo con ruffles" || lblPersonalizado2.Text == "Dogo con tocino")
            {
                lblPersonalizado2.Text = lblPersonalizado2.Text + "," + burro.ToString();
            }
            else if (lblPersonalizado2.Text != String.Empty)
            {
                lblPersonalizado2.Text += " y" + burro.ToString();
            }
        }

        private void labelCloseR_Click(object sender, EventArgs e)
        {
            BILL frm = (BILL)this.Owner;
            frm.total2.Text = lblPersonalizado2.Text;
            this.Close();
        }
    }
}
