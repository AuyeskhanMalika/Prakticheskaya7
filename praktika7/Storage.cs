﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika7
{
    public abstract class Storage
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public abstract double GetMemoryCapacity();

        public abstract void CopyDateToTheDevice();
        public abstract double GetInfoAboutFreeMemoryOnDevice();
        public abstract string GetFullInfoAboutDevice();
    }
}
