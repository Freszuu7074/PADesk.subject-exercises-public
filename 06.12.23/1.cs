<Window x:Class="WpfApp5.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApp5"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Window.InputBindings>
        <KeyBinding Key="N" Modifiers="Control" Command="local:MainWindow.NewCommand"/>
        <KeyBinding Key="O" Modifiers="Control" Command="local:MainWindow.OpenCommand"/>
    </Window.InputBindings>
    <Grid Background="#FF0069AB">
        <Menu HorizontalAlignment="Center" VerticalAlignment="Top" Width="800" Background="#FF50ABFF" Foreground="Black">
            <MenuItem Header="Nowy" Click="MenuItem_Click" Command="local:MainWindow.NewCommand" Margin="5,0,0,0" Foreground="Black" Background="{x:Null}"/>
            <MenuItem Header="Otwórz" Click="otworz_Click" Command="local:MainWindow.OpenCommand"/>
        </Menu>
        <Label x:Name="label" Content="Tutaj wyświetli się czas..." HorizontalAlignment="Center" VerticalAlignment="Center" Height="128" Width="388" BorderBrush="Black" BorderThickness="1" Foreground="#FFC8C8C8" RenderTransformOrigin="0,0" HorizontalContentAlignment="Center" VerticalContentAlignment="Center" FontSize="22"/>

    </Grid>
</Window>
