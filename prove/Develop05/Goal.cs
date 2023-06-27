using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Develop05
{
    public abstract class Goal
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public int Points { get; set; }

        public abstract void RecordEvent();
    }
}