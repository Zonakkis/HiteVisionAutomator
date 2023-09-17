using Automator.Models;
using Avalonia.Controls;
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
        public IEnumerable<List<Class>> GetClasses()
        {
            if (File.Exists(Path.Combine($"{AppDomain.CurrentDomain.SetupInformation.ApplicationBase}/config", "Classes.json")))
            {
                return Storage.Load<List<Class>[]>($"{AppDomain.CurrentDomain.SetupInformation.ApplicationBase}/config", "Classes.json");
            }
            else
            {
            List<Class>[] classes;
            classes = new List<Class>[]
                                {
                    new List<Class>(),new List<Class>(9),new List<Class>(9),new List<Class>(9),new List<Class>(9),new List<Class>(9),new List<Class>(9)
                                };
                foreach(var c in classes)
                {
                    c.Add(new Class());
                    c.Add(new Class());
                    c.Add(new Class());
                    c.Add(new Class());
                    c.Add(new Class());
                    c.Add(new Class());
                    c.Add(new Class());
                    c.Add(new Class());
                    c.Add(new Class());
                }
            return classes;



            //return new List<Class>[]
                //{
                //    new List<Class>(9),new List<Class>(9),new List<Class>(9),new List<Class>(9),new List<Class>(9),new List<Class>(9),new List<Class>(9)
                //};



            }
        }
    }
}
