using Automator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automator.ViewModels
{
    
    public class InitViewModel : ViewModelBase
    {
        public InitViewModel()
        {
            
        }
        public Settings Setting { get; set; } = new Settings();
    }
}
