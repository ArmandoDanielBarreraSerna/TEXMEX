using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEXMEX
{
    public partial class BILL : Form
    {

        public BILL(string value)
        {
        }
        public BILL()
        {
            InitializeComponent();
        }

        PBurro burrito;
        private void label5_Click(object sender, EventArgs e)
        {
            if (burrito == null)
            {
                burrito = new PBurro();
                burrito.Owner = this;
                burrito.FormClosed += new FormClosedEventHandler(nachos_FormClosed);
                burrito.DemoText = total1.Text;
                burrito.Show();
            }
            else
            {
                burrito.Activate();
            }
        }

        void nachos_FormClosed(object sender, FormClosedEventArgs e)
        {
            burrito = null;
        }

        PDogo dogo;
        private void label6_Click(object sender, EventArgs e)
        {

            if (dogo == null)
            {
                dogo = new PDogo();
                dogo.Owner = this;
                dogo.FormClosed += new FormClosedEventHandler(nachos_FormClosed);
                dogo.DemoText = total2.Text;
                dogo.Show();
            }
            else
            {
                dogo.Activate();
            }
        }

        PBurger burger;
        private void label8_Click(object sender, EventArgs e)
        {

            if ( burger  == null)
            {
                burger = new PBurger();
                burger.Owner = this;
                burger.FormClosed += new FormClosedEventHandler(nachos_FormClosed);
                burger.DemoText = total3.Text;
                burger.Show();
            }
            else
            {
                burger.Activate();
            }
        }
        PNachos nachos;
        private void label7_Click(object sender, EventArgs e)
        { 
            if (nachos == null)
            {
                nachos = new PNachos();
                nachos.Owner = this;
                nachos.FormClosed += new FormClosedEventHandler(nachos_FormClosed);
                nachos.DemoText = total4.Text;
                nachos.Show();
            }
            else
            {
                nachos.Activate();
            }
        }
    }
}
