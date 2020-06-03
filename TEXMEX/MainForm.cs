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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void labelClose3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelClose3_MouseEnter(object sender, EventArgs e)
        {
            labelClose3.ForeColor = Color.Red;
        }

        private void labelClose3_MouseLeave(object sender, EventArgs e)
        {
            labelClose3.ForeColor = Color.White;
        }

        private void btnNach_Click(object sender, EventArgs e)
        {

            var foodservice = new iFood[]
            {
                new Nacheesse(),
            };


            var organizador = new FoodOrganizador();
            var contador = new FoodContador();

            foreach (var food in foodservice)
            {
                food.Aceptar(organizador);
                food.Aceptar(contador);
            }

            lblTotal4.Text = contador.total.ToString();

            BILL frm = new BILL(lblTotal.Text);

            int count3 = int.Parse(lblDisplay4.Text);
            count3++;
            lblDisplay4.Text = count3.ToString();
        }

        private void btnMenos4_Click(object sender, EventArgs e)
        {
            if (lblDisplay4.Text != "0")
            {
                int count = int.Parse(lblDisplay4.Text);
                count--;
                lblDisplay4.Text = count.ToString();

                if (lblDisplay4.Text == "0")
                {
                    lblTotal4.Text = "";
                }
            }
        }

        private void btnHMexa_Click(object sender, EventArgs e)
        {

            var foodservice = new iFood[]
            {
                new Hamburmexa(),
            };


            var organizador = new FoodOrganizador();
            var contador = new FoodContador();

            foreach (var food in foodservice)
            {
                food.Aceptar(organizador);
                food.Aceptar(contador);
            }

            lblTotal3.Text = contador.total.ToString();

            BILL frm = new BILL(lblTotal3.Text);

            int count3 = int.Parse(lblDisplay3.Text);
            count3++;
            lblDisplay3.Text = count3.ToString();
        }

        private void btnMenos3_Click(object sender, EventArgs e)
        {
            if (lblDisplay3.Text != "0")
            {
                int count = int.Parse(lblDisplay3.Text);
                count--;
                lblDisplay3.Text = count.ToString();

                if (lblDisplay3.Text == "0")
                {
                    lblTotal3.Text = "";
                }
            }
        }

        private void btnBMexa_Click(object sender, EventArgs e)
        {
            var foodservice = new iFood[]
            {
                new Burromexa(),
            };

            var organizador = new FoodOrganizador();
            var contador = new FoodContador();

            foreach (var food in foodservice)
            {
                food.Aceptar(organizador);
                food.Aceptar(contador);
            }

            lblTotal.Text = contador.total.ToString();

            BILL frm = new BILL(lblTotal.Text);

            int count2 = int.Parse(lblDisplay.Text);
            count2++;
            lblDisplay.Text = count2.ToString();
        }

        private void btnDogo_Click(object sender, EventArgs e)
        {

            var foodservice = new iFood[]
            {
                new HotDog(),
            };


            var organizador = new FoodOrganizador();
            var contador = new FoodContador();

            foreach (var food in foodservice)
            {
                food.Aceptar(organizador);
                food.Aceptar(contador);
            }

            lblTotal2.Text = contador.total.ToString();

            BILL frm = new BILL(lblTotal2.Text);

            int count4 = int.Parse(lblDisplay2.Text);
            count4++;
            lblDisplay2.Text = count4.ToString();
        }

        private void btnMenos1_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            {
                int count = int.Parse(lblDisplay.Text);
                count--;
                lblDisplay.Text = count.ToString();

                if (lblDisplay.Text == "0")
                {
                    lblTotal.Text = "";
                }
            }
        }

        private void btnMenos2_Click(object sender, EventArgs e)
        {
            if (lblDisplay2.Text != "0")
            {
                int count = int.Parse(lblDisplay2.Text);
                count--;
                lblDisplay2.Text = count.ToString();
                if (lblDisplay2.Text == "0")
                {
                    lblTotal2.Text = "";
                }
            }

        }

        private void btnTot_Click(object sender, EventArgs e)
        {
            this.Hide();
            BILL frm = new BILL();
            frm.total1.Text = lblTotal.Text;
            frm.total2.Text = lblTotal2.Text;
            frm.total3.Text = lblTotal3.Text;
            frm.total4.Text = lblTotal4.Text;

            frm.cant1.Text = lblDisplay.Text;
            frm.cant2.Text = lblDisplay2.Text;
            frm.cant3.Text = lblDisplay3.Text;
            frm.cant4.Text = lblDisplay4.Text;

            if (lblTotal.Text != string.Empty)
            {

                frm.preciou1.Text = precio1.Text;
            }


            if (lblTotal2.Text != String.Empty)
            {

                frm.preciou2.Text = precio2.Text;
            }

            if (lblTotal3.Text != String.Empty)
            {

                frm.preciou3.Text = precio3.Text;
            }

            if (lblTotal4.Text != String.Empty)
            {
                frm.preciou4.Text = precio4.Text;
            }




            frm.Show();
        }
    }
}
