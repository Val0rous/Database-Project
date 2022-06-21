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
        bool cliente_nome;
        bool cliente_cognome;
        bool cliente_CF;
        bool cliente_telefono;

        bool prenotazione_CF;
        bool prenotazione_IDtour;

        bool magazzino_capMaxAccessori;
        bool magazzino_capMaxBici;
        bool magazzino_IDmagazzino;
        bool magazzino_IDindirizzo;
        bool magazzino_IDsede;

        bool percorso_IDpercorso;
        bool percorso_difficolta;
        bool percorso_nome;
        bool percorso_numTappe;
        bool percorso_lunghezzaPercorso;
        bool percorso_IDsede;

        bool nuovatappa_inizio;
        bool nuovatappa_fine;
        bool nuovatappa_lunghezza;
        bool nuovatappa_IDtappa;
        bool nuovatappa_IDpercorso;

        bool bp_PIVA;
        bool bp_nomeSocio;
        bool bp_costoServizio;
        bool bp_telefono;
        bool bp_tipologia;

        bool dipendente_nome;
        bool dipendente_cognome;
        bool dipendente_CF;
        bool dipendente_telefono;
        bool dipendente_codiceDipendente;
        bool dipendente_stipendio;
        bool dipendente_ruolo;
        bool dipendente_IDsede;

        bool tour_destinazione;
        bool tour_nome;
        bool tour_dataInizio;
        bool tour_dataFine;
        bool tour_prezzo;
        bool tour_IDtour;
        bool tour_IDsede;
        bool tour_CFtourManager;

        bool tappa_inizio;
        bool tappa_fine;
        bool tappa_lunghezzaTappa;
        bool tappa_ID;
        bool tappa_IDPercorso;

        bool servizi_DataInizio;
        bool servizi_DataFine;

        public DatabaseViewAdmin(bool isAdmin, string PIVAagenzia, string IDsede)
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
                catch (Exception e) { Console.WriteLine(e.StackTrace); }
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
        private void DatabaseViewAdmin_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'gestionale_per_agenzie_relDataSet3.magazzino' table. You can move, or remove it, as needed.
            //this.magazzinoTableAdapter.Fill(this.gestionale_per_agenzie_relDataSet3.magazzino);
            // TODO: This line of code loads data into the 'gestionale_per_agenzie_relDataSet2.dipendente' table. You can move, or remove it, as needed.
            //this.dipendenteTableAdapter.Fill(this.gestionale_per_agenzie_relDataSet2.dipendente);

            var connection = new CreateConnection();
            connection.Connection.Open();
            var queries = new QueryLibrary(connection.Connection);

            FillTable(TabellaClienti, queries.LeggiClienti().CommandText, connection.Connection);
            FillTable(TabellaPrenotazioni, queries.LeggiPrenotazioni().CommandText, connection.Connection);
            FillTable(TabellaMagazzini, queries.LeggiMagazzini(this.IDsede).CommandText, connection.Connection);
            FillTable(TabellaPercorsi, queries.LeggiPercorso(this.IDsede).CommandText, connection.Connection);
            FillTable(TabellaBusinessPartners, queries.LeggiBusinessPartner(this.PIVAagenzia).CommandText, connection.Connection);
            FillTable(TabellaDipendenti, queries.LeggiDipendenti(this.IDsede).CommandText, connection.Connection);
            FillTable(TabellaTour, queries.LeggiTour(this.IDsede).CommandText, connection.Connection);
            FillTable(TabellaServizi, queries.LeggiServiziSede(this.IDsede).CommandText, connection.Connection);

            connection.Connection.Close();

            this.Clienti_Nome.ForeColor = Color.Gray;
            this.Clienti_Cognome.ForeColor = Color.Gray;
            this.Clienti_CF.ForeColor = Color.Gray;
            this.Clienti_Telefono.ForeColor = Color.Gray;

            this.Prenotazioni_CFcliente.ForeColor = Color.Gray;
            this.Prenotazioni_IDtour.ForeColor = Color.Gray;

            this.Magazzini_CapMaxAccessori.ForeColor = Color.Gray;
            this.Magazzini_CapMaxBici.ForeColor = Color.Gray;
            this.Magazzini_IDmagazzino.ForeColor = Color.Gray;
            this.Magazzini_IDindirizzo.ForeColor = Color.Gray;
            this.Magazzini_IDsede.ForeColor = Color.Gray;

            this.Percorsi_IDpercorso.ForeColor = Color.Gray;
            this.Percorsi_Difficolta.ForeColor = Color.Gray;
            this.Percorsi_NomePercorso.ForeColor = Color.Gray;
            this.Percorsi_NumTappe.ForeColor = Color.Gray;
            this.Percorsi_LunghezzaPercorso.ForeColor = Color.Gray;
            this.Percorsi_IDsede.ForeColor = Color.Gray;

            this.NuovaTappa_Inizio.ForeColor = Color.Gray;
            this.NuovaTappa_Fine.ForeColor = Color.Gray;
            this.NuovaTappa_Lunghezza.ForeColor = Color.Gray;
            this.NuovaTappa_IDtappa.ForeColor = Color.Gray;
            this.NuovaTappa_IDpercorso.ForeColor = Color.Gray;

            /*
            this.BP_PIVA.ForeColor = Color.Gray;
            this.BP_NomeSocio.ForeColor = Color.Gray;
            this.BP_CostoServizio.ForeColor = Color.Gray;
            this.BP_Telefono.ForeColor = Color.Gray;
            this.BP_Tipologia.ForeColor = Color.Gray;
            */

            this.Dipendenti_Nome.ForeColor = Color.Gray;
            this.Dipendenti_Cognome.ForeColor = Color.Gray;
            this.Dipendenti_CF.ForeColor = Color.Gray;
            this.Dipendenti_Telefono.ForeColor = Color.Gray;
            this.Dipendenti_CodiceDipendente.ForeColor = Color.Gray;
            this.Dipendenti_Stipendio.ForeColor = Color.Gray;
            this.Dipendenti_IDsede.ForeColor = Color.Gray;
            this.Dipendenti_CFsuperiore.ForeColor = Color.Gray;

            /*
            this.Tour_Destinazione.ForeColor = Color.Gray;
            this.Tour_Nome.ForeColor = Color.Gray;
            this.Tour_DataInizio.ForeColor = Color.Gray;
            this.Tour_DataFine.ForeColor = Color.Gray;
            this.Tour_Prezzo.ForeColor = Color.Gray;
            this.Tour_IDtour.ForeColor = Color.Gray;
            this.Tour_IDsede.ForeColor = Color.Gray;
            this.Tour_CFtourManager.ForeColor = Color.Gray;
            */

            this.ThisSedeID.Text = "ID Sede: " + this.IDsede;
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

            //this.Tour_ID.Text = queries.GetNextID("tour", "IDtour");
        }
        private void TabPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connection = new CreateConnection();
            connection.Connection.Open();
            var queries = new QueryLibrary(connection.Connection);

            if (this.TabPage.SelectedTab.Text == "Tour")
            {
                TabellaTour.Update();
                TabellaTour.Refresh();
                this.Tour_ID.Text = queries.GetNextID("tour", "IDtour");
            }
        }

        private void AggiungiCliente_Click(object sender, EventArgs e)
        {
            /*if (this.cliente_nome 
                && this.cliente_cognome 
                && this.cliente_CF 
                && this.cliente_telefono)
            {
                var connection = new CreateConnection();
                connection.Connection.Open();
                var queries = new QueryLibrary(connection.Connection);

                try
                {
                    var result = queries.InserisciCliente(
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
            */
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

        private void Nome_Enter(object sender, EventArgs e)
        {
            if (this.Clienti_Nome.Text.Equals("Nome"))
            {
                this.Clienti_Nome.Text = "";
            }
            this.Clienti_Nome.ForeColor = Color.Black;
            this.cliente_nome = true;
        }

        private void Nome_Leave(object sender, EventArgs e)
        {
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.cliente_nome = false;
            }
        }

        private void Cognome_Enter(object sender, EventArgs e)
        {
            if (this.Clienti_Cognome.Text.Equals("Cognome"))
            {
                this.Clienti_Cognome.Text = "";
            }
            this.Clienti_Cognome.ForeColor = Color.Black;
            this.cliente_cognome = true;
        }

        private void Cognome_Leave(object sender, EventArgs e)
        {
            if (this.Clienti_Cognome.Text.Equals(""))
            {
                this.Clienti_Cognome.Text = "Cognome";
                this.Clienti_Cognome.ForeColor = Color.Gray;
                this.cliente_cognome = false;
            }
        }

        private void CodiceFiscale_Enter(object sender, EventArgs e)
        {
            if (this.Clienti_CF.Text.Equals("Codice Fiscale"))
            {
                this.Clienti_CF.Text = "";
            }
            this.Clienti_CF.ForeColor = Color.Black;
            this.cliente_CF = true;
        }

        private void CodiceFiscale_Leave(object sender, EventArgs e)
        {
            if (this.Clienti_CF.Text.Equals(""))
            {
                this.Clienti_CF.Text = "Codice Fiscale";
                this.Clienti_CF.ForeColor = Color.Gray;
                this.cliente_CF = false;
            }
        }

        private void Telefono_Enter(object sender, EventArgs e)
        {
            if (this.Clienti_Telefono.Text.Equals("Numero di Telefono"))
            {
                this.Clienti_Telefono.Text = "";
            }
            this.Clienti_Telefono.ForeColor = Color.Black;
            this.cliente_telefono = true;
        }

        private void Telefono_Leave(object sender, EventArgs e)
        {
            if (this.Clienti_Telefono.Text.Equals(""))
            {
                this.Clienti_Telefono.Text = "Numero di Telefono";
                this.Clienti_Telefono.ForeColor = Color.Gray;
                this.cliente_telefono = false;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Percorsi_Click(object sender, EventArgs e)
        {

        }

        private void Prenotazioni_CFcliente_Enter(object sender, EventArgs e)
        {
            if (this.Prenotazioni_CFcliente.Text.Equals("Codice Fiscale Cliente"))
            {
                this.Prenotazioni_CFcliente.Text = "";
            }
            this.Prenotazioni_CFcliente.ForeColor = Color.Black;
            this.prenotazione_CF = true;
        }

        private void Prenotazioni_CFcliente_Leave(object sender, EventArgs e)
        {
            if (this.Prenotazioni_CFcliente.Text.Equals(""))
            {
                this.Prenotazioni_CFcliente.Text = "Codice Fiscale Cliente";
                this.Prenotazioni_CFcliente.ForeColor = Color.Gray;
                this.prenotazione_CF = false;
            }
        }

        private void Prenotazioni_IDtour_Enter(object sender, EventArgs e)
        {
            if (this.Prenotazioni_IDtour.Text.Equals("ID Tour"))
            {
                this.Prenotazioni_IDtour.Text = "";
            }
            this.Prenotazioni_IDtour.ForeColor = Color.Black;
            this.prenotazione_IDtour= true;
        }

        private void Prenotazioni_IDtour_Leave(object sender, EventArgs e)
        {
            if (this.Prenotazioni_IDtour.Text.Equals(""))
            {
                this.Prenotazioni_IDtour.Text = "ID Tour";
                this.Prenotazioni_IDtour.ForeColor = Color.Gray;
                this.prenotazione_IDtour = false;
            }
        }

        private void AggiungiPrenotazione_Click(object sender, EventArgs e)
        {
            /*if (this.prenotazione_CF && this.prenotazione_IDtour)
            {
                var connection = new CreateConnection();
                connection.Connection.Open();
                var queries = new QueryLibrary(connection.Connection);

                try
                {
                    var result = queries.InserisciPrenotazione(
                        this.Prenotazioni_CFcliente.Text, 
                        this.Prenotazioni_IDtour.Text);
                    if (result)
                    {
                        MessageBox.Show("Prenotazione inserita correttamente",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Prenotazione non inserita",
                        "Errore",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
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
            }*/
            bool condition = this.prenotazione_CF && this.prenotazione_IDtour;
            ExecuteQueryIf(condition, q => {
                var result = q.InserisciPrenotazione(
                        this.Prenotazioni_CFcliente.Text,
                        this.Prenotazioni_IDtour.Text);
                if (result)
                {
                    MessageBox.Show("Prenotazione inserita correttamente",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Prenotazione non inserita",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            });
        }

        private void Magazzini_CapMaxAccessori_Enter(object sender, EventArgs e)
        {
            if (this.Magazzini_CapMaxAccessori.Text.Equals("Capienza Max Accessori"))
            {
                this.Magazzini_CapMaxAccessori.Text = "";
            }
            this.Magazzini_CapMaxAccessori.ForeColor = Color.Black;
            this.magazzino_capMaxAccessori = true;
        }

        private void Magazzini_CapMaxAccessori_Leave(object sender, EventArgs e)
        {
            if (this.Magazzini_CapMaxAccessori.Text.Equals(""))
            {
                this.Magazzini_CapMaxAccessori.Text = "Capienza Max Accessori";
                this.Magazzini_CapMaxAccessori.ForeColor = Color.Gray;
                this.magazzino_capMaxAccessori = false;
            }
        }

        private void Magazzini_CapMaxBici_Enter(object sender, EventArgs e)
        {
            if (this.Magazzini_CapMaxBici.Text.Equals("Capienza Max Bici"))
            {
                this.Magazzini_CapMaxBici.Text = "";
            }
            this.Magazzini_CapMaxBici.ForeColor = Color.Black;
            this.magazzino_capMaxBici = true;
        }

        private void Magazzini_CapMaxBici_Leave(object sender, EventArgs e)
        {
            if (this.Magazzini_CapMaxBici.Text.Equals(""))
            {
                this.Magazzini_CapMaxBici.Text = "Capienza Max Bici";
                this.Magazzini_CapMaxBici.ForeColor = Color.Gray;
                this.magazzino_capMaxBici = false;
            }
        }

        private void Magazzini_IDmagazzino_Enter(object sender, EventArgs e)
        {
            if (this.Magazzini_IDmagazzino.Text.Equals("ID Magazzino"))
            {
                this.Magazzini_IDmagazzino.Text = "";
            }
            this.Magazzini_IDmagazzino.ForeColor = Color.Black;
            this.magazzino_IDmagazzino = true;
        }

        private void Magazzini_IDmagazzino_Leave(object sender, EventArgs e)
        {
            if (this.Magazzini_IDmagazzino.Text.Equals(""))
            {
                this.Magazzini_IDmagazzino.Text = "ID Magazzino";
                this.Magazzini_IDmagazzino.ForeColor = Color.Gray;
                this.magazzino_IDmagazzino = false;
            }
        }

        private void Magazzini_IDindirizzo_Enter(object sender, EventArgs e)
        {
            if (this.Magazzini_IDindirizzo.Text.Equals("ID Indirizzo"))
            {
                this.Magazzini_IDindirizzo.Text = "";
            }
            this.Magazzini_IDindirizzo.ForeColor = Color.Black;
            this.magazzino_IDindirizzo = true;
        }

        private void Magazzini_IDindirizzo_Leave(object sender, EventArgs e)
        {
            if (this.Magazzini_IDindirizzo.Text.Equals(""))
            {
                this.Magazzini_IDindirizzo.Text = "ID Indirizzo";
                this.Magazzini_IDindirizzo.ForeColor = Color.Gray;
                this.magazzino_IDindirizzo = false;
            }
        }

        private void Magazzini_IDsede_Enter(object sender, EventArgs e)
        {
            if (this.Magazzini_IDsede.Text.Equals("ID Sede"))
            {
                this.Magazzini_IDsede.Text = "";
            }
            this.Magazzini_IDsede.ForeColor = Color.Black;
            this.magazzino_IDsede = true;
        }

        private void Magazzini_IDsede_Leave(object sender, EventArgs e)
        {
            if (this.Magazzini_IDsede.Text.Equals(""))
            {
                this.Magazzini_IDsede.Text = "ID Sede";
                this.Magazzini_IDsede.ForeColor = Color.Gray;
                this.magazzino_IDsede = false;
            }
        }

        private void AggiungiMagazzino_Click(object sender, EventArgs e)
        {
            /*if (this.magazzino_capMaxAccessori && this.magazzino_capMaxBici && this.magazzino_IDmagazzino && this.magazzino_IDindirizzo && this.magazzino_IDsede)
            {
                var connection = new CreateConnection();
                connection.Connection.Open();
                var queries = new QueryLibrary(connection.Connection);

                try
                {
                    var result = queries.InserisciMagazzino(
                        int.Parse(this.Magazzini_CapMaxAccessori.Text), 
                        int.Parse(this.Magazzini_CapMaxBici.Text), 
                        this.Magazzini_IDmagazzino.Text, 
                        this.Magazzini_IDindirizzo.Text, 
                        this.Magazzini_IDsede.Text);
                    if (result)
                    {
                        MessageBox.Show("Magazzino inserito correttamente",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Magazzino non inserito",
                        "Errore",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
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
            }*/
            bool condition = this.magazzino_capMaxAccessori && this.magazzino_capMaxBici && this.magazzino_IDmagazzino && this.magazzino_IDindirizzo && this.magazzino_IDsede;
            ExecuteQueryIf(condition, q => {
                var result = q.InserisciMagazzino(
                        int.Parse(this.Magazzini_CapMaxAccessori.Text),
                        int.Parse(this.Magazzini_CapMaxBici.Text),
                        this.Magazzini_IDmagazzino.Text,
                        this.Magazzini_IDindirizzo.Text,
                        this.Magazzini_IDsede.Text);
                if (result)
                {
                    MessageBox.Show("Magazzino inserito correttamente",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Magazzino non inserito",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            });
        }

        private void Percorsi_IDpercorso_Enter(object sender, EventArgs e)
        {
            if (this.Percorsi_IDpercorso.Text.Equals("ID Percorso"))
            {
                this.Percorsi_IDpercorso.Text = "";
            }
            this.Percorsi_IDpercorso.ForeColor = Color.Black;
            this.percorso_IDpercorso = true;
        }

        private void Percorsi_IDpercorso_Leave(object sender, EventArgs e)
        {
            if (this.Percorsi_IDpercorso.Text.Equals(""))
            {
                this.Percorsi_IDpercorso.Text = "ID Percorso";
                this.Percorsi_IDpercorso.ForeColor = Color.Gray;
                this.percorso_IDpercorso = false;
            }
        }

        private void Percorsi_Difficolta_Enter(object sender, EventArgs e)
        {
            if (this.Percorsi_Difficolta.Text.Equals("Difficoltà"))
            {
                this.Percorsi_Difficolta.Text = "";
            }
            this.Percorsi_Difficolta.ForeColor = Color.Black;
            this.percorso_difficolta = true;
        }

        private void Percorsi_Difficolta_Leave(object sender, EventArgs e)
        {
            if (this.Percorsi_Difficolta.Text.Equals(""))
            {
                this.Percorsi_Difficolta.Text = "Difficoltà";
                this.Percorsi_Difficolta.ForeColor = Color.Gray;
                this.percorso_difficolta = false;
            }
        }

        private void Percorsi_NomePercorso_Enter(object sender, EventArgs e)
        {
            if (this.Percorsi_NomePercorso.Text.Equals("Nome"))
            {
                this.Percorsi_NomePercorso.Text = "";
            }
            this.Percorsi_NomePercorso.ForeColor = Color.Black;
            this.percorso_nome = true;
        }

        private void Percorsi_NomePercorso_Leave(object sender, EventArgs e)
        {
            if (this.Percorsi_NomePercorso.Text.Equals(""))
            {
                this.Percorsi_NomePercorso.Text = "Nome";
                this.Percorsi_NomePercorso.ForeColor = Color.Gray;
                this.percorso_nome = false;
            }
        }

        private void Percorsi_NumTappe_Enter(object sender, EventArgs e)
        {
            if (this.Percorsi_NumTappe.Text.Equals("Numero di tappe"))
            {
                this.Percorsi_NumTappe.Text = "";
            }
            this.Percorsi_NumTappe.ForeColor = Color.Black;
            this.percorso_numTappe = true;
        }

        private void Percorsi_NumTappe_Leave(object sender, EventArgs e)
        {
            if (this.Percorsi_NumTappe.Text.Equals(""))
            {
                this.Percorsi_NumTappe.Text = "Numero di Tappe";
                this.Percorsi_NumTappe.ForeColor = Color.Gray;
                this.percorso_numTappe = false;
            }
        }

        private void Percorsi_LunghezzaPercorso_Enter(object sender, EventArgs e)
        {
            if (this.Percorsi_LunghezzaPercorso.Text.Equals("Lunghezza Percorso"))
            {
                this.Percorsi_LunghezzaPercorso.Text = "";
            }
            this.Percorsi_LunghezzaPercorso.ForeColor = Color.Black;
            this.percorso_lunghezzaPercorso = true;
        }

        private void Percorsi_LunghezzaPercorso_Leave(object sender, EventArgs e)
        {
            if (this.Percorsi_LunghezzaPercorso.Text.Equals(""))
            {
                this.Percorsi_LunghezzaPercorso.Text = "Lunghezza Percorso";
                this.Percorsi_LunghezzaPercorso.ForeColor = Color.Gray;
                this.percorso_lunghezzaPercorso = false;
            }
        }

        private void Percorsi_IDsede_Enter(object sender, EventArgs e)
        {
            if (this.Percorsi_IDsede.Text.Equals("ID sede"))
            {
                this.Percorsi_IDsede.Text = "";
            }
            this.Percorsi_IDsede.ForeColor = Color.Black;
            this.percorso_IDsede = true;
        }

        private void Percorsi_IDsede_Leave(object sender, EventArgs e)
        {
            if (this.Percorsi_IDsede.Text.Equals(""))
            {
                this.Percorsi_IDsede.Text = "ID Sede";
                this.Percorsi_IDsede.ForeColor = Color.Gray;
                this.percorso_IDsede = false;
            }
        }

        private void AggiungiPercorso_Click(object sender, EventArgs e)
        {
            /*if (this.percorso_IDpercorso 
                && this.percorso_difficolta 
                && this.percorso_nome 
                && this.percorso_numTappe
                && this.percorso_lunghezzaPercorso
                && this.percorso_IDsede)
            {
                var connection = new CreateConnection();
                connection.Connection.Open();
                var queries = new QueryLibrary(connection.Connection);

                try
                {
                    var result = queries.InserisciPercorso(
                        this.Percorsi_IDpercorso.Text,
                        this.Percorsi_Difficolta.Text,
                        int.Parse(this.Percorsi_NumTappe.Text),
                        float.Parse(this.Percorsi_LunghezzaPercorso.Text),
                        this.Percorsi_IDsede.Text);
                    if (result)
                    {
                        MessageBox.Show("Percorso inserito correttamente",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Percorso non inserito",
                        "Errore",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
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
            }*/
            bool condition = this.percorso_IDpercorso && this.percorso_difficolta && this.percorso_nome && this.percorso_numTappe && this.percorso_lunghezzaPercorso && this.percorso_IDsede;
            ExecuteQueryIf(condition, q => {
                var result = q.InserisciPercorso(
                        this.Percorsi_IDpercorso.Text,
                        this.Percorsi_Difficolta.Text,
                        int.Parse(this.Percorsi_NumTappe.Text),
                        float.Parse(this.Percorsi_LunghezzaPercorso.Text),
                        this.Percorsi_IDsede.Text);
                if (result)
                {
                    MessageBox.Show("Percorso inserito correttamente",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Percorso non inserito",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            });
        }

        private void BP_PIVA_Enter(object sender, EventArgs e)
        {
            if (this.BP_PIVA.Text.Equals("Partita IVA"))
            {
                this.BP_PIVA.Text = "";
            }
            this.BP_PIVA.ForeColor = Color.Black;
            this.bp_PIVA = true;
        }

        private void BP_PIVA_Leave(object sender, EventArgs e)
        {
            if (this.BP_PIVA.Text.Equals(""))
            {
                this.BP_PIVA.Text = "Partita IVA";
                this.BP_PIVA.ForeColor = Color.Gray;
                this.bp_PIVA = false;
            }
        }

        private void BP_NomeSocio_Enter(object sender, EventArgs e)
        {
            if (this.BP_NomeSocio.Text.Equals("Nome Socio"))
            {
                this.BP_NomeSocio.Text = "";
            }
            this.BP_NomeSocio.ForeColor = Color.Black;
            this.bp_nomeSocio = true;
        }

        private void BP_NomeSocio_Leave(object sender, EventArgs e)
        {
            if (this.BP_NomeSocio.Text.Equals(""))
            {
                this.BP_NomeSocio.Text = "Nome Socio";
                this.BP_NomeSocio.ForeColor = Color.Gray;
                this.bp_nomeSocio = false;
            }
        }

        private void BP_CostoServizio_Enter(object sender, EventArgs e)
        {
            if (this.BP_CostoServizio.Text.Equals("Costo Servizio"))
            {
                this.BP_CostoServizio.Text = "";
            }
            this.BP_CostoServizio.ForeColor = Color.Black;
            this.bp_costoServizio = true;
        }

        private void BP_CostoServizio_Leave(object sender, EventArgs e)
        {
            if (this.BP_CostoServizio.Text.Equals(""))
            {
                this.BP_CostoServizio.Text = "Nome";
                this.BP_CostoServizio.ForeColor = Color.Gray;
                this.bp_costoServizio = false;
            }
        }

        private void BP_Telefono_Enter(object sender, EventArgs e)
        {
            if (this.BP_Telefono.Text.Equals("Numero di Telefono"))
            {
                this.BP_Telefono.Text = "";
            }
            this.BP_Telefono.ForeColor = Color.Black;
            this.bp_telefono = true;
        }

        private void BP_Telefono_Leave(object sender, EventArgs e)
        {
            if (this.BP_Telefono.Text.Equals(""))
            {
                this.BP_Telefono.Text = "Numero di Telefono";
                this.BP_Telefono.ForeColor = Color.Gray;
                this.bp_telefono = false;
            }
        }

        private void BP_Tipologia_Enter(object sender, EventArgs e)
        {
            if (this.BP_Tipologia.Text.Equals("Tipologia"))
            {
                this.BP_Tipologia.Text = "";
            }
            this.BP_Tipologia.ForeColor = Color.Black;
            this.bp_tipologia = true;
        }

        private void BP_Tipologia_Leave(object sender, EventArgs e)
        {
            if (this.BP_Tipologia.Text.Equals(""))
            {
                this.BP_Tipologia.Text = "Tipologia";
                this.BP_Tipologia.ForeColor = Color.Gray;
                this.bp_tipologia = false;
            }
        }

        private void AggiungiBusinessPartner_Click(object sender, EventArgs e)
        {
            if (this.bp_PIVA && this.bp_nomeSocio && this.bp_costoServizio && this.bp_telefono && this.bp_tipologia)
            {
                var connection = new CreateConnection();
                connection.Connection.Open();
                var queries = new QueryLibrary(connection.Connection);

                try
                {
                    var result = queries.InserisciBusinessPartner(this.BP_PIVA.Text, this.BP_NomeSocio.Text, int.Parse(this.BP_CostoServizio.Text), float.Parse(this.BP_Telefono.Text), this.BP_Tipologia.Text);
                    if (result)
                    {
                        MessageBox.Show("BP inserito correttamente",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("BP non inserito",
                        "Errore",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
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

        private void Dipendenti_Nome_Enter(object sender, EventArgs e)
        {
            if (this.Dipendenti_Nome.Text.Equals("Nome"))
            {
                this.Dipendenti_Nome.Text = "";
            }
            this.Dipendenti_Nome.ForeColor = Color.Black;
            this.dipendente_nome = true;
        }

        private void Dipendenti_Nome_Leave(object sender, EventArgs e)
        {
            if (this.Dipendenti_Nome.Text.Equals(""))
            {
                this.Dipendenti_Nome.Text = "Nome";
                this.Dipendenti_Nome.ForeColor = Color.Gray;
                this.dipendente_nome = false;
            }
        }

        private void Dipendenti_Cognome_Enter(object sender, EventArgs e)
        {
            if (this.Dipendenti_Cognome.Text.Equals("Cognome"))
            {
                this.Dipendenti_Cognome.Text = "";
            }
            this.Dipendenti_Cognome.ForeColor = Color.Black;
            this.dipendente_cognome = true;
        }

        private void Dipendenti_Cognome_Leave(object sender, EventArgs e)
        {
            if (this.Dipendenti_Cognome.Text.Equals(""))
            {
                this.Dipendenti_Cognome.Text = "Cognome";
                this.Dipendenti_Cognome.ForeColor = Color.Gray;
                this.dipendente_cognome = false;
            }
        }

        private void Dipendenti_CF_Enter(object sender, EventArgs e)
        {
            if (this.Dipendenti_CF.Text.Equals("Codice Fiscale"))
            {
                this.Dipendenti_CF.Text = "";
            }
            this.Dipendenti_CF.ForeColor = Color.Black;
            this.dipendente_CF = true;
        }

        private void Dipendenti_CF_Leave(object sender, EventArgs e)
        {
            if (this.Dipendenti_CF.Text.Equals(""))
            {
                this.Dipendenti_CF.Text = "Codice Fiscale";
                this.Dipendenti_CF.ForeColor = Color.Gray;
                this.dipendente_CF = false;
            }
        }

        private void Dipendenti_Telefono_Enter(object sender, EventArgs e)
        {
            if (this.Dipendenti_Telefono.Text.Equals("Numero di Telefono"))
            {
                this.Dipendenti_Telefono.Text = "";
            }
            this.Dipendenti_Telefono.ForeColor = Color.Black;
            this.dipendente_telefono = true;
        }

        private void Dipendenti_Telefono_Leave(object sender, EventArgs e)
        {
            if (this.Dipendenti_Telefono.Text.Equals(""))
            {
                this.Dipendenti_Telefono.Text = "Numero di Telefono";
                this.Dipendenti_Telefono.ForeColor = Color.Gray;
                this.dipendente_telefono = false;
            }
        }

        private void Dipendenti_CodiceDipendente_Enter(object sender, EventArgs e)
        {
            if (this.Dipendenti_CodiceDipendente.Text.Equals("Codice Dipendente"))
            {
                this.Dipendenti_CodiceDipendente.Text = "";
            }
            this.Dipendenti_CodiceDipendente.ForeColor = Color.Black;
            this.dipendente_codiceDipendente = true;
        }

        private void Dipendenti_CodiceDipendente_Leave(object sender, EventArgs e)
        {
            if (this.Dipendenti_CodiceDipendente.Text.Equals(""))
            {
                this.Dipendenti_CodiceDipendente.Text = "Codice Dipendente";
                this.Dipendenti_CodiceDipendente.ForeColor = Color.Gray;
                this.dipendente_codiceDipendente = false;
            }
        }

        private void Dipendenti_Stipendio_Enter(object sender, EventArgs e)
        {
            if (this.Dipendenti_Stipendio.Text.Equals("Stipendio"))
            {
                this.Dipendenti_Stipendio.Text = "";
            }
            this.Dipendenti_Stipendio.ForeColor = Color.Black;
            this.dipendente_stipendio = true;
        }

        private void Dipendenti_Stipendio_Leave(object sender, EventArgs e)
        {
            if (this.Dipendenti_Stipendio.Text.Equals(""))
            {
                this.Dipendenti_Stipendio.Text = "Stipendio";
                this.Dipendenti_Stipendio.ForeColor = Color.Gray;
                this.dipendente_stipendio = false;
            }
        }

        private void Dipendenti_IDsede_Enter(object sender, EventArgs e)
        {
            if (this.Dipendenti_IDsede.Text.Equals("ID Sede"))
            {
                this.Dipendenti_IDsede.Text = "";
            }
            this.Dipendenti_IDsede.ForeColor = Color.Black;
            this.dipendente_IDsede = true;
        }

        private void Dipendenti_IDsede_Leave(object sender, EventArgs e)
        {
            if (this.Dipendenti_IDsede.Text.Equals(""))
            {
                this.Dipendenti_IDsede.Text = "ID Sede";
                this.Dipendenti_IDsede.ForeColor = Color.Gray;
                this.dipendente_IDsede = false;
            }
        }

        private void Dipendenti_CFsuperiore_Enter(object sender, EventArgs e)
        {
            if (this.Dipendenti_CFsuperiore.Text.Equals("Cod. Fiscale del Superiore"))
            {
                this.Dipendenti_CFsuperiore.Text = "";
            }
            this.Dipendenti_CFsuperiore.ForeColor = Color.Black;
        }

        private void Dipendenti_CFsuperiore_Leave(object sender, EventArgs e)
        {
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Cod. Fiscale del Superiore";
                this.Clienti_Nome.ForeColor = Color.Gray;
            }
        }

        private void AggiungiDipendente_Click(object sender, EventArgs e)
        {
            /*if (this.dipendente_nome && this.dipendente_cognome && this.dipendente_CF && this.dipendente_telefono
               && this.dipendente_stipendio && this.dipendente_codiceDipendente)
            {
                var connection = new CreateConnection();
                connection.Connection.Open();
                var queries = new QueryLibrary(connection.Connection);

                try
                {
                    var result = queries.InserisciDipendente(Dipendenti_Nome.Text, Dipendenti_Cognome.Text, Dipendenti_CF.Text, Dipendenti_Telefono.Text, 
                        Dipendenti_CodiceDipendente.Text, float.Parse(Dipendenti_Stipendio.Text), Convert.ToByte(Dipendente_isGuida.Checked), 
                        Convert.ToByte(Dipendente_isTourManager.Checked), Convert.ToByte(Dipendente_isAltro.Checked), Dipendenti_IDsede.Text);
                    if (result)
                    {
                        MessageBox.Show("Dipendente inserito correttamente",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Dipendente non inserito",
                        "Errore",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
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
            }*/
            bool condition = this.dipendente_nome && this.dipendente_cognome && this.dipendente_CF && this.dipendente_telefono
               && this.dipendente_stipendio && this.dipendente_codiceDipendente;
            ExecuteQueryIf(condition, q => {
                var result = q.InserisciDipendente(Dipendenti_Nome.Text, Dipendenti_Cognome.Text, Dipendenti_CF.Text, Dipendenti_Telefono.Text,
                        Dipendenti_CodiceDipendente.Text, float.Parse(Dipendenti_Stipendio.Text), Convert.ToByte(Dipendente_isGuida.Checked),
                        Convert.ToByte(Dipendente_isTourManager.Checked), Convert.ToByte(Dipendente_isAltro.Checked), Dipendenti_IDsede.Text);
                if (result)
                {
                    MessageBox.Show("Dipendente inserito correttamente",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Dipendente non inserito",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            });
        }

        private void TourDestinazione_Enter(object sender, EventArgs e)
        {
            if (this.TourDestinazione.Text.Equals("Destinazione"))
            {
                this.TourDestinazione.Text = "";
            }
            this.TourDestinazione.ForeColor = Color.Black;
            this.tour_destinazione = true;
        }

        private void TourDestinazione_Leave(object sender, EventArgs e)
        {
            if (this.TourDestinazione.Text.Equals(""))
            {
                this.TourDestinazione.Text = "Destinazione";
                this.TourDestinazione.ForeColor = Color.Gray;
                this.tour_destinazione = false;
            }
        }

        private void TourNome_Enter(object sender, EventArgs e)
        {
            if (this.TourNome.Text.Equals("Nome"))
            {
                this.TourNome.Text = "";
            }
            this.TourNome.ForeColor = Color.Black;
            this.tour_nome = true;
        }

        private void Tour_Nome_Leave(object sender, EventArgs e)
        {
            if (this.TourNome.Text.Equals(""))
            {
                this.TourNome.Text = "Nome";
                this.TourNome.ForeColor = Color.Gray;
                this.tour_nome = false;
            }
        }

        private void TourDataInizio_Enter(object sender, EventArgs e)
        {
            if (this.TourDataInizio.Text.Equals("Data Inizio (YYYY-MM-DD)"))
            {
                this.TourDataInizio.Text = "";
            }
            this.TourDataInizio.ForeColor = Color.Black;
            this.tour_dataInizio = true;
        }

        private void TourDataInizio_Leave(object sender, EventArgs e)
        {
            if (this.TourDataInizio.Text.Equals(""))
            {
                this.TourDataInizio.Text = "Data Inizio (YYYY-MM-DD)";
                this.TourDataInizio.ForeColor = Color.Gray;
                this.tour_dataInizio = false;
            }
        }

        private void TourDataFine_Enter(object sender, EventArgs e)
        {
            if (this.TourDataFine.Text.Equals("Data Fine (YYYY-MM-DD)"))
            {
                this.TourDataFine.Text = "";
            }
            this.TourDataFine.ForeColor = Color.Black;
            this.tour_dataFine = true;
        }

        private void TourDataFine_Leave(object sender, EventArgs e)
        {
            if (this.TourDataFine.Text.Equals(""))
            {
                this.TourDataFine.Text = "Data Inizio (YYYY-MM-DD)";
                this.TourDataFine.ForeColor = Color.Gray;
                this.tour_dataFine = false;
            }
        }

        private void TourPrezzo_Enter(object sender, EventArgs e)
        {
            if (this.TourPrezzo.Text.Equals("Prezzo"))
            {
                this.TourPrezzo.Text = "";
            }
            this.TourPrezzo.ForeColor = Color.Black;
            this.tour_prezzo = true;
        }

        private void Tour_Prezzo_Leave(object sender, EventArgs e)
        {
            if (this.TourPrezzo.Text.Equals(""))
            {
                this.TourPrezzo.Text = "Prezzo";
                this.TourPrezzo.ForeColor = Color.Gray;
                this.tour_prezzo = false;
            }
        }

        private void Tour_ID_Enter(object sender, EventArgs e)
        {
            if (this.Tour_ID.Text.Equals("ID Tour"))
            {
                this.Tour_ID.Text = "";
            }
            this.Tour_ID.ForeColor = Color.Black;
            this.tour_IDtour = true;
        }

        private void Tour_ID_Leave(object sender, EventArgs e)
        {
            if (this.Tour_ID.Text.Equals(""))
            {
                this.Tour_ID.Text = "ID Tour";
                this.Tour_ID.ForeColor = Color.Gray;
                this.tour_IDtour = false;
            }
        }

        private void TourCFtourManager_Enter(object sender, EventArgs e)
        {
            if (this.TourCFManager.Text.Equals("CF del Tour Manager"))
            {
                this.TourCFManager.Text = "";
            }
            this.TourCFManager.ForeColor = Color.Black;
            this.tour_CFtourManager = true;
        }

        private void TourCFtourManager_Leave(object sender, EventArgs e)
        {
            if (this.TourCFManager.Text.Equals(""))
            {
                this.TourCFManager.Text = "CF del Tour Manager";
                this.TourCFManager.ForeColor = Color.Gray;
                this.tour_CFtourManager = false;
            }
        }

        private void AggiungiTour_Click(object sender, EventArgs e)
        {
            bool condition = this.tour_dataInizio && this.tour_dataFine && this.tour_prezzo && this.tour_CFtourManager;
            ExecuteQueryIf(condition, q => {
                var result = q.InserisciTour(this.TourDestinazione.Text, this.TourNome.Text, this.TourDataInizio.Text, this.TourDataFine.Text, float.Parse(this.TourPrezzo.Text), this.Tour_ID.Text, this.IDsede, this.TourCFManager.Text);
                if (result)
                {
                    MessageBox.Show("Tour inserito correttamente",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tour non inserito",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            });
        }

        private void Dipendenti_Ruolo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AggiungiTappa_Click(object sender, EventArgs e)
        {
            /*if (this.tappa_inizio && this.tappa_fine && this.tappa_lunghezzaTappa && this.tappa_ID && this.tappa_IDPercorso)
            {
                var connection = new CreateConnection();
                connection.Connection.Open();
                var queries = new QueryLibrary(connection.Connection);

                try
                {
                    var result = queries.InserisciTappa(this.NuovaTappa_Inizio.Text, this.NuovaTappa_Fine.Text, int.Parse(this.NuovaTappa_Lunghezza.Text), this.NuovaTappa_IDtappa.Text);
                    if (result)
                    {
                        result = queries.InserisciSequenza(this.NuovaTappa_IDtappa.Text, this.NuovaTappa_IDpercorso.Text);
                        if (result)
                        {
                            MessageBox.Show("Tappa inserita correttamente",
                            "Info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Tappa non inserita",
                            "Errore",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        }
                        MessageBox.Show("Tappa inserita correttamente",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tappa non inserita",
                        "Errore",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }

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
            }*/
            bool condition = this.tappa_inizio && this.tappa_fine && this.tappa_lunghezzaTappa && this.tappa_ID && this.tappa_IDPercorso;
            ExecuteQueryIf(condition, q => {
                var result = q.InserisciTappa(this.NuovaTappa_Inizio.Text, this.NuovaTappa_Fine.Text, int.Parse(this.NuovaTappa_Lunghezza.Text), this.NuovaTappa_IDtappa.Text);
                if (result)
                {
                    result = q.InserisciSequenza(this.NuovaTappa_IDtappa.Text, this.NuovaTappa_IDpercorso.Text);
                    if (result)
                    {
                        MessageBox.Show("Tappa inserita correttamente",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tappa non inserita",
                        "Errore",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Tappa inserita correttamente",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tappa non inserita",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            });
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void Dipendenti_Click(object sender, EventArgs e)
        {

        }

        private void NuovaTappa_Inizio_Enter(object sender, EventArgs e)
        {
            if (this.NuovaTappa_Inizio.Text.Equals("Inizio"))
            {
                this.NuovaTappa_Inizio.Text = "";
            }
            this.NuovaTappa_Inizio.ForeColor = Color.Black;
            this.nuovatappa_inizio = true;
        }

        private void NuovaTappa_Inizio_Leave(object sender, EventArgs e)
        {
            if (this.NuovaTappa_Inizio.Text.Equals(""))
            {
                this.NuovaTappa_Inizio.Text = "Inizio";
                this.NuovaTappa_Inizio.ForeColor = Color.Gray;
                this.nuovatappa_inizio = false;
            }
        }

        private void NuovaTappa_Fine_Enter(object sender, EventArgs e)
        {
            if (this.NuovaTappa_Fine.Text.Equals("Fine"))
            {
                this.NuovaTappa_Fine.Text = "";
            }
            this.NuovaTappa_Fine.ForeColor = Color.Black;
            this.nuovatappa_fine = true;
        }

        private void NuovaTappa_Fine_Leave(object sender, EventArgs e)
        {
            if (this.NuovaTappa_Fine.Text.Equals(""))
            {
                this.NuovaTappa_Fine.Text = "Fine";
                this.NuovaTappa_Fine.ForeColor = Color.Gray;
                this.nuovatappa_fine = false;
            }
        }

        private void NuovaTappa_Lunghezza_Enter(object sender, EventArgs e)
        {
            if (this.NuovaTappa_Lunghezza.Text.Equals("Lunghezza Tappa"))
            {
                this.NuovaTappa_Lunghezza.Text = "";
            }
            this.NuovaTappa_Lunghezza.ForeColor = Color.Black;
            this.nuovatappa_lunghezza = true;
        }

        private void NuovaTappa_Lunghezza_Leave(object sender, EventArgs e)
        {
            if (this.NuovaTappa_Lunghezza.Text.Equals(""))
            {
                this.NuovaTappa_Lunghezza.Text = "Lunghezza Tappa";
                this.NuovaTappa_Lunghezza.ForeColor = Color.Gray;
                this.nuovatappa_lunghezza = false;
            }
        }

        private void NuovaTappa_IDtappa_Enter(object sender, EventArgs e)
        {
            if (this.NuovaTappa_IDtappa.Text.Equals("ID Tappa"))
            {
                this.NuovaTappa_IDtappa.Text = "";
            }
            this.NuovaTappa_IDtappa.ForeColor = Color.Black;
            this.nuovatappa_IDtappa = true;
        }

        private void NuovaTappa_IDtappa_Leave(object sender, EventArgs e)
        {
            if (this.NuovaTappa_IDtappa.Text.Equals(""))
            {
                this.NuovaTappa_IDtappa.Text = "ID Tappa";
                this.NuovaTappa_IDtappa.ForeColor = Color.Gray;
                this.nuovatappa_IDtappa = false;
            }
        }

        private void NuovaTappa_IDpercorso_Enter(object sender, EventArgs e)
        {
            if (this.NuovaTappa_IDpercorso.Text.Equals("ID Percorso"))
            {
                this.NuovaTappa_IDpercorso.Text = "";
            }
            this.NuovaTappa_IDpercorso.ForeColor = Color.Black;
            this.nuovatappa_IDpercorso = true;
        }

        private void NuovaTappa_IDpercorso_Leave(object sender, EventArgs e)
        {
            if (this.NuovaTappa_IDpercorso.Text.Equals(""))
            {
                this.NuovaTappa_IDpercorso.Text = "ID Percorso";
                this.NuovaTappa_IDpercorso.ForeColor = Color.Gray;
                this.nuovatappa_IDpercorso = false;
            }
        }

        private void AggiungiTappa_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Servizi_DataInizio_Enter(object sender, EventArgs e)
        {
            if (this.Servizi_DataInizio.Text.Equals("DataInizio"))
            {
                this.Servizi_DataInizio.Text = "";
            }
            this.Servizi_DataInizio.ForeColor = Color.Black;
            this.servizi_DataInizio = true;
        }

        private void Servizi_DataInizio_Leave(object sender, EventArgs e)
        {
            if (this.Servizi_DataInizio.Text.Equals(""))
            {
                this.Servizi_DataInizio.Text = "DataInizio";
                this.Servizi_DataInizio.ForeColor = Color.Gray;
                this.servizi_DataInizio = false;
            }
        }
        private void Servizi_DataFine_Enter(object sender, EventArgs e)
        {
            if (this.Servizi_DataFine.Text.Equals("DataFine"))
            {
                this.Servizi_DataFine.Text = "";
            }
            this.Servizi_DataFine.ForeColor = Color.Black;
            this.servizi_DataFine = true;
        }

        private void Servizi_DataFine_Leave(object sender, EventArgs e)
        {
            if (this.Servizi_DataFine.Text.Equals(""))
            {
                this.Servizi_DataFine.Text = "DataFine";
                this.Servizi_DataFine.ForeColor = Color.Gray;
                this.servizi_DataFine = false;
            }
        }
        private void Servizi_Calcola_Click(object sender, EventArgs e)
        {
            bool condition = this.servizi_DataFine && this.servizi_DataInizio;
            if (condition)
            {
                var connection = new CreateConnection();
                connection.Connection.Open();
                var queries = new QueryLibrary(connection.Connection);
                FillTable(TabellaServizi, queries.LeggiServiziSede(this.IDsede,Servizi_DataInizio.Text, Servizi_DataFine.Text).CommandText, connection.Connection);
                var reader = queries.LeggiTagliaBicicletta(this.IDsede, Servizi_DataInizio.Text, Servizi_DataFine.Text).ExecuteReader();
                reader.Read();
                Servizio_TagliaBiciTop.Text = reader.GetString(0);
                reader.Close();
                reader = queries.LeggiPeriodoMedioPrenotazioneBici(this.PIVAagenzia).ExecuteReader();
                reader.Read();
                Servizio_PeriodoMedioBici.Text = reader.GetString(0);
                reader.Close();
                reader = queries.LeggiAccessorioPiuRichiesto(this.IDsede, Servizi_DataInizio.Text, Servizi_DataFine.Text).ExecuteReader();
                reader.Read();
                Servizio_AccessorioTop.Text = reader.GetString(0);
                reader.Close();
                connection.Connection.Close();
            }
            else
            {
                MessageBox.Show("Impossile visualizzare servizi",
                "Errore",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }
    }
}
