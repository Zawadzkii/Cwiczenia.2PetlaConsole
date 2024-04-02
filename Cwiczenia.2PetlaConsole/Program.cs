using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Liczby parzyste w zakresie od 0 do 1000:");

		int number = 0;

		do
		{
			if (number % 2 == 0)
			{
				Console.WriteLine(number);
			}

			number++;
		} while (number <= 1000);
	}
}