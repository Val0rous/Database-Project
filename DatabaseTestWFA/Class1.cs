using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DatabaseTestWFA
{
    /* Funzioni per la creazione ed esecuzione di query sul database
     * input: MySqlConnection connection 
     * input: parametri query
     * output: risultato query-> true: tutto ok, false: errore
     */
    public class QueryLibrary
    {
        MySqlConnection connection { get; set; }
        public QueryLibrary(MySqlConnection connection)
        {
            this.connection = connection;
        }
        public bool inserisciAccessorio (String Tipologia, String UltimoControllo, String Produttore, char Taglia, String IDaccessorio, String IDmagazzino)
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.Parameters.AddWithValue("@Tipologia", Tipologia);
            command.Parameters.AddWithValue("@UltimoControllo", UltimoControllo);
            command.Parameters.AddWithValue("@Produttore", Produttore);
            command.Parameters.AddWithValue("@Taglia", Taglia);
            command.Parameters.AddWithValue("@IDaccessorio", IDaccessorio);
            command.Parameters.AddWithValue("@IDmagazzino", IDmagazzino);
            command.CommandText = "INSERT INTO accessorio (Tipologia, UltimoControllo, Produttore, Taglia, IDaccessorio, IDmagazzino) " +
                "VALUES (@Tipologia, @UltimoControllo, @Produttore, @Taglia, @IDaccessorio, @IDmagazzino)";
            try
            {
                if (command.ExecuteNonQuery() > 0) return true;
                else return false;

            }
            catch(MySqlException) {
                return false;
            }
        }
        public bool inserisciBicicletta(String Produttore, String NumTelaio, char Taglia, int RaggioRuota, String Tipologia, String UltimoControllo, int NumeroRapportiAnteriori, int NumeroRapportiPosteriori, int isElettrica, int PotenzaBatteria, int CapacitàBatteria, String IDmagazzino)
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.Parameters.AddWithValue("@Produttore", Produttore);
            command.Parameters.AddWithValue("@NumTelaio", NumTelaio);
            command.Parameters.AddWithValue("@Taglia", Taglia);
            command.Parameters.AddWithValue("@RaggioRuota", RaggioRuota);
            command.Parameters.AddWithValue("@Tipologia", Tipologia);
            command.Parameters.AddWithValue("@UltimoControllo", UltimoControllo);
            command.Parameters.AddWithValue("@NumRapportiAnteriori", NumeroRapportiAnteriori);
            command.Parameters.AddWithValue("@NumRapportiPosteriori", NumeroRapportiPosteriori);
            command.Parameters.AddWithValue("@isElettrica", isElettrica);
            command.Parameters.AddWithValue("@PotenzaBatteria", PotenzaBatteria);
            command.Parameters.AddWithValue("@CapacitàBatteria", CapacitàBatteria);
            command.Parameters.AddWithValue("@IDmagazzino", IDmagazzino);
            if (isElettrica > 0) command.CommandText = "INSERT INTO bicicletta (Produttore, NumTelaio, Taglia, RaggioRuota, Tipologia, UltimoControllo, NumRapportiAnteriori, NumRapportiPosteriori, " +
                      "isElettrica, PotenzaBatteria, CapacitàBatteria, IDmagazzino) VALUES (@Produttore, @NumTelaio, @Taglia, @RaggioRuota, @Tipologia, @UltimoControllo, @NumRapportiAnteriori, " +
                      "@NumRapportiPosteriori, @isElettrica, @PotenzaBatteria, @CapacitàBatteria, @IDmagazzino)";
            else command.CommandText = "INSERT INTO bicicletta (Produttore, NumTelaio, Taglia, RaggioRuota, Tipologia, UltimoControllo, NumRapportiAnteriori, NumRapportiPosteriori, " +
                      "isElettrica, IDmagazzino) VALUES (@Produttore, @NumTelaio, @Taglia, @RaggioRuota, @Tipologia, @UltimoControllo, @NumRapportiAnteriori, " +
                      "@NumRapportiPosteriori, @isElettrica, @IDmagazzino)";
            try
            {
                if (command.ExecuteNonQuery() > 0) return true;
                else return false;
            }
            catch (MySqlException)
            {
                return false;
            }
        }
        public bool inserisciPercorso(String IDpercorso, String Difficolta, int NumTappe, float LunghezzaPercorso, String IDsede)
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.Parameters.AddWithValue("@IDpercorso", IDpercorso);
            command.Parameters.AddWithValue("@Difficolta", Difficolta);
            command.Parameters.AddWithValue("@NumTappe", NumTappe);
            command.Parameters.AddWithValue("@LunghezzaPercorso", LunghezzaPercorso);
            command.Parameters.AddWithValue("@IDsede", IDsede);
            command.CommandText = "INSERT INTO percorso (IDpercorso, Difficolta, NumTappe, LunghezzaPercorso, IDsede) " +
                "VALUES (@IDpercorso, @Difficolta, @NumTappe, @LunghezzaPercorso, @IDsede)";
            try
            {
                if (command.ExecuteNonQuery() > 0) return true;
                else return false;

            }
            catch (MySqlException)
            {
                return false;
            }
        }
        public bool inserisciCliente(String Nome, String Cognome, String CF, String Recapito)
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.Parameters.AddWithValue("@Nome", Nome);
            command.Parameters.AddWithValue("@Cognome", Cognome);
            command.Parameters.AddWithValue("@CF", CF);
            command.Parameters.AddWithValue("@Recapito", Recapito);
            command.CommandText = "INSERT INTO cliente (Nome, Cognome, CF, NumTelefono) " +
                "VALUES (@Nome, @Cognome, @CF, @NumTelefono)";
            try
            {
                if (command.ExecuteNonQuery() > 0) return true;
                else return false;

            }
            catch (MySqlException)
            {
                return false;
            }
        }
        public bool inserisciDipendente(String Nome, String Cognome, String CF, String Recapito, String CodiceDipendente, float Stipendio, byte isGuida, byte isTourManager, byte isAltro, String IDsede)
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.Parameters.AddWithValue("@Nome", Nome);
            command.Parameters.AddWithValue("@Cognome", Cognome);
            command.Parameters.AddWithValue("@CF", CF);
            command.Parameters.AddWithValue("@Recapito", Recapito);
            command.Parameters.AddWithValue("@CodiceDipendente", CodiceDipendente);
            command.Parameters.AddWithValue("@Stipendio", Stipendio);
            command.Parameters.AddWithValue("@isGuida", isGuida);
            command.Parameters.AddWithValue("@isTourManager", isTourManager);
            command.Parameters.AddWithValue("@isAltro", isAltro);
            command.Parameters.AddWithValue("@IDsede", IDsede);
            command.CommandText = "INSERT INTO dipendente (Nome, Cognome, CF, Recapito, CodiceDipendente, Stipendio, isGuida, isTourManager, isAltro, IDsede) " +
                "VALUES (@Nome, @Cognome, @CF, @Recapito, @CodiceDipendente, @Stipendio, @isGuida, @isTourManager, @isAltro, @IDsede)";
            try
            {
                if (command.ExecuteNonQuery() > 0) return true;
                else return false;

            }
            catch (MySqlException)
            {
                return false;
            }
        }
    }
}
