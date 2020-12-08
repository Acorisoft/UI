using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Acorisoft.UI.Controls
{
    public enum BulletMode
    {
        Fixed,
        Auto
    }

    public class BulletControl : ContentControl
    {
        static BulletControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BulletControl) , new FrameworkPropertyMetadata(typeof(BulletControl)));
        }

        public double BulletSize
        {
            get => (double)GetValue(BulletSizeProperty);
            set => SetValue(BulletSizeProperty , value);
        }

        public BulletMode Mode
        {
            get => (BulletMode)GetValue(ModeProperty);
            set => SetValue(ModeProperty , value);
        }

        public object Bullet
        {
            get => (object)GetValue(BulletProperty);
            set => SetValue(BulletProperty , value);
        }

        public DataTemplate BulletTemplate
        {
            get => (DataTemplate)GetValue(BulletTemplateProperty);
            set => SetValue(BulletTemplateProperty , value);
        }

        public DataTemplateSelector BulletTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(BulletTemplateSelectorProperty);
            set => SetValue(BulletTemplateSelectorProperty , value);
        }


        public string BulletStringFormat
        {
            get => (string)GetValue(BulletStringFormatProperty);
            set => SetValue(BulletStringFormatProperty , value);
        }

        public Thickness BulletPadding
        {
            get => (Thickness)GetValue(BulletPaddingProperty);
            set => SetValue(BulletPaddingProperty , value);
        }


        public HorizontalAlignment HorizontalBulletAlignment
        {
            get => (HorizontalAlignment)GetValue(HorizontalBulletAlignmentProperty);
            set => SetValue(HorizontalBulletAlignmentProperty , value);
        }


        public VerticalAlignment VerticalBulletAlignment
        {
            get => (VerticalAlignment)GetValue(VerticalBulletAlignmentProperty);
            set => SetValue(VerticalBulletAlignmentProperty , value);
        }

        public static readonly DependencyProperty HorizontalBulletAlignmentProperty = DependencyProperty.Register(
            "HorizontalBulletAlignment",
            typeof(HorizontalAlignment),
            typeof(BulletControl),
            new PropertyMetadata(null));

        public static readonly DependencyProperty VerticalBulletAlignmentProperty = DependencyProperty.Register(
            "VerticalBulletAlignment",
            typeof(VerticalAlignment),
            typeof(BulletControl),
            new PropertyMetadata(null));

        public static readonly DependencyProperty BulletPaddingProperty = DependencyProperty.Register(
            "BulletPadding",
            typeof(Thickness),
            typeof(BulletControl), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty BulletStringFormatProperty = DependencyProperty.Register(
            "BulletStringFormat",
            typeof(string),
            typeof(BulletControl),
            new PropertyMetadata(null));

        public static readonly DependencyProperty BulletTemplateSelectorProperty = DependencyProperty.Register(
            "BulletTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(BulletControl),
            new PropertyMetadata(null));

        public static readonly DependencyProperty BulletTemplateProperty = DependencyProperty.Register(
            "BulletTemplate",
            typeof(DataTemplate),
            typeof(BulletControl),
            new PropertyMetadata(null));

        public static readonly DependencyProperty BulletProperty = DependencyProperty.Register(
            "Bullet",
            typeof(object),
            typeof(BulletControl),
            new PropertyMetadata(null));
        public static readonly DependencyProperty ModeProperty = DependencyProperty.Register(
            "Mode",
            typeof(BulletMode),
            typeof(BulletControl), 
            new PropertyMetadata(null));

        public static readonly DependencyProperty BulletSizeProperty = DependencyProperty.Register(
            "BulletSize",
            typeof(double),
            typeof(BulletControl), 
            new PropertyMetadata(null));

    }
}
