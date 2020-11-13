using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Acorisoft.Buttons
{

    public class ToolbarButton : CornerRadiusButton
    {
        protected static readonly object DefaultThemeValue = Theme.Light;

        static ToolbarButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ToolbarButton), new FrameworkPropertyMetadata(typeof(ToolbarButton)));
            HasIconPropertyKey = DependencyProperty.RegisterReadOnly(
            "HasIcon",
            typeof(bool),
            typeof(ToolbarButton),
            new PropertyMetadata(null));
            HasIconProperty = HasIconPropertyKey.DependencyProperty;
        }


        public bool HasIcon
        {
            get => (bool)GetValue(HasIconProperty);
        }

        public Geometry Icon
        {
            get => (Geometry)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }


        public double IconWidth
        {
            get => (double)GetValue(IconWidthProperty);
            set => SetValue(IconWidthProperty, value);
        }

        public double IconHeight
        {
            get => (double)GetValue(IconHeightProperty);
            set => SetValue(IconHeightProperty, value);
        }

        public Brush HoverBrush
        {
            get => (Brush)GetValue(HoverBrushProperty);
            set => SetValue(HoverBrushProperty , value);
        }

        public Brush PressBrush
        {
            get => (Brush)GetValue(PressBrushProperty);
            set => SetValue(PressBrushProperty , value);
        }

        public static readonly DependencyProperty PressBrushProperty = DependencyProperty.Register(
            "PressBrush",
            typeof(Brush),
            typeof(ToolbarButton), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty HoverBrushProperty = DependencyProperty.Register(
            "HoverBrush",
            typeof(Brush),
            typeof(ToolbarButton), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty IconHeightProperty = DependencyProperty.Register(
            "IconHeight",
            typeof(double),
            typeof(ToolbarButton), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty IconWidthProperty = DependencyProperty.Register(
            "IconWidth",
            typeof(double),
            typeof(ToolbarButton), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty HasIconProperty;

        public static readonly DependencyPropertyKey HasIconPropertyKey;


        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
            "Icon",
            typeof(Geometry),
            typeof(ToolbarButton),
            new PropertyMetadata(null,OnIconChanged));

        private static void OnIconChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.SetValue(HasIconPropertyKey, e.NewValue is Geometry);
        }
    }
}
