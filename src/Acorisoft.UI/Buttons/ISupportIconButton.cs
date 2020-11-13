using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Acorisoft.Buttons
{
    public interface ISupportIconButton
    {
        Geometry Icon { get; set; }
        double IconWidth { get; set; }
        double IconHeight { get; set; }
        Thickness IconPadding { get; set; }
    }
}
