using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ButtonSample.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        TestButton.Click += TestButton_Click;
    }

    private void TestButton_Click
    (
        object? sender, 
        RoutedEventArgs e)
    {

    }
}