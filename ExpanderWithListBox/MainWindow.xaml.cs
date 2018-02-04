using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ExpanderWithListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Items = new List<string> { "Item 1", "String 2", "Content 3" };
        }


        public List<string> Items { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(ListBoxControl.SelectedItem.ToString());
        }

        private void ListBoxControl_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var eSource = (ListBox) e.Source;
            Expander.Header = eSource.SelectedItem.ToString();
        }
    }
}
