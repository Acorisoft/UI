using System.Windows;
using System.Windows.Media;

namespace Acorisoft.UI.Buttons
{
    public interface ISupportIcon
    {
        double IconWidth { get; set; }
        double IconHeight { get; set; }
        Thickness IconPadding { get; set; }
        Geometry Icon { get; set; }
    }
}
