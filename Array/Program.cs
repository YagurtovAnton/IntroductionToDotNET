#define ARRAYS_1
//#define DEBUG
//#define ARRAYS_2
#define JAGED_ARRAY

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if ARRAYS_1
			Console.WriteLine("Введите размер массива");
			int n = Convert.ToInt32(Console.ReadLine());
			//int[]arr = new[] { 3, 5, 8, 13, 21 };
			int[] arr = new int[n];
			Random rend = new Random(0);
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rend.Next(100);
			}
#if DEBUG
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}

#endif
			Console.WriteLine();
			foreach (int i in arr)//Range-based for
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
#endif
#if ARRAYS_2
			Console.Write("Введите количетсво строк:");
			int rows = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите количество элементов строки: ");
			int cols = Convert.ToInt32(Console.ReadLine());

			int[,] i_arr_2 = new int[rows, cols];

			Console.WriteLine(i_arr_2.Rank);

			Random rand = new Random(0);
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					i_arr_2[i, j] = rand.Next(100);
				}
			}
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			}
			foreach (int i in i_arr_2)//Range-based for
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
#endif
#if JAGED_ARRAY

			int[][] arr_jagged = new int[][]
			{   new int[] { 0, 1, 1, 2 },
				new int[] { 3, 5, 8, 13, 21 },
				new int[] { 34, 55, 89 },
				new int[] { 144, 233, 377, 610 }
			};
			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0;j< arr_jagged[i].Length; j++)
				{
					Console.Write(arr_jagged[i][j] + "\t");
				}
                Console.WriteLine();
            }
#endif
			Console.WriteLine();
			int sum = 0;
			for ( int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
			}
			Console.WriteLine(	$"Сумма элеметов массива ............ {sum}");
			Console.WriteLine(	$"Сркднее-арифметическое ............ {(double)sum/n}");
			int min, max;
			min = max = arr[0];
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < min) min = arr[i];
				if (arr[i] > max) max = arr[i];
			}
			Console.WriteLine(	$"Минимальное значение в массиве..... {min}\n" +
								$"Максимальное значение в массиве.... {max}\n");

		}
	}
}
