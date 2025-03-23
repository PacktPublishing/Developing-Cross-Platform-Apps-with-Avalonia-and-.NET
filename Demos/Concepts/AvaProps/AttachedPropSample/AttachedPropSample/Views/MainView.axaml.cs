using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AttachedPropSample.Views;

public partial class MainView : UserControl
{
    private const string GREETING_TEXT_BASE =
        "Hello World";

    int _numberClicks = 0;
    IDisposable? _callbackDisposable = null;

    public MainView()
    {
        InitializeComponent();

        // Set Attached Property GreetingText
        AttachedProps.SetGreetingText(this, GREETING_TEXT_BASE);

        string? greetingText =
            AttachedProps.GetGreetingText(this);

        // assert greeting text is correct
        if (greetingText != GREETING_TEXT_BASE)
        {
            throw new System.Exception($"greetingText is incorrect");
        }

        ChangeGreetingTextOnMainViewButton.Click += 
            ChangeGreetingText;


        // registering a callback
        _callbackDisposable =
            AttachedProps.GreetingTextProperty
                     .Changed
                     .Subscribe(OnGreetingTextChanged!);

        // another way to register a callback
        //_callbackDisposable =
        //    this.GetObservable(AttachedProps.GreetingTextProperty)
        //        .Subscribe(OnGreetingTextChangedCallback);
    }

    private void ChangeGreetingText(object? sender, RoutedEventArgs e)
    {
        _numberClicks++;
        AttachedProps.SetGreetingText
        (
            this, 
            $"{GREETING_TEXT_BASE}_{_numberClicks}");
    }

    private void OnGreetingTextChanged
    (
        AvaloniaPropertyChangedEventArgs<string> args
    )
    {
        var sender = args.Sender;

        // continue only if this
        // the sender is the MainView itself
        if (sender != this)
        {
            return; 
        }


    }

    private void OnGreetingTextChangedCallback(string newGreetingText)
    {

    }
}