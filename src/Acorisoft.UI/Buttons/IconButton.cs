using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Acorisoft.UI.Buttons
{

    public class IconButton : PathButton
    {
        static IconButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IconButton) , new FrameworkPropertyMetadata(typeof(IconButton)));
        }


        public Dock Dock
        {
            get => (Dock)GetValue(DockProperty);
            set => SetValue(DockProperty , value);
        }

        public static readonly DependencyProperty DockProperty = DependencyProperty.Register(
            "Dock",
            typeof(Dock),
            typeof(IconButton), 
            new PropertyMetadata(null));

    }
}
