using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.LogicalTree;
using System.Linq;

namespace LogicalTreeCalculusSample.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        GetLogicalParentButton.Click += GetLogicalParentButton_Click;

        GetLogicalAncestorsButton.Click += GetLogicalAncestorsButton_Click;

        GetLogicalChildrenButton.Click += GetLogicalChildrenButton_Click;

        GetLogicalDescendantsButton.Click += GetLogicalDescendantsButton_Click;
    }

    private void GetLogicalParentButton_Click
    (
        object? sender, 
        RoutedEventArgs e)
    {
        LogicalParentTextBlock.Text =
            TheToggleSwitch.GetLogicalParent()?.GetDisplayStr();
    }


    private void GetLogicalAncestorsButton_Click(object? sender, RoutedEventArgs e)
    {
        AncestorsListBox.ItemsSource = 
            TheToggleSwitch
                .GetLogicalAncestors()
                .Select(l =>  l.GetDisplayStr())
                .ToArray();
    }

    private void GetLogicalChildrenButton_Click(object? sender, RoutedEventArgs e)
    {
        ChildrenListBox.ItemsSource =
            TheToggleSwitch
                .GetLogicalChildren ()
                .Select(l => l.GetDisplayStr())
                .ToArray();
    }

    private void GetLogicalDescendantsButton_Click(object? sender, RoutedEventArgs e)
    {
        DescendantsListBox.ItemsSource =
            TheToggleSwitch
                .GetLogicalDescendants()
                .Select(l => l.GetDisplayStr())
                .ToArray();
    }

}

public static class ControlStringHelper
{
    public static string GetDisplayStr(this ILogical logicalElement)
    {
        StyledElement? element = logicalElement as StyledElement;
        string elementName = element?.Name == null ? string.Empty : $": {element.Name}";

        return $"{logicalElement.GetType().Name}{elementName}";
    }
}