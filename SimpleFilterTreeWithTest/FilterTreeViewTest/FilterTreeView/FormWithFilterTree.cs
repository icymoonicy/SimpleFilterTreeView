using System;
using System.Windows.Forms;

namespace FilterTreeViewTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.Load += Form1_Load;
		}

		void Form1_Load(object sender, EventArgs e)
		{
			BuildTestTree();
		}

		void BuildTestTree()
		{
			var a = filterTreeView1.DisplayTree.Nodes.Add("AAA1");
			a.Nodes.Add("BBB").Nodes.Add("EEE");
			a.Nodes.Add("MMM");

			var b = filterTreeView1.DisplayTree.Nodes.Add("BBB1");
			b.Nodes.Add("MMM");
			b.Nodes.Add("BBB").Nodes.Add("EEE");

			var c = filterTreeView1.DisplayTree.Nodes.Add("CCC2");
			for (int i = 0; i < 5000; i++)
			{
				c.Nodes.Add("KKK");
			}


			var d = filterTreeView1.DisplayTree.Nodes.Add("DDD2");
			for (int i = 0; i < 5000; i++)
			{
				d.Nodes.Add("AAA");
			}

			filterTreeView1.DisplayTree.Nodes.Add("EEE1");

			filterTreeView1.DisplayTree.Nodes.Add("FFF1");
		}
	}
}
