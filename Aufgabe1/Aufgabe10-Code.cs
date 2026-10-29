using System;
					
public class Program
{
	public static void Main()
	{
		int sum = 0;
		int zahl = 0;
		Console.WriteLine("numbr");
		zahl = Convert.ToInt32(Console.ReadLine());
		while (zahl != 0)
		{
			sum += (zahl % 10);
			zahl = (zahl/10);
		}
		Console.WriteLine(sum);
	}	
}