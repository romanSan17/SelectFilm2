using System;
using Microsoft.Maui.Controls;

namespace SelectFilm;

public partial class ChooseFilmPage : ContentPage
{
    public ChooseFilmPage()
    {
        InitializeComponent();
    }

    private void OnGenreChanged(object sender, EventArgs e)
    {
        var selectedGenre = GenrePicker.SelectedItem?.ToString();
    }

    private void OnLikeClicked(object sender, EventArgs e)
    {

    }

    private void OnDislikeClicked(object sender, EventArgs e)
    {

    }

    private async void OnFavoritesClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("FavoritesPage"); // если она будет
    }
}
