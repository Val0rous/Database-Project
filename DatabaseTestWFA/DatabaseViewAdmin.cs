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
        bool dipendente_CFsuperiore;

        bool tour_destinazione;
        bool tour_nome;
        bool tour_dataInizio;
        bool tour_dataFine;
        bool tour_prezzo;
        bool tour_IDtour;
        bool tour_IDsede;
        bool tour_CFtourManager;

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
            connection.Connection.Open();
            var queries = new QueryLibrary(connection.Connection);

            FillTable(TabellaClienti, queries.LeggiClienti().CommandText, connection.Connection);
            FillTable(TabellaPrenotazioni, queries.LeggiPrenotazioni().CommandText, connection.Connection);
            FillTable(TabellaMagazzini, queries.LeggiMagazzini(this.IDsede).CommandText, connection.Connection);
            FillTable(TabellaPercorsi, queries.LeggiPercorso(this.IDsede).CommandText, connection.Connection);
            FillTable(TabellaBusinessPartners, queries.LeggiBusinessPartner(this.PIVAagenzia).CommandText, connection.Connection);
            FillTable(TabellaDipendenti, queries.LeggiDipendenti(this.IDsede).CommandText, connection.Connection);
            FillTable(TabellaTour, queries.LeggiTour(this.IDsede).CommandText, connection.Connection);

            connection.Connection.Close();

            this.Clienti_Nome.ForeColor = Color.Gray;
            this.Clienti_Cognome.ForeColor = Color.Gray;
            this.Clienti_CF.ForeColor = Color.Gray;
            this.Clienti_Telefono.ForeColor = Color.Gray;
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
            if (this.cliente_nome && this.cliente_cognome && this.cliente_CF && this.cliente_telefono)
            {
                var connection = new CreateConnection();
                connection.Connection.Open();
                var queries = new QueryLibrary(connection.Connection);

                try
                {
                    var result = queries.InserisciCliente(this.Clienti_Nome.Text, this.Clienti_Cognome.Text, this.Clienti_CF.Text, this.Clienti_Telefono.Text);
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
            }
        }

        private void AggiungiPrenotazione_Click(object sender, EventArgs e)
        {

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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
            }
        }

        private void AggiungiMagazzino_Click(object sender, EventArgs e)
        {

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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
            }
        }

        private void AggiungiPercorso_Click(object sender, EventArgs e)
        {

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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
            }
        }

        private void AggiungiBusinessPartner_Click(object sender, EventArgs e)
        {

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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
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
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
            }
        }

        private void AggiungiDipendente_Click(object sender, EventArgs e)
        {

        }

        private void Tour_Destinazione_Enter(object sender, EventArgs e)
        {
            if (this.Tour_Destinazione.Text.Equals("Destinazione"))
            {
                this.Tour_Destinazione.Text = "";
            }
            this.Tour_Destinazione.ForeColor = Color.Black;
            this.tour_destinazione = true;
        }

        private void Tour_Destinazione_Leave(object sender, EventArgs e)
        {
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
            }
        }

        private void Tour_Nome_Enter(object sender, EventArgs e)
        {
            if (this.Tour_Nome.Text.Equals("Nome"))
            {
                this.Tour_Nome.Text = "";
            }
            this.Tour_Nome.ForeColor = Color.Black;
            this.tour_nome = true;
        }

        private void Tour_Nome_Leave(object sender, EventArgs e)
        {
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
            }
        }

        private void Tour_DataInizio_Enter(object sender, EventArgs e)
        {
            if (this.Tour_DataInizio.Text.Equals("Data Inizio (YYYY-MM-DD)"))
            {
                this.Tour_DataInizio.Text = "";
            }
            this.Tour_DataInizio.ForeColor = Color.Black;
            this.tour_dataInizio = true;
        }

        private void Tour_DataInizio_Leave(object sender, EventArgs e)
        {
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
            }
        }

        private void Tour_DataFine_Enter(object sender, EventArgs e)
        {
            if (this.Tour_DataFine.Text.Equals("Data Fine (YYYY-MM-DD)"))
            {
                this.Tour_DataFine.Text = "";
            }
            this.Tour_DataFine.ForeColor = Color.Black;
            this.tour_dataFine = true;
        }

        private void Tour_DataFine_Leave(object sender, EventArgs e)
        {
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
            }
        }

        private void Tour_Prezzo_Enter(object sender, EventArgs e)
        {
            if (this.Tour_Prezzo.Text.Equals("Prezzo"))
            {
                this.Tour_Prezzo.Text = "";
            }
            this.Tour_Prezzo.ForeColor = Color.Black;
            this.tour_prezzo = true;
        }

        private void Tour_Prezzo_Leave(object sender, EventArgs e)
        {
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
            }
        }

        private void Tour_IDtour_Enter(object sender, EventArgs e)
        {
            if (this.Tour_IDtour.Text.Equals("ID Tour"))
            {
                this.Tour_IDtour.Text = "";
            }
            this.Tour_IDtour.ForeColor = Color.Black;
            this.tour_IDtour = true;
        }

        private void Tour_IDtour_Leave(object sender, EventArgs e)
        {
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
            }
        }

        private void Tour_IDsede_Enter(object sender, EventArgs e)
        {
            if (this.Tour_IDsede.Text.Equals("ID Sede"))
            {
                this.Tour_IDsede.Text = "";
            }
            this.Tour_IDsede.ForeColor = Color.Black;
            this.tour_IDsede = true;
        }

        private void Tour_IDsede_Leave(object sender, EventArgs e)
        {
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
            }
        }

        private void Tour_CFtourManager_Enter(object sender, EventArgs e)
        {
            if (this.Tour_CFtourManager.Text.Equals("CF del Tour Manager"))
            {
                this.Tour_CFtourManager.Text = "";
            }
            this.Tour_CFtourManager.ForeColor = Color.Black;
            this.tour_CFtourManager = true;
        }

        private void Tour_CFtourManager_Leave(object sender, EventArgs e)
        {
            if (this.Clienti_Nome.Text.Equals(""))
            {
                this.Clienti_Nome.Text = "Nome";
                this.Clienti_Nome.ForeColor = Color.Gray;
                this.nome = false;
            }
        }

        private void AggiungiTour_Click(object sender, EventArgs e)
        {

        }

        private void Dipendenti_Ruolo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
