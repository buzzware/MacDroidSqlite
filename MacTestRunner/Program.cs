using System;
using System.Reflection;
using NUnit.Common;
using NUnitLite;

namespace NUnitLite.Tests
{
    public class Program
    {
        public static int Main(string[] args)
        {
					args = new string[] { "--verbose" };
					var writer = new ExtendedTextWrapper(Console.Out);
					var assembly = Assembly.GetExecutingAssembly();
					return new AutoRun(assembly).Execute(args, writer, Console.In);
        }
    }
}
