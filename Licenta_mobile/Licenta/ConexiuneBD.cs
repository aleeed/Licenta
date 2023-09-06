using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licenta
{
    internal class ConexiuneBD
    {
        public static SqlConnection conn = new SqlConnection("Server=tcp:cazare.database.windows.net,1433;Initial Catalog = cazare_camin; Persist Security Info=False;User ID = sqladmin; Password=Steluta1020.; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
    }
}