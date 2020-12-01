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

namespace Acorisoft.UI.Panels
{
    public enum Alert
    {
        Custom,
        Info,
        Success,
        Warning,
        Danger
    }

    /// <summary>
    /// 警告按钮
    /// </summary>
    public class AlertPanel : ContentControl
    {
        static AlertPanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AlertPanel) ,
                new FrameworkPropertyMetadata(typeof(AlertPanel)));
        }


        public Alert Alert
        {
            get => (Alert)GetValue(AlertProperty);
            set => SetValue(AlertProperty , value);
        }

        public static readonly DependencyProperty AlertProperty = DependencyProperty.Register(
            "Alert",
            typeof(Alert),
            typeof(AlertPanel), 
            new PropertyMetadata(null));

    }
}
