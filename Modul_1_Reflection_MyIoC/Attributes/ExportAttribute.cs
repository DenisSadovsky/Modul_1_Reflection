﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_1_Reflection_MyIoC.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ExportAttribute : Attribute
    {
        public ExportAttribute()
        { }

        public ExportAttribute(Type contract)
        {
            Contract = contract;
        }

        public Type Contract { get; private set; }
    }
}
