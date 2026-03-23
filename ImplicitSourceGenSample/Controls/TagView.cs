using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;

namespace ImplicitSourceGenSample.Controls
{
    /// <summary>
    /// A custom pill-shaped tag control that displays text inside a rounded container with customizable binding support.
    /// </summary>
    /// <remarks>
    /// TagView is designed as a lightweight UI element commonly used for labels, categories, chips, or badges. The Text property is bindable and updates the visual label automatically.
    /// </remarks>
    public class TagView : ContentView
    {
        /// <summary>
        /// Identifies the <see cref="Text"/> bindable property.
        /// </summary>
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(TagView), default(string));

        /// <summary>
        /// Gets or sets the text displayed inside the tag.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> representing the content of the tag.
        /// </value>
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagView"/> class.
        /// </summary>
        /// <remarks>
        /// The control is rendered with a rounded blue background and a label that binds to the <see cref="Text"/> property.
        /// </remarks>
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
}