using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acorisoft.UI.Views
{
    /// <summary>
    /// <see cref="IMasterDetailView"/> 表示主从视图布局面板。
    /// </summary>
    public interface IMasterDetailView
    {
        /// <summary>
        /// 获取或设置主视图的宽度。
        /// </summary>
        double MasterWidth { get; set; }

        /// <summary>
        /// 获取或设置主视图内容。
        /// </summary>
        object Master { get; set; }

        /// <summary>
        /// 获取或设置从视图内容。
        /// </summary>
        object Detail { get; set; }

        /// <summary>
        /// 获取或设置主从视图的布局方向。
        /// </summary>
        HorizontalDirection Direction { get; set; }
    }
}
