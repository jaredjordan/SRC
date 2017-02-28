using System;
using System.Collections.Generic;

//First Handle if the number is negative or positive 
//then break down from left to right 

namespace integertoenglish
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var numbertoenglish = 11;
			var tensnteens = new List<string> {"zero", "one", "two", "three","four","five","six","seven","eight","nine","ten","eleven" };
			var endings = new List <string> {"twenty","thirty","fourty","fifty","sixty","seventy","eighty","ninety"};
			var bignumbers = new List<string> {"hundred","thousand","million","billion" };
			var neg = new List<string> { "negative"};

			if(numbertoenglish < 20) 
				
				Console.WriteLine(tensnteens[numbertoenglish]);
		}
	}
}