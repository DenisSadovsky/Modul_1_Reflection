using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_1_Reflection_MyIoC.Interfaces
{
    public interface IActivator
    {
        object CreateInstance(Type type, params object[] parameters);
    }
}
