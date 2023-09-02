using Automator.Services;
using ReactiveUI;
using System.Diagnostics;
using System.IO;

namespace Automator.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";
        
        private ViewModelBase _contentViewModel;
        
        public MainWindowViewModel()
        {
            var service = new AutoMatorService();
            ClassOption = new ClassOptionViewModel(service.GetClasses());
            Debug.WriteLine(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase);
            if (!Directory.Exists($"{System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase}Settings.json"))
            {
                _contentViewModel = new InitViewModel();
            }
            else
            {
                _contentViewModel = ClassOption;
            }
        }

        public ClassOptionViewModel ClassOption { get; }

        public ViewModelBase ContentViewModel
        {
            get => _contentViewModel;
            private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
        }
    }
}