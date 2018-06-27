using System.ComponentModel;
using System.Threading;
using System.Windows;


namespace WpfApp3
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private int progress;
        public int Progress
        {
            get => progress;
            set { progress = value; OnPropertyChanged("Progress"); }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            var timer = new Timer(new TimerCallback(x =>
            {
                Progress++;
            }));
            timer.Change(0, 1000);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
