using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acorisoft.UI
{
    internal static class Boxes
    {
        private sealed class Default<T>
        {
            public static readonly object DefaultObject = default(T);
        }

        public static object Box<T>() => Default<T>.DefaultObject;
    }

}
