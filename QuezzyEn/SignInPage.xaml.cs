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
    /// Логика взаимодействия для SignInPage.xaml
    /// </summary>
    public partial class SignInPage : Page
    {

        quezzyEnEntities db = new quezzyEnEntities();

        public SignInPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var users = db.users;
            bool userValid = false;

            foreach (users u in users)
            {
                if (Login.Text == "" || Password.Password == "")
                {
                    MessageBox.Show("Заполните все поля");
                }

                if (Login.Text == u.login && Password.Password == u.password)
                {
                    userValid = true;
                }
              
            }

            if (userValid)
            {
                MessageBox.Show("Вы успешно авторизовались!");
                NavigationService.Navigate(new MainPage());
            }
            else
            {
                MessageBox.Show("Некорректные данные");
            }

            

        }

        private void RedirectToRegButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());

        }
    }
}
