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

namespace Acorisoft.UI.Controls
{
    /// <summary>
    /// 透明组合框
    /// </summary>
    public class TransparentComboBox : ComboBox
    {
        static TransparentComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TransparentComboBox) , 
                new FrameworkPropertyMetadata(typeof(TransparentComboBox)));
        }


        public Brush PopupForeground
        {
            get => (Brush)GetValue(PopupForegroundProperty);
            set => SetValue(PopupForegroundProperty , value);
        }

        public static readonly DependencyProperty PopupForegroundProperty = DependencyProperty.Register(
            "PopupForeground",
            typeof(Brush),
            typeof(TransparentComboBox), 
            new PropertyMetadata(null));

    }
}
