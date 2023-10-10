﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace first_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        public ObservableCollection<ComboBoxItem> comboBoxItems {  get; set; }
        public ComboBoxItem selectedCbItem { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext= this;

            comboBoxItems = new ObservableCollection<ComboBoxItem>();
            var CbItem = new ComboBoxItem { Content = "<-- SV -->" };
            selectedCbItem = CbItem;
            comboBoxItems.Add(CbItem);

            comboBoxItems.Add(new ComboBoxItem { Content = "OPTION 1" });
            comboBoxItems.Add(new ComboBoxItem { Content = "OPTION 2" });
            comboBoxItems.Add(new ComboBoxItem { Content = "OPTION 3" });
        }

        private void select_cb_item_Click(object sender, RoutedEventArgs e)
        {
            string selected_value = selectedCbItem.Content.ToString();
            selected_item_text_block.Text = selected_value;
        }

        private void add_new_cb_item_Click(object sender, RoutedEventArgs e)
        {
            if (new_item_text_box.Text != String.Empty)
            {
                MessageBox.Show("Added!");
                comboBoxItems.Add(new ComboBoxItem { Content = new_item_text_box.Text.ToString() });
                new_item_text_box.Clear();
            }
            else
                MessageBox.Show("Fill input!");
        }

        private void generate_passowrd_btn(object sender, RoutedEventArgs e)
        {
            const string lower_case = "abcdefgijklmnoprstwuxyz";
            const string upper_case = "ABCDEFGHIJKLOMNOPRSTWUXYZ";
            const string digits = "1234567890";
            const string special_chars = "!@#%^&*():{}|";

            string result_pass = string.Empty;
            string all_chars = string.Empty;
            Random random = new Random();
            int checkbox_counter = 0;

            if(chb_lower.IsChecked == true)
            {
                all_chars += lower_case;
                checkbox_counter++;
            }
            if(chb_upper.IsChecked == true)
            {
                all_chars += upper_case;
                checkbox_counter++;
            }
            if(chb_digits.IsChecked == true)
            {
                all_chars += digits;
                checkbox_counter++;
            }
            if(chb_special.IsChecked == true)
            {
                all_chars += special_chars;
                checkbox_counter++;
            }

            // MessageBox.Show("Checkboxes: " + checkbox_counter);
            
            for(int i=0; i<15; i++)
            {
                result_pass += all_chars[random.Next(0, all_chars.Length - 1)];
            }
            generated_password_text_block.Text = result_pass;
        }
    }
    
}
