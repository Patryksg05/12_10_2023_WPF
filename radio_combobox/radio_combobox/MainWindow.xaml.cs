using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace radio_combobox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ComboBoxItem> comboBoxItems { get; set; }
        public ComboBoxItem selectedComboBoxItem { get; set; }

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
        }
    }
}
