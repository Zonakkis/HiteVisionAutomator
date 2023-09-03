using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Automator.Models
{
    public class Storage
    {
        public static void Save(string path,string name,object obj)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(path,name), false))
            {
                sw.WriteLine(JsonConvert.SerializeObject(obj));
                sw.Close();
                sw.Dispose();
            }
        }
        public static T Load<T>(string path, string name)
        {
            return (T)(JsonConvert.DeserializeObject<T>(File.ReadAllText(Path.Combine(path, name))));
        }
    }
}
