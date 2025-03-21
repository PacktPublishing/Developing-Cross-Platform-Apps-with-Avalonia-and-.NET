using System;
using Avalonia;
using Avalonia.Controls;

namespace SimpleAttachedPropSample.Views;

public partial class MainView : UserControl
{
    private const string GREETING_TEXT_BASE =
        "Hello World";

    int _numberClicks = 0;

    IDisposable? _callbackDisposable = null;

    public MainView()
    {
        InitializeComponent();
    }
}