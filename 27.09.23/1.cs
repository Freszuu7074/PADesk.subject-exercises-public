<Window x:Class="Menu.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Menu"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
        <DockPanel>
            <Menu HorizontalAlignment="Right" VerticalAlignment="Top">
                <MenuItem x:Name="morevert" Width="25">
                    <MenuItem.Icon>
                        <Image Source="C:\Users\uczen\Desktop\Menu\Menu\assets\morevert.png"></Image>
                    </MenuItem.Icon>
                    <MenuItem Header="Otwórz" Click="message1_Click"></MenuItem>
                    <MenuItem Header="Nowa karta"></MenuItem>
                    <MenuItem Header="Nowe okno"></MenuItem>
                    <MenuItem Header="Historia"></MenuItem>
                    <MenuItem Header="Pobrane pliki"></MenuItem>
                    <MenuItem Header="Drukuj"></MenuItem>
                    <MenuItem Header="Przesy³aj"></MenuItem>
                </MenuItem>
                <MenuItem x:Name="settings" Width="25">
                    <MenuItem.Icon>
                        <Image Source="C:\Users\uczen\Desktop\Menu\Menu\assets\settings.png"></Image>
                    </MenuItem.Icon>
                    <MenuItem Header="Cofnij"></MenuItem>
                    <MenuItem Header="Wytnij"></MenuItem>
                    <MenuItem Header="Kopiuj"></MenuItem>
                    <MenuItem Header="Wklej"></MenuItem>
                    <MenuItem Header="Duplikuj"></MenuItem>
                    <MenuItem Header="Usuñ"></MenuItem>
                    <MenuItem Header="O programie" Click="message2_Click"></MenuItem>
                </MenuItem>
            </Menu>
        </DockPanel>
    </Grid>
</Window>
