using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Media;

namespace TambolaGame.ViewModels
{
    public class NumbersViewModel : INotifyPropertyChanged
    {
        private int _timerTicks { get; set; }
        private string _outNumberString { get; set; }
        private int _outNumber { get; set; }
        private Brush _outColor { get; set; }
        private Dictionary<string, string> _outNumbers { get; set; }
        public int TimerTicks
        {
            get => _timerTicks;
            set
            {
                _timerTicks = value;
                OnPropertyRaised("TimerTicks");
            }
        }
        public string OutNumberString
        {
            get => _outNumberString;
            set
            {
                _outNumberString = value;
                OnPropertyRaised("OutNumberString");
            }
        }
        public int OutNumber
        {
            get => _outNumber;
            set
            {
                _outNumber = value;
                OnPropertyRaised("OutNumber");
            }
        }
        public Brush OutColor
        {
            get => _outColor;
            set
            {
                _outColor = value;
                OnPropertyRaised("OutColor");
            }
        }
        public Dictionary<string, string> OutNumbers
        {
            get => _outNumbers;
            set
            {
                _outNumbers = value;
                OnPropertyRaised("OutNumbers");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}