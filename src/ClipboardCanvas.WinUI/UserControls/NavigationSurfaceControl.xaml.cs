using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Windows.Input;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ClipboardCanvas.WinUI.UserControls
{
    public sealed partial class NavigationSurfaceControl : UserControl
    {
        public NavigationSurfaceControl()
        {
            InitializeComponent();
        }

        public ICommand? BackCommand
        {
            get => (ICommand?)GetValue(BackCommandProperty);
            set => SetValue(BackCommandProperty, value);
        }
        public static readonly DependencyProperty BackCommandProperty =
            DependencyProperty.Register(nameof(BackCommand), typeof(ICommand), typeof(NavigationSurfaceControl), new PropertyMetadata(null));

        public ICommand? ForwardCommand
        {
            get => (ICommand?)GetValue(ForwardCommandProperty);
            set => SetValue(ForwardCommandProperty, value);
        }
        public static readonly DependencyProperty ForwardCommandProperty =
            DependencyProperty.Register(nameof(ForwardCommand), typeof(ICommand), typeof(NavigationSurfaceControl), new PropertyMetadata(null));

        public ICommand? HomeCommand
        {
            get => (ICommand?)GetValue(HomeCommandProperty);
            set => SetValue(HomeCommandProperty, value);
        }
        public static readonly DependencyProperty HomeCommandProperty =
            DependencyProperty.Register(nameof(HomeCommand), typeof(ICommand), typeof(NavigationSurfaceControl), new PropertyMetadata(null));

        public bool IsForwardEnabled
        {
            get => (bool)GetValue(IsForwardEnabledProperty);
            set => SetValue(IsForwardEnabledProperty, value);
        }
        public static readonly DependencyProperty IsForwardEnabledProperty =
            DependencyProperty.Register(nameof(IsForwardEnabled), typeof(bool), typeof(NavigationSurfaceControl), new PropertyMetadata(true));

        public bool IsBackEnabled
        {
            get => (bool)GetValue(IsBackEnabledProperty);
            set => SetValue(IsBackEnabledProperty, value);
        }
        public static readonly DependencyProperty IsBackEnabledProperty =
            DependencyProperty.Register(nameof(IsBackEnabled), typeof(bool), typeof(NavigationSurfaceControl), new PropertyMetadata(true));
    }
}