using Avalonia.Controls;
using Avalonia.Input;

namespace TextBlockSample.Views;

public partial class MainView : UserControl
{
public MainView()
{
    InitializeComponent();

    TestTextBlock.PointerPressed +=
        TestTextBlock_PointerPressed;
    //TestTextBlock.PointerReleased +=
    //    TestTextBlock_PointerReleased;
    //TestTextBlock.PointerEntered +=
    //    TestTextBlock_PointerEntered;
    //TestTextBlock.PointerMoved +=
    //    TestTextBlock_PointerMoved;
    //TestTextBlock.PointerExited +=
    //    TestTextBlock_PointerExited;
    //TestTextBlock.DoubleTapped +=
    //    TestTextBlock_DoubleTapped;
}

private void TestTextBlock_PointerPressed
(
    object? sender,
    PointerPressedEventArgs e)
{
    if (e.ClickCount == 3)
    {

    }
}


    private void TestTextBlock_PointerReleased
    (
        object? sender,
        PointerReleasedEventArgs e)
    {

    }


    private void TestTextBlock_PointerEntered
        (object? sender, 
        PointerEventArgs e)
    {

    }

    private void TestTextBlock_PointerMoved
    (
        object? sender, 
        PointerEventArgs e)
    {

    }

    private void TestTextBlock_PointerExited
    (
        object? sender, 
        PointerEventArgs e)
    {

    }

    private void TestTextBlock_DoubleTapped
    (
        object? sender, 
        TappedEventArgs e)
    {

    }
}