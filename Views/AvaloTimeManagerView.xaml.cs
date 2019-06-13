using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TimeManagerAvalo.Views
{
    public class AvaloTimeManagerView : UserControl
    {
        public AvaloTimeManagerView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
