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
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Automator.ViewModels
{
    public class ClassViewModel : ViewModelBase
    {
        public ClassViewModel(IEnumerable<List<Class>> items)
        { 
            ClassesofADay = new ObservableCollection<List<Class>>(items);
            Day = 1;
        }

        public ObservableCollection<List<Class>> ClassesofADay { get; }

        public int Day { get
            {
                return Day - 1;
            }
            set
            {
                Day = value;
            }
        }
    }
}
