using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace Acorisoft.Panels
{
    /// <summary>
    /// <see cref="AnchorPanel"/> 锚点面板不是面板，只是提供了一个特殊的封装。
    /// </summary>
    [DefaultProperty("Content")]
    [ContentProperty("Content")]
    public class AnchorPanel : Control, IAddChild
    {
        public static readonly DependencyProperty ShowMoreButtonProperty;
        public static readonly DependencyProperty MoreButtonCommandProperty;
        public static readonly DependencyProperty MoreButtonCommandParameterProperty;
        public static readonly DependencyProperty MoreButtonCommandTargetProperty;
        public static readonly DependencyProperty ShowClearButtonProperty;
        public static readonly DependencyProperty ClearButtonCommandProperty;
        public static readonly DependencyProperty ClearButtonCommandParameterProperty;
        public static readonly DependencyProperty ClearButtonCommandTargetProperty;
        public static readonly DependencyProperty ShowAddButtonProperty;
        public static readonly DependencyProperty AddButtonCommandProperty;
        public static readonly DependencyProperty AddButtonCommandParameterProperty;
        public static readonly DependencyProperty AddButtonCommandTargetProperty;
        public static readonly DependencyProperty ShowEditButtonProperty;
        public static readonly DependencyProperty EditButtonCommandProperty;
        public static readonly DependencyProperty EditButtonCommandParameterProperty;
        public static readonly DependencyProperty EditButtonCommandTargetProperty;
        public static readonly DependencyProperty CornerRadiusProperty;
        public static readonly DependencyProperty TitleProperty;
        public static readonly DependencyProperty TitleTemplateProperty;
        public static readonly DependencyProperty TitleTemplateSelectorProperty;
        public static readonly DependencyProperty TitleStringFormatProperty;
        public static readonly DependencyProperty SubtitleProperty;
        public static readonly DependencyProperty SubtitleTemplateProperty;
        public static readonly DependencyProperty SubtitleTemplateSelectorProperty;
        public static readonly DependencyProperty SubtitleStringFormatProperty;
        public static readonly DependencyProperty ContentProperty;
        public static readonly DependencyProperty ContentTemplateProperty;
        public static readonly DependencyProperty ContentTemplateSelectorProperty;
        public static readonly DependencyProperty ContentStringFormatProperty;

        static AnchorPanel()
        {
            ShowAddButtonProperty = DependencyProperty.Register("ShowAddButton", typeof(bool), typeof(AnchorPanel), new FrameworkPropertyMetadata(BooleanBoxes.FalseBox));
            AddButtonCommandProperty = DependencyProperty.Register("AddButtonCommand", typeof(ICommand), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnAddButtonCommandChanged));
            AddButtonCommandParameterProperty = DependencyProperty.Register("AddButtonCommandParameter", typeof(object), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnAddButtonCommandParameterChanged));
            AddButtonCommandTargetProperty = DependencyProperty.Register("AddButtonCommandTarget", typeof(IInputElement), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnAddButtonCommandTargetChanged));
            ShowEditButtonProperty = DependencyProperty.Register("ShowEditButton", typeof(bool), typeof(AnchorPanel), new FrameworkPropertyMetadata(BooleanBoxes.FalseBox));
            EditButtonCommandProperty = DependencyProperty.Register("EditButtonCommand", typeof(ICommand), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnEditButtonCommandChanged));
            EditButtonCommandParameterProperty = DependencyProperty.Register("EditButtonCommandParameter", typeof(object), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnEditButtonCommandParameterChanged));
            EditButtonCommandTargetProperty = DependencyProperty.Register("EditButtonCommandTarget", typeof(IInputElement), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnEditButtonCommandTargetChanged));
            ShowClearButtonProperty = DependencyProperty.Register("ShowClearButton", typeof(bool), typeof(AnchorPanel), new FrameworkPropertyMetadata(BooleanBoxes.FalseBox));
            ClearButtonCommandProperty = DependencyProperty.Register("ClearButtonCommand", typeof(ICommand), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnClearButtonCommandChanged));
            ClearButtonCommandParameterProperty = DependencyProperty.Register("ClearButtonCommandParameter", typeof(object), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnClearButtonCommandParameterChanged));
            ClearButtonCommandTargetProperty = DependencyProperty.Register("ClearButtonCommandTarget", typeof(IInputElement), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnClearButtonCommandTargetChanged));
            ShowMoreButtonProperty = DependencyProperty.Register("ShowMoreButton", typeof(bool), typeof(AnchorPanel), new FrameworkPropertyMetadata(BooleanBoxes.FalseBox));
            MoreButtonCommandProperty = DependencyProperty.Register("MoreButtonCommand", typeof(ICommand), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnMoreButtonCommandChanged));
            MoreButtonCommandParameterProperty = DependencyProperty.Register("MoreButtonCommandParameter", typeof(object), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnMoreButtonCommandParameterChanged));
            MoreButtonCommandTargetProperty = DependencyProperty.Register("MoreButtonCommandTarget", typeof(IInputElement), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnMoreButtonCommandTargetChanged));
            CornerRadiusProperty = DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(AnchorPanel), new FrameworkPropertyMetadata(new CornerRadius(), OnCornerRadiusChanged));
            TitleProperty = DependencyProperty.Register("Title", typeof(object), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnTitleChanged));
            TitleTemplateProperty = DependencyProperty.Register("TitleTemplate", typeof(DataTemplate), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnTitleTemplateChanged));
            TitleTemplateSelectorProperty = DependencyProperty.Register("TitleTemplateSelector", typeof(DataTemplateSelector), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnTitleTemplateSelectorChanged));
            TitleStringFormatProperty = DependencyProperty.Register("TitleStringFormat", typeof(string), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnTitleStringFormatChanged));
            SubtitleProperty = DependencyProperty.Register("Subtitle", typeof(object), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnSubtitleChanged));
            SubtitleTemplateProperty = DependencyProperty.Register("SubtitleTemplate", typeof(DataTemplate), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnSubtitleTemplateChanged));
            SubtitleTemplateSelectorProperty = DependencyProperty.Register("SubtitleTemplateSelector", typeof(DataTemplateSelector), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnSubtitleTemplateSelectorChanged));
            SubtitleStringFormatProperty = DependencyProperty.Register("SubtitleStringFormat", typeof(string), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnSubtitleStringFormatChanged));
            ContentProperty = DependencyProperty.Register("Content", typeof(object), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnContentChanged));
            ContentTemplateProperty = DependencyProperty.Register("ContentTemplate", typeof(DataTemplate), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnContentTemplateChanged));
            ContentTemplateSelectorProperty = DependencyProperty.Register("ContentTemplateSelector", typeof(DataTemplateSelector), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnContentTemplateSelectorChanged));
            ContentStringFormatProperty = DependencyProperty.Register("ContentStringFormat", typeof(string), typeof(AnchorPanel), new FrameworkPropertyMetadata(null, OnContentStringFormatChanged));
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AnchorPanel), new FrameworkPropertyMetadata(typeof(AnchorPanel)));
        }

        private static void OnMoreButtonCommandTargetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }


        private static void OnMoreButtonCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void OnMoreButtonCommandParameterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void OnClearButtonCommandTargetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }


        private static void OnClearButtonCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void OnClearButtonCommandParameterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void OnAddButtonCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void OnAddButtonCommandTargetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void OnAddButtonCommandParameterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void OnEditButtonCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void OnEditButtonCommandTargetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void OnEditButtonCommandParameterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        public bool ShowMoreButton
        {
            get => (bool)GetValue(ShowMoreButtonProperty);
            set => SetValue(ShowMoreButtonProperty, value);
        }

        public ICommand MoreButtonCommand
        {
            get => (ICommand)GetValue(MoreButtonCommandProperty);
            set => SetValue(MoreButtonCommandProperty, value);
        }

        public object MoreButtonCommandParameter
        {
            get => (object)GetValue(MoreButtonCommandParameterProperty);
            set => SetValue(MoreButtonCommandParameterProperty, value);
        }

        public IInputElement MoreButtonCommandTarget
        {
            get => (IInputElement)GetValue(MoreButtonCommandTargetProperty);
            set => SetValue(MoreButtonCommandTargetProperty, value);
        }

        public bool ShowEditButton
        {
            get => (bool)GetValue(ShowEditButtonProperty);
            set => SetValue(ShowEditButtonProperty, value);
        }

        public ICommand EditButtonCommand
        {
            get => (ICommand)GetValue(EditButtonCommandProperty);
            set => SetValue(EditButtonCommandProperty, value);
        }

        public object EditButtonCommandParameter
        {
            get => (object)GetValue(EditButtonCommandParameterProperty);
            set => SetValue(EditButtonCommandParameterProperty, value);
        }

        public IInputElement EditButtonCommandTarget
        {
            get => (IInputElement)GetValue(EditButtonCommandTargetProperty);
            set => SetValue(EditButtonCommandTargetProperty, value);
        }

        public bool ShowClearButton
        {
            get => (bool)GetValue(ShowClearButtonProperty);
            set => SetValue(ShowClearButtonProperty, value);
        }

        public ICommand ClearButtonCommand
        {
            get => (ICommand)GetValue(ClearButtonCommandProperty);
            set => SetValue(ClearButtonCommandProperty, value);
        }

        public object ClearButtonCommandParameter
        {
            get => (object)GetValue(ClearButtonCommandParameterProperty);
            set => SetValue(ClearButtonCommandParameterProperty, value);
        }

        public IInputElement ClearButtonCommandTarget
        {
            get => (IInputElement)GetValue(ClearButtonCommandTargetProperty);
            set => SetValue(ClearButtonCommandTargetProperty, value);
        }

        public bool ShowAddButton
        {
            get => (bool)GetValue(ShowAddButtonProperty);
            set => SetValue(ShowAddButtonProperty, value);
        }

        public ICommand AddButtonCommand
        {
            get => (ICommand)GetValue(AddButtonCommandProperty);
            set => SetValue(AddButtonCommandProperty, value);
        }

        public object AddButtonCommandParameter
        {
            get => (object)GetValue(AddButtonCommandParameterProperty);
            set => SetValue(AddButtonCommandParameterProperty, value);
        }

        public IInputElement AddButtonCommandTarget
        {
            get => (IInputElement)GetValue(AddButtonCommandTargetProperty);
            set => SetValue(AddButtonCommandTargetProperty, value);
        }

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
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

        private static void OnCornerRadiusChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }


        private static void OnTitleStringFormatChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void OnTitleTemplateSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void OnTitleTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }


        private static void OnTitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void OnContentStringFormatChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void OnContentTemplateSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void OnContentTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }


        private static void OnContentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void OnSubtitleStringFormatChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void OnSubtitleTemplateSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void OnSubtitleTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }


        private static void OnSubtitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
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
    }
}
