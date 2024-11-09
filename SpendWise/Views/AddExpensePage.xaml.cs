using SpendWise.ViewModels;

namespace SpendWise.Views;

public partial class AddExpensePage : ContentPage
{
	public AddExpensePage()
	{
		InitializeComponent();
		BindingContext = new AddExpenseViewModel();
	}
}