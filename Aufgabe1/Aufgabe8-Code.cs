using System;
					
public class Program
{
	public static void Main()
	{
		string[] forbiddenWords = {
			// Core English Profanity & Variations
			"fuck", "fvck", "fck", "fuk", "fück", "f*ck", "f_u_c_k", "fucking", "fucker",
			"bitch", "b1tch", "btch", "b!tch", "bitches",
			"shit", "sh1t", "sht", "sh!t", "shat", "shitting",
			"ass", "4ss", "@ss", "asshole", "a$$", "arse",
			"bastard", "b4stard", "crap", "damn", "dih",

			// Core German Profanity & Variations
			"fick", "ficken", "f1cken", "fckn", "ficker", "gefickt",
			"arsch", "4rsch", "arschloch", "arschlappen", "arschgesicht",
			"schlampe", "schl4mpe", "schlampen",
			"hure", "hurn", "h0re", "hurensohn", "lewd",
			"wichser", "wixxer", "wichsen", "nutte", "nutt3",
			"miststueck", "miststück", "depp", "idiot", "rape",

			// Adult Content & Anatomy Bypasses
			"sex", "s3x", "porno", "porn", "p0rn", "prn", "p0rno", "pornography",
			"viagra", "v1agra", "v14gr4", "cialis", "levitra", "corn",
			"penis", "p1nes", "p3nis", "peen", "dick", "d1ck", "cock", "c0ck",
			"vagina", "v4gina", "pussy", "puss1", "fotze", "f0tze",
			"boobs", "b00bs", "tits", "t1ts", "titten",
			"orgasm", "orgasmus", "cum", "c0m", "sperm", "sperma"
		};

        Console.WriteLine("Bitte gib deine Nachricht ein:");
        string userInput = Console.ReadLine(); 
        string lowerInput = userInput.ToLower(); 
        int badWordCount = 0;
        foreach (string word in forbiddenWords)
        {
            if (lowerInput.Contains(word))
            {
                badWordCount++;
            }
        }
        if (badWordCount > 0)
        {
            Console.WriteLine($"\nDeine Nachricht enthält {badWordCount} verbotene Wörter.\nEr wird nicht veröffentlicht.");
        }
        else
        {
            Console.WriteLine("\nVielen Dank für deinen Kommentar.");
        }
	}
}