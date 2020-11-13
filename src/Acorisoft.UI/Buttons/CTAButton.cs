using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Acorisoft.Buttons
{
    public class CTAButton : CornerRadiusButton
    {
        static CTAButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CTAButton), new FrameworkPropertyMetadata(typeof(CTAButton)));
        }

    }
}
