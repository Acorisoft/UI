using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Acorisoft.UI.Buttons
{
    public class ModeButton : Button
    {
        private static readonly object DefaultCornerRadius = new CornerRadius(8);

        static ModeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ModeButton) , new FrameworkPropertyMetadata(typeof(ModeButton)));
        }


        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty , value);
        }

        public Brush HoverBackgroundBrush
        {
            get => (Brush)GetValue(HoverBackgroundBrushProperty);
            set => SetValue(HoverBackgroundBrushProperty , value);
        }

        public Brush HoverForegroundBrush
        {
            get => (Brush)GetValue(HoverForegroundBrushProperty);
            set => SetValue(HoverForegroundBrushProperty , value);
        }

        public Brush PressBackgroundBrush
        {
            get => (Brush)GetValue(PressBackgroundBrushProperty);
            set => SetValue(PressBackgroundBrushProperty , value);
        }

        public Brush PressForegroundBrush
        {
            get => (Brush)GetValue(PressForegroundBrushProperty);
            set => SetValue(PressForegroundBrushProperty , value);
        }

        public ButtonMode Mode
        {
            get => (ButtonMode)GetValue(ModeProperty);
            set => SetValue(ModeProperty , value);
        }

        public static readonly DependencyProperty ModeProperty = DependencyProperty.Register(
            "Mode",
            typeof(ButtonMode),
            typeof(ModeButton), 
            new PropertyMetadata(null));


        public static readonly DependencyProperty PressForegroundBrushProperty = DependencyProperty.Register(
            "PressForegroundBrush",
            typeof(Brush),
            typeof(ModeButton),
            new PropertyMetadata(null));

        public static readonly DependencyProperty PressBackgroundBrushProperty = DependencyProperty.Register(
            "PressBackgroundBrush",
            typeof(Brush),
            typeof(ModeButton),
            new PropertyMetadata(null));

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(
            "CornerRadius",
            typeof(CornerRadius),
            typeof(ModeButton),
            new PropertyMetadata(DefaultCornerRadius));

        public static readonly DependencyProperty HoverForegroundBrushProperty = DependencyProperty.Register(
            "HoverForegroundBrush",
            typeof(Brush),
            typeof(ModeButton), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty HoverBackgroundBrushProperty = DependencyProperty.Register(
            "HoverBackgroundBrush",
            typeof(Brush),
            typeof(ModeButton), 
            new PropertyMetadata(null));

    }
}
