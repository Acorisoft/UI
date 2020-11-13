using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Acorisoft.Buttons
{
    public abstract class CornerRadiusButton : Button
    {


        /// <summary>
        /// 获取或设置 <see cref="CTAButton"/> 按钮的圆角半径。
        /// </summary>
        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(
            "CornerRadius",
            typeof(CornerRadius),
            typeof(CornerRadiusButton),
            new PropertyMetadata(new CornerRadius(8)));

    }
}
