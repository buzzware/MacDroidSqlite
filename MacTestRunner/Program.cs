using System;
using System.Reflection;
using GalaSoft.MvvmLight.Ioc;
using NUnit.Common;
using NUnitLite;
using SQLite;

namespace NUnitLite.Tests
{
    public class Program
    {
        public static int Main(string[] args)
        {

					string databaseFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
					string dbFilePath = databaseFolder + "/MacTestRunner.db";
					//File folder = new File(databaseFolder);
					//if (!folder.Exists())
					//	folder.Mkdir();
					SQLitePCL.Batteries.Init();
					var conn = new SQLite.SQLiteConnection(dbFilePath);
					SimpleIoc.Default.Register<SQLiteConnection>(() => conn);


					args = new string[] { "--verbose" };
					var writer = new ExtendedTextWrapper(Console.Out);
					var assembly = Assembly.GetExecutingAssembly();
					return new AutoRun(assembly).Execute(args, writer, Console.In);
        }
    }
}
