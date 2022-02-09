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
using System.Windows.Shapes;
using TeackWorks.Model;
using TeackWorks.View.Pages;
using TeackWorks.View.Pages.Services;

namespace TeackWorks.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public static MainMenuWindow menuWindow { get; set; }
        public MainMenuWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MainPage());
            menuWindow = this;
            MP4.Source = new Uri(Environment.CurrentDirectory + @"\Concept.wmv");
            MP4.Position = TimeSpan.Zero;
            MP4.Play();
        }


        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new MainPage());
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProfilePage());
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void TextBlock_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new ServiceTypePage());
        }

        private void TextBlock_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new OrderPage());
        }

        private void TextBlock_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new ContatcPage());
        }

        private void MP4_MediaEnded(object sender, RoutedEventArgs e)
        {
            MP4.Position = TimeSpan.Zero;
            MP4.Play();
        }
    }
}
