using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Acorisoft.Buttons
{
    public class IconTextButton : IconButton
    {
        static IconTextButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IconTextButton) , new FrameworkPropertyMetadata(typeof(IconTextButton)));
        }

        public Dock Placement
        {
            get => (Dock)GetValue(PlacementProperty);
            set => SetValue(PlacementProperty , value);
        }

        public static readonly DependencyProperty PlacementProperty = DependencyProperty.Register(
            "Placement",
            typeof(Dock),
            typeof(IconTextButton), 
            new PropertyMetadata(null));
    }
}
