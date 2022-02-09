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
using TeackWorks.Model;
using TeackWorks.View.Windows;

namespace TeackWorks.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ContatcPage.xaml
    /// </summary>
    public partial class ContatcPage : Page
    {
        public ContatcPage()
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
