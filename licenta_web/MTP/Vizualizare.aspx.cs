using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading.Tasks;

namespace MTP
{

    public partial class Vizualizare : System.Web.UI.Page
    {



        //    List<Student> Students = new List<Student>();
        //    protected async void Page_Load(object sender, EventArgs e)
        //    {
        //        if (!IsPostBack)
        //        {
        //            //DataTable dt = new DataTable();


        //            try
        //            {
        //                SqlConnection conn = new SqlConnection("Server=tcp:cazare.database.windows.net,1433;Initial Catalog = cazare_camin; Persist Security Info=False;User ID = sqladmin; Password=Steluta1020.; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
        //                SqlCommand cmd = new SqlCommand("SELECT email, Nume,Prenume, Adresa, CNP, SerieCI, NrCI, NumeMama, NumeTata, Facultatea, AnStudiu, Specializarea, TeleofonParinte, TelefonStudent" +
        //                    " FROM date_studenti", ConexiuneBD.conn);

        //                await conn.OpenAsync();

        //                SqlDataReader reader = await cmd.ExecuteReaderAsync();
        //                while (await reader.ReadAsync())
        //                {
        //                    Students.Add(new Student
        //                    {
        //                        Email = reader.GetString(0),
        //                        Nume = reader.GetString(1),
        //                        Prenume = reader.GetString(2),
        //                        Adresa = reader.GetString(3),
        //                        CNP = reader.GetString(4),
        //                        SerieCI = reader.GetString(5),
        //                        NrCI = reader.GetString(6),
        //                        NumeMama = reader.GetString(7),
        //                        NumeTata = reader.GetString(8),
        //                        Facultatea = reader.GetString(9),
        //                        AnStudiu = reader.GetString(10),
        //                        Specializarea = reader.GetString(11),
        //                        TeleofonParinte = reader.GetString(12),
        //                        TelefonStudent = reader.GetString(13),
        //                    });
        //                }
        //            }


        //            catch (Exception ex)
        //            {

        //                LabelEroare.Text = "Eroare la deschidere baza date " + ex.Message;
        //            }

        //            finally
        //            {
        //                ConexiuneBD.conn.Close();
        //            }
        //        }

        //        }
        //    }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GVbind();

            }
        }

        protected void GVbind() {

            //SqlConnection conn = new SqlConnection("Server=tcp:cazare.database.windows.net,1433;Initial Catalog = cazare_camin; Persist Security Info=False;User ID = sqladmin; Password=Steluta1020.; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
            SqlCommand cmd;

            ConexiuneBD.conn.Open();
            cmd = new SqlCommand("SELECT email, Nume,Prenume, Gen, Adresa, Judet, CNP, SerieCI, NrCI, NumeMama, NumeTata, TeleofonParinte, TelefonStudent, Facultatea, AnStudiu, Specializarea,  NrMatricol, NrCamera" +
                " FROM date_studenti", ConexiuneBD.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true) {
            
                GridView1.DataSource= dr;
                GridView1.DataBind();
                ConexiuneBD.conn.Close();

            }
        }



    }
}