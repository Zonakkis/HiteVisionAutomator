using Automator.Services;
using ReactiveUI;
using System.Diagnostics;
using System.IO;

namespace Automator.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        private ViewModelBase _contentViewModel;
        
        public MainWindowViewModel()
        {
            var service = new AutoMatorService();
            ClassOption = new MainViewModel();
            Debug.WriteLine(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase);
            if (!File.Exists($"{System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase}/config/Settings.json"))
            {
                _contentViewModel = new InitViewModel();
            }
            else
            {
                _contentViewModel = ClassOption;
            }
        }

        public MainViewModel ClassOption { get; }

        public ViewModelBase ContentViewModel
        {
            get => _contentViewModel;
            private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
        }
    }
}