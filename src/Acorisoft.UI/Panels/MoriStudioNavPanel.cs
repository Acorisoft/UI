using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Acorisoft.UI.Panels
{
    public class MoriStudioNavBar : Control
    {
        static MoriStudioNavBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MoriStudioNavBar) , new FrameworkPropertyMetadata(typeof(MoriStudioNavBar)));
        }


        public object Logo
        {
            get => (object)GetValue(LogoProperty);
            set => SetValue(LogoProperty , value);
        }

        public DataTemplate LogoTemplate
        {
            get => (DataTemplate)GetValue(LogoTemplateProperty);
            set => SetValue(LogoTemplateProperty , value);
        }

        public DataTemplateSelector LogoTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(LogoTemplateSelectorProperty);
            set => SetValue(LogoTemplateSelectorProperty , value);
        }


        public string LogoStringFormat
        {
            get => (string)GetValue(LogoStringFormatProperty);
            set => SetValue(LogoStringFormatProperty , value);
        }

        public object NavigationBar
        {
            get => (object)GetValue(NavigationBarProperty);
            set => SetValue(NavigationBarProperty , value);
        }

        public DataTemplate NavigationBarTemplate
        {
            get => (DataTemplate)GetValue(NavigationBarTemplateProperty);
            set => SetValue(NavigationBarTemplateProperty , value);
        }

        public DataTemplateSelector NavigationBarTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(NavigationBarTemplateSelectorProperty);
            set => SetValue(NavigationBarTemplateSelectorProperty , value);
        }


        public string NavigationBarStringFormat
        {
            get => (string)GetValue(NavigationBarStringFormatProperty);
            set => SetValue(NavigationBarStringFormatProperty , value);
        }

        public object Toolbar
        {
            get => (object)GetValue(ToolbarProperty);
            set => SetValue(ToolbarProperty , value);
        }

        public DataTemplate ToolbarTemplate
        {
            get => (DataTemplate)GetValue(ToolbarTemplateProperty);
            set => SetValue(ToolbarTemplateProperty , value);
        }

        public DataTemplateSelector ToolbarTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(ToolbarTemplateSelectorProperty);
            set => SetValue(ToolbarTemplateSelectorProperty , value);
        }


        public string ToolbarStringFormat
        {
            get => (string)GetValue(ToolbarStringFormatProperty);
            set => SetValue(ToolbarStringFormatProperty , value);
        }

        public static readonly DependencyProperty ToolbarStringFormatProperty = DependencyProperty.Register(
            "ToolbarStringFormat",
            typeof(string),
            typeof(MoriStudioNavBar),
            new PropertyMetadata(null));

        public static readonly DependencyProperty ToolbarTemplateSelectorProperty = DependencyProperty.Register(
            "ToolbarTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(MoriStudioNavBar),
            new PropertyMetadata(null));

        public static readonly DependencyProperty ToolbarTemplateProperty = DependencyProperty.Register(
            "ToolbarTemplate",
            typeof(DataTemplate),
            typeof(MoriStudioNavBar),
            new PropertyMetadata(null));

        public static readonly DependencyProperty ToolbarProperty = DependencyProperty.Register(
            "Toolbar",
            typeof(object),
            typeof(MoriStudioNavBar),
            new PropertyMetadata(null));
        public static readonly DependencyProperty NavigationBarStringFormatProperty = DependencyProperty.Register(
            "NavigationBarStringFormat",
            typeof(string),
            typeof(MoriStudioNavBar),
            new PropertyMetadata(null));

        public static readonly DependencyProperty NavigationBarTemplateSelectorProperty = DependencyProperty.Register(
            "NavigationBarTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(MoriStudioNavBar),
            new PropertyMetadata(null));

        public static readonly DependencyProperty NavigationBarTemplateProperty = DependencyProperty.Register(
            "NavigationBarTemplate",
            typeof(DataTemplate),
            typeof(MoriStudioNavBar),
            new PropertyMetadata(null));

        public static readonly DependencyProperty NavigationBarProperty = DependencyProperty.Register(
            "NavigationBar",
            typeof(object),
            typeof(MoriStudioNavBar),
            new PropertyMetadata(null));
        public static readonly DependencyProperty LogoStringFormatProperty = DependencyProperty.Register(
            "LogoStringFormat",
            typeof(string),
            typeof(MoriStudioNavBar),
            new PropertyMetadata(null));

        public static readonly DependencyProperty LogoTemplateSelectorProperty = DependencyProperty.Register(
            "LogoTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(MoriStudioNavBar),
            new PropertyMetadata(null));

        public static readonly DependencyProperty LogoTemplateProperty = DependencyProperty.Register(
            "LogoTemplate",
            typeof(DataTemplate),
            typeof(MoriStudioNavBar),
            new PropertyMetadata(null));

        public static readonly DependencyProperty LogoProperty = DependencyProperty.Register(
            "Logo",
            typeof(object),
            typeof(MoriStudioNavBar),
            new PropertyMetadata(null));
    }
}
