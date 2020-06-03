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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            //remove the focus from the textboxes
            this.ActiveControl = label1;
        }

        #region EVENTS
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            labelCloseR.ForeColor = Color.Red;
        }

        private void labelCloseR_MouseLeave(object sender, EventArgs e)
        {
            labelCloseR.ForeColor = Color.White;
        }

        private void labelCloseR_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstname_Enter(object sender, EventArgs e)
        {
            String fname = txtFirstname.Text;
            if (fname.ToLower().Trim().Equals("first name"))
            {
                txtFirstname.Text = "";
                txtFirstname.ForeColor = Color.Black;
            }
        }

        private void txtFirstname_Leave(object sender, EventArgs e)
        {
            String fname = txtFirstname.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                txtFirstname.Text = "first name";
                txtFirstname.ForeColor = Color.Gray;
            }
        }
        #endregion

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastname_Enter(object sender, EventArgs e)
        {
            String lname = txtLastname.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                txtLastname.Text = "";
                txtLastname.ForeColor = Color.Black;
            }
        }

        private void txtLastname_Leave(object sender, EventArgs e)
        {
            String lname = txtLastname.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.Trim().Equals(""))
            {
                txtLastname.Text = "last name";
                txtLastname.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            String email = txtEmail.Text;
            if (email.ToLower().Trim().Equals("email address"))
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            String email = txtEmail.Text;
            if (email.ToLower().Trim().Equals("email address") || email.Trim().Equals(""))
            {
                txtEmail.Text = "email address";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            if (username.ToLower().Trim().Equals("username"))
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            if (username.ToLower().Trim().Equals("email address") || username.Trim().Equals(""))
            {
                txtUsername.Text = "email address";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            String password = txtPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            String password = txtPassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                txtPassword.Text = "password";
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void txtPasswordConfirm_Enter(object sender, EventArgs e)
        {
            String passwordconfirm = txtPasswordConfirm.Text;
            if (passwordconfirm.ToLower().Trim().Equals("confirm password"))
            {
                txtPasswordConfirm.Text = "";
                txtPasswordConfirm.UseSystemPasswordChar = true;
                txtPasswordConfirm.ForeColor = Color.Black;
            }
        }

        private void txtPasswordConfirm_Leave(object sender, EventArgs e)
        {
            String passwordconfirm = txtPasswordConfirm.Text;
            if (passwordconfirm.ToLower().Trim().Equals("confirm password") || 
                passwordconfirm.ToLower().Trim().Equals("password") || 
                passwordconfirm.Trim().Equals(""))
            {
                txtPasswordConfirm.Text = "confirm password";
                txtPasswordConfirm.UseSystemPasswordChar = false;
                txtPasswordConfirm.ForeColor = Color.Gray;
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`fistname`, `lastname`, `emailaddress`, `username`, `password`) VALUES (@fn, @ln, @email, @usn, @pass)", db.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = txtFirstname.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = txtLastname.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPassword.Text;

            //Abriendo la conexión
            db.openConnection();

            if (!CheckTextBoxesValues())
            {
                // Revisar si las contraseñas coinciden
                if (txtPassword.Text.Equals(txtPasswordConfirm.Text))
                {
                    //Revisar si el usuario ya existe 
                 
                    if (checkUsername())
                    {
                        MessageBox.Show("El nombre de usuario ya está reservado por alguien más.", "Usuario Duplicado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("SU CUENTA HA SIDO CREADA CON EXITO", "CUENTA CREADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("CONTRASEÑAS NO COINCIDEN", "ERROR DE CONTRASEÑA", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("FALTA INFORMACIÓN", "ESPACIOS VACIOS", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

                //Cerrando la conexión
                db.closeConnection();
        }

        // Revisar si el usuario ya existe o no
        public Boolean checkUsername()
        {
            DB db = new DB();

            String username = txtUsername.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            //Checamos si el usuario ya existe en la base de datos
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Revisar si los espacios están en blanco
        public Boolean CheckTextBoxesValues()
        {
            String fname = txtFirstname.Text;
            String lname = txtLastname.Text;
            String email = txtEmail.Text;
            String uname = txtUsername.Text;
            String pass = txtPassword.Text;

            if (fname.Equals("first name") || lname.Equals("last name") || email.Equals("email address") || uname.Equals("username") || pass.Equals("password"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void labelGoToLogIn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            TEXMEXFOOD texmex = new TEXMEXFOOD();
            texmex.Show();
        }

        private void labelGoToLogIn_MouseEnter(object sender, EventArgs e)
        {
            labelGoToLogIn.ForeColor = Color.Yellow;
        }

        private void labelGoToLogIn_MouseLeave(object sender, EventArgs e)
        {
            labelGoToLogIn.ForeColor = Color.White;
        }
    }
}
