using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PermutationChars
{
	public class Permutation
	{
		public TextBox txtResult;
		private int[] index;
		public string input;
		public int n;
		private Dictionary<int, string> direction;

		public static int count = 0;

		public Permutation(string input)
		{

			this.input = input;
			index = new int[input.Length];
			direction = new Dictionary<int, string>();
		}

		public virtual void createPermutation()
		{

			//at the beginning all numbers (index of items) are pointing from right to left
			//<0 <1 <2 ...

			for (int i = 0; i < index.Length; i++)
			{
				index[i] = i;
				direction[i] = "left";
			}

			int mobile = 0;

			while (mobile != -1)
			{

				mobile = Mobile;
				printPermutation();
				count++;
				swap(mobile);
			}
		}

		public virtual int Mobile
		{
			get
			{

				//find largest mobile number (by Bennett Post)
				//return -1 if no number is found

				int lm1 = index.Length - 1;
				int maxMobile = -1;

				// slicing loop to avoid "array index test"
				if (string.ReferenceEquals(direction[index[0]], "right"))
				{

					if (index[0] > index[1])
					{

						maxMobile = index[0];
					}
				}

				for (int i = 1; i < lm1; i++)
				{

					if (index[i] > maxMobile)
					{

						if (string.ReferenceEquals(direction[index[i]], "left"))
						{
							if (index[i] > index[i - 1])
							{
								maxMobile = index[i];
							}

						}
						else
						{

							if (index[i] > index[i + 1])
							{
								maxMobile = index[i];
							}
						}
					}
				}

				if (string.ReferenceEquals(direction[lm1], "left"))
				{

					if (index[lm1] > maxMobile && index[lm1] > index[lm1 - 1])
					{

						maxMobile = index[lm1];
					}
				}

				//change direction of numbers > maxMobile

				for (int i = 0; i < index.Length; i++)
				{
					if (maxMobile < index[i])
					{

						if (string.ReferenceEquals(direction[index[i]], "left"))
						{
							direction[index[i]] = "right";
						}
						else
						{
							direction[index[i]] = "left";

						}
					}
				}

				return maxMobile;
			}
		}

		public virtual void swap(int mobile)
		{

			//get index of mobile

			int x = 0;

			for (int i = 0; i < index.Length; i++)
			{
				if (mobile == index[i])
				{

					x = i;
				}

			}

			//position of mobile = index[x]

			//left: index[x] <> index[x-1]
			//right: index[x] <> index[x+1]

			if (string.ReferenceEquals(direction[mobile], "left"))
			{

				int temp = index[x];
				index[x] = index[x - 1];
				index[x - 1] = temp;

			}
			else
			{

				int temp = index[x];
				index[x] = index[x + 1];
				index[x + 1] = temp;

			}
		}

		//print every char from input
		//--> input.charAt(index[i])

		public virtual void printPermutation()
		{

			for (int i = 0; i < index.Length; i++)
			{
				/*Console.Write(input[index[i]]);*/
				txtResult.AppendText(input[index[i]].ToString());
			}

			/*Console.WriteLine();*/
			txtResult.AppendText(Environment.NewLine);
			//txtResult.AppendText("Count is " + count);
		}
		

		/*public static void Main(string[] args)
		{

			Scanner scan = new Scanner(System.in);
			Console.WriteLine("Enter n:");
			int n = int.Parse(scan.nextLine());
			Console.WriteLine("Enter symbols: ");
			string input = scan.nextLine();

			if (input.Length < n || input.Length > n)
			{
				Console.WriteLine("Invalid input!");
			}
			else
			{
				Permutation perm = new Permutation(input);
				perm.createPermutation();
			}

			Console.WriteLine("Count is: " + count);

		}*/
	}
}
