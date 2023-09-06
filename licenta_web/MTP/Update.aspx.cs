using DocumentFormat.OpenXml.Office.Word;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MTP
{
    public partial class Update : System.Web.UI.Page
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
                    cmd = new SqlCommand("select Nume, Prenume from date_studenti", ConexiuneBD.conn);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["Nume"].ToString();
                            string surname = reader["Prenume"].ToString();

                            // Combine name and surname and add to the DropDownList
                            string fullName = $"{name} {surname}";
                            DropDownList1.Items.Add(fullName);
                        }
                    }
                    ConexiuneBD.conn.Close();

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
            SqlCommand cmd;
            try
            {
                string fullName = DropDownList1.SelectedValue;
                //string inputPrenume = DropDownList2.SelectedValue;

                string[] Nume_Prenume = fullName.Split(' ');
                string inputNume = Nume_Prenume[0];
                string newValue = TextBox1.Text;
                string option = DropDownList2.SelectedValue;

                ConexiuneBD.conn.Open();

                cmd = new SqlCommand("UPDATE date_studenti SET "+ option +" = @newValue WHERE Nume = '" + inputNume + "' ", ConexiuneBD.conn);
                cmd.Parameters.AddWithValue("@newValue", newValue);

                cmd.Parameters.AddWithValue("@Nume", inputNume);


                
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 1)
                {
                    LabelEroare.Text = "Datele au fost actualizate cu success";
                    ConexiuneBD.conn.Close();
                }
                else
                    LabelEroare.Text = "Eroare actualizare date!";

            }



            catch (Exception ex)
            {
                LabelEroare.Text = "Eroare la deschidere baza date " + ex.Message;
            }

            finally
            {
                //string url = "Home.aspx";
                //Response.Redirect(url);
                ConexiuneBD.conn.Close();

            }
            
        }

    }
}