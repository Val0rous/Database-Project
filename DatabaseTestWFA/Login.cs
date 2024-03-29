﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class Login : Form
    {
        private Form PreviousWindow { get; set; }

        public Login(Form PreviousWindow)
        {
            InitializeComponent();
            this.PreviousWindow = PreviousWindow;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (this.UsernameBox.Text.Equals("admin") && this.PasswordBox.Text.Equals("admin"))
            {
                this.Hide();
                this.PreviousWindow.Hide();
                var selezioneSede = new SelezioneSede(true);
                selezioneSede.Show();
            }
            else
            {
                MessageBox.Show("Username o password errati",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        

        private void UsernameBox_Enter(object sender, EventArgs e)
        {
            if (this.UsernameBox.Text.Equals("Username"))
            {
                this.UsernameBox.Text = "";
            }
            this.UsernameBox.ForeColor = Color.Black;
        }

        private void UsernameBox_Leave(object sender, EventArgs e)
        {
            if (this.UsernameBox.Text.Equals(""))
            {
                this.UsernameBox.Text = "Username";
                this.UsernameBox.ForeColor = Color.Gray;
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (this.PasswordBox.Text.Equals("Password"))
            {
                this.PasswordBox.Text = "";
            }
            this.PasswordBox.ForeColor = Color.Black;
            this.PasswordBox.UseSystemPasswordChar = true;
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (this.PasswordBox.Text.Equals(""))
            {
                this.PasswordBox.Text = "Password";
                this.PasswordBox.ForeColor = Color.Gray;
                this.PasswordBox.UseSystemPasswordChar = false;
            }
        }
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.LoginButton_Click(sender, e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.UsernameBox.ForeColor = Color.Gray;
            this.PasswordBox.ForeColor = Color.Gray;
        }
    }
}
