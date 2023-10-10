using System;
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
            var CbItem = new ComboBoxItem { Content = "SELECT VALUE" };
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
                comboBoxItems.Add(new ComboBoxItem { Content = new_item_text_box.Text.ToString() });
                new_item_text_box.Clear();
            }
            else
                MessageBox.Show("Fill input!");
        }
    }
    
}
