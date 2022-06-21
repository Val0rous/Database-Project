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

namespace DatabaseProject
{
    public partial class DatabaseViewUser : Form
    {
        bool IsAdmin { get; }
        string PIVAagenzia { get; }
        string IDsede { get; }

        private bool pacchetto_ID;
        private bool pacchetto_sconto;
        private bool cliente_nome;
        private bool cliente_cognome;
        private bool cliente_CF;
        private bool cliente_telefono;
        private bool tour_id;

        public DatabaseViewUser(bool isAdmin, string PIVAagenzia, string IDsede)
        {
            this.IsAdmin = isAdmin;
            this.PIVAagenzia = PIVAagenzia;
            this.IDsede = IDsede;
            InitializeComponent();
        }
        public void ExecuteQueryIf(bool condition, Action<QueryLibrary> query)
        {
            if (condition)
            {
                var connection = new CreateConnection();
                connection.Connection.Open();
                var queries = new QueryLibrary(connection.Connection);

                try
                {
                    query(queries);
                }
                catch (Exception) { }
                connection.Connection.Close();
            }
            else
            {
                MessageBox.Show("Si prega di completare tutti i campi",
                "Attenzione",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
        private bool CheckCF()
        {
            string cf = this.ClienteCF.Text;
            var connection = new CreateConnection();
            connection.Connection.Open();
            var queries = new QueryLibrary(connection.Connection);
            var dataAdapter = new MySqlDataAdapter(queries.LeggiClienti().CommandText, connection.Connection);
            var table = new DataTable();
            dataAdapter.Fill(table);
            foreach (DataRow r in table.Rows)
            {
                if (r["CF"].Equals(cf))
                {
                    connection.Connection.Close();
                    return true;
                }
            }
            connection.Connection.Close();
            return false;
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var s = new SelezioneSede(this.IsAdmin);
            s.Show();
        }

        private void DatabaseViewUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionale_per_agenzie_relDataSet1.prenotazione' table. You can move, or remove it, as needed.
            //this.prenotazioneTableAdapter.Fill(this.gestionale_per_agenzie_relDataSet1.prenotazione);
            // TODO: This line of code loads data into the 'gestionale_per_agenzie_relDataSet.cliente' table. You can move, or remove it, as needed.
            //this.clienteTableAdapter.Fill(this.gestionale_per_agenzie_relDataSet.cliente);
            
            var connection = new CreateConnection();
            connection.Connection.Open();
            var queries = new QueryLibrary(connection.Connection);

            //FillTable(TabellaPrenotazioni, queries.LeggiPrenotazioni().CommandText, connection.Connection);
            //FillTable(TabellaPercorsi, queries.LeggiPercorso().CommandText, connection.Connection);
            FillTable(TabellaTour, queries.LeggiTour(IDsede).CommandText, connection.Connection);
            FillTable(Tabella_StoricoServiziCliente, queries.LeggiServiziCliente(this.ClienteCF.Text).CommandText, connection.Connection);
            //this.Pacchetto_ID.ForeColor = Color.Gray;
            this.Pacchetto_Sconto.ForeColor = Color.Gray;
            this.TourID.ForeColor = Color.Gray;
            this.Clienti_Nome.ForeColor = Color.Gray;
            this.Clienti_Cognome.ForeColor = Color.Gray;
            this.Clienti_CF.ForeColor = Color.Gray;
            this.Clienti_Telefono.ForeColor = Color.Gray;

            this.Pacchetto_ID.Text = queries.GetNextID("pacchetto", "IDpacchetto");

            connection.Connection.Close();
        }

        private static void FillTable(DataGridView grid, string command, MySqlConnection connection)
        {
            var dataAdapter = new MySqlDataAdapter(command, connection);
            var table = new DataTable();
            dataAdapter.Fill(table);
            var SBind = new BindingSource();
            SBind.DataSource = table;
            grid.DataSource = SBind;
        }

        private void RefreshAll(object sender, EventArgs e)
        {
            this.DatabaseViewUser_Load(sender, e);
            TabellaTour.Update();
            TabellaTour.Refresh();
        }
        private void TabPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connection = new CreateConnection();
            connection.Connection.Open();
            var queries = new QueryLibrary(connection.Connection);

            if (this.TabPage.SelectedTab.Text == "Pacchetti")
            {
                this.Pacchetto_ID.Text = queries.GetNextID("pacchetto", "IDpacchetto");
            }
            if (this.TabPage.SelectedTab.Text == "Storico servizi")
            {
                FillTable(Tabella_StoricoServiziCliente, queries.LeggiServiziCliente(this.ClienteCF.Text).CommandText, connection.Connection);
            }
            connection.Connection.Close();
        }
        private void CreaPacchettoButton_Click(object sender, EventArgs e)
        {
            if (!CheckCF())
            {
                MessageBox.Show("Inserisci un codice fiscale gia' registrato",
                "Errore",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            var us = new UserServices(IDsede, this.Pacchetto_ID.Text, pacchetto_sconto ? Int32.Parse(this.Pacchetto_Sconto.Text) : 0, this.ClienteCF.Text);
            us.Show();
        }

        private void ClienteCF_Enter(object sender, EventArgs e)
        {
            if (this.ClienteCF.Text.Equals("Codice Fiscale"))
            {
                this.ClienteCF.Text = "";
            }
            this.ClienteCF.ForeColor = Color.Black;
        }

        private void ClienteCF_Leave(object sender, EventArgs e)
        {
            if (this.ClienteCF.Text.Equals(""))
            {
                this.ClienteCF.Text = "Codice Fiscale";
                this.ClienteCF.ForeColor = Color.Gray;
            }
        }

        private void Pacchetto_Sconto_Enter(object sender, EventArgs e)
        {
            if (this.Pacchetto_Sconto.Text.Equals("Sconto"))
            {
                this.Pacchetto_Sconto.Text = "";
            }
            this.Pacchetto_Sconto.ForeColor = Color.Black;
            this.pacchetto_sconto = true;
        }

        private void Pacchetto_Sconto_Leave(object sender, EventArgs e)
        {
            if (this.Pacchetto_Sconto.Text.Equals(""))
            {
                this.Pacchetto_Sconto.Text = "Sconto";
                this.Pacchetto_Sconto.ForeColor = Color.Gray;
                this.pacchetto_sconto = false;
            }
        }

        private void TourButton_Click(object sender, EventArgs e)
        {
            var bindAcc = (BindingSource)TabellaTour.DataSource;
            var listaAcc = ((DataTable)bindAcc.DataSource).Rows;
            foreach (DataRow r in listaAcc)
            {
                if (r["IDtour"].Equals(this.TourID.Text))
                {
                    //Console.WriteLine("trovato");
                    if (!CheckCF())
                    {
                        MessageBox.Show("Inserisci un codice fiscale gia' registrato",
                        "Errore",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        return;
                    }
                    ExecuteQueryIf(true, q =>
                    {
                        var result = q.InserisciPrenotazione(ClienteCF.Text, TourID.Text);
                        if (!result)
                        {
                            MessageBox.Show("Errore nella prenotazione",
                            "Errore",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        } else
                        {
                            MessageBox.Show("Tour prenotato correttamente",
                               "Info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        }
                    });
                    //Console.WriteLine("completato?");
                    return;
                }
            }
        }

        private void CloseProgram(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Registrazione_Cliente_Click(object sender, EventArgs e)
        {
            bool condition = this.cliente_nome && this.cliente_cognome && this.cliente_CF && this.cliente_telefono;
            ExecuteQueryIf(condition, q =>
            {
                var result = q.InserisciCliente(
                                 this.Clienti_Nome.Text,
                                 this.Clienti_Cognome.Text,
                                 this.Clienti_CF.Text,
                                 this.Clienti_Telefono.Text);
                if (result)
                {
                    MessageBox.Show("Cliente inserito correttamente",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente non inserito",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            });
        }

        private void Clienti_Nome_Enter(object sender, EventArgs e)
        {
            if (this.Clienti_Nome.Text.Equals("Nome"))
            {
                this.Clienti_Nome.Text = "";
            }
            this.Clienti_Nome.ForeColor = Color.Black;
            this.cliente_nome = true;
        }

        private void Clienti_Nome_Leave(object sender, EventArgs e)
        {
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.cliente_nome = false;
            }
        }

        private void Clienti_Cognome_Enter(object sender, EventArgs e)
        {
            if (this.Clienti_Cognome.Text.Equals("Cognome"))
            {
                this.Clienti_Cognome.Text = "";
            }
            this.Clienti_Cognome.ForeColor = Color.Black;
            this.cliente_cognome = true;
        }

        private void Clienti_Cognome_Leave(object sender, EventArgs e)
        {
            if (this.Clienti_Cognome.Text.Equals(""))
            {
                this.Clienti_Cognome.Text = "Cognome";
                this.Clienti_Cognome.ForeColor = Color.Gray;
                this.cliente_cognome = false;
            }
        }

        private void Clienti_CF_Enter(object sender, EventArgs e)
        {
            if (this.Clienti_CF.Text.Equals("Codice Fiscale"))
            {
                this.Clienti_CF.Text = "";
            }
            this.Clienti_CF.ForeColor = Color.Black;
            this.cliente_CF = true;
        }

        private void Clienti_CF_Leave(object sender, EventArgs e)
        {
            if (this.Clienti_CF.Text.Equals(""))
            {
                this.Clienti_CF.Text = "Codice Fiscale";
                this.Clienti_CF.ForeColor = Color.Gray;
                this.cliente_CF = false;
            }
        }

        private void Clienti_Telefono_Enter(object sender, EventArgs e)
        {
            if (this.Clienti_Telefono.Text.Equals("Numero di Telefono"))
            {
                this.Clienti_Telefono.Text = "";
            }
            this.Clienti_Telefono.ForeColor = Color.Black;
            this.cliente_telefono = true;
        }

        private void Clienti_Telefono_Leave(object sender, EventArgs e)
        {
            if (this.Clienti_Telefono.Text.Equals(""))
            {
                this.Clienti_Telefono.Text = "Numero di Telefono";
                this.Clienti_Telefono.ForeColor = Color.Gray;
                this.cliente_telefono = false;
            }
        }

        private void TourID_Enter(object sender, EventArgs e)
        {
            if (this.TourID.Text.Equals("ID Tour"))
            {
                this.TourID.Text = "";
            }
            this.TourID.ForeColor = Color.Black;
            this.tour_id = true;
        }

        private void TourID_Leave(object sender, EventArgs e)
        {
            if (this.TourID.Text.Equals(""))
            {
                this.TourID.Text = "ID Tour";
                this.TourID.ForeColor = Color.Gray;
                this.tour_id = false;
            }
        }
    }
}
