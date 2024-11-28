using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace ButtonSample.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        //TestButton.Click += TestButton_Click;
        TestButton.PointerPressed += 
            TestButton_PointerPressed;
        //TestButton.PointerReleased += TestButton_PointerReleased;
        //TestButton.PointerEntered += TestButton_PointerEntered;
        //TestButton.PointerMoved += TestButton_PointerMoved;
        //TestButton.PointerExited += TestButton_PointerExited;
        //TestButton.DoubleTapped += TestButton_DoubleTapped;
    }

    private void TestButton_Click
    (
        object? sender, 
        RoutedEventArgs e)
    {

    }

    private void TestButton_PointerPressed
    (
        object? sender, 
        PointerPressedEventArgs e)
    {
        if (e.ClickCount == 3)
        {

        }
    }


    private void TestButton_PointerReleased(object? sender, Avalonia.Input.PointerReleasedEventArgs e)
    {

    }


    private void TestButton_PointerEntered(object? sender, Avalonia.Input.PointerEventArgs e)
    {

    }

    private void TestButton_PointerMoved(object? sender, Avalonia.Input.PointerEventArgs e)
    {

    }

    private void TestButton_PointerExited(object? sender, Avalonia.Input.PointerEventArgs e)
    {

    }

    private void TestButton_DoubleTapped(object? sender, Avalonia.Input.TappedEventArgs e)
    {

    }

}