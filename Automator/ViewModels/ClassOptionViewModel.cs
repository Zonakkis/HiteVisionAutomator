using Automator.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automator.ViewModels
{
    public class ClassOptionViewModel :ViewModelBase
    {
        public ClassOptionViewModel(IEnumerable<Class> items)
        {
            ClassOptions = new ObservableCollection<Class>(items);
        }

        public ObservableCollection<Class> ClassOptions { get; }
    }
}
