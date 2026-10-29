using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
		int AnzahlKm = Convert.ToInt32(Console.ReadLine());
		if (AnzahlKm > 42)
		{
			Console.WriteLine("Das schaffst du nicht!");
		}
		else
		{
			int n = ((AnzahlKm*1000)/400);
			Console.WriteLine($"Das sind {n} Runden. Bereit für den Lauf? (0/1)");
			int bereit = Convert.ToInt32(Console.ReadLine());
			if (bereit == 1)
			{
				int i = 1;
				while (i <= n)
				{
					Console.WriteLine($"Du läufst Runde {i}");
					i++;
				}
				Console.WriteLine("Du hast es geschaft!");
			}
		}
	}
}