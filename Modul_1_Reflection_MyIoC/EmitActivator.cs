using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Modul_1_Reflection_MyIoC.Interfaces;

namespace Modul_1_Reflection_MyIoC
{
    public class EmitActivator : IActivator
    {
        public object CreateInstance(Type type, params object[] parameters)
        {
            Type[] parametersTypes = parameters.Select(p => p.GetType()).ToArray();
            DynamicMethod createMethod = new DynamicMethod(
                string.Empty, type, parametersTypes);
            ILGenerator il = createMethod.GetILGenerator();
            for (int i = 0; i < parameters.Length; i++)
            {
                il.Emit(OpCodes.Ldarg, i);
            }

            ConstructorInfo ctor = type.GetConstructor(parametersTypes);
            il.Emit(OpCodes.Newobj, ctor);
            il.Emit(OpCodes.Ret);

            return createMethod.Invoke(null, parameters);
        }
    }
}
