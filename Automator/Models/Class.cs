using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automator.Models
{
    public class Class
    {
        public Class()
        {
            Name = "英语";
        }
        public bool Enabled { get; set; }
        public string Name { get; set; } = String.Empty;

        public int Index { get; set; }

        public bool OpenCamera { get; set; }
        public bool OpenTouch { get; set; }

    }
}
