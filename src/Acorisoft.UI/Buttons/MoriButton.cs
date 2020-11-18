using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Acorisoft.UI.Buttons
{
    public class MoriButton : MoriButtonBase
    {
        static MoriButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MoriButton) , new FrameworkPropertyMetadata(typeof(MoriButton)));
            HasIconPropertyKey = DependencyProperty.RegisterReadOnly(
                "HasIcon" ,
                typeof(bool) ,
                typeof(MoriButton) ,
                new PropertyMetadata(null));
            HasIconProperty = HasIconPropertyKey.DependencyProperty;
        }

        public Geometry Icon
        {
            get => (Geometry)GetValue(IconProperty);
            set => SetValue(IconProperty , value);
        }


        public double IconWidth
        {
            get => (double)GetValue(IconWidthProperty);
            set => SetValue(IconWidthProperty , value);
        }

        public double IconHeight
        {
            get => (double)GetValue(IconHeightProperty);
            set => SetValue(IconHeightProperty , value);
        }

        public Thickness IconPadding
        {
            get => (Thickness)GetValue(IconPaddingProperty);
            set => SetValue(IconPaddingProperty , value);
        }


        public ButtonMode Mode
        {
            get => (ButtonMode)GetValue(ModeProperty);
            set => SetValue(ModeProperty , value);
        }


        public Dock IconDock
        {
            get => (Dock)GetValue(IconDockProperty);
            set => SetValue(IconDockProperty , value);
        }

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty , value);
        }

        public Brush Highlight
        {
            get => (Brush)GetValue(HighlightProperty);
            set => SetValue(HighlightProperty , value);
        }

        public bool HasIcon
        {
            get => (bool)GetValue(HasIconProperty);
        }

        public static readonly DependencyProperty HasIconProperty;
        public static readonly DependencyPropertyKey HasIconPropertyKey;

        public static readonly DependencyProperty HighlightProperty = DependencyProperty.Register(
            "Highlight",
            typeof(Brush),
            typeof(MoriButton), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(
            "CornerRadius",
            typeof(CornerRadius),
            typeof(MoriButton), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty IconDockProperty = DependencyProperty.Register(
            "IconDock",
            typeof(Dock),
            typeof(MoriButton), 
            new PropertyMetadata(null));


        public static readonly DependencyProperty ModeProperty = DependencyProperty.Register(
            "Mode",
            typeof(ButtonMode),
            typeof(MoriButton), 
            new PropertyMetadata(null));


        public static readonly DependencyProperty IconPaddingProperty = DependencyProperty.Register(
            "IconPadding",
            typeof(Thickness),
            typeof(MoriButton), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty IconHeightProperty = DependencyProperty.Register(
            "IconHeight",
            typeof(double),
            typeof(MoriButton), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty IconWidthProperty = DependencyProperty.Register(
            "IconWidth",
            typeof(double),
            typeof(MoriButton), 
            new PropertyMetadata(null));


        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
            "Icon",
            typeof(Geometry),
            typeof(MoriButton), 
            new PropertyMetadata(null,OnIconChanged));

        private static void OnIconChanged(DependencyObject d , DependencyPropertyChangedEventArgs e)
        {
            d.SetValue(HasIconPropertyKey , e.NewValue is Geometry);
        }
    }
}
