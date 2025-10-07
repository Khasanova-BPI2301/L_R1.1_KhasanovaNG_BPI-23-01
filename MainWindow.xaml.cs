using System.Linq.Expressions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace L_R1._1_Khasanova
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Проверка ввода числа. обработчик
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0) && e.Text != "-")
            {

                e.Handled = true;
            }

        }
        //Обработчик проверки пробела
        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
        //Обработчик кнопки процентов
        private void CalculatePercentage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int numerator = int.Parse(numeratorTextBox.Text);
                int denominator = int.Parse(denominatorTextBox.Text);

                if (denominator == 0)
                {
                    resultTextBox.Text = "Ошибка: знаменатель не может быть равен нулю!";
                    return;
                }
                Fraction fraction = new Fraction(numerator, denominator);

                // Проверяем, является ли дробь правильной
                if (!fraction.IsFraction())
                {
                    resultTextBox.Text = "Ошибка: дробь неправильная!";
                    return;
                }

                double percentage = fraction.ToPercentage();
                resultTextBox.Text = $"{percentage:F2}%";
            }
            catch (FormatException)
            {
                resultTextBox.Text = "Ошибка: введите корректные числа!";
            }
            catch (Exception ex)
            {
                resultTextBox.Text = $"Ошибка:{ex.Message}";


            }

        }
        //Обработчик кнопки сумма цифр знаменателя
        private void CalculateSumDigits_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                int numerator = int.Parse(numeratorTextBox.Text);
                int denominator = int.Parse(denominatorTextBox.Text);
                
                if (denominator == 0)
                {
                    resultTextBox.Text = "Ошибка: знаменатель не может быть равен нулю!";
                    return;
                }

                
                Fraction fraction = new Fraction(numerator, denominator);

                // Проверяем, является ли дробь правильной
                if (!fraction.IsFraction())
                {
                    resultTextBox.Text = "Ошибка: дробь неправильная!";
                    return;
                }

                
                int sumDigits = fraction.SumOfDenominatorDigits();

                
                resultTextBox.Text = $"Сумма цифр знаменателя: {sumDigits}";
            }
            catch (FormatException)
            {
                resultTextBox.Text = "Ошибка: введите корректные числа!";
            }
            catch (Exception ex)
            {
                resultTextBox.Text = $"Ошибка: {ex.Message}";
            }
        }


    }
}

                



            

            
        
    

    


