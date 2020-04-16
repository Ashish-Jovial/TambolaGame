using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TambolaGame.ViewModels;

namespace TambolaGame
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public bool IsRunningFirstTime = true;
        public NumbersViewModel numbersViewModel { get; set; }
        public ObservableCollection<NumbersViewModel> _NumbersVm = new ObservableCollection<NumbersViewModel>();
        public ObservableCollection<NumbersViewModel> NumbersVm
        {
            get
            {
                return _NumbersVm;
            }
            set
            {
                _NumbersVm = value;
            }
        }
    }
}
