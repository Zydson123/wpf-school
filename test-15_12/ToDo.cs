using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test15_12
{
    public class ToDo
    {
        public string WhatToDo { get; set; }
        public bool IsDone { get; set; }
        public string WhenToDo { get; set; }
        public ToDo(string what, bool done, string when)
        {
            WhatToDo = what;
            IsDone = done;
            WhenToDo = when;
        }
    }

}
