using Avalonia.Controls;
using Avalonia.Interactivity;

namespace DynamicResourceSample.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        ChangeResourceButton.Click +=
            ToggleGreeting;
    }

    private void ToggleGreeting
    (
        object? sender, 
        RoutedEventArgs e
    )
    {
        string greeting = 
            (string) this.Resources["Greeting"]!;

        if (greeting == "Greetings!")
        {
            greeting = "Hello!";
        }
        else
        {
            greeting = "Greetings!";
        }

        this.Resources["Greeting"] = greeting;
    }
}