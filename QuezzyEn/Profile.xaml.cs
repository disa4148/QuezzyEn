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
using System.Data.SqlClient;


namespace QuezzyEn
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        quezzyEnEntities db = new quezzyEnEntities();

        public Profile()
        {
            InitializeComponent();
            tblUserName.Text = SignInPage.UserName;
            tblUserId.Text = SignInPage.idUser.ToString();
            tblUserLevel.Text = SignInPage.userLevel.ToString();
        }

        private void RedirectToMainPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

  
    }

 
}
