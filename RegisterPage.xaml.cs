namespace SelectFilm;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {

    }

    //    private async void OnRegisterClicked(object sender, EventArgs e)
    //    {
    //        string username = usernameEntry.Text?.Trim();
    //        string password = passwordEntry.Text;
    //        string confirmPassword = confirmPasswordEntry.Text;

    //        errorLabel.IsVisible = false;

    //        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
    //        {
    //            errorLabel.Text = "Пожалуйста, заполните все поля";
    //            errorLabel.IsVisible = true;
    //            return;
    //        }

    //        if (password != confirmPassword)
    //        {
    //            errorLabel.Text = "Пароли не совпадают";
    //            errorLabel.IsVisible = true;
    //            return;
    //        }

    //        // Здесь можно добавить логику сохранения нового пользователя, пока пропустим

    //        await DisplayAlert("Успешно", "Регистрация прошла успешно!", "ОК");
    //        await Shell.Current.GoToAsync("LoginPage");
    //    }

    //    private async void OnGoToLoginClicked(object sender, EventArgs e)
    //    {
    //        await Shell.Current.GoToAsync("LoginPage");
    //    }
}
