using System;
using System.Linq;
using System.Media;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using TambolaGame.HelperClasses;

namespace TambolaGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rnd = new Random();
        private int increment = 10;
        private int counter = 0;
        bool isFirstTime = false;
        private App thisApp = (App)Application.Current;
        private MediaPlayer mediaPlayer = new MediaPlayer();
        private NumberLogic numberLogic = null;
        public MainWindow()
        {
            InitializeComponent();
            mediaPlayer.Open(new Uri(@"C:\Users\ashishjain06\source\TambolaGame\TambolaGame\Assets\Countdown-timer.mp3"));
            numberLogic = new NumberLogic();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            mediaPlayer.Play();
            increment--;
            thisApp.numbersViewModel.TimerTicks = increment;
            if (!isFirstTime)
            {
                NumberAssignment(counter);
                isFirstTime = true;
            }
            if (increment == 0)
            {
                counter++;
                NumberAssignment(counter);
                mediaPlayer.Stop();
            }

        }
        private void NumberAssignment(int count)
        {
            
            foreach (var x in thisApp.numbersViewModel.OutNumbers.Select((Entry, Index) => new { Entry, count }))
            {
                thisApp.numbersViewModel.OutNumber = Convert.ToInt32(x.Entry.Key);
                thisApp.numbersViewModel.OutNumberString = x.Entry.Value.ToString();
                SetBackgroundColor();
                increment = 10;
                break;
            }
        }
        private void SetBackgroundColor()
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(0, 256), (byte)rnd.Next(0, 256), (byte)rnd.Next(0, 256)));
            thisApp.numbersViewModel.OutColor = brush;
        }
    }
}
