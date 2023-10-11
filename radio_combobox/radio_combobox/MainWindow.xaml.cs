using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
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

namespace radio_combobox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ComboBoxItem> comboBoxItems { get; set; }
        public ComboBoxItem selectedComboBoxItem { get; set; }

        List<Club> clubs = new List<Club>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            comboBoxItems = new ObservableCollection<ComboBoxItem>();

            var comboBoxItem = new ComboBoxItem { Content="EXTEND"}; // make a LITTLE HEADER 
            selectedComboBoxItem = comboBoxItem;
            comboBoxItems.Add(selectedComboBoxItem);

            comboBoxItems.Add(new ComboBoxItem { Content = "Option1" });
            comboBoxItems.Add(new ComboBoxItem { Content = "Option2" });
            comboBoxItems.Add(new ComboBoxItem { Content = "Option3" });
            comboBoxItems.Add(new ComboBoxItem { Content = "Option4" });

            clubs.Add(new Club("BVB", "../../../images/bvb.png"));
            clubs.Add(new Club("BAYERN", "../../../images/bayern.png"));

            image.Source = new BitmapImage(new Uri("../../../images/bvb.png", UriKind.Relative));
        }

        private void add_new_cb_item_click(object sender, RoutedEventArgs e)
        {
            if (new_combobox_item_text_box.Text != string.Empty)
            {
                comboBoxItems.Add(new ComboBoxItem { Content = new_combobox_item_text_box.Text.ToString() });
                MessageBox.Show("Added!");
                // MessageBox.Show(comboBoxItems.Count.ToString());
            }
            else
                MessageBox.Show("Fill input!");
        }

        private void display_cb_item_click(object sender, RoutedEventArgs e)
        {
            string content = selectedComboBoxItem.Content.ToString(); // get a content of selected element
            int index = comboBoxItems.IndexOf(selectedComboBoxItem); // get an index of selected element
            selected_cb_item_text_block.Text = index.ToString() + " " + content;

            if(index == 2 && selectedComboBoxItem.Content.ToString().Equals("Option2"))
                if_sth_selected_text_block.Visibility= Visibility.Visible;
            else
                if_sth_selected_text_block.Visibility = Visibility.Hidden;
        }

        private void add_new_radio_click(object sender, RoutedEventArgs e)
        {
            if(new_radiobox_text_box.Text != string.Empty)
            {
                RadioButton radioButton = new RadioButton
                {
                    Content = new_radiobox_text_box.Text,
                    GroupName = "radio_btns"    
                };
                radio_buttons_stack_panel.Children.Add(radioButton);
            }
        }

        private void display_radio_click(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = radio_buttons_stack_panel.Children.OfType<RadioButton>().FirstOrDefault(r=>r.IsChecked == true);
            if(radioButton != null)
            {
                int index = radio_buttons_stack_panel.Children.IndexOf(radioButton); 
                string content = radioButton.Content.ToString();
                selected_radio_btn_value_text_block.Text = index.ToString() + " " + content;
                selected_radio_btn_value_text_block.Visibility = Visibility.Visible;
            }
        }

        private void add_new_club_click(object sender, RoutedEventArgs e)
        {
            if (new_radio_club_text_box.Text != String.Empty)
            {
                RadioButton radioButton = new RadioButton
                {
                    Content = new_radio_club_text_box.Text,
                    GroupName = "radio_clubs"
                };
                radio_images_stack_panel.Children.Add(radioButton);
                clubs.Add(new Club(new_radio_club_text_box.Text, "../../../images/defualt.png"));
            }
            else
                MessageBox.Show("Fill input to add!");
        }

        public static SolidColorBrush GetColorFromHexa(string hexaColor)
        {
            return new SolidColorBrush(
                Color.FromArgb(
                    Convert.ToByte(hexaColor.Substring(1, 2), 16),
                    Convert.ToByte(hexaColor.Substring(3, 2), 16),
                    Convert.ToByte(hexaColor.Substring(5, 2), 16),
                    Convert.ToByte(hexaColor.Substring(7, 2), 16)
                )
            );
        }

        private void display_club_click(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = radio_images_stack_panel.Children.OfType<RadioButton>().FirstOrDefault(r=>r.IsChecked == true);
            if(radioButton != null)
            {
                int selected_index = radio_images_stack_panel.Children.IndexOf(radioButton);

                Club club = clubs[selected_index];
                image.Source = new BitmapImage(new Uri(club.getImage(), UriKind.Relative));
            }
        }

        private void generate_colour(object sender, RoutedEventArgs e)
        {
            /*foreach (var item in checkbox_stack_panel.Children)
            {
                if(item is CheckBox checkBox)
                {
                    bool isChecked = checkBox.IsChecked == true;
                    string content = checkBox.Content.ToString();
                    MessageBox.Show(content);
                }
            }*/

            var list = new List<string>();
            list.Add("#");
            foreach(CheckBox check in checkbox_stack_panel.Children.OfType<CheckBox>())
            {
                if (check.IsChecked == true)
                    list.Add("FF");
                else
                    list.Add("00");
            }
            string result = String.Join("", list.ToArray());
            MessageBox.Show(result);
            Color color = (Color)ColorConverter.ConvertFromString(result);
            color_text_block.Foreground= new SolidColorBrush(color);
        }
    }

    class Club
    {
        private string Name { get; set;  }
        private string image { get; set; }
        public Club(string n, string i) {
            this.Name = n;
            this.image = i;
        }

        public string getName()
        {
            return this.Name;
        }
        public string getImage()
        {
            return this.image;
        }

        public Club(string n)
        {
            this.Name = n;
            this.image = "../../../images/defualt.png";
        }
    }
}
