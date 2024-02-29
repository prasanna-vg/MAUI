using ExpensePro.Services;

namespace ExpensePro.Pages;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

    async void RegisterBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        var response = await ApiService.RegisterUser(EntName.Text, EntEmail.Text, EntPassword.Text);
        if (response)
        {
            await DisplayAlert("", "Your account has been created!", "Alright");
            await Navigation.PushModalAsync(new LoginPage());
        }
        else
        {
            await DisplayAlert("", "Something went wrong", "Cancel");
        }
    }

    async void TapLogin_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        await Navigation.PushModalAsync(new LoginPage());
    }
}
