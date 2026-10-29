using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Bitte geben Sie eine Zahl ein.");
		int zahl = 0;
		zahl = Convert.ToInt32(Console.ReadLine());
		string bin = Convert.ToString(zahl, 2); // Konvertieren in binäre Darstellung
		Console.WriteLine("Die binäre Darstellung von " + zahl + " ist: " + bin);
	}
}