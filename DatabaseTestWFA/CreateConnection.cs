using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    public class CreateConnection
    {
        public MySqlConnectionStringBuilder Builder { get; set; }
        public MySqlConnection Connection { get; set; }
        public CreateConnection()
        {
            this.Builder = new MySqlConnectionStringBuilder();
            this.Builder.Server = "localhost";
            this.Builder.UserID = "root";
            this.Builder.Password = "SIMONE2001";
            //this.Builder.Password = "S@9WfQHnqrgFPN";
            this.Builder.Database = "gestionale_per_agenzie_rel";
            this.Connection = new MySqlConnection(this.Builder.ToString());
        }
    }
}
