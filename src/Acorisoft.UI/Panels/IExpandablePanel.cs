using System;
using System.Collections.Generic;
using System.Text;

namespace Acorisoft.Panels
{
    /// <summary>
    /// <see cref="IExpandablePanel"/> 接口用于表示一个可折叠的面板。
    /// </summary>
    /// <remarks>
    /// <para>面板存在以下行为：</para>
    /// <para>当面板存在内容的时候，单击面板标头得到的行为是展开或者折叠内容</para>
    /// <para>当面板不存在内容的时候，单击面板标头得到的行为则是跳转页面</para>
    /// </remarks>
    public interface IExpandablePanel
    {
    }
}
