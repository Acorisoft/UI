using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Acorisoft.UI.Buttons
{
    public class GeometryButton : Button
    {
        static GeometryButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GeometryButton) , new FrameworkPropertyMetadata(typeof(GeometryButton)));
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

        public double IconThickness
        {
            get => (double)GetValue(IconThicknessProperty);
            set => SetValue(IconThicknessProperty , value);
        }

        public static readonly DependencyProperty IconThicknessProperty = DependencyProperty.Register(
            "IconThickness",
            typeof(double),
            typeof(GeometryButton),
            new PropertyMetadata(1d));

        public static readonly DependencyProperty IconPaddingProperty = DependencyProperty.Register(
            "IconPadding",
            typeof(Thickness),
            typeof(GeometryButton),
            new PropertyMetadata(null));

        public static readonly DependencyProperty IconHeightProperty = DependencyProperty.Register(
            "IconHeight",
            typeof(double),
            typeof(GeometryButton),
            new PropertyMetadata(null));

        public static readonly DependencyProperty IconWidthProperty = DependencyProperty.Register(
            "IconWidth",
            typeof(double),
            typeof(GeometryButton),
            new PropertyMetadata(null));

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
            "Icon",
            typeof(Geometry),
            typeof(GeometryButton),
            new PropertyMetadata(null));

    }
}
