using System.Windows;

namespace Acorisoft.UI.Buttons
{
    public class WindowMaxButton : MoriButtonBase
    {
        static WindowMaxButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowMaxButton) , new FrameworkPropertyMetadata(typeof(WindowMaxButton)));
        }


        public WindowState WindowState
        {
            get => (WindowState)GetValue(WindowStateProperty);
            set => SetValue(WindowStateProperty , value);
        }

        public static readonly DependencyProperty WindowStateProperty = DependencyProperty.Register(
            "WindowState",
            typeof(WindowState),
            typeof(WindowMaxButton), 
            new PropertyMetadata((object)WindowState.Normal));

    }
}
