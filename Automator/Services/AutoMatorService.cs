using Automator.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automator.Services
{
    public class AutoMatorService
    {       
        public IEnumerable<Class> GetClasses() => new[]
        {
            new Class { Name = "语文" },
            new Class { Name = "数学" },
            new Class { Name = "英语", OpenCamera = true },
        };



    }
}
