using System;
using Microsoft.Data.SqlClient;
using Microsoft.Maui.Controls;

namespace Licenta;

public partial class MainPage : ContentPage
{
   
    public MainPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        try
        {
            ConexiuneBD.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT password FROM date_login WHERE email='" + username + "' ", ConexiuneBD.conn);
            //cmd.Parameters.AddWithValue("@Username", EmailEntry.Text.Trim());


            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                if (EncDec.Decrypt(dr[0].ToString().Trim()) == password)
                {
                    await DisplayAlert("Success", "Login successful!", "OK");
                    await Navigation.PushAsync(new Register());
                }
                else
                {
                    // Password doesn't match
                  
                    await DisplayAlert("Error", "parola nu se potriveste", "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Userul nu a fost gasit", "OK");
            }


        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", "Nu se poate realiza conexiunea", "OK");
        }
        finally
        {
            ConexiuneBD.conn.Close();
        }
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Registration());
    }
}






