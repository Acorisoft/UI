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

namespace Acorisoft.UI.Views
{
    /// <summary>
    /// <see cref="MasterDetailView"/> 表示一个主从视图布局控件。
    /// </summary>
    [DefaultProperty("Detail")]
    [ContentProperty("Detail")]
    public class MasterDetailView : Control, IMasterDetailView
    {
        static MasterDetailView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MasterDetailView), new FrameworkPropertyMetadata(typeof(MasterDetailView)));
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
            typeof(MasterDetailView), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty DirectionProperty = DependencyProperty.Register(
            "Direction",
            typeof(HorizontalDirection),
            typeof(MasterDetailView), 
            new PropertyMetadata(null));


        public static readonly DependencyProperty DetailStringFormatProperty = DependencyProperty.Register(
            "DetailStringFormat",
            typeof(string),
            typeof(MasterDetailView),
            new PropertyMetadata(null));

        public static readonly DependencyProperty DetailTemplateSelectorProperty = DependencyProperty.Register(
            "DetailTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(MasterDetailView),
            new PropertyMetadata(null));

        public static readonly DependencyProperty DetailTemplateProperty = DependencyProperty.Register(
            "DetailTemplate",
            typeof(DataTemplate),
            typeof(MasterDetailView),
            new PropertyMetadata(null));

        public static readonly DependencyProperty DetailProperty = DependencyProperty.Register(
            "Detail",
            typeof(object),
            typeof(MasterDetailView),
            new PropertyMetadata(null,OnDetailChanged));

        private static void OnDetailChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var mdView = (MasterDetailView)d;
            mdView.RaiseEvent(new RoutedEventArgs { RoutedEvent = DetailChangedEvent });
        }

        public static readonly DependencyProperty MasterStringFormatProperty = DependencyProperty.Register(
            "MasterStringFormat",
            typeof(string),
            typeof(MasterDetailView),
            new PropertyMetadata(null));

        public static readonly DependencyProperty MasterTemplateSelectorProperty = DependencyProperty.Register(
            "MasterTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(MasterDetailView),
            new PropertyMetadata(null));

        public static readonly DependencyProperty MasterTemplateProperty = DependencyProperty.Register(
            "MasterTemplate",
            typeof(DataTemplate),
            typeof(MasterDetailView),
            new PropertyMetadata(null));

        public static readonly DependencyProperty MasterProperty = DependencyProperty.Register(
            "Master",
            typeof(object),
            typeof(MasterDetailView),
            new PropertyMetadata(null));

        public static readonly RoutedEvent MasterChangedEvent = EventManager.RegisterRoutedEvent(
            "MasterChanged",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(MasterDetailView));

        public static readonly RoutedEvent DetailChangedEvent = EventManager.RegisterRoutedEvent(
            "DetailChanged",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler), 
            typeof(MasterDetailView));

        public static readonly RoutedEvent DirectionChangedEvent = EventManager.RegisterRoutedEvent(
            "DirectionChanged",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(MasterDetailView));

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
