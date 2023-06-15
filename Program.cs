namespace EqualRowColumnPairs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			EqualRowColumnPairsHashMap equalRowColumnPairs = new();
            Console.WriteLine(equalRowColumnPairs.EqualPairs(new int[][]
			{
				new int[] { 3, 2, 1 },
				new int[] { 1, 7, 6 },
				new int[] { 2, 7, 7 }
			}));
			Console.WriteLine(equalRowColumnPairs.EqualPairs(new int[][]
			{
				new int[] { 3, 1, 2, 2 },
				new int[] { 1, 4, 4, 5 },
				new int[] { 2, 4, 2, 2 },
				new int[] { 2, 4, 2, 2 }
			}));
			EqualRowColumnPairsTrie equalRowColumnPairsTrie = new();
			Console.WriteLine(equalRowColumnPairsTrie.EqualPairs(new int[][]
			{
				new int[] { 3, 2, 1 },
				new int[] { 1, 7, 6 },
				new int[] { 2, 7, 7 }
			}));
			Console.WriteLine(equalRowColumnPairsTrie.EqualPairs(new int[][]
			{
				new int[] { 3, 1, 2, 2 },
				new int[] { 1, 4, 4, 5 },
				new int[] { 2, 4, 2, 2 },
				new int[] { 2, 4, 2, 2 }
			}));
		}
	}
}