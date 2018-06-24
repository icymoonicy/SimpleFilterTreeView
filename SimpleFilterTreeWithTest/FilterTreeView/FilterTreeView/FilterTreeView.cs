using System.Collections.Generic;
using System.Windows.Forms;

namespace KControl.GUI
{
	public partial class FilterTreeView : UserControl
	{
		public FilterTreeView()
		{
			InitializeComponent();
			nodeCache = new List<TreeNode>();
			FilterTxtBox.TextChanged += FilterTxtBox_TextChanged;
		}

		List<TreeNode> nodeCache;
		string lastFilterText = string.Empty;
		void FilterTxtBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(lastFilterText))
			{
				UpdateNodeCache();
			}
			RebuildDisplayTree(FilterTxtBox.Text);
			lastFilterText = FilterTxtBox.Text;
		}

		void UpdateNodeCache()
		{
			nodeCache.Clear();
			foreach (TreeNode node in DisplayTree.Nodes)
			{
				var newNode = (TreeNode)node.Clone();
				nodeCache.Add(newNode);
			}
		}

		void RebuildDisplayTree(string filterString)
		{
			DisplayTree.Nodes.Clear();
			foreach (var node in nodeCache)
			{
				var newNode = (TreeNode)node.Clone();
				if (!string.IsNullOrEmpty(filterString))
				{
					FilterNodes(newNode, filterString);
					if (newNode.Nodes.Count > 0 || newNode.Text.Contains(filterString))
					{
						DisplayTree.Nodes.Add(newNode);
					}
				}
				else
				{
					DisplayTree.Nodes.Add(newNode);
				}
			}
		}

		void FilterNodes(TreeNode parentNode, string filterString)
		{
			if (parentNode.Nodes.Count > 0)
			{
				for (int i = parentNode.Nodes.Count - 1; i >= 0; i--)
				{
					var currentNode = parentNode.Nodes[i];
					if (!currentNode.Text.Contains(filterString))
					{
						FilterNodes(currentNode, filterString);
						if (currentNode.Nodes.Count == 0)
						{
							parentNode.Nodes.RemoveAt(i);
						}
					}
					else if (currentNode.Nodes.Count > 0)
					{
						FilterNodes(currentNode, filterString);
					}
				}
			}
		}
	}
}
