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
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Data.Converters;
using System.Globalization;

namespace Automator.ViewModels
{
    public class ClassViewModel : ViewModelBase
    {
        public ClassViewModel(IEnumerable<ObservableCollection<Class>> items)
        {
            ClassesofAWeek = new ObservableCollection<ObservableCollection<Class>>(items);
            Day = 1;
        }

        public ObservableCollection<ObservableCollection<Class>> ClassesofAWeek { get; }


        public ObservableCollection<Class> Classes { get; set; }

        public ObservableCollection<Class> ClassesofaDay;
        public ObservableCollection<Class> ClassesofADay
        {
            get
            {
                return ClassesofaDay;
            }
            set
            {
                ClassesofaDay = new ObservableCollection<Class>();
                foreach (var @class in value)
                {
                    ClassesofaDay.Add(@class);
                }
            }
        }

        public int day;
        public int Day
        {
            get
            {
                return day - 1;
            }
            set
            {
                day = value;
                ClassesofADay = ClassesofAWeek[Day];

                Classes = new ObservableCollection<Class>();
                foreach (var @class in ClassesofAWeek[Day])
                {
                    Classes.Add(@class);
                    Trace.WriteLine(@class.Index);
                    Trace.WriteLine(@class.Name);
                }
            }
        }
    }
}

