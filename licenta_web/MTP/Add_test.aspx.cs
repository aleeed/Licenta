using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MTP
{
    public partial class Add_test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool add_all_values = false;
            //if (string.IsNullOrWhiteSpace(txtName.Text))
            //{
            //    // Display an error message
            //    lblMessage.Text = "Please enter a value in the textbox.";
            //}

            SqlCommand cmd;
            if (TextBox5.Text.ToString().Length != 13)
            {
                Label1.Visible = true;
                add_all_values = true;
            }

            if (TextBox6.Text.ToString().Length != 2)
            {
                Label2.Visible = true;
                add_all_values = true;
            }
            if (TextBox7.Text.ToString().Length != 6)
            {
                Label3.Visible = true;
                add_all_values = true;
            }
            if (TextBox14.Text.ToString().Length != 10)
            {
                Label4.Visible = true;
                add_all_values = true;
            }
            if (TextBox13.Text.ToString().Length != 10)
            {
                Label5.Visible = true;
                    add_all_values = true;
            }
            if (DropDownList1.SelectedValue == "")
            {
                Label6.Visible = true;
                add_all_values = true;
            }
            if (DropDownList2.SelectedValue == "")
            {
                Label7.Visible = true;
                add_all_values = true;
            }
            else
            {
                try
                {
                    if (add_all_values == true)
                        LabelEroare.Visible = true; 

                    else
                        ConexiuneBD.conn.Open();
                        cmd = new SqlCommand("insert into date_studenti (email, Nume,Prenume, Adresa, CNP, SerieCI, NrCI, NumeMama, NumeTata, Facultatea, AnStudiu, Specializarea, TeleofonParinte, TelefonStudent, Gen, NrMatricol, Judet, NrCamera)" +
                            " values(@email, @Nume,@Prenume, @Adresa, @CNP, @SerieCI, @NrCI, @NumeMama, @NumeTata, @Facultatea, @AnStudiu, @Specializarea, @TeleofonParinte, @TelefonStudent, @Gen, @NrMatricol, @Judet, @NrCamera) ", ConexiuneBD.conn);
                        cmd.Parameters.AddWithValue("@email", TextBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Nume", TextBox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@Prenume", TextBox3.Text.Trim());
                        cmd.Parameters.AddWithValue("@Adresa", TextBox4.Text.Trim());

                        cmd.Parameters.AddWithValue("@CNP", TextBox5.Text.Trim());
                        cmd.Parameters.AddWithValue("@SerieCI", TextBox6.Text.Trim());
                        cmd.Parameters.AddWithValue("@NrCI", TextBox7.Text.Trim());
                        cmd.Parameters.AddWithValue("@NumeMama", TextBox8.Text.Trim());
                        cmd.Parameters.AddWithValue("@NumeTata", TextBox9.Text.Trim());
                        cmd.Parameters.AddWithValue("@Facultatea", DropDownList1.SelectedValue.Trim());
                        cmd.Parameters.AddWithValue("@AnStudiu", DropDownList2.SelectedValue.Trim());
                        cmd.Parameters.AddWithValue("@Specializarea", TextBox12.Text.Trim());
                        cmd.Parameters.AddWithValue("@TeleofonParinte", TextBox13.Text.Trim());
                        cmd.Parameters.AddWithValue("@TelefonStudent", TextBox14.Text.Trim());

                        cmd.Parameters.AddWithValue("@Gen", DropDownList3.SelectedValue.Trim());
                        cmd.Parameters.AddWithValue("@NrMatricol", TextBox11.Text.Trim());
                        cmd.Parameters.AddWithValue("@Judet", TextBox10.Text.Trim());
                        cmd.Parameters.AddWithValue("@NrCamera", TextBox15.Text.Trim());

                    



                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 1)
                        {
                            LabelEroare.Text = "Studentul a fost adaugat cu success";
                            ConexiuneBD.conn.Close();

                            TextBox1.Text = string.Empty;
                            TextBox2.Text = string.Empty;
                            TextBox3.Text= string.Empty;    
                            TextBox4.Text = string.Empty;
                            TextBox5.Text = string.Empty;
                            TextBox6.Text = string.Empty;
                            TextBox7.Text = string.Empty;
                            TextBox8.Text = string.Empty;
                            TextBox9.Text = string.Empty;
                            TextBox10.Text = string.Empty;
                            TextBox11.Text = string.Empty;
                            TextBox12.Text = string.Empty;
                            TextBox13.Text = string.Empty;
                            TextBox14.Text = string.Empty;
                            TextBox15.Text = string.Empty;
                            DropDownList1.SelectedIndex = -1;
                            DropDownList2.SelectedIndex = -1;
                            DropDownList3.SelectedIndex = -1;
                        }
                        else
                            LabelEroare.Text = "Eroare inserare!";
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
}