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
using Microsoft.Win32;
using System.IO;

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

        private void uploadFile(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            
            using (db)
            {
                if (openFileDialog.ShowDialog() == true)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    // Обновляем аватарку с помощью выбранного изображения
                    UpdateAvatar(selectedFilePath);

                    var fileName = System.IO.Path.GetFileName(selectedFilePath);
                    string destFile = System.IO.Path.Combine(@"images\", fileName);

                    //File.Copy(selectedFilePath, destFile, true);

                    //users.avatarUrl = destFile; NADO POCHINIT` NE RABOTAET((((

                    //db.users.Add(avatarUrl);
                    //db.SaveChanges();

                }
            }

           
        }

        private void UpdateAvatar(string selectedFilePath)
        {
            try
            {
                // Создаем новый BitmapImage с указанным путем к изображению
                BitmapImage bitmapImage = new BitmapImage(new Uri(selectedFilePath));

                // Устанавливаем новый BitmapImage в качестве источника изображения для элемента Image
                AvatarImage.Source = bitmapImage;
            }
            catch (Exception ex)
            {
                // Обработка возможных ошибок при загрузке изображения
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
            }
        }
    }


}
