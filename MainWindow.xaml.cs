using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private readonly Random _rand = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void PrintNumbersButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i <= 1; i++)
            {
                string randomString = new string(Enumerable.Range(0, _rand.Next(1, 100)).Select(_ => (char)_rand.Next(32, 127)).ToArray());

                var textBlock = new TextBlock
                {
                    Text = $"Spicy@Garnachas-PC:{randomString}",
                    FontFamily = new FontFamily("Consolas"),
                    FontSize = 14,
                    Foreground = new SolidColorBrush(Colors.Green),
                    Opacity = 0
                };

                ConsoleStackPanel.Children.Insert(0, textBlock);
                DoubleAnimation animation = new DoubleAnimation
                {
                    From = 0,
                    To = 1,
                    Duration = new Duration(TimeSpan.FromSeconds(0.001)),
                    EasingFunction = new PowerEase { EasingMode = EasingMode.EaseOut }
                };

                textBlock.BeginAnimation(UIElement.OpacityProperty, animation);

               

                await Task.Delay(1);  // Mantener el mismo retraso constante
            }
        }
    }
}
