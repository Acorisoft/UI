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
    public class EmptyStateControl : ContentControl
    {
        static EmptyStateControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(EmptyStateControl) , new FrameworkPropertyMetadata(typeof(EmptyStateControl)));
        }


        public bool IsEmpty
        {
            get => (bool)GetValue(IsEmptyProperty);
            set => SetValue(IsEmptyProperty , value);
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
            typeof(EmptyStateControl),
            new PropertyMetadata(null));

        public static readonly DependencyProperty AlternativeTemplateSelectorProperty = DependencyProperty.Register(
            "AlternativeTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(EmptyStateControl),
            new PropertyMetadata(null));

        public static readonly DependencyProperty AlternativeTemplateProperty = DependencyProperty.Register(
            "AlternativeTemplate",
            typeof(DataTemplate),
            typeof(EmptyStateControl),
            new PropertyMetadata(null));

        public static readonly DependencyProperty AlternativeProperty = DependencyProperty.Register(
            "Alternative",
            typeof(object),
            typeof(EmptyStateControl),
            new PropertyMetadata(null));
        public static readonly DependencyProperty IsEmptyProperty = DependencyProperty.Register(
            "IsEmpty",
            typeof(bool),
            typeof(EmptyStateControl), 
            new PropertyMetadata(true,OnIsEmptyChanged));

        private static void OnIsEmptyChanged(DependencyObject d , DependencyPropertyChangedEventArgs e)
        {
        }
    }
}
