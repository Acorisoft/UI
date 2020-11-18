using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acorisoft.UI.Dialogs
{
    /// <summary>
    /// <see cref="IDialogResult{T}"/> 表示一个抽象的对话框结果。
    /// </summary>
    /// <typeparam name="T">返回数据的实际类型</typeparam>
    public interface IDialogResult
    {

        /// <summary>
        /// 获取一个值，该值用于表示当前 <see cref="IDialogResult{T}"/> 是否成功。
        /// </summary>
        /// <remarks>
        /// 只有用户正确的完成了对话框的输入、或者确定操作才会返回 true。否则返回false。
        /// </remarks>
        bool IsSuccess { get; }
    }

    /// <summary>
    /// <see cref="IDialogResult{T}"/> 表示一个抽象的对话框结果。
    /// </summary>
    /// <typeparam name="T">返回数据的实际类型</typeparam>
    public interface IDialogResult<T> : IDialogResult
    {

        /// <summary>
        /// 获取此次对话框操作的结果。只有 <see cref="IDialogResult.IsSuccess"/> 属性返回 true时该值才有效。
        /// </summary>
        T Result { get; }
    }
}
