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

namespace Menu
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

        private void message1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Póki co nic nie otworzysz", "Nie dzia³a", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void message2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("To mia³o tylko siê wyœwietlaæ, nawet nic mi siê nie chce o nim pisaæ", "O programie", MessageBoxButton.OK, MessageBoxImage.Question);
        }
    }
}
