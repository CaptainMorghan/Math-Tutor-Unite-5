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

namespace Updated_Math_Tutor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Random1;
        int Random2;
        int Random3;
        int StudentAnswer;
        int Answer;
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
           
        }
      
        private void BtnClickToStart_Click(object sender, RoutedEventArgs e)
        {

            Random1 = random.Next(1, 111);
            Random2 = random.Next(1, 111);
            Random3 = random.Next(1, 5); //this will determin if + - / * is used
            if (Random3 == 1)
            {
                lblQuestion1.Content = Random1;
                lblOperator.Content = "+";
                lblQuestion2.Content = Random2;
            }
            else if (Random3 == 2)
            {
                lblQuestion1.Content = Random1;
                lblOperator.Content = "-";
                lblQuestion2.Content = Random2;
            }
            else if (Random3 == 3)
            {
                lblQuestion1.Content = Random1;
                lblOperator.Content = "/";
                lblQuestion2.Content = Random2;
            }
            else if (Random3 == 4)
            {
                lblQuestion1.Content = Random1;
                lblOperator.Content = "*";
                lblQuestion2.Content = Random2;
            }

        }

        private void BtnClickToCheck_Click(object sender, RoutedEventArgs e)
        {
            if (Random3 == 1)
            {
                Answer = Random1 + Random2;
                int.TryParse(txtAnswer.Text, out StudentAnswer);
                if (Answer == StudentAnswer)
                {
                    lblResponse.Content = "You Passed now get a job";
                }
                else
                {
                    lblResponse.Content = "You Failed guess I'll be a bus driver";
                }
            }
            if (Random3 == 2)
            {
                Answer = Random1 - Random2;
                int.TryParse(txtAnswer.Text, out StudentAnswer);
                if (Answer == StudentAnswer)
                {
                    lblResponse.Content = "You Passed now get a job";
                }
                else
                {
                    lblResponse.Content = "You Failed guess I'll be a bus driver";
                }
            }
            if (Random3 == 3)
            {
                Answer = Random1 / Random2;
                int.TryParse(txtAnswer.Text, out StudentAnswer);
                if (Answer == StudentAnswer)
                {
                    lblResponse.Content = "You Passed now get a job";
                }
                else
                {
                    lblResponse.Content = "You Failed guess I'll be a bus driver";
                }
            }
            if (Random3 == 4)
            {
                Answer = Random1 * Random2;
                int.TryParse(txtAnswer.Text, out StudentAnswer);
                if (Answer == StudentAnswer)
                {
                    lblResponse.Content = "You Passed now get a job";
                }
                else
                {
                    lblResponse.Content = "You Failed guess I'll be a bus driver";
                }
            }
        }
            
    }
    }
    
