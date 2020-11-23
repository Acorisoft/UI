using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Acorisoft.UI.Buttons
{

    public class DropDownIconButton : ButtonBase,ISupportIcon
    {
        static DropDownIconButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DropDownIconButton) , new FrameworkPropertyMetadata(typeof(DropDownIconButton)));
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


        public Geometry Icon
        {
            get => (Geometry)GetValue(IconProperty);
            set => SetValue(IconProperty , value);
        }


        public object PopupContent
        {
            get => (object)GetValue(PopupContentProperty);
            set => SetValue(PopupContentProperty , value);
        }

        public DataTemplate PopupContentTemplate
        {
            get => (DataTemplate)GetValue(PopupContentTemplateProperty);
            set => SetValue(PopupContentTemplateProperty , value);
        }

        public DataTemplateSelector PopupContentTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(PopupContentTemplateSelectorProperty);
            set => SetValue(PopupContentTemplateSelectorProperty , value);
        }


        public string PopupContentStringFormat
        {
            get => (string)GetValue(PopupContentStringFormatProperty);
            set => SetValue(PopupContentStringFormatProperty , value);
        }

        public static readonly DependencyProperty PopupContentStringFormatProperty = DependencyProperty.Register(
            "PopupContentStringFormat",
            typeof(string),
            typeof(DropDownIconButton),
            new PropertyMetadata(null));

        public static readonly DependencyProperty PopupContentTemplateSelectorProperty = DependencyProperty.Register(
            "PopupContentTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(DropDownIconButton),
            new PropertyMetadata(null));

        public static readonly DependencyProperty PopupContentTemplateProperty = DependencyProperty.Register(
            "PopupContentTemplate",
            typeof(DataTemplate),
            typeof(DropDownIconButton),
            new PropertyMetadata(null));

        public static readonly DependencyProperty PopupContentProperty = DependencyProperty.Register(
            "PopupContent",
            typeof(object),
            typeof(DropDownIconButton),
            new PropertyMetadata(null));

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
            "Icon",
            typeof(Geometry),
            typeof(DropDownIconButton), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty IconPaddingProperty = DependencyProperty.Register(
            "IconPadding",
            typeof(Thickness),
            typeof(DropDownIconButton),
            new PropertyMetadata(null));

        public static readonly DependencyProperty IconHeightProperty = DependencyProperty.Register(
            "IconHeight",
            typeof(double),
            typeof(DropDownIconButton),
            new PropertyMetadata(null));

        public static readonly DependencyProperty IconWidthProperty = DependencyProperty.Register(
            "IconWidth",
            typeof(double),
            typeof(DropDownIconButton),
            new PropertyMetadata(null));
    }
}
