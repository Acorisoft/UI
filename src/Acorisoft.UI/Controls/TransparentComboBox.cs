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

namespace Acorisoft.UI.Controls
{
    /// <summary>
    /// 透明组合框
    /// </summary>
    public class TransparentComboBox : ComboBox
    {
        static TransparentComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TransparentComboBox) , 
                new FrameworkPropertyMetadata(typeof(TransparentComboBox)));
        }


        public Thickness ItemsPadding
        {
            get => (Thickness)GetValue(ItemsPaddingProperty);
            set => SetValue(ItemsPaddingProperty , value);
        }

        public Brush PanelForeground
        {
            get => (Brush)GetValue(PanelForegroundProperty);
            set => SetValue(PanelForegroundProperty , value);
        }


        public double IconSize
        {
            get => (double)GetValue(IconSizeProperty);
            set => SetValue(IconSizeProperty , value);
        }

        public static readonly DependencyProperty IconSizeProperty = DependencyProperty.Register(
            "IconSize",
            typeof(double),
            typeof(TransparentComboBox), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty ItemsPaddingProperty = DependencyProperty.Register(
            "ItemsPadding",
            typeof(Thickness),
            typeof(TransparentComboBox),
            new PropertyMetadata(null));


        public static readonly DependencyProperty PanelForegroundProperty = DependencyProperty.Register(
            "PanelForeground",
            typeof(Brush),
            typeof(TransparentComboBox), 
            new PropertyMetadata(null));

    }
}
