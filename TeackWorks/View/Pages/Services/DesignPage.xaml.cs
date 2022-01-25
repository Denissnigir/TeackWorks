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
using TeackWorks.View.Windows;

namespace TeackWorks.View.Pages.Services
{
    /// <summary>
    /// Логика взаимодействия для DesignPage.xaml
    /// </summary>
    public partial class DesignPage : Page
    {
        public DesignPage()
        {
            InitializeComponent();
        }

        private void OpenConstructor(object sender, RoutedEventArgs e)
        {
            OrderConstructorWindow orderConstructorWindow = new OrderConstructorWindow();
            orderConstructorWindow.ShowDialog();
        }
    }
}
