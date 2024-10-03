using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calk
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите арифмитическое выражение: ");
			string expression=Console.ReadLine();
			expression= expression.Replace(',','.');
			//Console.WriteLine(exspessin);
			char[]delimiters=new char[] { '+','-','*','/'};
			string[] numbers=expression.Split(delimiters);
			// в классе string есть  метод Split(...), который принимает набор разделителей,
			// и возращает токены(" разрезаную строку
			try
			{
				double a = Convert.ToDouble(numbers[0]);
				double b = Convert.ToDouble(numbers[1]);
#if IFcalk
			if (expression.Contains('+')) Console.WriteLine($"{a}+{b}={a + b}");
			else if (expression.Contains('-')) Console.WriteLine($"{a}+{b}={a - b}");
			else if (expression.Contains('*')) Console.WriteLine($"{a}+{b}={a * b}");
			else if (expression.Contains('/')) Console.WriteLine($"{a}+{b}={a / b}"); 
#endif
				switch (expression[expression.IndexOfAny(delimiters)])
				{
					case '+': Console.WriteLine($"{numbers[0]}+{numbers[1]}={a + b}"); break;
					case '-': Console.WriteLine($"{numbers[0]}-{numbers[1]}={a - b}"); break;
					case '*': Console.WriteLine($"{numbers[0]}*{numbers[1]}={a * b}"); break;
					case '/': Console.WriteLine($"{numbers[0]}/{numbers[1]}={a / b}"); break;
					default: Console.WriteLine("Error: No operation"); break;
				}
			}
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			Main(args);
		}
	}
}
