using System.Reflection;

using Android.App;
using Android.OS;
using GalaSoft.MvvmLight.Ioc;
using Java.IO;
using SQLite;
using Xamarin.Android.NUnitLite;

namespace SqliteTestsDroid
{
	[Activity(Label = "SqliteTestsDroid", MainLauncher = true)]
	public class MainActivity : TestSuiteActivity
	{
		protected override void OnCreate(Bundle bundle)
		{


			string dbFilePath = Android.App.Application.Context.GetDatabasePath("MacTestRunner.db").AbsolutePath;
			string databaseFolder = System.IO.Path.GetDirectoryName(dbFilePath);
			File folder = new File(databaseFolder);
			if (!folder.Exists())
				folder.Mkdir();
			var conn = new SQLite.SQLiteConnection(dbFilePath);
			SimpleIoc.Default.Register<SQLiteConnection>(() => conn);

			// tests can be inside the main assembly
			AddTest(Assembly.GetExecutingAssembly());
			// or in any reference assemblies
			// AddTest (typeof (Your.Library.TestClass).Assembly);






			// Once you called base.OnCreate(), you cannot add more assemblies.
			base.OnCreate(bundle);
		}
	}
}
