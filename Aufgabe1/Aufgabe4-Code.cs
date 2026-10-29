using System;
					
public class Program
{
	public static void Main()
	{
		string[] months = new string[] { "Invalid", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
		Console.WriteLine("gimme a number 1-12, ill tell ya what month that number corelates to!");
		int given = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(months[given]+"!");
		
	}
}