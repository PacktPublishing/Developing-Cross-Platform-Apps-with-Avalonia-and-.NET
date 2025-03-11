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

        GetLogicalParentButton.Click += 
            GetLogicalParentButton_Click;

        GetLogicalAncestorsButton.Click += 
            GetLogicalAncestorsButton_Click;

        GetLogicalChildrenButton.Click += 
            GetLogicalChildrenButton_Click;

        GetLogicalDescendantsButton.Click += 
            GetLogicalDescendantsButton_Click;
    }

    private void GetLogicalParentButton_Click
    (
        object? sender, 
        RoutedEventArgs e)
    {
        LogicalParentTextBlock.Text =
            TheToggleSwitch.GetLogicalParent()?.GetType().Name;
    }


    private void GetLogicalAncestorsButton_Click
    (
        object? sender, 
        RoutedEventArgs e)
    {
        AncestorsListBox.ItemsSource = 
            TheToggleSwitch
                .GetLogicalAncestors()
                .Select(l =>  l.GetType().Name)
                .ToArray();
    }

    private void GetLogicalChildrenButton_Click
    (
        object? sender, 
        RoutedEventArgs e)
    {
        ChildrenListBox.ItemsSource =
            TheToggleSwitch
                .GetLogicalChildren ()
                .Select(l => l.GetType().Name)
                .ToArray();
    }

    private void GetLogicalDescendantsButton_Click
    (
        object? sender, 
        RoutedEventArgs e)
    {
        DescendantsListBox.ItemsSource =
            TheToggleSwitch
                .GetLogicalDescendants()
                .Select(l => l.GetType().Name)
                .ToArray();
    }

}