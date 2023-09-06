namespace Licenta_test;

public partial class Registration : ContentPage
{
	public Registration()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;


        if ((username == "ale@student.upt.ro") & (password == "pass"))
        {
            // Successful login
            await DisplayAlert("Success", "Successful registred!", "OK");
            await Navigation.PushAsync(new Register());
        }
        else
        {
            // Failed login
            await DisplayAlert("Error", "Invalid credentials. Please try again.", "OK");
        }
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }
}