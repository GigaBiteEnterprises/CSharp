using System;
using System.Collections;

//Defines the class Person as an object
public class Person
{
	public string Name {get; set;}
	public int Age {get; set;}
	public Person(string name, int age)
	{
		Name = name;
		Age = age;
	}
	//Put some other shit here
}

//Defines the struct Human as an object
public struct Human
{
	public string Name;
	public int Age;
	public Human(string name, int age)
	{
		Name = name;
		Age = age;
	}
}

//Main class
public class b
{
	public static void Main()
	{



		
		//Initializes 2 instances of the Person object as p1 & p2
		Person p1 = new Person("Steven", 20);
		Person p2 = new Person("Tyler", 21);

		//Checks that both instances were initialized correctly
		Console.WriteLine("Person 1: {0} {1}", p1.Name, p1.Age);
		Console.WriteLine("Person 2: {0} {1}", p2.Name, p2.Age);

		//This section checks for what happens when you assign one object to another of the same type
		Person p3 = p2;
		p2.Name = "Trevor";
		p3.Age = 12;

		//Checks the current value of p2 & p3
		Console.WriteLine("Person 2: {0} {1}", p2.Name, p2.Age);
		Console.WriteLine("Person 3: {0} {1}", p3.Name, p3.Age);

		//Changing the value of p2 or p3 overwrites the value of both objects





		//Initializes 2 instances of the Human object as h1 & h2
		Human h1 = new Human("Kaleb", 13);
		Human h2 = new Human("Austin", 24);

		//Checks that both instances were initialized correctly
		Console.WriteLine("Human 1: {0} {1}", h1.Name, h2.Age);
		Console.WriteLine("Human 2: {0} {1}", h2.Name, h2.Age);

		Human h3 = h2;
		h2.Name = "Bob";
		h3.Age = 47;

		Console.WriteLine("Human 2: {0} {1}", h2.Name, h2.Age);
		Console.WriteLine("Human 3: {0} {1}", h3.Name, h3.Age);

		//Changing the value of h2 or h3 individually changes it (h3 is a copy, not a pointer)




		//End of program buffer
		Console.WriteLine("Press any key to exit.");
		Console.ReadKey();
	}
}

