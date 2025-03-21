using System;
using Avalonia;
using Avalonia.Controls;

namespace SimpleAttachedPropSample.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        //AttachedProps.SetGreetingText(RootPanel, "RootPanel Greetings!")

        //var greetingText = AttachedProps.GetGreetingText(RootPanel);

        //string? mainViewGreetingText = AttachedProps.GetGreetingText(this);
    }
}