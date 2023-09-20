<Window x:Class="_20._09._23.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:_20._09._23"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid VerticalAlignment="Center" HorizontalAlignment="Center" Height="434" Width="800">
        <TextBox x:Name="nazwa" TextWrapping="Wrap" Text="" Width="120" HorizontalAlignment="Left" VerticalAlignment="Top" Margin="460,46,0,0" RenderTransformOrigin="0.5,0.5">
            <TextBox.RenderTransform>
                <TransformGroup>
                    <ScaleTransform ScaleX="2" ScaleY="2"/>
                    <SkewTransform/>
                    <RotateTransform/>
                    <TranslateTransform/>
                </TransformGroup>
            </TextBox.RenderTransform>
        </TextBox>
        <Label Content="Podaj nazwê pliku:" HorizontalAlignment="Left" VerticalAlignment="Top" Margin="239,42,0,0" RenderTransformOrigin="0.5,0.5">
            <Label.RenderTransform>
                <TransformGroup>
                    <ScaleTransform ScaleX="2" ScaleY="2"/>
                    <SkewTransform/>
                    <RotateTransform/>
                    <TranslateTransform/>
                </TransformGroup>
            </Label.RenderTransform>
        </Label>
        <Label Content="Wpisz zawartoœæ pliku:" RenderTransformOrigin="0.5,0.5" Margin="207,112,0,0" HorizontalAlignment="Left" VerticalAlignment="Top">
            <Label.RenderTransform>
                <TransformGroup>
                    <ScaleTransform ScaleX="2" ScaleY="2"/>
                    <SkewTransform/>
                    <RotateTransform/>
                    <TranslateTransform/>
                </TransformGroup>
            </Label.RenderTransform>
        </Label>
        <TextBox x:Name="zawartosc" TextWrapping="Wrap" Text="" Width="147" HorizontalAlignment="Left" VerticalAlignment="Top" RenderTransformOrigin="0.5,0.5" Margin="473,141,0,0" Height="67">
            <TextBox.RenderTransform>
                <TransformGroup>
                    <ScaleTransform ScaleX="2" ScaleY="2"/>
                    <SkewTransform/>
                    <RotateTransform/>
                    <TranslateTransform/>
                </TransformGroup>
            </TextBox.RenderTransform>
        </TextBox>
        <Button Content="Zapisz" HorizontalAlignment="Center" VerticalAlignment="Top" RenderTransformOrigin="0.5,0.5" Height="26" Width="84" Margin="0,324,0,0" Click="Button_Click">
            <Button.RenderTransform>
                <TransformGroup>
                    <ScaleTransform ScaleX="2" ScaleY="2"/>
                    <SkewTransform/>
                    <RotateTransform/>
                    <TranslateTransform/>
                </TransformGroup>
            </Button.RenderTransform>
        </Button>
        <Label Content=".txt" HorizontalAlignment="Left" VerticalAlignment="Top" RenderTransformOrigin="0.5,0.5" Margin="653,42,0,0">
            <Label.RenderTransform>
                <TransformGroup>
                    <ScaleTransform ScaleX="2" ScaleY="2"/>
                    <SkewTransform/>
                    <RotateTransform/>
                    <TranslateTransform/>
                </TransformGroup>
            </Label.RenderTransform>
        </Label>
    </Grid>
</Window>
