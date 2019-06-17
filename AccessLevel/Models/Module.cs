using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessLevel.Models
{
    public class Module
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Icon { get; set; }

        public string Image { get; set; }

        public string LinkName { get; set; }

        public bool IsPermision { get; set; } = false;

        public int Order { get; set; } = 1;

        public List<Action> Actions { get; set; } = new List<Action>();
    }
}
