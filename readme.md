This Xamarin solution demonstrates an issue with the latest sqlite-net-pcl, Xamarin.Mac 4.5 and Xamarin Studio on OSX.

* On the latest Xamarin Studio for Mac (stable or beta), the tests pass on Android but not Mac.
* The tests pass using Jetbrains Rider EAP (https://www.jetbrains.com/rider/) on Mac, so the issue may be the XS linker

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
