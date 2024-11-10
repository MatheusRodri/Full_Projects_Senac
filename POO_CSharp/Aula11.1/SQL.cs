using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    public class SQL
    {
        public SqlConnection connection = new SqlConnection();
        
        public SQL()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = @"10.135.0.53\sqledutsi";
            sb.UserID = "aluno";
            sb.Password = "aluno";
            sb.InitialCatalog = "IBGE";
            sb.Encrypt = true;//Dados encripatados
            sb.TrustServerCertificate = true;

            connection.ConnectionString = sb.ConnectionString;
        }
    }
}
