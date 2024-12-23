using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Interactivity;
using Avalonia.LogicalTree;
using Avalonia.Layout;

namespace ButtonSample.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        StartWindowButton.Click += StartWindowButton_Click;
        StartModalWindowButton.Click += StartModalWindowButton_Click;
    }

    private void StartWindowButton_Click
    (
        object? sender, 
        RoutedEventArgs e)
    {
        Window window = new Window
        { 
            Width = 350, 
            Height = 200, 
            Title = "Simple (Non-Modal) Window" };

        // starts at point 50, 50 from top left 
        // corner of the current screen
        window.Position = 
            new Avalonia.PixelPoint(50, 50);

        window.Content =
            new Button
            {
                Content = "Click Me",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
            };

        window.Show();
    }

    private void StartModalWindowButton_Click
    (
        object? sender,
        RoutedEventArgs e)
    {
        Window window = 
            new Window() 
            { 
                Width = 350, 
                Height = 200, 
                Title = "Modal (Blocking) Window" 
            };

        // starts at point (270, 160) from top left 
        // corner of the current screen
        window.Position =
            new Avalonia.PixelPoint(270, 160);

        var currentWindow = 
            this.GetLogicalParent<Window>();

        window.ShowDialog(currentWindow!);
    }
}