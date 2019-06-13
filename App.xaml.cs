using Avalonia;
using Avalonia.Markup.Xaml;

namespace TimeManagerAvalo
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
