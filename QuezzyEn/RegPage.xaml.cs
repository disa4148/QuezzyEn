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
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        quezzyEnEntities db = new quezzyEnEntities();

        public RegPage()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            using (db)
            {
                bool userValid = false;
                if (Login.Text == "" || Password.Password == "")
                {
                    MessageBox.Show("Заполните все поля");
                }
                else
                {
                    if (db.users.Select(item => item.login).Contains(Login.Text))
                    {
                        MessageBox.Show("Такой логин уже существует");
                        userValid = false;
                        
                    }
                    else
                    {
                        userValid = true;
                    }
                }

                if (userValid)
                {
                    int maxIdUser = (from us in db.users select us.idUser).Max();
                    users user = new users();

                    user.idUser = maxIdUser + 1;
                    user.login = Login.Text;
                    user.password = Password.Password;
                    user.avatarUrl = "default";
                    user.userlevel = 1;
                    db.users.Add(user);
                    db.SaveChanges();

                    MessageBox.Show("Вы успешно зарегистрированы!");
                    NavigationService.Navigate(new SignInPage());
                    

                }
            }

            

            

            
        }

        private void RedirectToLoginBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignInPage());

        }
    }
}
