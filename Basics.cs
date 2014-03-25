using System;
using System.Collections;

public class project
{
	public static void Main()
	{
		//Counts to 5 using a for loop
		for(int i=1; i<=5; i++)
		{
			Console.WriteLine("This is iteration number "+i+".");
			
		}


		//Requests & returns name
		Console.WriteLine("What is your name?");
		string name;
		name = Console.ReadLine();
		Console.WriteLine("Your name is "+name+".");


		//Requests & returns age 
		Console.WriteLine("How old are you?");
		int age;
		age = int.Parse(Console.ReadLine());
		Console.WriteLine("You are "+age+" years old!");


		//Asks the user to pick a choice 1 - 3 that outputs flavor text
		//Do loop is recurring by equality until broken by choices 1 - 3
		int choice;
		do
		{
			//Asks for choice
			Console.WriteLine("What would you like to do? Pick a number 1 - 3.");

			choice = int.Parse(Console.ReadLine());


			//Switch for int choice
			if(choice==1)
			{
				Console.WriteLine("You picked one; you're the winner!");
				break;
			}
			else if(choice==2)
			{
				Console.WriteLine("You picked two, try again.");
				break;
			}
			else if(choice==3)
			{
				Console.WriteLine("You picked three. I guess that's acceptable.");
				break;
			}
			else
			{
				Console.WriteLine("You did not pick a valid number.");
			}

		} while(choice==choice);


		//Returns the user input from earlier
		Console.WriteLine("So your name is "+name+" and you're "+age+" years old.");


		//I jest, I jest
		Console.Write("Isn't programming fun?");
		Console.WriteLine(" I'm kidding of course.");


		//End of program buffer
		Console.WriteLine("Press any key to exit.");
		Console.ReadKey();
	}
}
