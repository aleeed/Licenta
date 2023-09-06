using Microsoft.Data.SqlClient;

namespace Licenta;

public partial class AddStudentPage : ContentPage
{
    private const string ConnectionString = "Server=tcp:cazare.database.windows.net,1433;Initial Catalog = cazare_camin; Persist Security Info=False;User ID = sqladmin; Password=Steluta1020.; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";
    public AddStudentPage()
    {
        InitializeComponent();
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            try
            {
                await connection.OpenAsync();

                string query = "insert into date_studenti (email, Nume,Prenume, Adresa, CNP, SerieCI, NrCI, NumeMama, NumeTata, Facultatea, AnStudiu, Specializarea, TeleofonParinte, TelefonStudent, Gen, NrMatricol, Judet)" +
                      " values(@email, @Nume,@Prenume, @Adresa, @CNP, @SerieCI, @NrCI, @NumeMama, @NumeTata, @Facultatea, @AnStudiu, @Specializarea, @TeleofonParinte, @TelefonStudent, @Gen, @NrMatricol, @Judet";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nume", NameEntry.Text);
                    command.Parameters.AddWithValue("@Prenume", PrenumeEntry.Text);

                    command.Parameters.AddWithValue("@Adresa", AdresaEntry);
                    command.Parameters.AddWithValue("@CNP", CnpEntry);
                    command.Parameters.AddWithValue("@SerieCI", SerieCiEntry);
                    command.Parameters.AddWithValue("@NrCI", NrCiEntry);
                    command.Parameters.AddWithValue("@NumeMama", NumeMamaEntry);
                    command.Parameters.AddWithValue("@NumeTata", NumeTataEntry);
                    command.Parameters.AddWithValue("@Facultatea", FacultateaEntry);
                    command.Parameters.AddWithValue("@AnStudiu", AnStudiuEntry);
                    command.Parameters.AddWithValue("@Specializarea", SpecializareaEntry);
                    command.Parameters.AddWithValue("@TeleofonParinte", TelefonParinteEntry);
                    command.Parameters.AddWithValue("@TelefonStudent", TelefonStudentEntry);
                    command.Parameters.AddWithValue("@Gen", GenEntry);
                    command.Parameters.AddWithValue("@NrMatricol", NrMatricolEntry);
                    command.Parameters.AddWithValue("@Judet", JudetEntry);


                    await command.ExecuteNonQueryAsync();
                }

                await DisplayAlert("Success", "Data saved to the database.", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }
        }
    }

}