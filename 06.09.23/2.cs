<Window x:Class="WpfApp2.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApp2"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
        <Button Content="Wyœwietl komunikat" Margin="283,301,312,63" Click="Button_Click" Grid.Column="1"/>
        <Button Content="zamknij" Margin="703,10,10,368" Background="Red" Click="Button_Click_1" Grid.Column="1"/>
        <TextBox x:Name="imiee" TextWrapping="Wrap" Text="Wpisz imiê" Margin="71,54,443,266" FontSize="36" Grid.Column="1"/>
        <TextBox x:Name="nazwiskoo" TextWrapping="Wrap" Text="Wpisz nazwisko" Margin="371,54,120,266" FontSize="36" Grid.Column="1"/>
    </Grid>
</Window>

---

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Witaj "+imiee.Text+" "+nazwiskoo.Text+"!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {    
            if(MessageBox.Show("Napewno chcesz zamknac", "zamykam", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Close();
            }
        }
    }
}
