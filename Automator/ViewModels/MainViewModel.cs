using Automator.Models;
using Automator.Services;
using Automator.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automator.ViewModels
{
    public class MainViewModel :ViewModelBase
    {
        public MainViewModel()
        {
            var service = new AutoMatorService();
            ClassView = new ClassViewModel(service.GetClasses());

        }


        public ClassViewModel ClassView { get; }

        public ObservableCollection<Class> ClassOptions { get; }
    }
}
