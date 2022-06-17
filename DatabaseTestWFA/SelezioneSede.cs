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
    public partial class SelezioneSede : Form
    {
        bool IsAdmin { get; set; }

        public SelezioneSede(bool isAdmin)
        {
            this.IsAdmin = IsAdmin;
            InitializeComponent();
        }

        private void SelezioneSede_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var d = new DatabaseView(this.IsAdmin);
            d.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var u = new UserAdminChoice();
            u.Show();
        }

        private void SedeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgenziaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
