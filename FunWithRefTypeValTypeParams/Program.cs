﻿using FunWithRefTypeValTypeParams;

// Passing ref-types by value.
Console.WriteLine("***** Passing Person object by value *****");
Person fred = new Person("Fred", 12);
Console.WriteLine("\nBefore by value call, Person is:");
fred.Display();
SendAPersonByValue(fred);
Console.WriteLine("\nAfter by value call, Person is:");
fred.Display();


Console.WriteLine("\n***** Passing Person object by reference *****");

Person mel = new Person("Mel", 23);
Console.WriteLine("Before by ref call, Person is:");
mel.Display();
SendAPersonByReference(ref mel);
Console.WriteLine("After by ref call, Person is:");
mel.Display();
Console.ReadLine();



//NOTE: As you can see, the value of personAge has been modified. This behavior, discussed earlier, should make
//more sense now that you understand the way reference types work. Given that you were able to change the
//state of the incoming Person, what was copied? The answer: a copy of the reference to the caller’s object.
//Therefore, as the SendAPersonByValue() method is pointing to the same object as the caller, it is possible to
//alter the object’s state data. What is not possible is to reassign what the reference is pointing to.

static void SendAPersonByValue(Person p)
{
    // Change the age of "p"?
    p.personAge = 99;
    // Will the caller see this reassignment?
    p = new Person("Nikki", 99);
}


static void SendAPersonByReference(ref Person p)
{
    // Change some data of "p".
    p.personAge = 555;
    // "p" is now pointing to a new object on the heap!
    p = new Person("Nikki", 999);
}



//NOTE:  If a reference type is passed by reference, the callee may change the values of the
//object’s state data, as well as the object it is referencing.

//•  If a reference type is passed by value, the callee may change the values of the object’s
//state data but not the object it is referencing.