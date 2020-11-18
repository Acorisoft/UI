using Acorisoft.UI.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Acorisoft.UI.Navigations
{
    public static class NavigationService
    {
        class GoBackCommandImpl : ICommand
        {
            public event EventHandler CanExecuteChanged;

            private bool _value;

            internal void RaiseUpdate(bool value)
            {
                _value = value;
                CanExecuteChanged?.Invoke(this , EventArgs.Empty);
            }
            public bool CanExecute(object parameter) => _value;

            public void Execute(object parameter)
            {
                Messenger<INavigateBackMessage>.Publish(new NavigateBackMessageImpl());
            }
        }

        class NavigateBackMessageImpl : INavigateBackMessage
        {

        }

        class NavigateToMessageImpl : INavigateToMessage 
        {
            public Type View { get; set; }
            public Type ViewModel { get; set; }
        }


        private static readonly GoBackCommandImpl _goBack;

        static NavigationService()
        {
            _goBack = new GoBackCommandImpl();
        }
        internal static void CanGoBack(bool value)
        {
            _goBack.RaiseUpdate(value);
        }

        public static void NavigateByView(Type view) => Messenger<INavigateToMessage>.Publish(new NavigateToMessageImpl { View = view });
        public static void NavigateByViewModel(Type viewModel) => Messenger<INavigateToMessage>.Publish(new NavigateToMessageImpl { ViewModel = viewModel });

        public static ICommand GoBack => _goBack;

    }
}
