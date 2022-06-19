using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace DatabaseProject
{
    public partial class SelezioneSede : Form
    {
        private bool IsAdmin { get; set; }
        private CreateConnection Connection { get; set; }

        private List<(string, string, Int64)> ListaAgenzie = new List<(string PIVA, string Nome, Int64 NumTotDipendenti)>();
        private List<(string, string, string)> ListaSedi = new List<(string IDsede, string PIVAagenzia, string IDindirizzo)>();


        public SelezioneSede(bool isAdmin)
        {
            this.IsAdmin = isAdmin;
            InitializeComponent();
            this.Connection = new CreateConnection();
            this.Connection.Connection.Open();
            var query = new QueryLibrary(this.Connection.Connection);
            var reader = query.LeggiAgenzie().ExecuteReader();
            while (reader.Read())
            {
                var PIVA = reader.GetString("PIVA");
                var Nome = reader.GetString("Nome");
                var NumTotDipendenti = reader.GetInt64("NumTotDipendenti");
                this.AgenziaComboBox.Items.Add(Nome);
                this.ListaAgenzie.Add((PIVA, Nome, NumTotDipendenti));
            }
            this.Connection.Connection.Close();
        }

        

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            if (this.AgenziaComboBox.SelectedItem == null || this.SedeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Devi selezionare un'agenzia e una sede per poter continuare", 
                    "Errore",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                //SystemSounds.Exclamation.Play();
            }
            else
            {
                this.Hide();
                if (this.IsAdmin)
                {
                    var d = new DatabaseViewAdmin(this.IsAdmin,
                    this.ListaAgenzie[this.AgenziaComboBox.SelectedIndex].Item1,
                    this.ListaSedi[this.SedeComboBox.SelectedIndex].Item1);
                    d.Show();

                }
                else
                {
                    var d = new DatabaseViewUser(this.IsAdmin,
                    this.ListaAgenzie[this.AgenziaComboBox.SelectedIndex].Item1,
                    this.ListaSedi[this.SedeComboBox.SelectedIndex].Item1);
                    d.Show();
                }
            }
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
            this.SedeComboBox.ResetText();
            var index = this.AgenziaComboBox.SelectedIndex;
            this.Connection = new CreateConnection();
            this.Connection.Connection.Open();
            var query = new QueryLibrary(this.Connection.Connection);
            var reader = query.LeggiSedi(ListaAgenzie[index].Item1).ExecuteReader();
            this.SedeComboBox.Items.Clear();
            this.ListaSedi.Clear();

            while (reader.Read())
            {
                var IDsede = reader.GetString("IDsede");
                var PIVAagenzia = reader.GetString("PIVAagenzia");
                var IDindirizzo = reader.GetString("IDindirizzo");

                this.ListaSedi.Add((IDsede, PIVAagenzia, IDindirizzo));

                var addressConnection = new CreateConnection();
                addressConnection.Connection.Open();
                var addressQuery = new QueryLibrary(addressConnection.Connection);
                var addressReader = addressQuery.LeggiIndirizzi(IDindirizzo).ExecuteReader();
                addressReader.Read();
                var NumCivico = addressReader.GetString("NumCivico");
                var Via = addressReader.GetString("Via");
                var CAP = addressReader.GetString("CAP");
                var Paese = addressReader.GetString("Paese");

                this.SedeComboBox.Items.Add(IDsede + ": " + Via + ", " + NumCivico + ", " + CAP + ", " + Paese);
                addressConnection.Connection.Close();
            }
            this.Connection.Connection.Close();
        }

        private void SelezioneSede_Load(object sender, EventArgs e)
        {

        }
    }
}
