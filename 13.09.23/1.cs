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

namespace WpfApp2
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter dane = new StreamWriter("dane.txt");
            string imiee = imie.Text;
            string plec;
            if(chlop.IsChecked == true) plec = "Mê¿czyzna";
            if (baba.IsChecked == true) plec = "Kobieta";
            else plec = "Nie podano";
            string hobby = "";
            if(programowanie.IsChecked == true) hobby+="Programowanie ";
            if(gry.IsChecked == true) hobby+= "Gry ";
            if(koszykowka.IsChecked == true) hobby+="Koszykówka ";
            string osobiee = osobie.Text;
            if (MessageBox.Show("Chcesz zapisaæ dane?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                dane.WriteLine("Imiê: "+imiee+"\n"+
                "P³eæ: "+plec+"\n"+
                "Hobby: "+hobby+"\n"+
                "O sobie: "+osobiee);
                dane.Close();
                Close();
            }
        }
    }
}