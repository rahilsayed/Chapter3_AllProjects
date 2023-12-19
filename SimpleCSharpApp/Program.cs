// Display a simple message to the user.
Console.WriteLine("***** My First C# App *****");
Console.WriteLine("Hello World!");
Console.WriteLine();

//Process any incoming args.
//foreach(string arg in args)
//{
//    Console.WriteLine("Args: {0}", arg);
//}
// Get arguments using System.Environment.
string[] theArgs = Environment.GetCommandLineArgs();
foreach (string arg in theArgs)
{
    Console.WriteLine("Arg: {0}", arg);
}

// Local method within the Top-level statements.
ShowEnvironmentDetails();


// Wait for Enter key to be pressed before shutting down.
Console.ReadLine();

//Return an arbitrary error code.
return -1;

//Additional Members of the System.Environment Class demo
static void ShowEnvironmentDetails()
{
    // Print out the drives on this machine,
    // and other interesting details.
    foreach (string drive in Environment.GetLogicalDrives())
    {
        Console.WriteLine("Drive: {0}", drive);
    }
    Console.WriteLine("OS: {0}", Environment.OSVersion);
    Console.WriteLine("Number of processors: {0}",
    Environment.ProcessorCount);
    Console.WriteLine(".NET Core Version: {0}",
    Environment.Version);
    Console.WriteLine("Machine Name: {0}", Environment.MachineName);
}

