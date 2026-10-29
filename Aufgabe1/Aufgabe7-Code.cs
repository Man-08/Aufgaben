using System;
					
public class Program
{
	public static void Main()
	{
		int num = 0;
		while (num <= 29)
		{
			if (num % 3 == 0)
			{
				Console.Write(num+", ");
				num++;
			}
			else if (num % 5 == 0)
			{
				Console.Write(num+", ");
				num++;
			}
			num++;
		}
		Console.Write("30");
	}
}