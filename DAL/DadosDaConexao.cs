using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Data Access Layer*/
namespace DAL
{
    public class DadosDaConexao
    {
        private string server = "sql10.freemysqlhosting.net";
        private string port = "3306";
        private string user = "sql10351329";
        private string pass = "qHtI2jILu6";
        private string database = "sql10351329";

        public string StringDeConexao
        {
            get
            {
                return "server=" + this.server + ";" +
                       "port=" + this.port + ";" +
                       "User Id= " + this.user + ";" +
                       "Password=" + this.pass + ";" +
                       "database= " + this.database + ";";
            }
        }

    }
}
