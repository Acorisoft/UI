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
    public class ImageButton : ModeButton
    {
        static ImageButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton) ,
                new FrameworkPropertyMetadata(typeof(ImageButton)));
        }


        public ImageSource Image
        {
            get => (ImageSource)GetValue(ImageProperty);
            set => SetValue(ImageProperty , value);
        }

        public static readonly DependencyProperty ImageProperty = DependencyProperty.Register(
            "Image",
            typeof(ImageSource),
            typeof(ImageButton), 
            new PropertyMetadata(null));

    }
}
