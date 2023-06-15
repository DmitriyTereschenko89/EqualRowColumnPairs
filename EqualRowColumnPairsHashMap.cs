namespace EqualRowColumnPairs
{
	internal class EqualRowColumnPairsHashMap
	{
		public int EqualPairs(int[][] grid)
		{
			Dictionary<string, int> set = new();
			for (int r = 0; r < grid.Length; ++r)
			{
				string rowStr = string.Join(",", grid[r]);
				set[rowStr] = set.GetValueOrDefault(rowStr) + 1;
			}
			int equalPairs = 0;
			for (int c = 0; c < grid[0].Length; ++c)
			{
				List<int> colValues = new();
				for (int r = 0; r < grid.Length; ++r)
				{
					colValues.Add(grid[r][c]);
				}
				string colStr = string.Join(",", colValues);
				if (set.ContainsKey(colStr))
				{
					equalPairs += set[colStr];
				}
			}
			return equalPairs;
		}
	}
}
