using ExpensePro.Pages;

namespace ExpensePro;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		var email = Preferences.Get("userEmail", string.Empty);
		if (string.IsNullOrEmpty(email))
		{
			MainPage = new LoginPage();
		}
		else
		{
			MainPage = new HomePage();
		}
		//MainPage = new MainPage();
	}
}

