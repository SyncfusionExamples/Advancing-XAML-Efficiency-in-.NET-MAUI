using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;

namespace ImplicitSourceGenSample.Controls;

public class TagView : ContentView
{
    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(TagView), default(string));

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public TagView()
    {
        var label = new Label
        {
            TextColor = Colors.Black,
            LineBreakMode = LineBreakMode.TailTruncation
        };
        label.SetBinding(Label.TextProperty, new Binding(nameof(Text), source: this));

        var border = new Border
        {
            Background = new SolidColorBrush(Colors.LightBlue),
            Stroke = Brush.Transparent,
            StrokeThickness = 0,
            Padding = new Thickness(12, 6),
            StrokeShape = new RoundRectangle
            {
                CornerRadius = new CornerRadius(12)
            },
            Content = label
        };

        Content = border;
    }
}