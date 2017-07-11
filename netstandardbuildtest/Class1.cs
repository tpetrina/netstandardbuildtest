using System;

namespace netstandardbuildtest
{
    public class Class1
    {
        public string Say()
        {
#if NETSTANDARD1_0
            throw new NotSupportedException("This PCL assembly must not be used at runtime..");
#else
            return Message.Greeting;
#endif
        }
    }
}
