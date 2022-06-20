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
    public partial class DatabaseViewAdmin : Form
    {
        bool IsAdmin { get; }
        string PIVAagenzia { get; }
        string IDsede { get; }
        bool nome;
        bool cognome;
        bool CF;
        bool telefono;
        public DatabaseViewAdmin(bool isAdmin, string PIVAagenzia, string IDsede)
        {
            this.IsAdmin = isAdmin;
            this.PIVAagenzia = PIVAagenzia;
            this.IDsede = IDsede;
            InitializeComponent();
        }

        private void DatabaseViewAdmin_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'gestionale_per_agenzie_relDataSet3.magazzino' table. You can move, or remove it, as needed.
            //this.magazzinoTableAdapter.Fill(this.gestionale_per_agenzie_relDataSet3.magazzino);
            // TODO: This line of code loads data into the 'gestionale_per_agenzie_relDataSet2.dipendente' table. You can move, or remove it, as needed.
            //this.dipendenteTableAdapter.Fill(this.gestionale_per_agenzie_relDataSet2.dipendente);

            var connection = new CreateConnection();
            var queries = new QueryLibrary(connection.Connection);

            FillTable(TabellaClienti, queries.LeggiClienti().CommandText, connection.Connection);
            FillTable(TabellaPrenotazioni, queries.LeggiPrenotazioni().CommandText, connection.Connection);
            FillTable(TabellaMagazzini, queries.LeggiMagazzini(this.IDsede).CommandText, connection.Connection);
            FillTable(TabellaPercorsi, queries.LeggiPercorso(this.IDsede).CommandText, connection.Connection);
            FillTable(TabellaBusinessPartners, queries.LeggiBusinessPartner(this.PIVAagenzia).CommandText, connection.Connection);
            FillTable(TabellaDipendenti, queries.LeggiDipendenti(this.IDsede).CommandText, connection.Connection);
            FillTable(TabellaTour, queries.LeggiTour(this.IDsede).CommandText, connection.Connection);

            this.Nome.ForeColor = Color.Gray;
            this.Cognome.ForeColor = Color.Gray;
            this.CodiceFiscale.ForeColor = Color.Gray;
            this.Telefono.ForeColor = Color.Gray;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var s = new SelezioneSede(this.IsAdmin);
            s.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            this.DatabaseViewAdmin_Load(sender, e);
            TabellaClienti.Update();
            TabellaClienti.Refresh();
            TabellaPrenotazioni.Update();
            TabellaPrenotazioni.Refresh();
            TabellaMagazzini.Update();
            TabellaMagazzini.Refresh();
            TabellaPercorsi.Update();
            TabellaPercorsi.Refresh();
            TabellaBusinessPartners.Update();
            TabellaBusinessPartners.Refresh();
            TabellaDipendenti.Update();
            TabellaDipendenti.Refresh();
            TabellaTour.Update();
            TabellaTour.Refresh();
        }

        private void AggiungiCliente_Click(object sender, EventArgs e)
        {
            if (this.nome && this.cognome && this.CF && this.telefono)
            {
                var connection = new CreateConnection();
                var queries = new QueryLibrary(connection.Connection);

                try
                {
                    var result = queries.InserisciCliente(this.Nome.Text, this.Cognome.Text, this.CodiceFiscale.Text, this.Telefono.Text);
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
                }
                catch (Exception) { }
            }
            else
            {
                MessageBox.Show("Si prega di completare tutti i campi",
                "Attenzione",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void Nome_Enter(object sender, EventArgs e)
        {
            if (this.Nome.Text.Equals("Nome"))
            {
                this.Nome.Text = "";
            }
            this.Nome.ForeColor = Color.Black;
            this.nome = true;
        }

        private void Nome_Leave(object sender, EventArgs e)
        {
            if (this.Nome.Text.Equals(""))
            {
                this.Nome.Text = "Nome";
                this.Nome.ForeColor = Color.Gray;
                this.nome = false;
            }
        }

        private void Cognome_Enter(object sender, EventArgs e)
        {
            if (this.Cognome.Text.Equals("Cognome"))
            {
                this.Cognome.Text = "";
            }
            this.Cognome.ForeColor = Color.Black;
            this.cognome = true;
        }

        private void Cognome_Leave(object sender, EventArgs e)
        {
            if (this.Cognome.Text.Equals(""))
            {
                this.Cognome.Text = "Cognome";
                this.Cognome.ForeColor = Color.Gray;
                this.cognome = false;
            }
        }

        private void CodiceFiscale_Enter(object sender, EventArgs e)
        {
            if (this.CodiceFiscale.Text.Equals("Codice Fiscale"))
            {
                this.CodiceFiscale.Text = "";
            }
            this.CodiceFiscale.ForeColor = Color.Black;
            this.CF = true;
        }

        private void CodiceFiscale_Leave(object sender, EventArgs e)
        {
            if (this.CodiceFiscale.Text.Equals(""))
            {
                this.CodiceFiscale.Text = "Codice Fiscale";
                this.CodiceFiscale.ForeColor = Color.Gray;
                this.CF = false;
            }
        }

        private void Telefono_Enter(object sender, EventArgs e)
        {
            if (this.Telefono.Text.Equals("Numero di Telefono"))
            {
                this.Telefono.Text = "";
            }
            this.Telefono.ForeColor = Color.Black;
            this.telefono = true;
        }

        private void Telefono_Leave(object sender, EventArgs e)
        {
            if (this.Telefono.Text.Equals(""))
            {
                this.Telefono.Text = "Numero di Telefono";
                this.Telefono.ForeColor = Color.Gray;
                this.telefono = false;
            }
        }
    }
}
