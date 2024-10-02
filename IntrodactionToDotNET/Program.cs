//#define CONSOLE_CLASS
//#define STRING_OPERATIONS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrodactionToDotNET
{
	internal class Program
	{
		static readonly String delimiter = "\n_____________________________________\n";
		static void Main(string[] args)
		{
			Console.Title = "Inntrodution to .NET";
			Console.WriteLine("\t\tHello .NET");
			//Console.CursorLeft = 25;
			// Console.CursorTop = 8;
			Console.SetCursorPosition(21, 5);
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("Привет .NET");
			Console.ResetColor();

			Console.WriteLine(delimiter);

#if CONSOLE_CLASS

			#region CW
            Console.WriteLine("позиция окна консоли " + Console.WindowLeft + "знакопозиция ");
            Console.WriteLine("позиция окна консоли " + Console.WindowTop + "знакопозиция ");

            Console.SetWindowSize(91, 22);
            Console.WriteLine("высота окна консоли " + Console.WindowHeight + "знакопозиция ");
            Console.WriteLine("ширина окна консоли " + Console.WindowWidth + "знакопозиция ");

            Console.SetBufferSize(91, 22);
            Console.WriteLine("высота буфер консоли " + Console.BufferHeight + "знакопозиция ");
            Console.WriteLine("ширина Буфера консоли " + Console.BufferWidth + "знакопозиция ");
			#endregion
#endif
#if STRING_OPERATIONS
			Console.Write("Введите ваше имя: ");
            string first_name = Console.ReadLine();

            Console.Write("Введите ваше фамилию: ");
            string last_name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(first_name + " " + last_name + " " + age);
            Console.WriteLine(String.Format("{0}{1}{2}", first_name, last_name, age));
            Console.WriteLine($"{first_name}{last_name}{age}"); 
#endif
			// SQUARE
			int n = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
					Console.Write("* ");
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine(delimiter);

			// TRIANGLE_1
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);

			// TRIANGLE_2
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
				Console.WriteLine(delimiter);

				// TRIANGLE_3
				for ( i = 0; i < n; i++)
				{
					for (int h = 0; h < i; h++)
					{
						Console.Write(" ");
					}
					for (int j = i; j < n; j++)
					{
						Console.Write("* ");
					}
					Console.WriteLine();

				}
					Console.WriteLine(delimiter);
			}
		}
	}
}
