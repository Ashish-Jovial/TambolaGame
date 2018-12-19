using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TambolaGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        App thisApp = (App)Application.Current;
        public MainWindow()
        {
            InitializeComponent();
            Dictionary<string,string> lstList = new Dictionary<string,string>();
            RandomNumberGeneration randomNumber = new RandomNumberGeneration();
            for (int i = 0; i < 100; i++)
            {
                string record = randomNumber.GetNumber();
                string[] x = record.Split(new char[] { ' ' });
                GetNumerCombination(x, ref lstList);
            }
        }

        private void GetNumerCombination(string[] x,ref Dictionary<string, string> lstList)
        {
            string number, name;
            if(x.Length>3)
            {
                number = x[1];
                name = x[2] + " " + x[3];
            }
            else
            {
                number = x[1];
                name = x[2];
            }
            lstList.Add(number, name);
        }
    }
}
