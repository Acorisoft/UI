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
    /// <see cref="https://dribbble.com/shots/4795714-Welcome-Dialog"/>
    /// </summary>
    public class BannerMessageDialogControl : ContentControl
    {
        static BannerMessageDialogControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BannerMessageDialogControl) , new FrameworkPropertyMetadata(typeof(BannerMessageDialogControl)));
        }


        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty , value);
        }


        public ImageSource Banner
        {
            get => (ImageSource)GetValue(BannerProperty);
            set => SetValue(BannerProperty , value);
        }

        public object Title
        {
            get => (object)GetValue(TitleProperty);
            set => SetValue(TitleProperty , value);
        }

        public DataTemplate TitleTemplate
        {
            get => (DataTemplate)GetValue(TitleTemplateProperty);
            set => SetValue(TitleTemplateProperty , value);
        }

        public DataTemplateSelector TitleTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(TitleTemplateSelectorProperty);
            set => SetValue(TitleTemplateSelectorProperty , value);
        }


        public string TitleStringFormat
        {
            get => (string)GetValue(TitleStringFormatProperty);
            set => SetValue(TitleStringFormatProperty , value);
        }      


        public object DefaultButtonContent
        {
            get => (object)GetValue(DefaultButtonContentProperty);
            set => SetValue(DefaultButtonContentProperty , value);
        }

        public DataTemplate DefaultButtonContentTemplate
        {
            get => (DataTemplate)GetValue(DefaultButtonContentTemplateProperty);
            set => SetValue(DefaultButtonContentTemplateProperty , value);
        }

        public DataTemplateSelector DefaultButtonContentTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(DefaultButtonContentTemplateSelectorProperty);
            set => SetValue(DefaultButtonContentTemplateSelectorProperty , value);
        }


        public string DefaultButtonContentStringFormat
        {
            get => (string)GetValue(DefaultButtonContentStringFormatProperty);
            set => SetValue(DefaultButtonContentStringFormatProperty , value);
        }


        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty , value);
        }

        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register(
            "Command",
            typeof(ICommand),
            typeof(BannerMessageDialogControl), 
            new PropertyMetadata(null));


        public static readonly DependencyProperty DefaultButtonContentStringFormatProperty = DependencyProperty.Register(
            "DefaultButtonContentStringFormat",
            typeof(string),
            typeof(BannerMessageDialogControl),
            new PropertyMetadata(null));

        public static readonly DependencyProperty DefaultButtonContentTemplateSelectorProperty = DependencyProperty.Register(
            "DefaultButtonContentTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(BannerMessageDialogControl),
            new PropertyMetadata(null));

        public static readonly DependencyProperty DefaultButtonContentTemplateProperty = DependencyProperty.Register(
            "DefaultButtonContentTemplate",
            typeof(DataTemplate),
            typeof(BannerMessageDialogControl),
            new PropertyMetadata(null));

        public static readonly DependencyProperty DefaultButtonContentProperty = DependencyProperty.Register(
            "DefaultButtonContent",
            typeof(object),
            typeof(BannerMessageDialogControl),
            new PropertyMetadata(null));

        public static readonly DependencyProperty TitleStringFormatProperty = DependencyProperty.Register(
            "TitleStringFormat",
            typeof(string),
            typeof(BannerMessageDialogControl),
            new PropertyMetadata(null));

        public static readonly DependencyProperty TitleTemplateSelectorProperty = DependencyProperty.Register(
            "TitleTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(BannerMessageDialogControl),
            new PropertyMetadata(null));

        public static readonly DependencyProperty TitleTemplateProperty = DependencyProperty.Register(
            "TitleTemplate",
            typeof(DataTemplate),
            typeof(BannerMessageDialogControl),
            new PropertyMetadata(null));

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
            "Title",
            typeof(object),
            typeof(BannerMessageDialogControl),
            new PropertyMetadata(null));
        public static readonly DependencyProperty BannerProperty = DependencyProperty.Register(
            "Banner",
            typeof(ImageSource),
            typeof(BannerMessageDialogControl), 
            new PropertyMetadata(null));


        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(
            "CornerRadius",
            typeof(CornerRadius),
            typeof(BannerMessageDialogControl), 
            new PropertyMetadata(null));

    }
}
