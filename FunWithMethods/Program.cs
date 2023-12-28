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