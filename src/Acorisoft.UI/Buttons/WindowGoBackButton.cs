using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Acorisoft.UI.Buttons
{
    public class WindowGoBackButton : ModeButton
    {
        static WindowGoBackButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowGoBackButton) , new FrameworkPropertyMetadata(typeof(WindowGoBackButton)));
        }
    }
}
