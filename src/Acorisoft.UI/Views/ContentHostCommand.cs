using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acorisoft.UI.Views
{
    public class SampleDialogViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        private string _text;
        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                PropertyChanged?.Invoke(this , new PropertyChangedEventArgs(nameof(Text)));
            }
        }

        public string this[string columnName]
        {
            get
            {
                return $"{columnName}{DateTime.Now}错误";
            }
        }

        public string Error => "所有的错误";

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public static class ContentHostCommand
    {
    }
}
