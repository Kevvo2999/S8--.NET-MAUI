namespace MauiApp1;

public partial class MainPage : ContentPage
{
    private int contador = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        contador++;

        // Buscar el Label por nombre en el XAML
        var label = this.FindByName<Label>("CounterLabel");
        if (label != null)
        {
            label.Text = $"Has presionado el botón {contador} veces.";
        }

        await DisplayAlert("Evento activado",
                           "¡Has presionado el botón!",
                           "Aceptar");
    }
}
