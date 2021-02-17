using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Markup;

namespace Acorisoft.UI.Layout
{
    /// <summary>
    /// <see cref="MasterDetailLayout"/> 表示一个主从视图布局控件。
    /// </summary>
    [DefaultProperty("Master")]
    [ContentProperty("Master")]
    public class MasterDetailLayout : Control, IMasterDetailLayout
    {
        static MasterDetailLayout()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MasterDetailLayout), new FrameworkPropertyMetadata(typeof(MasterDetailLayout)));
        }


        public object Master
        {
            get => (object)GetValue(MasterProperty);
            set => SetValue(MasterProperty, value);
        }

        public DataTemplate MasterTemplate
        {
            get => (DataTemplate)GetValue(MasterTemplateProperty);
            set => SetValue(MasterTemplateProperty, value);
        }

        public DataTemplateSelector MasterTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(MasterTemplateSelectorProperty);
            set => SetValue(MasterTemplateSelectorProperty, value);
        }


        public string MasterStringFormat
        {
            get => (string)GetValue(MasterStringFormatProperty);
            set => SetValue(MasterStringFormatProperty, value);
        }

        public object Detail
        {
            get => (object)GetValue(DetailProperty);
            set => SetValue(DetailProperty, value);
        }

        public DataTemplate DetailTemplate
        {
            get => (DataTemplate)GetValue(DetailTemplateProperty);
            set => SetValue(DetailTemplateProperty, value);
        }

        public DataTemplateSelector DetailTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(DetailTemplateSelectorProperty);
            set => SetValue(DetailTemplateSelectorProperty, value);
        }


        public string DetailStringFormat
        {
            get => (string)GetValue(DetailStringFormatProperty);
            set => SetValue(DetailStringFormatProperty, value);
        }


        public HorizontalDirection Direction
        {
            get => (HorizontalDirection)GetValue(DirectionProperty);
            set => SetValue(DirectionProperty, value);
        }
        public double MasterWidth
        {
            get => (double)GetValue(MasterWidthProperty);
            set => SetValue(MasterWidthProperty, value);
        }

        public static readonly DependencyProperty MasterWidthProperty = DependencyProperty.Register(
            "MasterWidth",
            typeof(double),
            typeof(MasterDetailLayout), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty DirectionProperty = DependencyProperty.Register(
            "Direction",
            typeof(HorizontalDirection),
            typeof(MasterDetailLayout), 
            new PropertyMetadata(null));


        public static readonly DependencyProperty DetailStringFormatProperty = DependencyProperty.Register(
            "DetailStringFormat",
            typeof(string),
            typeof(MasterDetailLayout),
            new PropertyMetadata(null));

        public static readonly DependencyProperty DetailTemplateSelectorProperty = DependencyProperty.Register(
            "DetailTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(MasterDetailLayout),
            new PropertyMetadata(null));

        public static readonly DependencyProperty DetailTemplateProperty = DependencyProperty.Register(
            "DetailTemplate",
            typeof(DataTemplate),
            typeof(MasterDetailLayout),
            new PropertyMetadata(null));

        public static readonly DependencyProperty DetailProperty = DependencyProperty.Register(
            "Detail",
            typeof(object),
            typeof(MasterDetailLayout),
            new PropertyMetadata(null));
        public static readonly DependencyProperty MasterStringFormatProperty = DependencyProperty.Register(
            "MasterStringFormat",
            typeof(string),
            typeof(MasterDetailLayout),
            new PropertyMetadata(null));

        public static readonly DependencyProperty MasterTemplateSelectorProperty = DependencyProperty.Register(
            "MasterTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(MasterDetailLayout),
            new PropertyMetadata(null));

        public static readonly DependencyProperty MasterTemplateProperty = DependencyProperty.Register(
            "MasterTemplate",
            typeof(DataTemplate),
            typeof(MasterDetailLayout),
            new PropertyMetadata(null));

        public static readonly DependencyProperty MasterProperty = DependencyProperty.Register(
            "Master",
            typeof(object),
            typeof(MasterDetailLayout),
            new PropertyMetadata(null));

        public static readonly RoutedEvent MasterChangedEvent = EventManager.RegisterRoutedEvent(
            "MasterChanged",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(MasterDetailLayout));

        public static readonly RoutedEvent DetailChangedEvent = EventManager.RegisterRoutedEvent(
            "DetailChanged",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler), 
            typeof(MasterDetailLayout));

        public static readonly RoutedEvent DirectionChangedEvent = EventManager.RegisterRoutedEvent(
            "DirectionChanged",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(MasterDetailLayout));

        public event RoutedEventHandler DirectionChanged
        {
            add => AddHandler(DirectionChangedEvent, value);
            remove => RemoveHandler(DirectionChangedEvent, value);
        }
        public event RoutedEventHandler DetailChanged
        {
            add => AddHandler(DetailChangedEvent, value);
            remove => RemoveHandler(DetailChangedEvent, value);
        }
        public event RoutedEventHandler MasterContentChanged
        {
            add => AddHandler(MasterChangedEvent, value);
            remove => RemoveHandler(MasterChangedEvent, value);
        }
    }
}
