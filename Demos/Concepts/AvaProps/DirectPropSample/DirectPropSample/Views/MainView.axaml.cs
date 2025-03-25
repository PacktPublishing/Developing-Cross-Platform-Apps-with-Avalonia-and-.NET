using Avalonia;
using Avalonia.Controls;

namespace DirectPropSample.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        this.GreetingText = "Hello World!";
    }

    #region GreetingText Direct Avalonia Property
    private string? _GreetingText = default;

    public static readonly DirectProperty<MainView, string?> GreetingTextProperty =
        AvaloniaProperty.RegisterDirect<MainView, string?>
        (
            nameof(GreetingText),
            o => o.GreetingText,
            (o, v) => o.GreetingText = v
        );

    public string? GreetingText
    {
        get => _GreetingText;
        set
        {
            SetAndRaise(GreetingTextProperty, ref _GreetingText, value);
        }
    }
    #endregion GreetingText Direct Avalonia Property
}