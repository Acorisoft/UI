using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Acorisoft.UI.Views
{
    [TemplatePart(Name = ContentTemplateName , Type = typeof(ContentPresenter))]
    [TemplatePart(Name = FlyoutTopTemplateName , Type = typeof(ContentPresenter))]
    [TemplatePart(Name = FlyoutRightTemplateName , Type = typeof(ContentPresenter))]
    [TemplatePart(Name = FlyoutBottomTemplateName , Type = typeof(ContentPresenter))]
    [TemplatePart(Name = FlyoutLeftTemplateName , Type = typeof(ContentPresenter))]
    [TemplatePart(Name = DialogTemplateName , Type = typeof(ContentPresenter))]
    [TemplatePart(Name = MaskTemplateName , Type = typeof(Border))]
    [DefaultProperty("Content")]
    [ContentProperty("Content")]
    public class ContentHost : Control
    {
        private const string ContentTemplateName = "PART_Content";
        private const string FlyoutTopTemplateName = "PART_TopFlyout";
        private const string FlyoutRightTemplateName = "PART_RightFlyout";
        private const string FlyoutBottomTemplateName = "PART_BottomFlyout";
        private const string FlyoutLeftTemplateName = "PART_LeftFlyout";
        private const string DialogTemplateName  = "PART_Dialog";
        private const string MaskTemplateName = "PART_Mask";

        private ContentPresenter PART_LeftFlyout;
        private ContentPresenter PART_RightFlyout;
        private ContentPresenter PART_TopFlyout;
        private ContentPresenter PART_BottomFlyout;
        private ContentPresenter PART_Dialog;
        private Border PART_Mask;

        static ContentHost()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ContentHost) ,
                new FrameworkPropertyMetadata(typeof(ContentHost)));
        }

        public override void OnApplyTemplate()
        {
            PART_LeftFlyout = GetTemplateChild(FlyoutLeftTemplateName) as ContentPresenter;
            PART_RightFlyout = GetTemplateChild(FlyoutRightTemplateName) as ContentPresenter;
            PART_TopFlyout = GetTemplateChild(FlyoutTopTemplateName) as ContentPresenter;
            PART_BottomFlyout = GetTemplateChild(FlyoutBottomTemplateName) as ContentPresenter;
            PART_Dialog = GetTemplateChild(DialogTemplateName) as ContentPresenter;
            PART_Mask = GetTemplateChild(MaskTemplateName) as Border;
            PART_Mask.MouseDown += OnCloseAllContent;
        }

        private void OnCloseAllContent(object sender , MouseButtonEventArgs e)
        {
            IsOpenDialog = false;
            e.Handled = true;
        }

        public object LeftFlyout
        {
            get => (object)GetValue(LeftFlyoutProperty);
            set => SetValue(LeftFlyoutProperty , value);
        }

        public DataTemplate LeftFlyoutTemplate
        {
            get => (DataTemplate)GetValue(LeftFlyoutTemplateProperty);
            set => SetValue(LeftFlyoutTemplateProperty , value);
        }

        public DataTemplateSelector LeftFlyoutTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(LeftFlyoutTemplateSelectorProperty);
            set => SetValue(LeftFlyoutTemplateSelectorProperty , value);
        }


        public string LeftFlyoutStringFormat
        {
            get => (string)GetValue(LeftFlyoutStringFormatProperty);
            set => SetValue(LeftFlyoutStringFormatProperty , value);
        }

        public object Content
        {
            get => (object)GetValue(ContentProperty);
            set => SetValue(ContentProperty , value);
        }

        public DataTemplate ContentTemplate
        {
            get => (DataTemplate)GetValue(ContentTemplateProperty);
            set => SetValue(ContentTemplateProperty , value);
        }

        public DataTemplateSelector ContentTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(ContentTemplateSelectorProperty);
            set => SetValue(ContentTemplateSelectorProperty , value);
        }


        public string ContentStringFormat
        {
            get => (string)GetValue(ContentStringFormatProperty);
            set => SetValue(ContentStringFormatProperty , value);
        }

        public object RightFlyout
        {
            get => (object)GetValue(RightFlyoutProperty);
            set => SetValue(RightFlyoutProperty , value);
        }

        public DataTemplate RightFlyoutTemplate
        {
            get => (DataTemplate)GetValue(RightFlyoutTemplateProperty);
            set => SetValue(RightFlyoutTemplateProperty , value);
        }

        public DataTemplateSelector RightFlyoutTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(RightFlyoutTemplateSelectorProperty);
            set => SetValue(RightFlyoutTemplateSelectorProperty , value);
        }


        public string RightFlyoutStringFormat
        {
            get => (string)GetValue(RightFlyoutStringFormatProperty);
            set => SetValue(RightFlyoutStringFormatProperty , value);
        }

        public object TopFlyout
        {
            get => (object)GetValue(TopFlyoutProperty);
            set => SetValue(TopFlyoutProperty , value);
        }

        public DataTemplate TopFlyoutTemplate
        {
            get => (DataTemplate)GetValue(TopFlyoutTemplateProperty);
            set => SetValue(TopFlyoutTemplateProperty , value);
        }

        public DataTemplateSelector TopFlyoutTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(TopFlyoutTemplateSelectorProperty);
            set => SetValue(TopFlyoutTemplateSelectorProperty , value);
        }


        public string TopFlyoutStringFormat
        {
            get => (string)GetValue(TopFlyoutStringFormatProperty);
            set => SetValue(TopFlyoutStringFormatProperty , value);
        }

        public object BottomFlyout
        {
            get => (object)GetValue(BottomFlyoutProperty);
            set => SetValue(BottomFlyoutProperty , value);
        }

        public DataTemplate BottomFlyoutTemplate
        {
            get => (DataTemplate)GetValue(BottomFlyoutTemplateProperty);
            set => SetValue(BottomFlyoutTemplateProperty , value);
        }

        public DataTemplateSelector BottomFlyoutTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(BottomFlyoutTemplateSelectorProperty);
            set => SetValue(BottomFlyoutTemplateSelectorProperty , value);
        }


        public string BottomFlyoutStringFormat
        {
            get => (string)GetValue(BottomFlyoutStringFormatProperty);
            set => SetValue(BottomFlyoutStringFormatProperty , value);
        }

        public object Dialog
        {
            get => (object)GetValue(DialogProperty);
            set => SetValue(DialogProperty , value);
        }

        public DataTemplate DialogTemplate
        {
            get => (DataTemplate)GetValue(DialogTemplateProperty);
            set => SetValue(DialogTemplateProperty , value);
        }

        public DataTemplateSelector DialogTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(DialogTemplateSelectorProperty);
            set => SetValue(DialogTemplateSelectorProperty , value);
        }


        public string DialogStringFormat
        {
            get => (string)GetValue(DialogStringFormatProperty);
            set => SetValue(DialogStringFormatProperty , value);
        }


        public bool IsOpenLeftFlyout
        {
            get => (bool)GetValue(IsOpenLeftFlyoutProperty);
            set => SetValue(IsOpenLeftFlyoutProperty , value);
        }

        public bool IsOpenTopFlyout
        {
            get => (bool)GetValue(IsOpenTopFlyoutProperty);
            set => SetValue(IsOpenTopFlyoutProperty , value);
        }

        public bool IsOpenRightFlyout
        {
            get => (bool)GetValue(IsOpenRightFlyoutProperty);
            set => SetValue(IsOpenRightFlyoutProperty , value);
        }

        public bool IsOpenBottomFlyout
        {
            get => (bool)GetValue(IsOpenBottomFlyoutProperty);
            set => SetValue(IsOpenBottomFlyoutProperty , value);
        }

        public bool IsOpenDialog
        {
            get => (bool)GetValue(IsOpenDialogProperty);
            set => SetValue(IsOpenDialogProperty , value);
        }

        public static readonly DependencyProperty IsOpenDialogProperty = DependencyProperty.Register(
            "IsOpenDialog",
            typeof(bool),
            typeof(ContentHost),
            new PropertyMetadata(BooleanBoxes.FalseBox,OnIsOpenDialogChanged));

        private static void OnIsOpenDialogChanged(DependencyObject d , DependencyPropertyChangedEventArgs e)
        {
            var host = (ContentHost)d;

            if (host.PART_Dialog == null)
            {
                return;
            }

            if (e.NewValue is bool Flag && Flag)
            {
                host.RaiseEvent(new RoutedEventArgs
                {
                    RoutedEvent = DialogOpeningEvent ,
                    Source = host,                    
                });
                //host.PART_Mask.Visibility = Visibility.Visible;
                //host.PART_Dialog.Visibility = Visibility.Visible;
                //host.PART_Dialog.BeginAnimation(OpacityProperty , new DoubleAnimation
                //{
                //    From = .3d,
                //    To = 1d,
                //    Duration = new Duration(TimeSpan.FromMilliseconds(300))
                //});
            }
            else
            {
                host.RaiseEvent(new RoutedEventArgs
                {
                    RoutedEvent = DialogClosingEvent ,
                    Source = host ,
                });
                //host.PART_Dialog.BeginAnimation(OpacityProperty , new DoubleAnimation
                //{
                //    From = 1d ,
                //    To = 0d ,
                //    Duration = new Duration(TimeSpan.FromMilliseconds(300))
                //});
                //host.PART_Mask.Visibility = Visibility.Collapsed;
                //host.PART_Dialog.Visibility = Visibility.Collapsed;
            }
        }

        public static readonly DependencyProperty IsOpenBottomFlyoutProperty = DependencyProperty.Register(
            "IsOpenBottomFlyout",
            typeof(bool),
            typeof(ContentHost),
            new PropertyMetadata(BooleanBoxes.FalseBox));

        public static readonly DependencyProperty IsOpenRightFlyoutProperty = DependencyProperty.Register(
            "IsOpenRightFlyout",
            typeof(bool),
            typeof(ContentHost),
            new PropertyMetadata(BooleanBoxes.FalseBox));

        public static readonly DependencyProperty IsOpenTopFlyoutProperty = DependencyProperty.Register(
            "IsOpenTopFlyout",
            typeof(bool),
            typeof(ContentHost),
            new PropertyMetadata(BooleanBoxes.FalseBox));

        public static readonly DependencyProperty IsOpenLeftFlyoutProperty = DependencyProperty.Register(
            "IsOpenLeftFlyout",
            typeof(bool),
            typeof(ContentHost), 
            new PropertyMetadata(BooleanBoxes.FalseBox));


        public static readonly DependencyProperty DialogStringFormatProperty = DependencyProperty.Register(
            "DialogStringFormat",
            typeof(string),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty DialogTemplateSelectorProperty = DependencyProperty.Register(
            "DialogTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty DialogTemplateProperty = DependencyProperty.Register(
            "DialogTemplate",
            typeof(DataTemplate),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty DialogProperty = DependencyProperty.Register(
            "Dialog",
            typeof(object),
            typeof(ContentHost),
            new PropertyMetadata(null));
        public static readonly DependencyProperty BottomFlyoutStringFormatProperty = DependencyProperty.Register(
            "BottomFlyoutStringFormat",
            typeof(string),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty BottomFlyoutTemplateSelectorProperty = DependencyProperty.Register(
            "BottomFlyoutTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty BottomFlyoutTemplateProperty = DependencyProperty.Register(
            "BottomFlyoutTemplate",
            typeof(DataTemplate),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty BottomFlyoutProperty = DependencyProperty.Register(
            "BottomFlyout",
            typeof(object),
            typeof(ContentHost),
            new PropertyMetadata(null));
        public static readonly DependencyProperty TopFlyoutStringFormatProperty = DependencyProperty.Register(
            "TopFlyoutStringFormat",
            typeof(string),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty TopFlyoutTemplateSelectorProperty = DependencyProperty.Register(
            "TopFlyoutTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty TopFlyoutTemplateProperty = DependencyProperty.Register(
            "TopFlyoutTemplate",
            typeof(DataTemplate),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty TopFlyoutProperty = DependencyProperty.Register(
            "TopFlyout",
            typeof(object),
            typeof(ContentHost),
            new PropertyMetadata(null));
        public static readonly DependencyProperty RightFlyoutStringFormatProperty = DependencyProperty.Register(
            "RightFlyoutStringFormat",
            typeof(string),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty RightFlyoutTemplateSelectorProperty = DependencyProperty.Register(
            "RightFlyoutTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty RightFlyoutTemplateProperty = DependencyProperty.Register(
            "RightFlyoutTemplate",
            typeof(DataTemplate),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty RightFlyoutProperty = DependencyProperty.Register(
            "RightFlyout",
            typeof(object),
            typeof(ContentHost),
            new PropertyMetadata(null));
        public static readonly DependencyProperty LeftFlyoutStringFormatProperty = DependencyProperty.Register(
            "LeftFlyoutStringFormat",
            typeof(string),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty LeftFlyoutTemplateSelectorProperty = DependencyProperty.Register(
            "LeftFlyoutTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty LeftFlyoutTemplateProperty = DependencyProperty.Register(
            "LeftFlyoutTemplate",
            typeof(DataTemplate),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty LeftFlyoutProperty = DependencyProperty.Register(
            "LeftFlyout",
            typeof(object),
            typeof(ContentHost),
            new PropertyMetadata(null));
        public static readonly DependencyProperty ContentStringFormatProperty = DependencyProperty.Register(
            "ContentStringFormat",
            typeof(string),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty ContentTemplateSelectorProperty = DependencyProperty.Register(
            "ContentTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty ContentTemplateProperty = DependencyProperty.Register(
            "ContentTemplate",
            typeof(DataTemplate),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public static readonly DependencyProperty ContentProperty = DependencyProperty.Register(
            "Content",
            typeof(object),
            typeof(ContentHost),
            new PropertyMetadata(null));

        public event RoutedEventHandler LeftFlyoutOpening
        {
            add => AddHandler(LeftFlyoutOpeningEvent,value);
            remove => RemoveHandler(LeftFlyoutOpeningEvent,value);
        }

        public event RoutedEventHandler LeftFlyoutClosing
        {
            add => AddHandler(LeftFlyoutClosingEvent,value);
            remove => RemoveHandler(LeftFlyoutClosingEvent,value);
        }

        public event RoutedEventHandler TopFlyoutOpening
        {
            add => AddHandler(TopFlyoutOpeningEvent,value);
            remove => RemoveHandler(TopFlyoutOpeningEvent,value);
        }

        public event RoutedEventHandler TopFlyoutClosing
        {
            add => AddHandler(TopFlyoutClosingEvent,value);
            remove => RemoveHandler(TopFlyoutClosingEvent,value);
        }

        public event RoutedEventHandler RightFlyoutOpening
        {
            add => AddHandler(RightFlyoutOpeningEvent,value);
            remove => RemoveHandler(RightFlyoutOpeningEvent,value);
        }

        public event RoutedEventHandler RightFlyoutClosing
        {
            add => AddHandler(RightFlyoutClosingEvent,value);
            remove => RemoveHandler(RightFlyoutClosingEvent,value);
        }
        public event RoutedEventHandler BottomFlyoutOpening
        {
            add => AddHandler(BottomFlyoutOpeningEvent,value);
            remove => RemoveHandler(BottomFlyoutOpeningEvent,value);
        }

        public event RoutedEventHandler BottomFlyoutClosing
        {
            add => AddHandler(BottomFlyoutClosingEvent,value);
            remove => RemoveHandler(BottomFlyoutClosingEvent,value);
        }
        public event RoutedEventHandler DialogOpening
        {
            add => AddHandler(DialogOpeningEvent,value);
            remove => RemoveHandler(DialogOpeningEvent,value);
        }

        public event RoutedEventHandler DialogClosing
        {
            add => AddHandler(DialogClosingEvent,value);
            remove => RemoveHandler(DialogClosingEvent,value);
        }

        public static readonly RoutedEvent DialogOpeningEvent = EventManager.RegisterRoutedEvent(
            "DialogOpening",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(ContentHost));

        public static readonly RoutedEvent DialogClosingEvent = EventManager.RegisterRoutedEvent(
            "DialogClosing",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(ContentHost));

        public static readonly RoutedEvent BottomFlyoutOpeningEvent = EventManager.RegisterRoutedEvent(
            "BottomFlyoutOpening",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(ContentHost));

        public static readonly RoutedEvent BottomFlyoutClosingEvent = EventManager.RegisterRoutedEvent(
            "BottomFlyoutClosing",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(ContentHost));

        public static readonly RoutedEvent RightFlyoutOpeningEvent = EventManager.RegisterRoutedEvent(
            "RightFlyoutOpening",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(ContentHost));

        public static readonly RoutedEvent RightFlyoutClosingEvent = EventManager.RegisterRoutedEvent(
            "RightFlyoutClosing",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(ContentHost));
        public static readonly RoutedEvent TopFlyoutOpeningEvent = EventManager.RegisterRoutedEvent(
            "TopFlyoutOpening",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(ContentHost));

        public static readonly RoutedEvent TopFlyoutClosingEvent = EventManager.RegisterRoutedEvent(
            "TopFlyoutClosing",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(ContentHost));

        public static readonly RoutedEvent LeftFlyoutOpeningEvent = EventManager.RegisterRoutedEvent(
            "LeftFlyoutOpening",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(ContentHost));

        public static readonly RoutedEvent LeftFlyoutClosingEvent = EventManager.RegisterRoutedEvent(
            "LeftFlyoutClosing",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(ContentHost));
    }
}
