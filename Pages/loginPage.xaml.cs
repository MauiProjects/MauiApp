namespace MauiApp.Pages;

public partial class loginPage : ContentPage
{
	public loginPage()
	{
		InitializeComponent();
	}

    private void ButtongoHome_Clicked(object sender, EventArgs e)
    {

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}