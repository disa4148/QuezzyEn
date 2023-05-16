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

namespace QuezzyEn
{
    /// <summary>
    /// Логика взаимодействия для GuidePage2.xaml
    /// </summary>
    public partial class GuidePage2 : Page
    {
        public GuidePage2()
        {
            InitializeComponent();
        }

        private void RedirectToMainPage(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
