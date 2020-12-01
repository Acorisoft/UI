using System.Windows;
using System.Windows.Controls.Primitives;

namespace Acorisoft.UI.Buttons
{
    public class WindowCloseButton : ModeButton
    {
        static WindowCloseButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowCloseButton) , new FrameworkPropertyMetadata(typeof(WindowCloseButton)));
        }
    }
}
