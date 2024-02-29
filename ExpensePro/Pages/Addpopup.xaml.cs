using CommunityToolkit.Maui.Views;

namespace ExpensePro.Pages;

public partial class Addpopup : Popup
{
	public Addpopup()
	{
		InitializeComponent();
	}

    void OKButton_Clicked(System.Object sender, System.EventArgs e)
    {
		var title = ExpenseTitle.Text;
		var amount = Amount.Text;
		Close();
    }
}
