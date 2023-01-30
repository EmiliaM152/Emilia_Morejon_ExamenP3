//using static Android.Provider.DocumentsContract;
using System.Collections.ObjectModel;
using Emilia_Morejon_ExamenP3.Models;
using Android.Net;
using Emilia_Morejon_ExamenP3.Data;

namespace Emilia_Morejon_ExamenP3.Views;

public partial class UserPage : ContentPage
{
    public UserPage()
    {
        InitializeComponent();
    }

    private async void llamrApi()
    {
        Root resp;
        resp = await App.API.GetUsers(); // aquí asumes que has creado una clase API en tu proyecto
        try
        {
            if (resp.data)
            {
                usersListView.ItemsSource = resp.data;
            }
            else
            {
                await DisplayAlert("Error", resp.data.error, "OK");
            }
        }
        catch (Exception)
        {
            await DisplayAlert("Alerta", "No se logró contactar a la API", "OK");
        }
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        llamrApi();
    }
    

}