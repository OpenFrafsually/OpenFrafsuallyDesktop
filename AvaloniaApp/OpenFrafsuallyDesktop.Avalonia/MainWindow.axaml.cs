using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace OpenFrafsuallyDesktop.Avalonia
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
           
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
