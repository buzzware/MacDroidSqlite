NUnitLite Console-based Test Runner with Xamarin.Mac

Runs and is debuggable in Xamarin Studio on Mac.

1) Tests can be included in the app itself (eg. Test.cs)
2) nunit library or Mac library projects can be linked containing tests, and then in Program.cs you use 
var assembly = typeof(MyTestsNamespace.ATestClass).GetTypeInfo().Assembly;

This was developed because the current stable of Xamarin Studio fails with an error "The application has not been built" when trying to debug a library of nunit tests with a reference to Xamarin.Mac. If you create an nunit library from Xamarin Studio, it works, but you can't access OSX specific APIs. Instead, you can create a Mac library, but then you get this error.

This may also be useful for Continuous Integration scenarios
