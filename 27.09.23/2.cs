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
            MessageBox.Show("P�ki co nic nie otworzysz", "Nie dzia�a", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void message2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("To mia�o tylko si� wy�wietla�, nawet nic mi si� nie chce o nim pisa�", "O programie", MessageBoxButton.OK, MessageBoxImage.Question);
        }
    }
}
