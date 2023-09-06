using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MTP
{
    public class ConexiuneBD
    {
        public static SqlConnection conn = new SqlConnection("Server=tcp:cazare.database.windows.net,1433;Initial Catalog = cazare_camin; Persist Security Info=False;User ID = sqladmin; Password=Steluta1020.; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
    }
}