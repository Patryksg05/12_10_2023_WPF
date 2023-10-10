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
        public ObservableCollection<ComboBoxItem> comboBoxItems { get; set; }
        public ComboBoxItem selectedCbItem { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext= this;

            comboBoxItems = new ObservableCollection<ComboBoxItem>();
            var cbItem = new ComboBoxItem { Content = "<-- SELECT -->"};
            selectedCbItem = cbItem;
            comboBoxItems.Add(cbItem);

            comboBoxItems.Add(new ComboBoxItem { Content = "Option 1"});
            comboBoxItems.Add(new ComboBoxItem { Content = "Option 2"});
        }

        private void add_to_combobox_Click(object sender, RoutedEventArgs e)
        {
            comboBoxItems.Add(new ComboBoxItem { Content = text_box_combox_item.Text.ToString() });
        }

        private void select_from_combo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(selectedCbItem.Content.ToString());
        }
    }
}
