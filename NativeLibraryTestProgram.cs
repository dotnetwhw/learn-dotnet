using System;
using System.Reflection;
using System.Runtime.InteropServices;
using NativeLibraryManager;

namespace learn_dotnet
{
    public class NativeLibraryTestProgram
    {
        private static void Main1(string[] args)
        {
            var accessor = new ResourceAccessor(Assembly.GetExecutingAssembly());
            
        }
    }
}