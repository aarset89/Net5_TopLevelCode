using System;


/*In .NET 5, top level code doesn't require Main method, curlyBracers and name space...
Top-level code, only works once in whole application and it is consider as the beggining of all application.
*/

Console.WriteLine("Hello World!");

var person = new PersonModel { Id = 2, FirstName = "William", LastName = "Sanchez" };


//person.Id = 2; //Because of the init setter keyword, it is impossible to change the value of the 

Console.WriteLine($"Hello {person.FirstName} {person.LastName} ({person.Id})");

Console.WriteLine(Add(4, 5));



static double Add(double x, double y)
{
    return x + y;
}

