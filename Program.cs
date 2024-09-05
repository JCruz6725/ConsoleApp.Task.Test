using System.Diagnostics;

namespace ConsoleApp.Test {
    internal class Program {
        static int Main(string[] args) {
            //This is only to serve

            // Create the source, if it does not already exist.
            const string Source = "ConsoleApp.Task.Test.Master";
            if(!EventLog.SourceExists(Source)) {
                EventLog.CreateEventSource(Source, "MyNewLog");
                Console.WriteLine("CreatedEventSource");
                Console.WriteLine("Exiting, execute the application a second time to use the source.");
                return 1;
            }

            // Create an EventLog instance and assign its source.
            EventLog myLog = new EventLog();
            myLog.Source = Source;

            // Write an informational entry to the event log.
            myLog.WriteEntry("Writing to event log.");
            return 0;
        }
    }
}
