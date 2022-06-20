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
        MySqlConnection Connection { get; set; }
        public QueryLibrary(MySqlConnection connection)
        {
            this.Connection = connection;
        }

        private static string Convert(string parameter)
        {
            return "'" + parameter + "'";
        }
        /*This function returns the new ID for the table, given the id field name*/
        private string GetID(string tableName, string IDFieldName)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT MAX(" + Convert(IDFieldName) + ") FROM " + Convert(tableName);
            var index = command.ExecuteNonQuery().GetString(0);
            string head = index.SubString(0,1);
            int num = Int32.Parse(index.SubString(1));
            num++;
            return head + num.ToString();
        }

        /* Funzioni per l'inserimento di dati nel database
        * input: parametri query
        * output: risultato query-> true: tutto ok, false: errore
        */
        public bool InserisciAccessorio (String Tipologia, String UltimoControllo, String Produttore, char Taglia, String IDaccessorio, String IDmagazzino)
        {
            MySqlCommand command = this.Connection.CreateCommand();
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
            MySqlCommand command = this.Connection.CreateCommand();
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
            MySqlCommand command = this.Connection.CreateCommand();
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
        public bool InserisciTappa(String Inizio, String Fine, float LunghezzaTappa, String IDtappa)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.Parameters.AddWithValue("@Inizio", Inizio);
            command.Parameters.AddWithValue("@Fine", Fine);
            command.Parameters.AddWithValue("@LunghezzaTappa", LunghezzaTappa);
            command.Parameters.AddWithValue("@IDtappa", IDtappa);
            command.CommandText = "INSERT INTO tappa (Inizio, Fine, LunghezzaTappa, IDtappa) " +
                "VALUES (@Inizio, @Fine, @LunghezzaTappa, @IDtappa)";
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
        public bool InserisciSequenza(String IDtappa, int Indice, String IDpercorso)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.Parameters.AddWithValue("@IDtappa", IDtappa);
            command.Parameters.AddWithValue("@Indice", Indice);
            command.Parameters.AddWithValue("@IDpercorso", IDpercorso);
            command.CommandText = "INSERT INTO sequenza (IDtappa, Indice, IDpercorso) " +
                "VALUES (@IDtappa, @Indice, @IDpercorso)";
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
            MySqlCommand command = this.Connection.CreateCommand();
            command.Parameters.AddWithValue("@Nome", Nome);
            command.Parameters.AddWithValue("@Cognome", Cognome);
            command.Parameters.AddWithValue("@CF", CF);
            command.Parameters.AddWithValue("@Recapito", Recapito);
            command.CommandText = "INSERT INTO cliente (Nome, Cognome, CF, Recapito) " +
                "VALUES (@Nome, @Cognome, @CF, @Recapito)";
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
            MySqlCommand command = this.Connection.CreateCommand();
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
        public bool InserisciDipendente(String Nome, String Cognome, String CF, String Recapito, String CodiceDipendente, float Stipendio, byte isGuida, byte isTourManager, byte isAltro, String IDsede, String CFsuperiore)
        {
            MySqlCommand command = this.Connection.CreateCommand();
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
            command.Parameters.AddWithValue("@CFsuperiore", CFsuperiore);
            command.CommandText = "INSERT INTO dipendente (Nome, Cognome, CF, Recapito, CodiceDipendente, Stipendio, isGuida, isTourManager, isAltro, IDsede, CFsuperiore) " +
                "VALUES (@Nome, @Cognome, @CF, @Recapito, @CodiceDipendente, @Stipendio, @isGuida, @isTourManager, @isAltro, @IDsede, @CFsuperiore)";
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
        public bool InserisciPacchetto(float Prezzo, int Sconto, String IDpacchetto, String CFcliente)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.Parameters.AddWithValue("@Prezzo", Prezzo);
            command.Parameters.AddWithValue("@Sconto", Sconto);
            command.Parameters.AddWithValue("@IDpacchetto", IDpacchetto);
            command.Parameters.AddWithValue("@CFcliente", CFcliente);
            command.CommandText = "INSERT INTO pacchetto (Prezzo, Sconto, IDpacchetto, CFcliente) " +
                "VALUES (@Prezzo, @Sconto, @IDpacchetto, @CFcliente)";
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
            MySqlCommand command = this.Connection.CreateCommand();
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

        public bool InserisciNoleggioBicicletta(String IDservizio, String NumTelaio)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.Parameters.AddWithValue("@IDservizio", IDservizio);
            command.Parameters.AddWithValue("@NumTelaio", NumTelaio);
            command.CommandText = "INSERT INTO noleggiobicicletta (IDservizio, NumTelaio) " +
                "VALUES (@IDservizio, @NumTelaio)";
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
        public bool InserisciNoleggioAccessorio(String IDservizio, String IDaccessorio)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.Parameters.AddWithValue("@IDservizio", IDservizio);
            command.Parameters.AddWithValue("@IDaccessorio", IDaccessorio);
            command.CommandText = "INSERT INTO noleggioaccessorio (IDservizio, IDaccessorio) " +
                "VALUES (@IDservizio, @IDaccessorio)";
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
        public bool InserisciPartecipazione(String IDpercorsoGuidato, String CFguida)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.Parameters.AddWithValue("@IDpercorsoGuidato", IDpercorsoGuidato);
            command.Parameters.AddWithValue("@CFguida", CFguida);
            command.CommandText = "INSERT INTO partecipazione (IDpercorsoGuidato, CFguida) " +
                "VALUES (@IDpercorsoGuidato, @CFguida)";
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
            MySqlCommand command = this.Connection.CreateCommand();
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
        public bool InserisciPrenotazione(String CFcliente, String IDtour)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.Parameters.AddWithValue("@CFcliente", CFcliente);
            command.Parameters.AddWithValue("@IDtour", IDtour);
            command.CommandText = "INSERT INTO prenotazione (CFcliente, IDtour) " +
                "VALUES (@CFcliente, @IDtour)";
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
            MySqlCommand command = this.Connection.CreateCommand();
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
        public MySqlCommand LeggiAgenzie()
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM agenzia";
            return command;
        }
        public MySqlCommand LeggiAccessori()
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM accessorio";
            return command;
        }
        public MySqlCommand LeggiAccessori(String IDsede)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            //command.Parameters.AddWithValue("@IDmagazzino", IDmagazzino);
            command.CommandText = "SELECT accessorio.* FROM accessorio, magazzino " +
                "WHERE accessorio.IDmagazzino=magazzino.IDmagazzino AND magazzino.IDsede=" + Convert(IDsede);
            return command;
        }
        public MySqlCommand LeggiAccessori(String IDsede, String Date)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            //command.Parameters.AddWithValue("@IDsede", IDsede);
            //command.Parameters.AddWithValue("@Date", Date);
            command.CommandText = "WITH NoleggiAccessoriAttivi(IDaccessorio) AS(SELECT A.IDaccessorio FROM accessorio A, noleggioaccessorio NA, servizio S " +
            "WHERE A.IDaccessorio = NA.IDaccessorio AND NA.IDservizio = S.IDservizio AND " + Convert(Date) + " >= S.DataInizio AND " + Convert(Date) + " <= S.DataFine) " +
            "SELECT * FROM accessorio A WHERE A.IDaccessorio NOT IN(SELECT NAA.IDaccessorio FROM NoleggiAccessoriAttivi AS NAA) " +
            "AND A.IDmagazzino IN(SELECT IDmagazzino FROM sede S, magazzino M WHERE S.IDsede=" + Convert(IDsede) + " AND M.IDsede= S.IDsede);";
            return command;
        }
        public MySqlCommand LeggiAccessorioPiuRichiesto(String IDsede, int Month)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            //command.Parameters.AddWithValue("@IDsede", IDsede);
            //command.Parameters.AddWithValue("@Date", Date);
            command.CommandText = "SELECT A.IDaccessorio, COUNT(NA.IDservizio) "+
                "FROM accessorio AS A, noleggioAccessorio AS NA, servizio AS S"+
                "WHERE A.IDaccessorio=NA.IDaccessorio AND NA.IDservizio=S.IDservizio "+
                "AND S.IDsede=" + Convert(IDsede) + $" AND MONTH(S.DataInizio)={Month} " + 
                "ORDER BY Count(NA.IDservizio) DESC LIMIT 1";
            return command;
        }
        public MySqlCommand LeggiAccessoriOrdinati(String IDsede)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT A.* FROM accessorio A JOIN magazzino M ON A.IDMagazzino = M.IDMagazzino " +
                "WHERE M.IDsede = "+Convert(IDsede)+" ORDER BY A.UltimoControllo DESC";
            return command;
        }
        public MySqlCommand LeggiBiciclette()
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM bicicletta";
            return command;
        }
        public MySqlCommand LeggiBiciclette(String IDsede)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            //command.Parameters.AddWithValue("@IDmagazzino", IDmagazzino);
            command.CommandText = command.CommandText = "SELECT bicicletta.* FROM bicicletta, magazzino " +
                "WHERE bicicletta.IDmagazzino=magazzino.IDmagazzino AND magazzino.IDsede=" + Convert(IDsede);
            return command;
        }
        public MySqlCommand LeggiBiciclette(String IDsede, String Date)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            //command.Parameters.AddWithValue("@IDsede", IDsede);
            //command.Parameters.AddWithValue("@Date", Date);
            command.CommandText = "WITH NoleggiBicicletteAttivi(NumTelaio) AS(SELECT B.NumTelaio FROM bicicletta B, noleggiobicicletta NB, servizio S " +
            "WHERE B.NumTelaio = NB.NumTelaio AND NB.IDservizio = S.IDservizio AND " + Convert(Date) + " >= S.DataInizio AND " + Convert(Date) + " <= S.DataFine) " +
            "SELECT * FROM bicicletta B WHERE B.NumTelaio NOT IN(SELECT NBA.NumTelaio FROM NoleggiBicicletteAttivi AS NBA) " +
            "AND B.IDmagazzino IN(SELECT IDmagazzino FROM sede S, magazzino M WHERE S.IDsede= " + Convert(IDsede) + " AND M.IDsede= S.IDsede);";
            return command;
        }
        public MySqlCommand LeggiBicicletteOrdinate(String IDsede)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            //command.Parameters.AddWithValue("@IDmagazzino", IDmagazzino);
            command.CommandText = command.CommandText = "SELECT bicicletta.* FROM bicicletta, magazzino " +
                "WHERE bicicletta.IDmagazzino=magazzino.IDmagazzino AND magazzino.IDsede=" + Convert(IDsede)+
                " ORDER BY bicicletta.UltimoControllo DESC";
            return command;
        }
        public MySqlCommand LeggiBusinessPartner(String PIVAagenzia)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * " +
                "FROM partnershipattrazione as PA, partnershipristorante as PR, partnershipsoggiorno as PS " +
                "WHERE PA.PIVAagenzia=PR.PIVAagenzia AND PR.PIVAagenzia=PS.PIVAagenzia AND PS.PIVAagenzia=" + Convert(PIVAagenzia);
            command.CommandText = "SELECT A.PIVA, A.NomeSocio, A.CostoServizio, A.Recapito, 'Attrazione' AS Tipo " +
                "FROM partnershipattrazione as PA, attrazione AS A " +
                "WHERE PA.PIVAagenzia = "+Convert(PIVAagenzia)+" AND PA.PIVApartner = A.PIVA " +
                "UNION " +
                "SELECT A.PIVA, A.NomeSocio, A.CostoServizio, A.Recapito, 'Ristorante' AS Tipo " +
                "FROM partnershipristorante as PA, ristorante AS A " +
                "WHERE PA.PIVAagenzia = " + Convert(PIVAagenzia) + " AND PA.PIVApartner = A.PIVA " +
                "UNION " +
                "SELECT A.PIVA, A.NomeSocio, A.CostoServizio, A.Recapito, 'Soggiorno' AS Tipo " +
                "FROM partnershipsoggiorno as PA, soggiorno AS A " +
                "WHERE PA.PIVAagenzia = " + Convert(PIVAagenzia) + " AND PA.PIVApartner = A.PIVA";
            return command;
        }
        public MySqlCommand LeggiClienti()
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM cliente";
            return command;
        }

        public MySqlCommand LeggiDipendenti()
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM dipendente";
            return command;
        }
        public MySqlCommand LeggiDipendenti(String IDsede)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            //command.Parameters.AddWithValue("@IDsede", IDsede);
            command.CommandText = "SELECT * FROM dipendente WHERE dipendente.IDsede=" + Convert(IDsede);
            return command;
        }
        public MySqlCommand LeggiGuide(String IDsede)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM dipendente WHERE dipendente.IDsede=" + Convert(IDsede)+" AND dipendente.isGuida=1";
            return command;
        }
        public MySqlCommand LeggiIndirizzi()
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM indirizzo";
            return command;
        }
        public MySqlCommand LeggiIndirizzi(String IDindirizzo)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            //command.Parameters.AddWithValue("@IDindirizzo", IDindirizzo);
            command.CommandText = "SELECT * FROM indirizzo WHERE indirizzo.IDindirizzo=" + Convert(IDindirizzo);
            return command;
        }
        public MySqlCommand LeggiMagazzini()
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM magazzino";
            return command;
        }
        public MySqlCommand LeggiMagazzini(String IDsede)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM magazzino WHERE magazzino.IDsede=" + Convert(IDsede);
            return command;
        }
        public MySqlCommand LeggiMagazziniToString(String IDsede)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM magazzino WHERE magazzino.IDsede='" + Convert(IDsede);
            return command;
        }
        public MySqlCommand LeggiNoleggiAccessori()
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM noleggioaccessorio";
            return command;
        }
        public MySqlCommand LeggiNoleggiAccessori(String IDservizio)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            //command.Parameters.AddWithValue("@IDservizio", IDservizio);
            command.CommandText = "SELECT * FROM noleggioaccessorio WHERE noleggioaccessorio.IDservizio=" + Convert(IDservizio);
            return command;
        }
        public MySqlCommand LeggiNoleggiBiciclette()
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM noleggiobicicletta";
            return command;
        }
        public MySqlCommand LeggiNoleggiBiciclette(String IDservizio)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM noleggiobicicletta WHERE noleggiobicicletta.IDservizio="+Convert(IDservizio);
            return command;
        }
        public MySqlCommand LeggiPacchetti()
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM pacchetto";
            return command;
        }
        public MySqlCommand LeggiPacchetti(String CFcliente)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM pacchetto WHERE pacchetto.CFcliente="+Convert(CFcliente);
            return command;
        }
        public MySqlCommand LeggiPercorso()
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM percorso";
            return command;
        }
        public MySqlCommand LeggiPercorso(String IDsede)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM percorso WHERE percorso.IDsede="+Convert(IDsede);
            return command;
        }
        public MySqlCommand LeggiPeriodoMedioPrenotazioneAccessori(String PIVA)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT S.IDsede, AVG(CAST(DATEDIFF(V.DataFine, V.DataInizio) AS float)) AS PeriodoMedioAccessori "+
                "FROM servizio V, sede S WHERE S.PIVAagenzia = " + Convert(PIVA) + " AND V.TipoServizio = 'Noleggio_Accessori' AND S.IDsede = V.IDsede GROUP BY IDSede";
            return command;
        }
        public MySqlCommand LeggiPeriodoMedioPrenotazioneBici(String PIVA)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT S.IDsede, AVG(CAST(DATEDIFF(V.DataFine, V.DataInizio) AS float)) AS PeriodoMedioBici "+
                "FROM servizio V, sede S WHERE S.PIVAagenzia = " + Convert(PIVA) + " AND V.TipoServizio = 'Noleggio_Bici' AND S.IDsede = V.IDsede GROUP BY IDSede";
            return command;
        }
        public MySqlCommand LeggiPrenotazioni()
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM prenotazione";
            return command;
        }
        public MySqlCommand LeggiPrenotazioni(String IDsede)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT prenotazione.* " +
                "FROM prenotazione, tour " +
                "WHERE prenotazione.IDtour = tour.IDtour AND tour.IDsede ="+Convert(IDsede);
            return command;
        }
        public MySqlCommand LeggiPrenotazioniTour(String IDtour)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM prenotazione WHERE prenotazione.IDtour="+Convert(IDtour);
            return command;
        }
        public MySqlCommand LeggiPrenotazioniCliente(String CFcliente)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM prenotazione WHERE prenotazione.CFcliente="+Convert(CFcliente);
            return command;
        }
        public MySqlCommand LeggiSedi()
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM sede";
            return command;
        }
        public MySqlCommand LeggiSedi(String PIVAagenzia)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM sede WHERE sede.PIVAagenzia="+Convert(PIVAagenzia);
            return command;
        }
        public MySqlCommand LeggiServizi()
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM servizio";
            return command;
        }
        public MySqlCommand LeggiServizi(String IDpacchetto)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM servizio WHERE servizio.IDpacchetto="+Convert(IDpacchetto);
            return command;
        }
        public MySqlCommand LeggiTagliaBicicletta(String IDsede, int Month)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT B.Taglia, COUNT(NB.IDservizio) FROM bicicletta AS B, noleggioBicicletta AS NB, servizio AS S " +
                    "WHERE B.NumTelaio=NB.NumTelaio AND NB.IDservizio=S.IDservizio " + 
                    "AND S.IDsede=" + Convert(IDsede) + $" AND MONTH(S.DataInizio)={Month} " + 
                    "GROUP BY B.Taglia ORDER BY Count(NB.IDservizio) DESC LIMIT 1";
            return command;
        }
        public MySqlCommand LeggiServiziCliente(String CFcliente)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT S.* FROM cliente C, pacchetto P, servizio S " +
                "WHERE C.CF=" + Convert(CFcliente) + " AND P.CFcliente = C.CF AND S.IDpacchetto = P.IDpacchetto";
            return command;
        }
        public MySqlCommand LeggiStipendioMedio(String IDsede)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT AVG(Stipendio) AS StipendioMedio FROM dipendente WHERE IDSede ="+Convert(IDsede);
            return command;
        }
        public MySqlCommand LeggiTour()
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM tour";
            return command;
        }
        public MySqlCommand LeggiTour(String IDsede)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM tour WHERE tour.IDsede="+Convert(IDsede);
            return command;
        }
        public MySqlCommand LeggiTour(String IDsede, String Date)
        {
            MySqlCommand command = this.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM tour AS t WHERE t.IDsede=" + Convert(IDsede) + " AND " + Convert(Date) + " >= t.DataInizio AND " + Convert(Date) + " <= t.DataFine ";
            return command;
        }
        
    }
}
