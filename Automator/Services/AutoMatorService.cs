using Automator.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automator.Services
{
    public class AutoMatorService
    {
        public IEnumerable<List<Class>[]> GetClasses()
        {
            if (File.Exists(Path.Combine($"{AppDomain.CurrentDomain.SetupInformation.ApplicationBase}/config", "Settings.json")))
            {
                return Storage.Load<List<Class>[][]>($"{AppDomain.CurrentDomain.SetupInformation.ApplicationBase}/config", "Settings.json");
            }
            else
            {

                return new List<Class>[][]
                {
                    new List<Class>[7]
                };
            }
        }
    }
}
