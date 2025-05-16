using Avalonia;
using Avalonia.Controls;

namespace BasicXAML.Views;

public static class AttachedProps
{
    #region GreetingText Attached Avalonia Property
    public static string? GetGreetingText(Control obj)
    {
        return obj.GetValue(GreetingTextProperty);
    }

    public static void SetGreetingText(Control obj, string? value)
    {
        obj.SetValue(GreetingTextProperty, value);
    }

    public static readonly AttachedProperty<string?> GreetingTextProperty =
        AvaloniaProperty.RegisterAttached<Control, Control, string?>
        (
            "GreetingText"
        );
    #endregion GreetingText Attached Avalonia Property
}
