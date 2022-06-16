using System;
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
    public partial class UserAdminChoice : Form
    {
        public UserAdminChoice()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userLaunch(object sender, EventArgs e)
        {
            this.Hide();
            var selezioneSede = new SelezioneSede(false);
            selezioneSede.Show();
        }

        private void adminLaunch(object sender, EventArgs e)
        {
            var login = new Login(this);
            login.Show();
        }

        private void UserAdminChoice_Load(object sender, EventArgs e)
        {

        }
    }
}
