using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ToggleButtonSample.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        TwoStateToggleTestButton.Click += TwoStateToggleTestButton_Click;
        ThreeStateToggleTestButton.Click += ThreeStateToggleTestButton_Click;
    }

    private void TwoStateToggleTestButton_Click
    (
        object? sender, 
        RoutedEventArgs e)
    {   
        bool? toggleButtonState = 
            TwoStateToggleTestButton.IsChecked;
    }


    private void ThreeStateToggleTestButton_Click
    (
        object? sender, 
        RoutedEventArgs e)
    {
        bool? toggleButtonState = ThreeStateToggleTestButton.IsChecked;
    }
}