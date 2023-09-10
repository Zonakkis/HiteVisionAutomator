using Automator.Models;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automator.ViewModels
{
    public class ClassViewModel : ViewModelBase
    {
        public ClassViewModel(IEnumerable<List<Class>[]> items)
        { 
            ClassesofADay = new ObservableCollection<List<Class>[]>(items);
        }

        public ObservableCollection<List<Class>[]> ClassesofADay { get; }
    }
}
