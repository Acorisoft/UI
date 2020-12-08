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

namespace Acorisoft.UI.Panels
{
    public class EmptyStatePanel : ContentControl
    {
        static EmptyStatePanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(EmptyStatePanel) , new FrameworkPropertyMetadata(typeof(EmptyStatePanel)));
        }


        public bool HasItems
        {
            get => (bool)GetValue(HasItemsProperty);
            set => SetValue(HasItemsProperty , value);
        }

        public object Alternative
        {
            get => (object)GetValue(AlternativeProperty);
            set => SetValue(AlternativeProperty , value);
        }

        public DataTemplate AlternativeTemplate
        {
            get => (DataTemplate)GetValue(AlternativeTemplateProperty);
            set => SetValue(AlternativeTemplateProperty , value);
        }

        public DataTemplateSelector AlternativeTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(AlternativeTemplateSelectorProperty);
            set => SetValue(AlternativeTemplateSelectorProperty , value);
        }


        public string AlternativeStringFormat
        {
            get => (string)GetValue(AlternativeStringFormatProperty);
            set => SetValue(AlternativeStringFormatProperty , value);
        }

        public static readonly DependencyProperty AlternativeStringFormatProperty = DependencyProperty.Register(
            "AlternativeStringFormat",
            typeof(string),
            typeof(EmptyStatePanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty AlternativeTemplateSelectorProperty = DependencyProperty.Register(
            "AlternativeTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(EmptyStatePanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty AlternativeTemplateProperty = DependencyProperty.Register(
            "AlternativeTemplate",
            typeof(DataTemplate),
            typeof(EmptyStatePanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty AlternativeProperty = DependencyProperty.Register(
            "Alternative",
            typeof(object),
            typeof(EmptyStatePanel),
            new PropertyMetadata(null));
        public static readonly DependencyProperty HasItemsProperty = DependencyProperty.Register(
            "HasItems",
            typeof(bool),
            typeof(EmptyStatePanel), 
            new PropertyMetadata(true,OnHasItemsChanged));

        private static void OnHasItemsChanged(DependencyObject d , DependencyPropertyChangedEventArgs e)
        {
            d.SetCurrentValue(HasItemsProperty , BooleanBoxes.Box((bool)e.NewValue));
        }
    }
}
