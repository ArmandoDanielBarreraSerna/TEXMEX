using MySql.Data.MySqlClient;
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
    public partial class TEXMEXFOOD : Form
    {
        

        public TEXMEXFOOD()
        {
            InitializeComponent();

            this.txtPass.AutoSize = false;
            this.txtPass.Size = new Size(this.txtPass.Size.Width, 50);
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Red;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = txtUser.Text;
            String password = txtPass.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn AND `password` = @pass", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            //Checamos si el usuario existe o no
            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show();
                //Form1 form = new Form1();
                //form.Show();
            }
            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Ingrese Nombre de Usuario", "Usuario Vacio", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Ingrese Contraseña", "Contraseña Faltante", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos", "Error de Inicio de Sesión", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void TEXMEXFOOD_Load(object sender, EventArgs e)
        {

        }

        private void labelGoToSingUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new  RegisterForm();
            registerForm.Show();
        }

        private void labelGoToSingUp_MouseEnter(object sender, EventArgs e)
        {
            labelGoToSingUp.ForeColor = Color.Yellow;
        }

        private void labelGoToSingUp_MouseLeave(object sender, EventArgs e)
        {
            labelGoToSingUp.ForeColor = Color.White;
        }
    }
}
