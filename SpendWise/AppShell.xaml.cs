using SpendWise.Views;

namespace SpendWise
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AddExpensePage), typeof(AddExpensePage));
        }
    }
}
