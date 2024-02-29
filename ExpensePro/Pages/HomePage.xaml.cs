using ExpensePro.Models;

namespace ExpensePro.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();

	}
    async void TapCategory1_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        var param = ((TappedEventArgs)e).Parameter;
        Console.WriteLine(">>HomePage >>TapCategory1_Tapped >> param", (string)param);
        await Navigation.PushModalAsync(new ExpenseList());
    }

}
