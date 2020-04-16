using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TambolaGame.ViewModels
{
    public class ViewModelLocator
    {
        App thisApp = (App)Application.Current;
        public ViewModelLocator()
        {
            numbersViewModel = new NumbersViewModel();
            thisApp.numbersViewModel = numbersViewModel;
        }
        public NumbersViewModel numbersViewModel
        {
            get; set;
        }
    }
}
