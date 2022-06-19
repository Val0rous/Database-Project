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
        public DatabaseViewAdmin(bool isAdmin, string PIVAagenzia, string IDsede)
        {
            this.IsAdmin = isAdmin;
            this.PIVAagenzia = PIVAagenzia;
            this.IDsede = IDsede;
            InitializeComponent();
            
            var connection = new CreateConnection();
            var queries = new QueryLibrary(connection.Connection);
            var dataAdapter = new MySqlDataAdapter(queries.LeggiDipendentiToString(this.IDsede), connection.Connection);

            //TabellaDipendenti.DataSource = queries.LeggiDipendenti(this.IDsede);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            BindingSource SBind = new BindingSource();
            SBind.DataSource = table;
            TabellaDipendenti.DataSource = SBind;

            dataAdapter = new MySqlDataAdapter(queries.LeggiMagazziniToString(this.IDsede), connection.Connection);
            table = new DataTable();
            dataAdapter.Fill(table);
            SBind = new BindingSource();
            SBind.DataSource = table;
            TabellaMagazzini.DataSource = SBind;

            dataAdapter = new MySqlDataAdapter(queries.LeggiTour(this.IDsede).CommandText, connection.Connection);
            table = new DataTable();
            dataAdapter.Fill(table);
            SBind = new BindingSource();
            SBind.DataSource = table;
            TabellaTour.DataSource = SBind;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'gestionale_per_agenzie_relDataSet3.magazzino' table. You can move, or remove it, as needed.
            //this.magazzinoTableAdapter.Fill(this.gestionale_per_agenzie_relDataSet3.magazzino);
            // TODO: This line of code loads data into the 'gestionale_per_agenzie_relDataSet2.dipendente' table. You can move, or remove it, as needed.
            //this.dipendenteTableAdapter.Fill(this.gestionale_per_agenzie_relDataSet2.dipendente);

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
