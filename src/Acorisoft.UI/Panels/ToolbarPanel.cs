using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Acorisoft.Panels
{
    /// <summary>
    /// <see cref="ToolbarPanel"/> 工具面板。
    /// </summary>
    [DefaultProperty("Content")]
    [ContentProperty("Content")]
    public class ToolbarPanel : Control, IAddChild
    {
        private static readonly CornerRadius DefaultCornerRadiusValue = new CornerRadius(8);

        static ToolbarPanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ToolbarPanel), new FrameworkPropertyMetadata(typeof(ToolbarPanel)));
        }

        public void AddChild(object value)
        {
            if (Content == null)
            {
                if (value == null)
                {
                    ClearValue(ContentProperty);
                }
                else
                {
                    SetValue(ContentProperty, value);
                }
            }
        }

        public void AddText(string text)
        {
            AddChild(text);
        }


        public object Toolbar
        {
            get => (object)GetValue(ToolbarProperty);
            set => SetValue(ToolbarProperty, value);
        }

        public DataTemplate ToolbarTemplate
        {
            get => (DataTemplate)GetValue(ToolbarTemplateProperty);
            set => SetValue(ToolbarTemplateProperty, value);
        }

        public DataTemplateSelector ToolbarTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(ToolbarTemplateSelectorProperty);
            set => SetValue(ToolbarTemplateSelectorProperty, value);
        }

        public object Title
        {
            get => (object)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public DataTemplate TitleTemplate
        {
            get => (DataTemplate)GetValue(TitleTemplateProperty);
            set => SetValue(TitleTemplateProperty, value);
        }

        public DataTemplateSelector TitleTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(TitleTemplateSelectorProperty);
            set => SetValue(TitleTemplateSelectorProperty, value);
        }


        public string TitleStringFormat
        {
            get => (string)GetValue(TitleStringFormatProperty);
            set => SetValue(TitleStringFormatProperty, value);
        }

        public object Content
        {
            get => (object)GetValue(ContentProperty);
            set => SetValue(ContentProperty, value);
        }

        public DataTemplate ContentTemplate
        {
            get => (DataTemplate)GetValue(ContentTemplateProperty);
            set => SetValue(ContentTemplateProperty, value);
        }

        public DataTemplateSelector ContentTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(ContentTemplateSelectorProperty);
            set => SetValue(ContentTemplateSelectorProperty, value);
        }


        public string ContentStringFormat
        {
            get => (string)GetValue(ContentStringFormatProperty);
            set => SetValue(ContentStringFormatProperty, value);
        }

        public object Subtitle
        {
            get => (object)GetValue(SubtitleProperty);
            set => SetValue(SubtitleProperty, value);
        }

        public DataTemplate SubtitleTemplate
        {
            get => (DataTemplate)GetValue(SubtitleTemplateProperty);
            set => SetValue(SubtitleTemplateProperty, value);
        }

        public DataTemplateSelector SubtitleTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(SubtitleTemplateSelectorProperty);
            set => SetValue(SubtitleTemplateSelectorProperty, value);
        }


        public string SubtitleStringFormat
        {
            get => (string)GetValue(SubtitleStringFormatProperty);
            set => SetValue(SubtitleStringFormatProperty, value);
        }

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }


        public bool EnableToolbarAutoHidden
        {
            get => (bool)GetValue(EnableToolbarAutoHiddenProperty);
            set => SetValue(EnableToolbarAutoHiddenProperty , value);
        }

        public static readonly DependencyProperty EnableToolbarAutoHiddenProperty = DependencyProperty.Register(
            "EnableToolbarAutoHidden",
            typeof(bool),
            typeof(ToolbarPanel), 
            new PropertyMetadata(null));


        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(
            "CornerRadius",
            typeof(CornerRadius),
            typeof(ToolbarPanel), 
            new PropertyMetadata(DefaultCornerRadiusValue));


        public static readonly DependencyProperty SubtitleStringFormatProperty = DependencyProperty.Register(
            "SubtitleStringFormat",
            typeof(string),
            typeof(ToolbarPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty SubtitleTemplateSelectorProperty = DependencyProperty.Register(
            "SubtitleTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(ToolbarPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty SubtitleTemplateProperty = DependencyProperty.Register(
            "SubtitleTemplate",
            typeof(DataTemplate),
            typeof(ToolbarPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty SubtitleProperty = DependencyProperty.Register(
            "Subtitle",
            typeof(object),
            typeof(ToolbarPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty ContentStringFormatProperty = DependencyProperty.Register(
            "ContentStringFormat",
            typeof(string),
            typeof(ToolbarPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty ContentTemplateSelectorProperty = DependencyProperty.Register(
            "ContentTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(ToolbarPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty ContentTemplateProperty = DependencyProperty.Register(
            "ContentTemplate",
            typeof(DataTemplate),
            typeof(ToolbarPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty ContentProperty = DependencyProperty.Register(
            "Content",
            typeof(object),
            typeof(ToolbarPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty TitleStringFormatProperty = DependencyProperty.Register(
            "TitleStringFormat",
            typeof(string),
            typeof(ToolbarPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty TitleTemplateSelectorProperty = DependencyProperty.Register(
            "TitleTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(ToolbarPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty TitleTemplateProperty = DependencyProperty.Register(
            "TitleTemplate",
            typeof(DataTemplate),
            typeof(ToolbarPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
            "Title",
            typeof(object),
            typeof(ToolbarPanel),
            new PropertyMetadata(null));

        public string ToolbarStringFormat
        {
            get => (string)GetValue(ToolbarStringFormatProperty);
            set => SetValue(ToolbarStringFormatProperty, value);
        }

        public static readonly DependencyProperty ToolbarStringFormatProperty = DependencyProperty.Register(
            "ToolbarStringFormat",
            typeof(string),
            typeof(ToolbarPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty ToolbarTemplateSelectorProperty = DependencyProperty.Register(
            "ToolbarTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(ToolbarPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty ToolbarTemplateProperty = DependencyProperty.Register(
            "ToolbarTemplate",
            typeof(DataTemplate),
            typeof(ToolbarPanel),
            new PropertyMetadata(null));

        public static readonly DependencyProperty ToolbarProperty = DependencyProperty.Register(
            "Toolbar",
            typeof(object),
            typeof(ToolbarPanel),
            new PropertyMetadata(null));
    }
}
