using ExpensePro.Services;

namespace ExpensePro.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    async void LoginBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        var response = await ApiService.LoginUser(EntEmail.Text, EntPassword.Text);
        Application.Current.MainPage = new HomePage();

    }
    async void TapRegister_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        await Navigation.PushModalAsync(new RegisterPage());
    }
}
