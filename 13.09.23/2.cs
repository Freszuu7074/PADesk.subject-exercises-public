<Window x:Class="WpfApp2.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApp2"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid RenderTransformOrigin="0.5,0.5">
        <TextBox x:Name="imie" TextWrapping="Wrap" Margin="317,13,272,360" TextChanged="TextBox_TextChanged" FontSize="24"/>
        <RadioButton x:Name="chlop" Content="Mê¿czyzna" Margin="283,123,0,0" RenderTransformOrigin="0.5,0.5" HorizontalAlignment="Left" VerticalAlignment="Top">
            <RadioButton.RenderTransform>
                <TransformGroup>
                    <ScaleTransform ScaleX="2" ScaleY="2"/>
                    <SkewTransform/>
                    <RotateTransform/>
                    <TranslateTransform X="0" Y="0"/>
                </TransformGroup>
            </RadioButton.RenderTransform>
        </RadioButton>
        <RadioButton x:Name="baba" Content="Kobieta" Margin="462,123,0,0" RenderTransformOrigin="0.5,0.5" HorizontalAlignment="Left" VerticalAlignment="Top">
            <RadioButton.RenderTransform>
                <TransformGroup>
                    <ScaleTransform ScaleX="2" ScaleY="2"/>
                    <SkewTransform/>
                    <RotateTransform/>
                    <TranslateTransform/>
                </TransformGroup>
            </RadioButton.RenderTransform>
        </RadioButton>
        <CheckBox x:Name="koszykowka" Content="Koszykówka" Margin="447,201,0,0" HorizontalAlignment="Left" VerticalAlignment="Top"/>
        <CheckBox x:Name="gry" Content="Gry" Margin="387,201,0,0" HorizontalAlignment="Left" VerticalAlignment="Top"/>
        <CheckBox x:Name="programowanie" Content="Programowanie" Margin="270,201,0,0" HorizontalAlignment="Left" VerticalAlignment="Top"/>
        <TextBox x:Name="osobie" TextWrapping="Wrap" Margin="256,275,256,97"/>
        <Label Content="Podaj imiê:" FontSize="18" Margin="215,14,0,0" HorizontalAlignment="Left" VerticalAlignment="Top"/>
        <Label Content="Wybierz p³eæ" FontSize="16" Margin="347,74,0,0" HorizontalAlignment="Left" VerticalAlignment="Top"/>
        <Label Content=" Wybierz hobby" FontSize="14" Margin="344,157,0,0" HorizontalAlignment="Left" VerticalAlignment="Top"/>
        <Button x:Name="btn" Content="Zapisz do pliku" HorizontalAlignment="Left" VerticalAlignment="Top" RenderTransformOrigin="0.5,0.5" Height="26" Width="106" Margin="345,375,0,0" Click="btn_Click">
            <Button.RenderTransform>
                <TransformGroup>
                    <ScaleTransform ScaleX="2" ScaleY="2"/>
                    <SkewTransform/>
                    <RotateTransform/>
                    <TranslateTransform/>
                </TransformGroup>
            </Button.RenderTransform>
        </Button>
        <Label Content="Napisz coœ o sobie..." HorizontalAlignment="Center" VerticalAlignment="Top" FontSize="14" Margin="0,230,0,0"/>

    </Grid>

</Window>