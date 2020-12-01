using System.Windows;

namespace Acorisoft.UI.Buttons
{
    public class WindowMinButton : ModeButton
    {
        static WindowMinButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowMinButton) , new FrameworkPropertyMetadata(typeof(WindowMinButton)));
        }
    }
}
