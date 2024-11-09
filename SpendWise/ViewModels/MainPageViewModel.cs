using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpendWise.Views;

namespace SpendWise.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
     
        [RelayCommand]
        public async Task AddExpenseButtonAsync() 
        {

            await Shell.Current.GoToAsync(nameof(AddExpensePage));
        }
    }
}
