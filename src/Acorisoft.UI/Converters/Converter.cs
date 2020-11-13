using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;

namespace Acorisoft.Converters
{
    public static class Converter
    {
        static Converter()
        {
            Bool2Visibile = new Bool2VisibleConverter();

        }
        public static IValueConverter Bool2Visibile { get; } 
    }
}
