using Avalonia.Controls;
using Avalonia.Interactivity;

namespace TempConverterApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        ConvertTemp();
    }

    private void Celsius_TextChanged(object? sender, TextChangedEventArgs e)
    {
        ConvertTemp();
    }

    private void ConvertTemp()
    {
        if (string.IsNullOrEmpty(Celsius.Text) || Celsius.Text == "-")
        {
            Fahrenheit.Text = "";
        } 
        else if (double.TryParse(Celsius.Text, out double C))
        {
            var F = C * (9d / 5d) + 32;
            Fahrenheit.Text = F.ToString("0.0");
        }
        else
        {
            Celsius.Text = "0";
            Fahrenheit.Text = "0";
        }
    }
}