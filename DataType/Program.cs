using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
	internal class Program
	{
		static readonly string delimirer;
		static void Main(string[] args)
		{
			Console.WriteLine("Byte: ");
			Console.WriteLine(sizeof(byte));
			Console.WriteLine(byte.MinValue);
			Console.WriteLine(byte.MaxValue);
			Console.WriteLine(delimirer);

			Console.WriteLine("SByte: ");
			Console.WriteLine(sizeof(sbyte));
			Console.WriteLine(sbyte.MinValue);
			Console.WriteLine(sbyte.MaxValue);
			Console.WriteLine(delimirer);

			Console.WriteLine("Decimal");
			Console.WriteLine(sizeof(decimal));
			Console.WriteLine(decimal.MinValue);
			Console.WriteLine(decimal.MaxValue);
			Console.WriteLine(delimirer);

			int a = 2000000000;
			int b = 4;
			try
			{
				Console.WriteLine((a * b).GetType());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("Вот и сказочке конец");

			}
		}
	}
}
