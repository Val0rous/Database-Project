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

        public DatabaseViewUser(bool isAdmin, string PIVAagenzia, string IDsede)
        {
            this.IsAdmin = isAdmin;
            this.PIVAagenzia = PIVAagenzia;
            this.IDsede = IDsede;
            InitializeComponent();
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
            this.prenotazioneTableAdapter.Fill(this.gestionale_per_agenzie_relDataSet1.prenotazione);
            // TODO: This line of code loads data into the 'gestionale_per_agenzie_relDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.gestionale_per_agenzie_relDataSet.cliente);
            
        }
    }
}
