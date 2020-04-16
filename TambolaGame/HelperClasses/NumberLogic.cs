using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TambolaGame.HelperClasses
{
    public class NumberLogic
    {
        App thisApp = (App)Application.Current;
        
        public NumberLogic()
        {
            thisApp.numbersViewModel.OutNumbers = new Dictionary<string, string>();
            RandomNumberGeneration randomNumber = new RandomNumberGeneration();
            for (int i = 0; i < 100; i++)
            {
                string record = randomNumber.GetNumber();
                string[] x = record.Split(new char[] { ' ' });
                GetNumerCombination(x);
            }
        }
        private async Task GetNumerCombination(string[] x)
        {
            string number, name;
            if (x.Length > 3)
            {
                number = x[1];
                name = x[2] + " " + x[3];
            }
            else
            {
                number = x[1];
                name = x[2];
            }
            
            thisApp.numbersViewModel.OutNumbers.Add(number, name);
        }
    }
}
