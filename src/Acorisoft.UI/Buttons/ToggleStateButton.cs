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
    public class ToggleStateButton : CheckBox
    {
        static ToggleStateButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ToggleStateButton) , new FrameworkPropertyMetadata(typeof(ToggleStateButton)));            
        }


        public Geometry TrueState
        {
            get => (Geometry)GetValue(TrueStateProperty);
            set => SetValue(TrueStateProperty , value);
        }


        public Geometry FalseState
        {
            get => (Geometry)GetValue(FalseStateProperty);
            set => SetValue(FalseStateProperty , value);
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


        public static readonly DependencyProperty IconPaddingProperty = DependencyProperty.Register(
            "IconPadding",
            typeof(Thickness),
            typeof(ToggleStateButton),
            new PropertyMetadata(null));

        public static readonly DependencyProperty IconHeightProperty = DependencyProperty.Register(
            "IconHeight",
            typeof(double),
            typeof(ToggleStateButton),
            new PropertyMetadata(null));

        public static readonly DependencyProperty IconWidthProperty = DependencyProperty.Register(
            "IconWidth",
            typeof(double),
            typeof(ToggleStateButton),
            new PropertyMetadata(null));

        public static readonly DependencyProperty FalseStateProperty = DependencyProperty.Register(
            "FalseState",
            typeof(Geometry),
            typeof(ToggleStateButton), 
            new PropertyMetadata(null));


        public static readonly DependencyProperty TrueStateProperty = DependencyProperty.Register(
            "TrueState",
            typeof(Geometry),
            typeof(ToggleStateButton), 
            new PropertyMetadata(null));

    }
}
