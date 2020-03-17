using System;
using Newtonsoft.Json.Linq;
using System.Numerics;

namespace learn_dotnet
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var array = new JArray {"Manual text", new DateTime(2000, 5, 23)};

            var o = new JObject {["MyArray"] = array};

            var json = o.ToString();
            
            Console.WriteLine(json);
            
            BigInteger aa = new BigInteger();
            
            MachineLearningProgram.Internal_Main(args);
        }
    }
}
