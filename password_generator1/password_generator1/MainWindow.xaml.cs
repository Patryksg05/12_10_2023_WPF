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

namespace password_generator1
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

        private void generate_password(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(pass_length.Text, out int password_length) && password_length>0)
            {
                const string lower_case = "abcdefgihijklmnoprstwuxyz";
                const string upper_case = "ABCDEFGHIJKLMNOPRSTWUXYZ";
                const string numbers = "0123456789";
                const string special_chars = "!@#$%&?";

                string result_password = string.Empty;
                string all_chars = string.Empty;
                string random_char = string.Empty;
                string first_chars = string.Empty;

                Random random = new Random();
                int char_random_index, checkbox_count = 0;

                if(lower.IsChecked == true)
                {
                    all_chars += lower_case;
                    char_random_index = random.Next(0, lower_case.Length - 1);
                    random_char = lower_case.Substring(char_random_index, 1);
                    first_chars += random_char;
                    checkbox_count++;
                }

                if(upper.IsChecked == true)
                {
                    all_chars += upper_case;
                    char_random_index = random.Next(0, upper_case.Length - 1);
                    random_char = upper_case.Substring(char_random_index, 1);
                    first_chars += random_char;
                    checkbox_count++;
                }

                if (digits.IsChecked == true)
                {
                    all_chars += numbers;
                    char_random_index = random.Next(0, numbers.Length - 1);
                    random_char = numbers.Substring(char_random_index, 1);
                    first_chars += random_char;
                    checkbox_count++;
                }

                if (special.IsChecked == true)
                {
                    all_chars += numbers;
                    char_random_index = random.Next(0, special_chars.Length - 1);
                    random_char = special_chars.Substring(char_random_index, 1);
                    first_chars += random_char;
                    checkbox_count++;
                }

                MessageBox.Show(first_chars);
                char[] ar = first_chars.ToCharArray();
                int n = ar.Length;
                MessageBox.Show("random elements");
                while(n > 1)
                {
                    n--;
                    int k = random.Next(n + 1);
                    var x = ar[k];
                    ar[k] = ar[n];
                    ar[n] = x;
                }
                string result = new string(ar);
                // MessageBox.Show(result);

                result_password += result;

                if(checkbox_count <= password_length)
                {
                    for(int i=0; i<password_length - checkbox_count; i++)
                        result_password += all_chars[random.Next(0, all_chars.Length-1)];
                    text_block_result.Text = result_password + "\ndlugosc hasla: " + result_password.Length.ToString();
                }
                else
                {
                    MessageBox.Show("za duze wymagania! liczba zaznaczonych > dlugosc hasla");
                }

            }
            else
            {
                MessageBox.Show("Haslo>0!");
            }
        }
    }
}
