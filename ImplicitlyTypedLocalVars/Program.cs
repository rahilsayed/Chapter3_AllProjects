using System.Xml;

Console.WriteLine("***** Fun with Implicit Typing *****");
DeclareImplicitVars();
DeclareImplicitNumerics();


static void DeclareImplicitVars()
{
    // Implicitly typed local variables.
    var myInt = 0;
    var myBool = true;
    var myString = "Time, marches on...";
    // Print out the underlying type.
    Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
    Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
    Console.WriteLine("myString is a: {0}", myString.GetType().Name);
}

static void DeclareImplicitNumerics()
{
    // Implicitly typed numeric variables.
    var myUInt = 0u;
    var myInt = 0;
    var myLong = 0L;
    var myDouble = 0.5;
    var myFloat = 0.5F;
    var myDecimal = 0.5M;
    // Print out the underlying type.
    Console.WriteLine("=>*****Decalring Implicit Numerics*****");
    Console.WriteLine("myUInt is a: {0}", myUInt.GetType().Name);
    Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
    Console.WriteLine("myLong is a: {0}", myLong.GetType().Name);
    Console.WriteLine("myDouble is a: {0}", myDouble.GetType().Name);
    Console.WriteLine("myFloat is a: {0}", myFloat.GetType().Name);
    Console.WriteLine("myDecimal is a: {0}", myDecimal.GetType().Name);
}

//class ThisWillNeverCompile
//{
//    // Error! var cannot be used as field data!
//    private var myInt = 10;
//    // Error! var cannot be used as a return value
//    // or parameter type!
//    public var MyMethod(var x, var y) { }
//}

//// Error! Must assign a value!
//var myData;

//// Error! Must assign value at exact time of declaration!
//var myInt;
//myInt = 0;

//// Error! Can't assign null as initial value!
//var myObj = null;

//It is permissible, however, to assign an inferred local variable to null after its initial assignment
//(provided it is a reference type).

//// OK, if SportsCar is a reference type!
//var myCar = new SportsCar();
//myCar = null;