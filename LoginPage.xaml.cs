using Microsoft.Extensions.Logging.Abstractions;

namespace SelectFilm;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = usernameEntry.Text?.Trim();
        string password = passwordEntry.Text;

        if (username == "user" && password == "1234")
        {
            await Shell.Current.GoToAsync("ChooseFilmPage");
        }
        else
        {
            errorLabel.Text = "Invalid username or password";
            errorLabel.IsVisible = true;
        }
    }
}