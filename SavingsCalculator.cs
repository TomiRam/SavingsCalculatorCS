using System;
using static System.Console;

namespace SavingsCalculator
{ 
	class Program 
	{	
		static void Main(string[] args)
		{
			int income = 1500; //enter your income 
			double savings = income*0.15;

			WriteLine(savings);
			ReadLine();
		}

	}
}