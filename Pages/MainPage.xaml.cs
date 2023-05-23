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
using WpfColonka.Core;

namespace WpfColonka.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new MainPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new Search());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new About());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new User());
        }
    }
}
