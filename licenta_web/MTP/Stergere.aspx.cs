using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MTP
{
    public partial class Stergere : System.Web.UI.Page
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


            
            SqlConnection conn = new SqlConnection("Server=tcp:cazare.database.windows.net,1433;Initial Catalog = cazare_camin; Persist Security Info=False;User ID = sqladmin; Password=Steluta1020.; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
            SqlCommand cmd;
            
            try
            {

                string fullName = DropDownList1.SelectedValue;
                //string inputPrenume = DropDownList2.SelectedValue;

                string[] Nume_Prenume = fullName.Split(' ');
                string inputNume = Nume_Prenume[0];


                ConexiuneBD.conn.Open();
                cmd = new SqlCommand("DELETE FROM date_studenti WHERE Nume='" + inputNume + "'", ConexiuneBD.conn);
                cmd.Parameters.AddWithValue("@Nume", inputNume);

                int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        LabelEroare.Text = "Studentul a fost sters cu success";
                        ConexiuneBD.conn.Close();
                }
                    else
                        LabelEroare.Text = "Eroare stergere!";
                }
                catch (Exception ex)
                {
                    //log error 
                    LabelEroare.Text = "Eroare la deschidere baza date " + ex.Message;

                }
                //adaugarea datelor
                finally
                {
                    ConexiuneBD.conn.Close();
                }
            }
        }
    }
