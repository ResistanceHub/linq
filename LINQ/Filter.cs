using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
	public class Filter
	{
		public bool contains(int num, int[] list)
		{
			return list.Contains(num);
//			bool result = list.Contains(num);
//			return result;

//			if (result)
//			{
//				return result;
//			}
//			else
//			{
//				return result;
//			}
			
			
		}

		private bool IsEven(int n)
		{
			// if it is even, then mod 2 is 0
			// if number modules 2 is 0, then the number is even
			return (n % 2 == 0);
		}

		public int[] filterOutOddNumbers(int[] inputList)
		{
			IEnumerable<int> result = inputList.Where((num) => IsEven(num));
//			return result.ToArray();



			Console.WriteLine("Please enter new content for the file - type exit and press enter to finish editing:");
			using (StreamWriter sw = new StreamWriter("test.txt")) {

				string newContent = Console.ReadLine();

				while (newContent != "exit") {
					sw.Write(newContent + Environment.NewLine);
					Console.Write("Enter a word (or exit to quite):");
					newContent = Console.ReadLine();
				}
			}
		}


	}
}
