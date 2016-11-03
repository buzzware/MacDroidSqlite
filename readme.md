This Xamarin solution demonstrates an issue with the latest sqlite-net-pcl, Xamarin.Mac 4.5 and Xamarin Studio on OSX.

* On the latest Xamarin Studio for Mac (stable or beta), the tests pass on Android but not Mac.
* The tests pass using Jetbrains Rider EAP (https://www.jetbrains.com/rider/) on Mac, so the issue may be the XS linker

The error on Mac is :


	Unhandled Exception:
	System.DllNotFoundException: e_sqlite3
	  at (wrapper managed-to-native) SQLitePCL.SQLite3Provider_e_sqlite3+NativeMethods:sqlite3_libversion_number ()
	  at SQLitePCL.SQLite3Provider_e_sqlite3.SQLitePCL.ISQLite3Provider.sqlite3_libversion_number () [0x00000] in <719e69bbbf954c0baf864f57a1e63149>:0 
	  at SQLitePCL.raw.SetProvider (SQLitePCL.ISQLite3Provider imp) [0x00000] in <df26777b0e574c3aa32c47dbac37ac58>:0 
	  at SQLitePCL.Batteries.Init () [0x00005] in <06606d52f10e4114bf994d92eb1573a1>:0 
	  at NUnitLite.Tests.Program.Main (System.String[] args) [0x0001b] in /Users/gary/repos/xamarin/MacDroidSqlite/MacTestRunner/Program.cs:20 

This is significant because sqlite-net-pcl is the most popular Xamarin database method, and so Xamarin.Mac developers 
are severely hampered without the ability to use Xamarin Studio on the Mac to develop for the Mac. It should work as it 
does on Rider.

The solution contains :

MacTestRunner : a commandline Xamarin.Mac test runner project which simply calls NunitLite
SqliteTestsDroid : a standard Xamarin Android Test runner app
SqliteTests : a shared project containing one test file

The platform specific projects using MvvMLight to create and inject a SqliteConnection for use by the tests.


Notes :

https://github.com/akavache/Akavache/issues/306
https://github.com/akavache/Akavache/pull/317
https://github.com/ericsink/SQLitePCL.raw/issues/44
