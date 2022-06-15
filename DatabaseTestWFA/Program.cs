using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseTestWFA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "S@9WfQHnqrgFPN";
            builder.Database = "gestionale_per_agenzie_rel";
            MySqlConnection connection = new MySqlConnection(builder.ToString());
            connection.Open();

            //string nuovoAccessorio_sql = "INSERT INTO accessorio (Tipologia, UltimoControllo, Produttore, Taglia, IDaccessorio, IDmagazzino) VALUES ('Guanto', '2022-06-15', 'Bianchi', 'M', '034', '011')";
            //MySqlCommand nuovoAccessorio = new MySqlCommand(nuovoAccessorio_sql, connection);
            //nuovoAccessorio.CommandText = nuovoAccessorio_sql;
            //nuovoAccessorio.ExecuteNonQuery();

            MySqlCommand command = connection.CreateCommand();
            command.Parameters.AddWithValue("@Tipologia", "Guanto");
            command.Parameters.AddWithValue("@UltimoControllo", "2022-06-15");
            command.Parameters.AddWithValue("@Produttore", "Bianchi");
            command.Parameters.AddWithValue("@Taglia", "M");
            command.Parameters.AddWithValue("@IDaccessorio", "034");
            command.Parameters.AddWithValue("@IDmagazzino", "011");


            string script = File.ReadAllText(@"C:\Users\fv260\source\repos\DatabaseTestWFA\insert_accessorio.sql");
            command.CommandText = script;
            //command.CommandText = "INSERT INTO accessorio (Tipologia, UltimoControllo, Produttore, Taglia, IDaccessorio, IDmagazzino) VALUES (@Tipologia, @UltimoControllo, @Produttore, @Taglia, @IDaccessorio, @IDmagazzino)";
            /*if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Record was added!");
            }
            else
            {
                MessageBox.Show("Record was NOT added!");
            }
            */
            connection.Close();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
