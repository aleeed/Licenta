using DocumentFormat.OpenXml.Office2013.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MTP
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                SqlConnection conn = new SqlConnection("Server=tcp:cazare.database.windows.net,1433;Initial Catalog = cazare_camin; Persist Security Info=False;User ID = sqladmin; Password=Steluta1020.; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
                SqlCommand cmd;
                SqlDataReader dr;

                try
                {
                    ConexiuneBD.conn.Open();
                    cmd = new SqlCommand("select Nume from date_studenti", ConexiuneBD.conn);

                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DropDownList1.Items.Add(dr[0].ToString());
                    }

                }
                catch (Exception ex)
                {
                    LabelEroare.Text = "Nu se poate realiza conexiunea " + ex.Message;
                }
                finally
                {
                    ConexiuneBD.conn.Close();
                }
            }
        }




        protected void Button1_Click(object sender, EventArgs e)
        {

            GVbind();
        }


        protected void GVbind()
        {

            //SqlConnection conn = new SqlConnection("Server=tcp:cazare.database.windows.net,1433;Initial Catalog = cazare_camin; Persist Security Info=False;User ID = sqladmin; Password=Steluta1020.; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
            SqlCommand cmd;

            ConexiuneBD.conn.Open();
            cmd = new SqlCommand("SELECT email, Nume,Prenume, Adresa, CNP, SerieCI, NrCI, NumeMama, NumeTata, Facultatea, AnStudiu, Specializarea, TeleofonParinte, TelefonStudent, Gen, NrMatricol, Judet" +
                " FROM date_studenti WHERE Nume='" + DropDownList1.Text + "'", ConexiuneBD.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {

                GridView1.DataSource = dr;
                GridView1.DataBind();

            }


        }
    }
}