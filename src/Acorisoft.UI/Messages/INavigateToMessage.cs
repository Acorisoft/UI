using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acorisoft.UI.Messages
{
    public interface INavigateToMessage : IMessage
    {
        Type ViewModel { get; }
        Type View { get; }
    }
}
