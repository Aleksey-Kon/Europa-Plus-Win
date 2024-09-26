using System.Windows;
using WMPLib;

namespace europaplus
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WindowsMediaPlayer wmPlayer = new WindowsMediaPlayer();
        public MainWindow()
        {
            InitializeComponent();
        }
    
        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            wmPlayer.URL = @"https://ep256.hostingradio.ru:8052/europaplus256.mp3"; ;
            wmPlayer.controls.play();
            button2.Visibility = Visibility.Visible;
            button1.Visibility = Visibility.Collapsed;

        }

        private void button1_Click_2(object sender, RoutedEventArgs e)
        {
            wmPlayer.controls.stop();
            button1.Visibility = Visibility.Visible;
            button2.Visibility = Visibility.Collapsed;
        }
    }
}
