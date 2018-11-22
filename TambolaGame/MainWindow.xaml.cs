using System;
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
        public MainWindow()
        {
            InitializeComponent();
            List<string> lstList = new List<string>();
            RandomNumberGeneration randomNumber = new RandomNumberGeneration(true);
            for (int i = 0; i < 100; i++)
            {
                string record = randomNumber.GetNumber();

                //Console.WriteLine(record);
                string[] x = record.Split(new char[] { ' ' });
                lstList.Add(x[1]);
            }
            //Console.WriteLine("--------------record numbers----------------");
            lstList.Sort();
            foreach (var VARIABLE in lstList)
            {
                //Console.WriteLine(VARIABLE);
            }
            //Console.Read();
        }
    }
}
