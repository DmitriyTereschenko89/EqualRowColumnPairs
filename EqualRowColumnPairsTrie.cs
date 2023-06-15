using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualRowColumnPairs
{
	internal class EqualRowColumnPairsTrie
	{
		private class TrieNode
		{
			public int data;
			public int count;
			public Dictionary<int, TrieNode> children;

			public TrieNode()
			{
				children = new Dictionary<int, TrieNode>();
			}
		}

		private class Trie
		{
			private TrieNode root;

			public Trie()
			{
				root = new TrieNode();
			}

			public void Add(int[] data)
			{
				TrieNode node = root;
				foreach(int val in data)
				{
					if (!node.children.ContainsKey(val))
					{
						node.children.Add(val, new TrieNode());
					}
					node = node.children[val];
				}
				node.count += 1;
			}

			public int Check(int[][] grid, int c)
			{
				TrieNode node = root;
				for (int r = 0; r < grid.Length; ++r)
				{
					if (!node.children.ContainsKey(grid[r][c]))
					{
						return 0;
					}
					node = node.children[grid[r][c]];
				}
				return node.count;
			}
		}

		public int EqualPairs(int[][] grid)
		{
			Trie trie = new();
			for (int r = 0; r < grid.Length; ++r)
			{
				trie.Add(grid[r]);
			}
			int equalPairs = 0;
			for (int c = 0; c < grid[0].Length; ++c)
			{
				equalPairs += trie.Check(grid, c);
			}
			return equalPairs;
		}
	}
}
