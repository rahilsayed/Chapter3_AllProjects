using FunWithNullableValueTypes;

Console.WriteLine("***** Fun with Nullable Value Types *****\n");
DatabaseReader dr = new DatabaseReader();
// Get int from "database".
int? i = dr.GetIntFromDatabase();
if (i.HasValue)
{
    Console.WriteLine("Value of 'i' is: {0}", i.Value);
}
else
{
    Console.WriteLine("Value of 'i' is undefined.");
}
// Get bool from "database".
bool? b = dr.GetBoolFromDatabase();
if (b != null)
{
    Console.WriteLine("Value of 'b' is: {0}", b.Value);
}
else
{
    Console.WriteLine("Value of 'b' is undefined.");
}
Console.ReadLine();





static void LocalNullableVariables()
{
    //Define some local nullable variables.
    int? nullableInt = 10;
    double? nullableDouble = 3.14;
    bool? nullableBool = null;
    char? nullableChar = 'a';
    int?[] arrayOfNullableInts = new int?[10];
}

static void LocalNullableVariablesUsingNullable()
{
    // Define some local nullable types using Nullable<T>.
    Nullable<int> nullableInt = 10;
    Nullable<double> nullableDouble = 3.14;
    Nullable<bool> nullableBool = null;
    Nullable<char> nullableChar = 'a';
    Nullable<int>[] arrayOfNullableInts = new Nullable<int>[10];
}