using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Acorisoft.UI.Messages;
using Acorisoft.UI.Navigations;

namespace Acorisoft.UI.Windows
{
    public class ClientWindow : Window, IHandle<INavigateBackMessage>, IHandle<INavigateToMessage>
    {
        private static ViewLocator _locator;

        static ClientWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ClientWindow) , new FrameworkPropertyMetadata(typeof(ClientWindow)));
        }

        #region ViewLocator

        class ViewLocator
        {
            private readonly List<Type> _types;
            private readonly Dictionary<Type,Type> _pairer;

            public ViewLocator()
            {
                _pairer = new Dictionary<Type , Type>();
                _types = new List<Type>();
            }

            internal void SetAssemblies(IEnumerable<Assembly> assemblies)
            {
                foreach (var assembly in assemblies)
                {
                    _types.AddRange(assembly.GetTypes());
                }
            }

            internal FrameworkElement Pair(Type viewModel)
            {
                if (_pairer.TryGetValue(viewModel , out var viewType))
                {
                    return (FrameworkElement)Activator.CreateInstance(viewType);
                }
                else
                {
                    var viewTypeName = viewModel.FullName.Replace("ViewModel","View");
                    viewType = _types.Where(x => x.FullName == viewTypeName).FirstOrDefault(); 
                    if (viewType != null)
                    {
                        _pairer.TryAdd(viewType , viewModel);
                        _pairer.TryAdd(viewModel , viewType);
                        return (FrameworkElement)Activator.CreateInstance(viewType);
                    }
                }
                return null;
            }

            internal FrameworkElement FindView(Type view)
            {
               return (FrameworkElement)Activator.CreateInstance(view);
            }

            internal object FindViewModel(Type view)
            {
                if(_pairer.TryGetValue(view,out var vmType))
                {
                    return Activator.CreateInstance(vmType);
                }

                var vmTypeName = view.FullName.Replace("View" , "ViewModel");
                vmType = _types.Where(x => x.FullName == vmTypeName).FirstOrDefault();
                if(vmType != null)
                {
                    _pairer.TryAdd(view , vmType);
                    _pairer.TryAdd(vmType , view);
                    return Activator.CreateInstance(vmType);
                }

                return null;
            }
        }

        #endregion

        public ClientWindow()
        {
            if (_locator == null)
            {
                _locator = new ViewLocator();
                _stack = new Stack<FrameworkElement>();
                _locator.SetAssemblies(AssemblyFilter());
                Messenger<INavigateBackMessage>.Subscribe(this);
                Messenger<INavigateToMessage>.Subscribe(this);
            }

            CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand , CloseWindow));
            CommandBindings.Add(new CommandBinding(SystemCommands.MaximizeWindowCommand , MaximizeWindow , CanResizeWindow));
            CommandBindings.Add(new CommandBinding(SystemCommands.MinimizeWindowCommand , MinimizeWindow , CanMinimizeWindow));
            CommandBindings.Add(new CommandBinding(SystemCommands.RestoreWindowCommand , RestoreWindow , CanResizeWindow));
        }

        protected virtual IEnumerable<Assembly> AssemblyFilter()
        {
            return new[] {
                Assembly.GetEntryAssembly() ,
                Assembly.GetCallingAssembly(),
                Assembly.GetExecutingAssembly()
            };
        }

        #region Window Commands

        private void CanResizeWindow(object sender , CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ResizeMode == ResizeMode.CanResize || ResizeMode == ResizeMode.CanResizeWithGrip;
        }

        private void CanMinimizeWindow(object sender , CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ResizeMode != ResizeMode.NoResize;
        }

        private void CloseWindow(object sender , ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void MaximizeWindow(object sender , ExecutedRoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                SystemCommands.RestoreWindow(this);
            }
            else
            {
                SystemCommands.MaximizeWindow(this);
            }
        }

        private void MinimizeWindow(object sender , ExecutedRoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void RestoreWindow(object sender , ExecutedRoutedEventArgs e)
        {
            SystemCommands.RestoreWindow(this);
        }


        private void ShowSystemMenu(object sender , ExecutedRoutedEventArgs e)
        {
            FrameworkElement element = e.OriginalSource as FrameworkElement;
            if (element == null)
                return;

            var point = WindowState == WindowState.Maximized ? new Point(0, element.ActualHeight)
            : new Point(Left + BorderThickness.Left, element.ActualHeight + Top + BorderThickness.Top);
            point = element.TransformToAncestor(this).Transform(point);
            SystemCommands.ShowSystemMenu(this , point);
        }


        #endregion

        #region IHandle<T> Interface Members

        private FrameworkElement _view;
        private Stack<FrameworkElement> _stack;


        void IObserver<INavigateBackMessage>.OnCompleted()
        {
            Content = _view;
        }

        void IObserver<INavigateBackMessage>.OnError(Exception error)
        {
        }

        void IObserver<INavigateBackMessage>.OnNext(INavigateBackMessage value)
        {
            _view = _stack.Pop();
            NavigationService.CanGoBack(_stack.Count > 0);

        }

        void IObserver<INavigateToMessage>.OnCompleted()
        {
            Content = _view;
        }

        void IObserver<INavigateToMessage>.OnError(Exception error)
        {
        }

        void IObserver<INavigateToMessage>.OnNext(INavigateToMessage value)
        {
            if(value.View != null)
            {
                if (Content is FrameworkElement)
                {
                    _stack.Push(Content as FrameworkElement);
                    NavigationService.CanGoBack(true);
                }
                _view = _locator.FindView(value.View);
                if (_view != null)
                {
                    _view.DataContext = _locator.FindViewModel(value.View);
                }
            }
            else if (value.ViewModel != null)
            {
                if (Content is FrameworkElement)
                {
                    _stack.Push(Content as FrameworkElement);
                    NavigationService.CanGoBack(true);
                }
                _view = _locator.Pair(value.ViewModel);
                if (_view != null)
                {
                    _view.DataContext = _locator.FindViewModel(value.ViewModel);
                }
            }
        }

        #endregion IHandle<T> Interface Members

        public object TitleBar
        {
            get => (object)GetValue(TitleBarProperty);
            set => SetValue(TitleBarProperty , value);
        }

        public DataTemplate TitleBarTemplate
        {
            get => (DataTemplate)GetValue(TitleBarTemplateProperty);
            set => SetValue(TitleBarTemplateProperty , value);
        }

        public DataTemplateSelector TitleBarTemplateSelector
        {
            get => (DataTemplateSelector)GetValue(TitleBarTemplateSelectorProperty);
            set => SetValue(TitleBarTemplateSelectorProperty , value);
        }


        public string TitleBarStringFormat
        {
            get => (string)GetValue(TitleBarStringFormatProperty);
            set => SetValue(TitleBarStringFormatProperty , value);
        }

        public Brush Color
        {
            get => (Brush)GetValue(ColorProperty);
            set => SetValue(ColorProperty , value);
        }


        public Thickness TitleBarPadding
        {
            get => (Thickness)GetValue(TitleBarPaddingProperty);
            set => SetValue(TitleBarPaddingProperty , value);
        }

        public static readonly DependencyProperty TitleBarPaddingProperty = DependencyProperty.Register(
            "TitleBarPadding",
            typeof(Thickness),
            typeof(ClientWindow),
            new PropertyMetadata(null));

        public static readonly DependencyProperty TitleBarStringFormatProperty = DependencyProperty.Register(
            "TitleBarStringFormat",
            typeof(string),
            typeof(ClientWindow),
            new PropertyMetadata(null));

        public static readonly DependencyProperty TitleBarTemplateSelectorProperty = DependencyProperty.Register(
            "TitleBarTemplateSelector",
            typeof(DataTemplateSelector),
            typeof(ClientWindow),
            new PropertyMetadata(null));

        public static readonly DependencyProperty TitleBarTemplateProperty = DependencyProperty.Register(
            "TitleBarTemplate",
            typeof(DataTemplate),
            typeof(ClientWindow),
            new PropertyMetadata(null));

        public static readonly DependencyProperty TitleBarProperty = DependencyProperty.Register(
            "TitleBar",
            typeof(object),
            typeof(ClientWindow),
            new PropertyMetadata(null));

        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register(
            "Color",
            typeof(Brush),
            typeof(ClientWindow),
            new PropertyMetadata(null));

    }
}
