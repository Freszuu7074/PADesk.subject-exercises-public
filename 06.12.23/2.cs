using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static RoutedCommand NewCommand = new RoutedCommand();
        public static RoutedCommand OpenCommand = new RoutedCommand();
        public MainWindow()
        {
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(NewCommand, New_Executed));
            CommandBindings.Add(new CommandBinding(OpenCommand, Open_Executed));
        }
        private void New_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Source is not MenuItem)
            {
                MenuItem_Click(sender, e);
            }
        }
        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Source is not MenuItem)
            {
                otworz_Click(sender, e);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FileStream FILE = new FileStream("czas.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(FILE);
            sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd---HH:mm:ss"));
            sw.Close();
            MessageBox.Show("Zapisano czas pomyślnie!","", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void otworz_Click(object sender, RoutedEventArgs e)
        {
            if(File.Exists("czas.txt"))
            {
                FileStream FILE2 = new FileStream("czas.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(FILE2);
                label.Foreground = Brushes.Black;
                label.Content = sr.ReadLine();
                sr.Close();
                MessageBox.Show("Wczytano pomyślnie plik!", "", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Brak danych!", "", MessageBoxButton.OK, MessageBoxImage.Error);
                label.Foreground = Brushes.Black;
                label.Content = "Najpierw utwórz plik!";
            }
        }
    }
}
