using System;
using System.Runtime.Serialization;

namespace Modul_1_Reflection_MyIoC
{
    [Serializable]
    public class DIException : Exception
    {
        public DIException()
        {
        }

        public DIException(string message)
            : base(message)
        {
        }

        public DIException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected DIException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
