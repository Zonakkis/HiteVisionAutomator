using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automator.Models
{
    public class Settings
    {
        public Settings() 
        { 

        }
        public string CameraPath { get; set; } = String.Empty;
        public string TouchPath { get; set; } = String.Empty;
    }
}
