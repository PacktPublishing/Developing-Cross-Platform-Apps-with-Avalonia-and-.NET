using Avalonia;
using Avalonia.Controls;

namespace StyledPropSample.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        this.GreetingText = "Hello World!";
    }


    #region GreetingText Styled Avalonia Property
    public string? GreetingText
    {
        get { return GetValue(GreetingTextProperty); }
        set { SetValue(GreetingTextProperty, value); }
    }

    public static readonly StyledProperty<string?> GreetingTextProperty =
        AvaloniaProperty.Register<MainView, string?>
        (
            nameof(GreetingText)
        );
    #endregion GreetingText Styled Avalonia Property
}