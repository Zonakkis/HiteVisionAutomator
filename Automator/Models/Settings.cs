using Automator.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
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

        public void Save()
        {
            Directory.CreateDirectory($"{System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase}/config");
            Storage.Save($"{System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase}/config", "Settings.json",this);
        }
        public string CameraPath { get; set; } = String.Empty;
        public string TouchPath { get; set; } = String.Empty;
    }
}
