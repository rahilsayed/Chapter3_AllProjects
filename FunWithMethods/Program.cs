Console.WriteLine("***** Fun with Methods *****");
// No need to assign initial value to local variables
// used as output parameters, provided the first time
// you use them is as output arguments.
// C# 7 allows for out parameters to be declared in the method call
AddUsingOutParam(90, 90, out int ans);
Console.WriteLine("90 + 90 = {0}", ans);

FillTheseValues(out int i, out string str, out bool b);
Console.WriteLine("Int is: {0}", i);
Console.WriteLine("String is: {0}", str);
Console.WriteLine("Boolean is: {0}", b);

string str1 = "Flip";
string str2 = "Flop";
Console.WriteLine("Before: {0}, {1} ", str1, str2);
SwapStrings(ref str1, ref str2);
Console.WriteLine("After: {0}, {1} ", str1, str2);


//NOTE: PARAMS MODIFIER EXAMPLE
//to avoid any ambiguity, C# demands a method support only a single params argument, which must
//be the final argument in the parameter list.
// Pass in a comma-delimited list of doubles...
double average;
average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
Console.WriteLine("Average of data is: {0}", average);

// ...or pass an array of doubles.
double[] data = { 4.0, 3.2, 5.7 };
average = CalculateAverage(data);
Console.WriteLine("Average of data is: {0}", average);

// Average of 0 is 0!
Console.WriteLine("Average of data is: {0}", CalculateAverage());

//NOTE: OPTIONAL PARAMS MODIFIER EXAMPLE
EnterLogData("Oh no! Grid can't find data");
EnterLogData("Oh no! I can't find the payroll data", "CFO");
Console.ReadLine();

//NOTE: NAMED PARAMS MODIFIER EXAMPLE
DisplayFancyMessage(message: "Wow! Very Fancy indeed!",
textColor: ConsoleColor.DarkRed,
backgroundColor: ConsoleColor.White);
DisplayFancyMessage(backgroundColor: ConsoleColor.Green,
message: "Testing...",
textColor: ConsoleColor.DarkBlue);

// This is OK, as positional args are listed before named args.
DisplayFancyMessage(ConsoleColor.Blue,
message: "Testing...",
backgroundColor: ConsoleColor.White);

// This is OK, all arguments are in the correct order
DisplayFancyMessage(textColor: ConsoleColor.White, backgroundColor: ConsoleColor.Blue,
"Testing...");

//// This is an ERROR, as positional args are listed after named args.
//DisplayFancyMessage(message: "Testing...",
//backgroundColor: ConsoleColor.White,
//ConsoleColor.Blue);


Console.ReadLine();






// Value type arguments are passed by value by default.
static int Add(int x, int y)
{
    int ans = x + y;
    // Caller will not see these changes
    // as you are modifying a copy of the
    // original data.
    x = 10000;
    y = 88888;
    return ans;
}

// Output parameters must be assigned by the called method.
static void AddUsingOutParam(int x, int y, out int ans)
{
    ans = x + y;
}

//static void ThisWontCompile(out int a)
//{
//    Console.WriteLine("Error! Forgot to assign output arg!");
//}

// Returning multiple output parameters.
static void FillTheseValues(out int a, out string b, out bool c)
{
    a = 9;
    b = "Enjoy your string.";
    c = true;
}

static void SwapStrings(ref string s1, ref string s2)
{
    string tempStr = s1;
    s1 = s2;
    s2 = tempStr;
}

static int Add2(int x, int y)
{
    x = 10000;
    y = 88888;
    int ans = x + y;
    return ans;
}


//in modifier can help reduce memory overload by not making copy of data, also can be used for readonly vars
static int AddReadOnly(in int x, in int y)
{
    //Error CS8331 Cannot assign to variable 'in int' because it is a readonly variable
    //x = 10000;
    //y = 88888;
    int ans = x + y;
    return ans;
}



//If you were to prototype this method to take an array of doubles, this would force the caller to first define
//the array, then fill the array, and finally pass it into the method. However, if you define CalculateAverage()
//to take a params of double[] data types, the caller can simply pass a comma-delimited list of doubles. The
//list of doubles will be packaged into an array of doubles behind the scenes.

// Return average of "some number" of doubles.
static double CalculateAverage(params double[] values)
{
    Console.WriteLine("You sent me {0} doubles.", values.Length);
    double sum = 0;
    if (values.Length == 0)
    {
        return sum;
    }
    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }
    return (sum / values.Length);
}


static void EnterLogData(string message, string owner = "Programmer")
{
    Console.WriteLine("Error: {0}", message);
    Console.WriteLine("Owner of Error: {0}", owner);
}

//NOTE: FOR OPTIONAL PARAMS,
//// Error! The default value for an optional arg must be known
//// at compile time!
//static void EnterLogData(string message, string owner = "Programmer", DateTime timeStamp =
//DateTime.Now)
//{
//    Console.WriteLine("Error: {0}", message);
//    Console.WriteLine("Owner of Error: {0}", owner);
//    Console.WriteLine("Time of Error: {0}", timeStamp);
//}


//NOTE: NAMED PARAMS EXAMPLE
static void DisplayFancyMessage(ConsoleColor textColor,
ConsoleColor backgroundColor, string message)
{
    // Store old colors to restore after message is printed.
    ConsoleColor oldTextColor = Console.ForegroundColor;
    ConsoleColor oldbackgroundColor = Console.BackgroundColor;
    // Set new colors and print message.
    Console.ForegroundColor = textColor;
    Console.BackgroundColor = backgroundColor;
    Console.WriteLine(message);
    // Restore previous colors.
    Console.ForegroundColor = oldTextColor;
    Console.BackgroundColor = oldbackgroundColor;
}

//Given that each argument has a default value, named arguments allow the caller to specify only the
//parameters for which they do not want to receive the defaults. Therefore, if the caller wants the value
//"Hello!" to appear in blue text surrounded by a white background, they can simply specify the following:
//DisplayFancyMessage(message: "Hello!");
//Or, if the caller wants to see “Test Message” print out with a green background containing blue text, they
//can invoke the following:
//DisplayFancyMessage(backgroundColor: ConsoleColor.Green);
//As you can see, optional arguments and named parameters tend to work hand in hand. To wrap up your
//examination of building C# methods, I need to address the topic of method overloading.


