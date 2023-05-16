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
    /// Логика взаимодействия для QuizPage1.xaml
    /// </summary>
    public partial class QuizPage1 : Page
    {
        public QuizPage1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonQue4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonQue3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonQue2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonQue1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonCheck_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RedirectToMainPage(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
