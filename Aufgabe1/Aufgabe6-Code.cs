using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("-----------\nKleines 1x1\n-----------");
		int row = 0;
		int multiplier = 0;
		while (multiplier <= 9)
		{
			multiplier += 1;
			row = (multiplier);
			Console.WriteLine("\n");
			while (row < ((multiplier*10) + multiplier))
			{
				Console.Write($"{row}\t");
				row = (row + multiplier);
			}
		}
	}
}