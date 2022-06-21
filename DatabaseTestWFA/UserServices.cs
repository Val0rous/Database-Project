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
    public partial class UserServices : Form
    {
        string IDSede { get; set; }
        string IDPacchetto { get; set; }

        int Sconto { get; set; }
        string CF { get; set; }

        private bool servizio_datainizio;
        private bool servizio_datafine;

        private bool percorso;

        private bool pacchetto;

        private static float valoreXBici = 30;
        private static float valoreXAccessorio = 15;
        private static float valoreXGuida = 25;
        private static float valorePercorso = 10;

        public UserServices(string IDSede, string IDPacchetto, int sconto, string cf)
        {
            this.IDSede = IDSede;
            this.IDPacchetto = IDPacchetto;
            this.Sconto = sconto;
            this.CF = cf;
            InitializeComponent();
        }
        public void ExecuteQueryIf(bool condition, Action<QueryLibrary, CreateConnection> query)
        {
            if (condition)
            {
                var connection = new CreateConnection();
                connection.Connection.Open();
                var queries = new QueryLibrary(connection.Connection);

                try
                {
                    query(queries, connection);
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
        private static void FillTable(DataGridView grid, string command, MySqlConnection connection)
        {
            var dataAdapter = new MySqlDataAdapter(command, connection);
            var table = new DataTable();
            dataAdapter.Fill(table);
            var SBind = new BindingSource();
            SBind.DataSource = table;
            grid.DataSource = SBind;
        }
        private void CreatePacchetto()
        {
            if (!pacchetto)
            {
                ExecuteQueryIf(true, (q, c) => {
                    var result = q.InserisciPacchetto(0, Sconto, this.IDPacchetto, this.CF);
                    if (!result)
                    {
                        MessageBox.Show("Pacchetto non creato!",
                        "Errore",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    pacchetto = true;
                });
            }
        }
        private void UserServices_Load(object sender, EventArgs e)
        {
            
            var connection = new CreateConnection();
            connection.Connection.Open();
            var queries = new QueryLibrary(connection.Connection);
            /*
            FillTable(TabellaBici, queries.LeggiBiciclette(IDSede).CommandText, connection.Connection);

            BNCFRN55P60E0583
            */

            this.Servizio_DataInizio.ForeColor = Color.Gray;
            this.Servizio_DataFine.ForeColor = Color.Gray;

            this.Servizio_ID.Text = queries.GetNextID("servizio", "IDservizio");
            this.Pacchetto_Sconto.Text = Sconto.ToString() + "%";
            this.Pacchetto_Prezzo.Text = "0.00";
        }

        private void Servizio_DataInizio_Enter(object sender, EventArgs e)
        {
            if (this.Servizio_DataInizio.Text.Equals("Data Inizio"))
            {
                this.Servizio_DataInizio.Text = "";
            }
            this.Servizio_DataInizio.ForeColor = Color.Black;
            this.servizio_datainizio = true;
        }

        private void Servizio_DataInizio_Leave(object sender, EventArgs e)
        {
            if (this.Servizio_DataInizio.Text.Equals(""))
            {
                this.Servizio_DataInizio.Text = "Data Inizio";
                this.Servizio_DataInizio.ForeColor = Color.Gray;
                this.servizio_datainizio = false;
            }
        }

        

        private void Servizio_DataFine_Enter(object sender, EventArgs e)
        {
            if (this.Servizio_DataFine.Text.Equals("Data Fine"))
            {
                this.Servizio_DataFine.Text = "";
            }
            this.Servizio_DataFine.ForeColor = Color.Black;
            this.servizio_datafine = true;
        }

        private void Servizio_DataFine_Leave(object sender, EventArgs e)
        {
            if (this.Servizio_DataFine.Text.Equals(""))
            {
                this.Servizio_DataFine.Text = "Data Fine";
                this.Servizio_DataFine.ForeColor = Color.Gray;
                this.servizio_datafine = false;
            }
        }

        private void AggiornaButton_Enter(object sender, EventArgs e)
        {
            if (TabPage.SelectedTab.Text == "Noleggio Biciclette")
            {
                ExecuteQueryIf(this.servizio_datafine && this.servizio_datainizio, (q, c) =>
                {
                    FillTable(TabellaBici, q.LeggiBiciclette(IDSede, this.Servizio_DataInizio.Text, this.Servizio_DataFine.Text).CommandText, c.Connection);
                });
            }
            else if (TabPage.SelectedTab.Text == "Noleggio Accessori")
            {
                ExecuteQueryIf(this.servizio_datafine && this.servizio_datainizio, (q, c) =>
                {
                    FillTable(TabellaAccessori, q.LeggiAccessori(IDSede, this.Servizio_DataInizio.Text, this.Servizio_DataFine.Text).CommandText, c.Connection);
                });
            }
            else if (TabPage.SelectedTab.Text == "Percorsi Guidati")
            {
                ExecuteQueryIf(this.servizio_datafine && this.servizio_datainizio, (q, c) =>
                {
                    FillTable(TabellaPercorsi, q.LeggiPercorso(IDSede).CommandText, c.Connection);
                    FillTable(TabellaGuide, q.LeggiGuide(IDSede).CommandText, c.Connection);
                });
            }
        }
        private void AggiungiNoleggioButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem v in NoleggioBiciclette_Lista.Items)
            {
                if (v.Text == this.Bici.Text) return;
            }
            var bindBici = (BindingSource)TabellaBici.DataSource;
            var listaBici = ((DataTable)bindBici.DataSource).Rows;
            foreach (DataRow r in listaBici)
            {
                if (r["NumTelaio"].Equals(this.Bici.Text))
                {
                    //aggiungi alla lista
                    NoleggioBiciclette_Lista.Items.Add(Bici.Text);
                    return;
                }
            }
        }

        private void NoleggiaBiciButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(NoleggioBiciclette_Lista.Items.Count);
            if (NoleggioBiciclette_Lista.Items.Count == 0) return;
            //crea pacchetto se non esiste
            CreatePacchetto();
            //crea il servizio 
            bool result = true;
            ExecuteQueryIf(this.servizio_datainizio && this.servizio_datafine, (q,c) => {
                result = q.InserisciServizio(Servizio_DataInizio.Text, Servizio_DataFine.Text, Servizio_ID.Text, "NOLEGGIO_BICICLETTE", IDPacchetto, IDSede, "");
                if (!result)
                {
                    MessageBox.Show("Servizio non creato!",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            });
            if (!result)
            {
                NoleggioBiciclette_Lista.Items.Clear();
                return;
            }
            float valoreTot = 0;
            foreach (ListViewItem b in NoleggioBiciclette_Lista.Items)
            {
                result = true;
                ExecuteQueryIf(true, (q, c) => {
                    result = q.InserisciNoleggioBicicletta(this.Servizio_ID.Text, b.Text);
                    //Console.WriteLine(b);
                    if (!result)
                    {
                        MessageBox.Show("Biciclette non noleggiate",
                        "Errore",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    valoreTot += valoreXBici;
                });
                if (!result)
                {
                    NoleggioBiciclette_Lista.Items.Clear();
                    return;
                }
            }
            NoleggioBiciclette_Lista.Items.Clear();

            this.Pacchetto_Prezzo.Text = (float.Parse(Pacchetto_Prezzo.Text) + valoreTot).ToString();
            ExecuteQueryIf(true, (q, c) => {
                result = q.UpdatePacchetto(this.IDPacchetto, float.Parse(Pacchetto_Prezzo.Text));
                //Console.WriteLine(b);
                if (!result)
                {
                    MessageBox.Show("errore aggiornamento del pacchetto",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                this.Servizio_ID.Text = q.GetNextID("servizio", "IDservizio");
            });
            MessageBox.Show("Biciclette noleggiate correttamente",
                      "Info",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
        }

        private void AggiungiNoleggio1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem v in NoleggioAccessori_Lista.Items)
            {
                if (v.Text == this.Accessorio.Text) return;
            }
            var bindAcc = (BindingSource)TabellaAccessori.DataSource;
            var listaAcc = ((DataTable)bindAcc.DataSource).Rows;
            foreach (DataRow r in listaAcc)
            {
                if (r["IDaccessorio"].Equals(this.Accessorio.Text))
                {
                    //aggiungi alla lista
                    NoleggioAccessori_Lista.Items.Add(Accessorio.Text);
                    return;
                }
            }
        }

        private void NoleggiaAccessorio_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(NoleggioBiciclette_Lista.Items.Count);
            if (NoleggioAccessori_Lista.Items.Count == 0) return;
            //crea pacchetto se non esiste
            CreatePacchetto();
            //crea il servizio 
            bool result = true;
            ExecuteQueryIf(this.servizio_datainizio && this.servizio_datafine, (q, c) => {
                result = q.InserisciServizio(Servizio_DataInizio.Text, Servizio_DataFine.Text, Servizio_ID.Text, "NOLEGGIO_ACCESSORI", IDPacchetto, IDSede, "");
                if (!result)
                {
                    MessageBox.Show("Servizio non creato!",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            });
            if (!result)
            {
                NoleggioAccessori_Lista.Items.Clear();
                return;
            }
            float valoreTot = 0;
            foreach (ListViewItem b in NoleggioAccessori_Lista.Items)
            {
                result = true;
                ExecuteQueryIf(true, (q, c) => {
                    result = q.InserisciNoleggioAccessorio(this.Servizio_ID.Text, b.Text);
                    //Console.WriteLine(b);
                    if (!result)
                    {
                        MessageBox.Show("Accessori non noleggiati",
                        "Errore",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    valoreTot += valoreXAccessorio;
                });
                if (!result)
                {
                    NoleggioAccessori_Lista.Items.Clear();
                    return;
                }
            }
            
            NoleggioAccessori_Lista.Items.Clear();

            this.Pacchetto_Prezzo.Text = (float.Parse(Pacchetto_Prezzo.Text) + valoreTot).ToString();
            ExecuteQueryIf(true, (q, c) => {
                result = q.UpdatePacchetto(this.IDPacchetto, float.Parse(Pacchetto_Prezzo.Text));
                //Console.WriteLine(b);
                if (!result)
                {
                    MessageBox.Show("errore aggiornamento del pacchetto",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                this.Servizio_ID.Text = q.GetNextID("servizio", "IDservizio");
            });
            MessageBox.Show("Accessori noleggiati correttamente",
                       "Info",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
        }

        private void Percorso_Enter(object sender, EventArgs e)
        {
            if (this.Percorso.Text.Equals("ID Percorso"))
            {
                this.Percorso.Text = "";
            }
            this.Percorso.ForeColor = Color.Black;
            this.percorso = true;
        }

        private void Percorso_Leave(object sender, EventArgs e)
        {
            if (this.Percorso.Text.Equals(""))
            {
                this.Percorso.Text = "ID Percorso";
                this.Percorso.ForeColor = Color.Gray;
                this.percorso = false;
            } else
            {
                var bindPerc = (BindingSource)TabellaPercorsi.DataSource;
                var listaPerc = ((DataTable)bindPerc.DataSource).Rows;
                foreach (DataRow r in listaPerc)
                {
                    if (r["IDpercorso"].Equals(this.Percorso.Text))
                    {
                        //e' nella lista
                        return;
                    }
                }
                //non e'nella lista
                this.Percorso.Text = "ID Percorso";
                this.Percorso.ForeColor = Color.Gray;
                this.percorso = false;
                MessageBox.Show("Percorso non presente",
                       "Errore",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }

        private void AggiungiGuida_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem v in Guide_Lista.Items)
            {
                if (v.Text == this.Guida.Text) return;
            }
            var bindAcc = (BindingSource)TabellaGuide.DataSource;
            var listaAcc = ((DataTable)bindAcc.DataSource).Rows;
            foreach (DataRow r in listaAcc)
            {
                if (r["CF"].Equals(this.Guida.Text))
                {
                    //aggiungi alla lista
                    Guide_Lista.Items.Add(Guida.Text);
                    return;
                }
            }
        }

        private void CreaPercorsoGuidato_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(NoleggioBiciclette_Lista.Items.Count);
            if (Guide_Lista.Items.Count == 0 || !percorso) return;
            //crea pacchetto se non esiste
            CreatePacchetto();
            //crea il servizio 
            bool result = true;
            ExecuteQueryIf(this.servizio_datainizio && this.servizio_datafine, (q, c) => {
                result = q.InserisciServizio(Servizio_DataInizio.Text, Servizio_DataFine.Text, Servizio_ID.Text, "PERCORSO_GUIDATO", IDPacchetto, IDSede, Percorso.Text);
                if (!result)
                {
                    MessageBox.Show("Servizio non creato!",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            });
            if (!result)
            {
                Guide_Lista.Items.Clear();
                return;
            }
            float valoreTot = valorePercorso;
            foreach (ListViewItem b in Guide_Lista.Items)
            {
                result = true;
                ExecuteQueryIf(true, (q, c) => {
                    result = q.InserisciPartecipazione(this.Servizio_ID.Text, b.Text);
                    //Console.WriteLine(b);
                    if (!result)
                    {
                        MessageBox.Show("Guide non registrate nel percorso guidato",
                        "Errore",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    valoreTot += valoreXGuida;
                });
                if (!result)
                {
                    Guide_Lista.Items.Clear();
                    return;
                }
            }
            
            Guide_Lista.Items.Clear();

            this.Pacchetto_Prezzo.Text = (float.Parse(Pacchetto_Prezzo.Text) + valoreTot).ToString();
            ExecuteQueryIf(true, (q, c) => {
                result = q.UpdatePacchetto(this.IDPacchetto, float.Parse(Pacchetto_Prezzo.Text));
                //Console.WriteLine(b);
                if (!result)
                {
                    MessageBox.Show("errore aggiornamento del pacchetto",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                this.Servizio_ID.Text = q.GetNextID("servizio", "IDservizio");
            });
            MessageBox.Show("Percorso guidato prenotato correttamente",
                       "Info",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
        }
    }
}
