using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("days");
		int days = Convert.ToInt32(Console.ReadLine());
		int solution = (days * 86400);
		Console.WriteLine(solution);
	}
}