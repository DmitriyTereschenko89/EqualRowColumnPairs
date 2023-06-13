namespace EqualRowColumnPairs
{
	internal class Program
	{
		public class EqualRowColumnPairs
		{
			public int EqualPairs(int[][] grid)
			{
				HashSet<string> set = new();
				for (int r = 0; r < grid.Length; ++r)
				{
					set.Add(string.Join(", ", grid[r]));
				}
				int equalPairs = 0;
				for (int c = 0; c < grid[0].Length; ++c)
				{
					string colStr = string.Join(", ", grid[c]);
					if (set.Contains(colStr))
					{
						++equalPairs;
					}
				}
				return equalPairs;
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
	}
}