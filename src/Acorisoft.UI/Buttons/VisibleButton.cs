using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Acorisoft.UI.Buttons
{
    public class VisibleButton : ToggleStateButton
    {
        static VisibleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VisibleButton) , new FrameworkPropertyMetadata(typeof(VisibleButton)));
        }

    }
}
