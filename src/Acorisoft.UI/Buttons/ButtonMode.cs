using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Acorisoft.UI.Buttons
{
    public enum ButtonMode
    {
        /// <summary>
        /// 普通模式，这个模式的按钮使用<see cref="ContentControl.Content"/> 属性作为输入, 
        /// <see cref="MoriButtonBase.HoverBackgroundBrush"/> 作为鼠标放置时的背景。<see cref="MoriButtonBase.PressBackgroundBrush"/> 表示鼠标按下时的背景。
        /// </summary>
        Normal,

        /// <summary>
        /// 透明度模式，这个模式下支持使用透明度
        /// </summary>
        Opacity,

        /// <summary>
        /// Call to Action 模式
        /// </summary>
        CTA,

        /// <summary>
        /// 大纲模式
        /// </summary>
        Outline,

        /// <summary>
        /// Call to Action 大纲模式,这个模式是白色轮廓外观。
        /// </summary>
        CTAOutline,

        /// <summary>
        /// 单纯的图标模式
        /// </summary>
        Icon,

        /// <summary>
        /// 
        /// </summary>
        MoriStudio
    }
}
