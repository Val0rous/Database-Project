using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DatabaseProject
{
    public class QueryLibrary
    {
        MySqlConnection connection { get; set; }
        public QueryLibrary(MySqlConnection connection)
        {
            this.connection = connection;
        }
        /* Funzioni per l'inserimento di dati nel database
        * input: parametri query
        * output: risultato query-> true: tutto ok, false: errore
        */
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
        public bool InserisciBicicletta(String Produttore, String NumTelaio, char Taglia, int RaggioRuota, String Tipologia, String UltimoControllo, int NumeroRapportiAnteriori, int NumeroRapportiPosteriori, int isElettrica, int PotenzaBatteria, int CapacitàBatteria, String IDmagazzino)
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
        public bool InserisciPercorso(String IDpercorso, String Difficolta, int NumTappe, float LunghezzaPercorso, String IDsede)
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
        public bool InserisciCliente(String Nome, String Cognome, String CF, String Recapito)
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
        public bool InserisciDipendente(String Nome, String Cognome, String CF, String Recapito, String CodiceDipendente, float Stipendio, byte isGuida, byte isTourManager, byte isAltro, String IDsede)
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
        public bool InserisciServizio(String DataInizio, String DataFine, float CostoGiornaliero, String IDservizio, String tipoServizio, String IDpacchetto, String IDsede, String IDpercorso)
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.Parameters.AddWithValue("@DataInizio", DataInizio);
            command.Parameters.AddWithValue("@DataFine", DataFine);
            command.Parameters.AddWithValue("@CostoGiornaliero", CostoGiornaliero);
            command.Parameters.AddWithValue("@IDservizio", IDservizio);
            command.Parameters.AddWithValue("@tipoServizio", tipoServizio);
            command.Parameters.AddWithValue("@IDpacchetto", IDpacchetto);
            command.Parameters.AddWithValue("@IDsede", IDsede);
            command.Parameters.AddWithValue("@IDpercorso", IDpercorso);
            if (tipoServizio=="PERCORSO_GUIDATO")
            {
                command.CommandText = "INSERT INTO servizio (DataInizio, DataFine, CostoGiornaliero, IDservizio, tipoServizio, IDpacchetto, IDsede, IDpercorso) " +
                "VALUES (@DataInizio, @DataFine, @CostoGiornaliero, @IDservizio, @tipoServizio, @IDpacchetto, @IDsede, @IDpercorso)";
            }
            else
            {
                command.CommandText = "INSERT INTO servizio (DataInizio, DataFine, CostoGiornaliero, IDservizio, tipoServizio, IDpacchetto, IDsede) " +
                "VALUES (@DataInizio, @DataFine, @CostoGiornaliero, @IDservizio, @tipoServizio, @IDpacchetto, @IDsede)";
            }
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
        public bool InserisciTour(String Destinazione, String Nome, String DataInizio, String DataFine, float Prezzo, String IDtour, String IDsede, String CFtourManager)
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.Parameters.AddWithValue("@Destinazione", Destinazione);
            command.Parameters.AddWithValue("@Nome", Nome);
            command.Parameters.AddWithValue("@DataInizio", DataInizio);
            command.Parameters.AddWithValue("@DataFine", DataFine);
            command.Parameters.AddWithValue("@Prezzo", Prezzo);
            command.Parameters.AddWithValue("@IDtour", IDtour);
            command.Parameters.AddWithValue("@IDsede", IDsede);
            command.Parameters.AddWithValue("@CFtourManager", CFtourManager);
            command.CommandText = "INSERT INTO cliente (Destinazione, Nome, DataInizio, DataFine, Prezzo, IDtour, IDsede, CFtourManager) " +
                "VALUES (@Destinazione, @Nome, @DataInizio, @DataFine, @Prezzo, @IDtour, @IDsede, @CFtourManager)";
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
        public bool InserisciMagazzino(long CapienzaMassimaAccessori, long CapienzaMassimaBici, String IDmagazzino, String IDIndirizzo, String IDsede)
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.Parameters.AddWithValue("@CapienzaMassimaAccessori", CapienzaMassimaAccessori);
            command.Parameters.AddWithValue("@CapienzaMassimiBici", CapienzaMassimaBici);
            command.Parameters.AddWithValue("@IDmagazzino", IDmagazzino);
            command.Parameters.AddWithValue("@IDIndirizzo", IDIndirizzo);
            command.Parameters.AddWithValue("@IDsede", IDsede);
            command.CommandText = "INSERT INTO magazzino (CapienzaMassimaAccessori, CapienzaMassimaBici, IDmagazzino, IDInidirizzo, IDsede) " +
                "VALUES (@CapienzaMassimaAccessori, @CapienzaMassimaBici, @IDmagazzino, @IDIndirizzo, @IDsede)";
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
        /* Funzioni per la lettura di dati dal database
        * input: eventuali parametri WHERE
        * output: MySqlDataReader, poi gestito da programma
        */
        public MySqlDataReader LeggiAgenzie()
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.CommandText = "SELECT * FROM agenzia";
            return command.ExecuteReader();
        }
        public MySqlDataReader LeggiSedi()
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.CommandText = "SELECT * FROM sede";
            return command.ExecuteReader();
        }
        public MySqlDataReader LeggiSedi(String PIVAagenzia)
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.Parameters.AddWithValue("@PIVA", PIVAagenzia);
            command.CommandText = "SELECT * FROM sede WHERE sede.PIVAagenzia=@PIVA";
            return command.ExecuteReader();
        }
        public MySqlDataReader LeggiAccessori()
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.CommandText = "SELECT * FROM accessorio";
            return command.ExecuteReader();
        }
        public MySqlDataReader LeggiClienti()
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.CommandText = "SELECT * FROM cliente";
            return command.ExecuteReader();
        }
        public MySqlDataReader LeggiDipendenti()
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.CommandText = "SELECT * FROM dipendente";
            return command.ExecuteReader();
        }
        public MySqlDataReader LeggiDipendenti(String IDsede)
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.Parameters.AddWithValue("@IDsede", IDsede);
            command.CommandText = "SELECT * FROM dipendente WHERE dipendente.IDsede=@IDsede";
            return command.ExecuteReader();
        }
        public MySqlDataReader LeggiIndirizzi()
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.CommandText = "SELECT * FROM insirizzo";
            return command.ExecuteReader();
        }
        public MySqlDataReader LeggiIndirizzi(String IDindirizzo)
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.Parameters.AddWithValue("@IDindirizzo", IDindirizzo);
            command.CommandText = "SELECT * FROM indirizzo WHERE indirizzo.IDindirizzo=@IDindirizzo";
            return command.ExecuteReader();
        }

        public MySqlDataReader LeggiMagazzini()
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.CommandText = "SELECT * FROM magazzino";
            return command.ExecuteReader();
        }
        public MySqlDataReader LeggiMagazzini(String IDsede)
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.Parameters.AddWithValue("@IDsede", IDsede);
            command.CommandText = "SELECT * FROM magazzino WHERE magazzino.IDsede=@IDsede";
            return command.ExecuteReader();
        }
        public MySqlDataReader LeggiPacchetti()
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.CommandText = "SELECT * FROM pacchetti";
            return command.ExecuteReader();
        }
        public MySqlDataReader LeggiPacchetti(String IDpacchetto)
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.Parameters.AddWithValue("@IDpacchetto", IDpacchetto);
            command.CommandText = "SELECT * FROM servizi WHERE servizi.IDpacchetto=@IDpacchetto";
            return command.ExecuteReader();
        }
        public MySqlDataReader LeggiServizi()
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.CommandText = "SELECT * FROM servizi";
            return command.ExecuteReader();
        }
        public MySqlDataReader LeggiServizi(String IDpacchetto)
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.Parameters.AddWithValue("@IDpacchetto", IDpacchetto);
            command.CommandText = "SELECT * FROM servizi WHERE servizi.IDpacchetto=@IDpacchetto";
            return command.ExecuteReader();
        }




    }
}
