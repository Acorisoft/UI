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

    public class PathButton : ModeButton
    {
        static PathButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PathButton) , 
                new FrameworkPropertyMetadata(typeof(PathButton)));
        }


        public Geometry Icon
        {
            get => (Geometry)GetValue(IconProperty);
            set => SetValue(IconProperty , value);
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
            typeof(PathButton), 
            new PropertyMetadata(1d));

        public static readonly DependencyProperty IconPaddingProperty = DependencyProperty.Register(
            "IconPadding",
            typeof(Thickness),
            typeof(PathButton), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
            "Icon",
            typeof(Geometry),
            typeof(PathButton), 
            new PropertyMetadata(null));

    }
}
