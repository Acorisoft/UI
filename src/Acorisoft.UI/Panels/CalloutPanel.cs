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
    /// <summary>
    /// 呼吁面板
    /// </summary>
    public class CalloutPanel : ContentControl
    {
        static CalloutPanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CalloutPanel) ,
                new FrameworkPropertyMetadata(typeof(CalloutPanel)));
        }


        public Brush CalloutColor
        {
            get => (Brush)GetValue(CalloutColorProperty);
            set => SetValue(CalloutColorProperty , value);
        }

        public object Callout
        {
            get => (object)GetValue(CalloutProperty);
            set => SetValue(CalloutProperty , value);
        }

        public DataTemplate CalloutTemplate
        {
            get => (DataTemplate)GetValue(CalloutTemplateProperty);
            set => SetValue(CalloutTemplateProperty , value);
        }

        public DataTemplateSelector CalloutTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(CalloutTemplateSelectorProperty);
            set => SetValue(CalloutTemplateSelectorProperty , value);
        }


        public string CalloutStringFormat
        {
            get => (string)GetValue(CalloutStringFormatProperty);
            set => SetValue(CalloutStringFormatProperty , value);
        }

        public static readonly DependencyProperty CalloutStringFormatProperty = DependencyProperty.Register(
            "CalloutStringFormat",
            typeof(string),
            typeof(CalloutPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty CalloutTemplateSelectorProperty = DependencyProperty.Register(
            "CalloutTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(CalloutPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty CalloutTemplateProperty = DependencyProperty.Register(
            "CalloutTemplate",
            typeof(DataTemplate),
            typeof(CalloutPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty CalloutProperty = DependencyProperty.Register(
            "Callout",
            typeof(object),
            typeof(CalloutPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty CalloutColorProperty = DependencyProperty.Register(
            "CalloutColor",
            typeof(Brush),
            typeof(CalloutPanel), 
            new PropertyMetadata(null));

    }
}
