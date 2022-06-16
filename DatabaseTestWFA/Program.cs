using DatabaseTestWFA;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
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
            //builder.Password = "SIMONE2001";
            builder.Password = "S@9WfQHnqrgFPN";
            builder.Database = "gestionale_per_agenzie_rel";

            MySqlConnection connection = new MySqlConnection(builder.ToString());
            connection.Open();
            QueryLibrary bro = new QueryLibrary(connection);
            var result = bro.inserisciBicicletta("Baldoni", "B1001", 'M', 20, "MountainBike", "2022-06-16", 3, 8, 0, 123, 2000, "M3");
            if (!result) Console.WriteLine("impossibile eseguire la query");
            else Console.WriteLine("Query eseguita correttamente");

            //string nuovoAccessorio_sql = "INSERT INTO accessorio (Tipologia, UltimoControllo, Produttore, Taglia, IDaccessorio, IDmagazzino) VALUES ('Guanto', '2022-06-15', 'Bianchi', 'M', '034', '011')";
            //MySqlCommand nuovoAccessorio = new MySqlCommand(nuovoAccessorio_sql, connection);
            //nuovoAccessorio.CommandText = nuovoAccessorio_sql;
            //nuovoAccessorio.ExecuteNonQuery();
            /*
            MySqlCommand command = connection.CreateCommand();
            command.Parameters.AddWithValue("@Tipologia", "Guanto");
            command.Parameters.AddWithValue("@UltimoControllo", "2022-06-15");
            command.Parameters.AddWithValue("@Produttore", "Bianchi");
            command.Parameters.AddWithValue("@Taglia", "M");
            command.Parameters.AddWithValue("@IDaccessorio", "034");
            command.Parameters.AddWithValue("@IDmagazzino", "011");


            //string script = File.ReadAllText(@"C:\Users\fv260\source\repos\DatabaseProject\insert_accessorio.sql");

            //command.CommandText = script;
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
            Application.Run(new UserAdminChoice());
        }
    }
}
