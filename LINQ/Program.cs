using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			int[] numbs = new int[3] {3, 6, 2};
			int num1 = 6;
			Filter filterInstance = new Filter();

			bool result = filterInstance.contains(num1, numbs);
			int[] evens = filterInstance.filterOutOddNumbers(numbs);

			var x = "hello" + Environment.NewLine;


			String[] names = new String[3] { "Bob", "Sue", "Daryn" };
			var shortNames = names.Where((n) => n.Length <= 3).ToArray();


			int[] numbers = new int[7] {1000, 1, 2, 3, 4, 5, 6};
			IEnumerable<int> doubled = numbers.Select((int num) => num * 2);
			var largenumbers = doubled.Where((int num) => num > 5);
			int sumOfLargeNumbers = largenumbers.Sum();

			IEnumerable<int> listA = numbers.Select((int num) => num * 2);

			List<int> list = new List<int>();
			for (int i = 0; i < numbers.Length; i++)
			{
				int dbl = numbers[i] * 2;
				list.Add(dbl);
			}


			foreach (int num in doubled)
			{
				Console.Write(num + " ");
			}
			Console.WriteLine();
			foreach (int num in largenumbers) 
			{
//				Console.Write(num + " ");
			}


			Console.ReadKey();
		}
	}
}
