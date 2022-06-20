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
            //var connection = new CreateConnection();
            
            //connection.Connection.Open();
            //QueryLibrary bro = new QueryLibrary(connection.Connection);
            //Console.WriteLine(bro.GetNextID("accessorio","IDaccessorio"));
            /*
            var reader = bro.LeggiAgenzie();
            while (reader.Read())
            {
                String PIVA = reader.GetString("PIVA");
                String Nome = reader.GetString("Nome");
                var NumTotDipendenti = reader.GetInt64("NumTotDipendenti");
                Console.WriteLine(PIVA + " " + Nome + " " + NumTotDipendenti);
            }
            */

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
            //connection.Connection.Close();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserAdminChoice());
        }
    }
}
