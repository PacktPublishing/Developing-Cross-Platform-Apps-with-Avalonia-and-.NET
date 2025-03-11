using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.VisualTree;
using System.Linq;

namespace VisualTreeCalculusSample.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        GetVisualParentButton.Click += GetVisualParentButton_Click;

        GetVisualAncestorsButton.Click += GetVisualAncestorsButton_Click;

        GetVisualChildrenButton.Click += GetVisualChildrenButton_Click;

        GetVisualDescendantsButton.Click += GetVisualDescendantsButton_Click;
    }

    private void GetVisualParentButton_Click
    (
        object? sender, 
        RoutedEventArgs e)
    {
        VisualParentTextBlock.Text =
            TheToggleSwitch.GetVisualParent()?.GetDisplayStr();
    }


    private void GetVisualAncestorsButton_Click(object? sender, RoutedEventArgs e)
    {
        AncestorsListBox.ItemsSource = 
            TheToggleSwitch
                .GetVisualAncestors()
                .Select(l =>  l.GetDisplayStr())
                .ToArray();
    }

    private void GetVisualChildrenButton_Click(object? sender, RoutedEventArgs e)
    {
        ChildrenListBox.ItemsSource =
            TheToggleSwitch
                .GetVisualChildren ()
                .Select(l => l.GetDisplayStr())
                .ToArray();
    }

    private void GetVisualDescendantsButton_Click(object? sender, RoutedEventArgs e)
    {
        DescendantsListBox.ItemsSource =
            TheToggleSwitch
                .GetVisualDescendants()
                .Select(l => l.GetDisplayStr())
                .ToArray();
    }

}

public static class ControlStringHelper
{
    public static string GetDisplayStr(this Visual VisualElement)
    {
        StyledElement? element = VisualElement as StyledElement;
        string elementName = element?.Name == null ? string.Empty : $": {element.Name}";

        return $"{VisualElement.GetType().Name}{elementName}";
    }
}