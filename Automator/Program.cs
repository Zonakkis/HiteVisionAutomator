using Avalonia;
using Avalonia.ReactiveUI;
using System;
using System.Diagnostics;

namespace Automator
{
    internal class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args)
        {
            if(args.Length == 0 && Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length>=2) 
            {
                Environment.Exit(0);
            }
            BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

        }

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .WithInterFont()
                .LogToTrace()
                .UseReactiveUI();
    }
}