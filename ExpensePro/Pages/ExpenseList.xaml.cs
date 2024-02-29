using CommunityToolkit.Maui.Views;
using ExpensePro.Models;

namespace ExpensePro.Pages;

public partial class ExpenseList : ContentPage
{
    void AddButton_Clicked(System.Object sender, System.EventArgs e)
    {
        var popup = new Addpopup();
        this.ShowPopup(popup);
    }
    public ExpenseList()
    {
        InitializeComponent();
        var item = new List<ExpenseData>
        {
            new  ExpenseData { category="Shopping", amount=300, created_at=new DateTime(2015, 12, 02), id =5, user_email="11@22.com"},
            new  ExpenseData { category="Shopping2", amount=200, created_at=new DateTime(2015, 06, 05), id =2, user_email="112@22.com"},
            new  ExpenseData { category="Shopping3", amount=350, created_at=new DateTime(2015, 09, 15), id =3, user_email="121@22.com"},
            new  ExpenseData { category="Shopping4", amount=650, created_at=new DateTime(2015, 11, 20), id =6, user_email="131@22.com"},
            new  ExpenseData { category="Shopping", amount=300, created_at=new DateTime(2015, 12, 02), id =5, user_email="11@22.com"},
            new  ExpenseData { category="Shopping2", amount=200, created_at=new DateTime(2015, 06, 05), id =2, user_email="112@22.com"},
            new  ExpenseData { category="Shopping3", amount=350, created_at=new DateTime(2015, 09, 15), id =3, user_email="121@22.com"},
            new  ExpenseData { category="Shopping4", amount=650, created_at=new DateTime(2015, 11, 20), id =6, user_email="131@22.com"},
            new  ExpenseData { category="Shopping", amount=300, created_at=new DateTime(2015, 12, 02), id =5, user_email="11@22.com"},
            new  ExpenseData { category="Shopping2", amount=200, created_at=new DateTime(2015, 06, 05), id =2, user_email="112@22.com"},
            new  ExpenseData { category="Shopping3", amount=350, created_at=new DateTime(2015, 09, 15), id =3, user_email="121@22.com"},
            new  ExpenseData { category="Shopping4", amount=650, created_at=new DateTime(2015, 11, 20), id =6, user_email="131@22.com"},
            new  ExpenseData { category="Shopping", amount=300, created_at=new DateTime(2015, 12, 02), id =5, user_email="11@22.com"},
            new  ExpenseData { category="Shopping2", amount=200, created_at=new DateTime(2015, 06, 05), id =2, user_email="112@22.com"},
            new  ExpenseData { category="Shopping3", amount=350, created_at=new DateTime(2015, 09, 15), id =3, user_email="121@22.com"},
            new  ExpenseData { category="Shopping4", amount=650, created_at=new DateTime(2015, 11, 20), id =6, user_email="131@22.com"},
            new  ExpenseData { category="Shopping", amount=300, created_at=new DateTime(2015, 12, 02), id =5, user_email="11@22.com"},
            new  ExpenseData { category="Shopping2", amount=200, created_at=new DateTime(2015, 06, 05), id =2, user_email="112@22.com"},
            new  ExpenseData { category="Shopping3", amount=350, created_at=new DateTime(2015, 09, 15), id =3, user_email="121@22.com"},
            new  ExpenseData { category="Shopping4", amount=650, created_at=new DateTime(2015, 11, 20), id =6, user_email="131@22.com"},
            new  ExpenseData { category="Shopping", amount=300, created_at=new DateTime(2015, 12, 02), id =5, user_email="11@22.com"},
            new  ExpenseData { category="Shopping2", amount=200, created_at=new DateTime(2015, 06, 05), id =2, user_email="112@22.com"},
            new  ExpenseData { category="Shopping3", amount=350, created_at=new DateTime(2015, 09, 15), id =3, user_email="121@22.com"},
            new  ExpenseData { category="Shopping4", amount=650, created_at=new DateTime(2015, 11, 20), id =6, user_email="131@22.com"},
            new  ExpenseData { category="Shopping", amount=300, created_at=new DateTime(2015, 12, 02), id =5, user_email="11@22.com"},
            new  ExpenseData { category="Shopping2", amount=200, created_at=new DateTime(2015, 06, 05), id =2, user_email="112@22.com"},
            new  ExpenseData { category="Shopping3", amount=350, created_at=new DateTime(2015, 09, 15), id =3, user_email="121@22.com"},
            new  ExpenseData { category="Shopping4", amount=650, created_at=new DateTime(2015, 11, 20), id =6, user_email="131@22.com"},

        };
        ListView.ItemsSource = item;
    }

    void TapDelete_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        var popupDel = new DeleteItemPopup();
        this.ShowPopup(popupDel);
    }
}
