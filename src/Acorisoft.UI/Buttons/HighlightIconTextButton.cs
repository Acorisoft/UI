using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Acorisoft.Buttons
{
    public class HighlightIconTextButton : IconTextButton
    {
        static HighlightIconTextButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HighlightIconTextButton) , new FrameworkPropertyMetadata(typeof(HighlightIconTextButton)));
        }

        public Brush Highlight
        {
            get => (Brush)GetValue(HighlightProperty);
            set => SetValue(HighlightProperty , value);
        }

        public static readonly DependencyProperty HighlightProperty = DependencyProperty.Register(
            "Highlight",
            typeof(Brush),
            typeof(HighlightIconTextButton), 
            new PropertyMetadata(null));

    }
}
