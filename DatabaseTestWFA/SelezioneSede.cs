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
        private bool IsAdmin { get; set; }
        private CreateConnection Connection { get; set; }

        private List<(string, string)> ListaAgenzie = new List<(string PIVA, String Nome)>();

        public SelezioneSede(bool isAdmin)
        {
            this.IsAdmin = isAdmin;
            InitializeComponent();
            this.Connection = new CreateConnection();
            this.Connection.Connection.Open();
            var query = new QueryLibrary(this.Connection.Connection);
            var reader = query.LeggiAgenzie();
            while (reader.Read())
            {
                var PIVA = reader.GetString("PIVA");
                var Nome = reader.GetString("Nome");
                var NumTotDipendenti = reader.GetInt64("NumTotDipendenti");
                this.AgenziaComboBox.Items.Add(Nome);
                this.ListaAgenzie.Add((PIVA, Nome));
            }
            this.Connection.Connection.Close();
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
            var index = this.AgenziaComboBox.SelectedIndex;
            this.Connection = new CreateConnection();
            this.Connection.Connection.Open();
            var query = new QueryLibrary(this.Connection.Connection);
            var reader = query.LeggiSedi(ListaAgenzie[index].Item1);
            this.SedeComboBox.Items.Clear();
            while (reader.Read())
            {
                var IDsede = reader.GetString("IDsede");
                var PIVAagenzia = reader.GetString("PIVAagenzia");
                var IDindirizzo = reader.GetString("IDindirizzo");
                this.SedeComboBox.Items.Add(IDsede + ": " + IDindirizzo);
            }
            this.Connection.Connection.Close();
        }
    }
}
