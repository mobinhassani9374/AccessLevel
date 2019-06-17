using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessLevel.Models
{
    public class Action
    {
        public string Title { get; set; }

        public string ControllerName { get; set; }

        public string ActionName { get; set; }

        public bool IsPermision { get; set; } = false;
    }
}
