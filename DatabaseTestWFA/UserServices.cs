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

        private bool pacchetto;

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
            ExecuteQueryIf(!pacchetto, (q,c) => {
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
                ExecuteQueryIf(this.servizio_datafine && this.servizio_datainizio, (q, c) => {
                    FillTable(TabellaBici, q.LeggiBiciclette(IDSede, this.Servizio_DataInizio.Text, this.Servizio_DataFine.Text).CommandText, c.Connection);
                });
            }
        }

        private void AggiungiNoleggioButton_Click(object sender, EventArgs e)
        {
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
            Console.WriteLine(NoleggioBiciclette_Lista.Items.Count);
            if (NoleggioBiciclette_Lista.Items.Count == 0) return;
            //crea pacchetto se non esiste
            CreatePacchetto();
            //crea il servizio 
            ExecuteQueryIf(true, (q,c) => {
                var result = q.InserisciServizio(Servizio_DataInizio.Text, Servizio_DataFine.Text, Servizio_ID.Text, "NOLEGGIO_BICICLETTE", IDPacchetto, IDSede, "");
                if (!result)
                {
                    MessageBox.Show("Servizio non creato!",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            });

            foreach (ListViewItem b in NoleggioBiciclette_Lista.Items)
            {
                bool result = true;
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
                });
                if (!result)
                {
                    return;
                }
            }
            MessageBox.Show("Biciclette noleggiate correttamente",
                       "Info",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
        }
    }
}
