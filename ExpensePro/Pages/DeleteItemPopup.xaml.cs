using CommunityToolkit.Maui.Views;

namespace ExpensePro.Pages;

public partial class DeleteItemPopup : Popup
{
	public DeleteItemPopup()
	{
		InitializeComponent();
	}

    void DeletBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        var cat = CategoryName.Text;
    }

    void CancelBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Close();
    }
}
