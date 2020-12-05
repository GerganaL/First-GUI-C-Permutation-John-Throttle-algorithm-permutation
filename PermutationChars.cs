using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie5Permutation
{


	public class PermutationChars
	{
		public TextBox txtResult;

		public StringBuilder input;
		public int n;
		
		/*public static void Main(string[] args)
		{
			Scanner scan = new Scanner(System.in);

			// starting element
			Console.WriteLine("Insert symbol");
			StringBuilder @string = new StringBuilder(scan.nextLine());
			// n number of elements
			Console.WriteLine("Insert n");
			int numberOfelements = int.Parse(scan.nextLine());

			for (int i = 1; i < numberOfelements; i++)
			{
				@string.Append((char)(@string[0] + i));

			}
			PermutationChars permutation = new PermutationChars();
			permutation.permute(@string.ToString(), 0, @string.Length);
		}*/


		private void permute(string str, int start, int end)
		{
			if (start == end)
			{
				Console.WriteLine(str);
			}
			else
			{
				for (int i = start; i < end; i++)
				{
					str = swap(str, start, i);
					permute(str, start + 1, end);
					str = swap(str, start, i);
				}
			}
		}

		public virtual string swap(string @string, int firstElement, int secondElement)
		{
			char temp;
			char[] charArray = @string.ToCharArray();
			temp = charArray[firstElement];
			charArray[firstElement] = charArray[secondElement];
			charArray[secondElement] = temp;
			return new string(charArray);
		}
	}
}

}
