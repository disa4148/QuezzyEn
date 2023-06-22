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
    /// Логика взаимодействия для QuizPage1.xaml
    /// </summary>
    public partial class QuizPage1 : Page
    {
        quezzyEnEntities db = new quezzyEnEntities();

        public QuizPage1()
        {
            InitializeComponent();
            questionsList = new List<CustomObject>();
            FillQuestions();
            DisplayNextQuestion();
        }


        private string selected = ""; //выбор

        private string answer;
        private List<CustomObject> questionsList;
        private int key = 0;
        private int idQuestion;

        public class CustomObject
        {
            private static int keyCounter = 0;

            public int Key { get; }
            public int IdQuestion { get; set; }
            public string Title { get; set; }
            public string Var1 { get; set; }
            public string Var2 { get; set; }
            public string Var3 { get; set; }
            public string Var4 { get; set; }
            public string Answer { get; set; }
         

            public CustomObject()
            {
                Key = ++keyCounter;
            }

            public static CustomObject GetObjectByKey(int key)
            {
                // Здесь вам нужно обращаться к вашей базе данных или коллекции объектов,
                // чтобы найти объект с указанным ключом и вернуть его
                // В этом примере я просто создаю новый объект для иллюстрации

                CustomObject obj = new CustomObject();
                obj.IdQuestion = key;
                obj.Title = "Object with Key " + key;
                obj.Var1 = "Var1";
                obj.Var2 = "Var2";
                obj.Var3 = "Var3";
                obj.Var4 = "Var4";
                obj.Answer = "Answer";

                return obj;
            }
          
        }

        private void DisplayNextQuestion()
        {
            if (questionsList.Count > 0 && key < questionsList.Count)
            {
                CustomObject obj = questionsList[key];
                idQuestion = obj.IdQuestion;
                title.Content = obj.Title;
                var1.Content = obj.Var1;
                var2.Content = obj.Var2;
                var3.Content = obj.Var3;
                if (obj.Var4.Length > 1)
                {
                    var4.Content = obj.Var4;
                }
               
                answer = obj.Answer;
                key++;
            }
            else
            {
                MessageBox.Show("Урок закончен \n" + "Верных ответов: " + TrueCount + "\nНеверных ответов: " + FalseCount);
                NavigationService.Navigate(new MainPage());

            }
        }
        int TrueCount = 0;
        int FalseCount = 0;
        private void FillQuestions()
        {

            quezzyEnEntities db = new quezzyEnEntities();

            using (db)
            {

                foreach (questions question in db.questions)
                {
                    CustomObject quest = new CustomObject();
                    quest.IdQuestion = question.idQuestion;
                    quest.Title = question.title;
                    quest.Var1 = question.var1;
                    quest.Var2 = question.var2;
                    quest.Var3 = question.var3;
                    if (question.var4 != null)
                    {
                        quest.Var4 = question.var4;
                    }
                    else
                    {
                        quest.Var4 = "lal";
                    }
                    quest.Answer = question.answer;
                    
                    questionsList.Add(quest);
                }

            }

        }


        private void ButtonQue1_Click(object sender, RoutedEventArgs e)
        {
            selected = var1.Content.ToString();

        }
        private void ButtonQue2_Click(object sender, RoutedEventArgs e)
        {
            selected = var2.Content.ToString();

        }
        private void ButtonQue3_Click(object sender, RoutedEventArgs e)
        {
            selected = var3.Content.ToString();

        }

        private void ButtonQue4_Click(object sender, RoutedEventArgs e)
        {
            
            selected = var4.Content.ToString();
        }
        private void ButtonCheck_Click(object sender, RoutedEventArgs e)
        {

                if (selected == answer)
                {
                    TrueCount++;
                    MessageBox.Show("Правильно!");
                }
                else
                {
                    FalseCount++;
                    MessageBox.Show("Не правильно :(");
                }
                DisplayNextQuestion();

        }

        private void RedirectToMainPage(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
