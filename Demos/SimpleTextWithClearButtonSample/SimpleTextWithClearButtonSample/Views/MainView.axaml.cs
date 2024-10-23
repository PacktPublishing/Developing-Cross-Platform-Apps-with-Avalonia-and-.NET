using Avalonia.Controls;
using Avalonia.Interactivity;

namespace SimpleTextWithClearButtonSample.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        ClearTextButton.Click += ClearTextButton_Click;
        ClearTextButton.IsEnabled = false;

        InputText.TextChanged += InputText_TextChanged;
    }

    private void ClearTextButton_Click(object? sender, RoutedEventArgs e)
    {
        InputText.Text = null;
    }

    private void InputText_TextChanged(object? sender, TextChangedEventArgs e)
    {
        ClearTextButton.IsEnabled = !string.IsNullOrEmpty(InputText.Text);
    }
}