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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void RedirectToGuide1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GuidePage1());

        }

        private void RedirectToGuide2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GuidePage2());

        }

       
      

        private void QuizPage1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new QuizPage1());
        }

        private void RedirectToProfile(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Profile());
        }
    }
}
