using System.Windows;

namespace Acorisoft.UI.Buttons
{
    public class WindowMinButton : MoriButtonBase
    {
        static WindowMinButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowMinButton) , new FrameworkPropertyMetadata(typeof(WindowMinButton)));
        }
    }
}
