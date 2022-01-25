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
using TeackWorks.View.Pages.OrderConstructor;

namespace TeackWorks.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для OrderConstructorWindow.xaml
    /// </summary>
    public partial class OrderConstructorWindow : Window
    {
        public static OrderConstructorWindow window { get; set; }
        public OrderConstructorWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new FirstPage());
            ProgressBarTB.Text = $"Готово: {MainPB.Value}%";
            window = this;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void MainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            if(MainFrame.CanGoBack)
            {
                MainPB.Value += 50;
                ProgressBarTB.Text = $"Готово: {MainPB.Value}%";
            }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            FirstPage.newOrder = null;
            this.Close();
        }
    }
}
