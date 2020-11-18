using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Acorisoft.UI.Buttons
{
    public abstract class MoriButtonBase : ButtonBase
    {

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

        public static readonly DependencyProperty PressForegroundBrushProperty = DependencyProperty.Register(
            "PressForegroundBrush",
            typeof(Brush),
            typeof(MoriButtonBase), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty PressBackgroundBrushProperty = DependencyProperty.Register(
            "PressBackgroundBrush",
            typeof(Brush),
            typeof(MoriButtonBase), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty HoverForegroundBrushProperty = DependencyProperty.Register(
            "HoverForegroundBrush",
            typeof(Brush),
            typeof(MoriButtonBase), 
            new PropertyMetadata(null));


        public static readonly DependencyProperty HoverBackgroundBrushProperty = DependencyProperty.Register(
            "HoverBackgroundBrush",
            typeof(Brush),
            typeof(MoriButtonBase), 
            new PropertyMetadata(null));

    }
}
