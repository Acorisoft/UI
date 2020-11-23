using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Acorisoft.UI.Panels
{
    public class ContextualPanel : HeaderedContentControl
    {
        static ContextualPanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ContextualPanel) , new FrameworkPropertyMetadata(typeof(ContextualPanel)));
            HasIconPropertyKey = DependencyProperty.RegisterReadOnly(
            "HasIcon" ,
            typeof(bool) ,
            typeof(ContextualPanel) ,
            new PropertyMetadata(BooleanBoxes.FalseBox));
            HasIconProperty = HasIconPropertyKey.DependencyProperty;
        }


        public Brush Color
        {
            get => (Brush)GetValue(ColorProperty);
            set => SetValue(ColorProperty , value);
        }

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty , value);
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

        public bool HasIcon
        {
            get => (bool)GetValue(HasIconProperty);
        }

        public static readonly DependencyPropertyKey HasIconPropertyKey;
        public static readonly DependencyProperty HasIconProperty;
        public static readonly DependencyProperty IconPaddingProperty = DependencyProperty.Register(
            "IconPadding",
            typeof(Thickness),
            typeof(ContextualPanel), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty IconHeightProperty = DependencyProperty.Register(
            "IconHeight",
            typeof(double),
            typeof(ContextualPanel), 
            new PropertyMetadata(null));


        public static readonly DependencyProperty IconWidthProperty = DependencyProperty.Register(
            "IconWidth",
            typeof(double),
            typeof(ContextualPanel), 
            new PropertyMetadata(null));


        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
            "Icon",
            typeof(Geometry),
            typeof(ContextualPanel), 
            new PropertyMetadata(null,OnIconChanged));


        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(
            "CornerRadius",
            typeof(CornerRadius),
            typeof(ContextualPanel), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register(
            "Color",
            typeof(Brush),
            typeof(ContextualPanel), 
            new PropertyMetadata(null));

        private static void OnIconChanged(DependencyObject d , DependencyPropertyChangedEventArgs e)
        {
            d.SetValue(HasIconPropertyKey , e.NewValue is Geometry);
        }
    }
}
