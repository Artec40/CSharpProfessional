using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private DispatcherTimer timer;
        async void timer_Tick(object sender, EventArgs e)
        {
            textBox.Text += await GetDataAsync();
            textBox.ScrollToEnd();
        }

        Task<string> GetDataAsync()
        {
            return Task.Run(() => { return "data received" + Environment.NewLine; });
        }
        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 3);
            timer.Tick += timer_Tick;

        }

        public async Task<string> ConnectToDBAsync()
        {
            Thread.Sleep(2000);
            return "Connect to DB" + Environment.NewLine;
        }

        public async Task<string> DisconnectFromDBAsync()
        {
            Thread.Sleep(2000);
            return textBox.Text = "Disconnect from DB" + Environment.NewLine;
        }

        private async void ConnectDatabaseButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            connectDatabase.IsEnabled = false;
            timer.Start();
            disconnectDatabase.IsEnabled = true;
            textBox.Text += await ConnectToDBAsync();
        }

        private async void DisconnectDatabaseButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            disconnectDatabase.IsEnabled = false;
            timer.Stop();
            connectDatabase.IsEnabled = true;
            await DisconnectFromDBAsync();
        }

    }
}
