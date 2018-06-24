namespace KControl.GUI
{
	partial class FilterTreeView
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.FilterTxtBox = new System.Windows.Forms.TextBox();
			this.DisplayTree = new System.Windows.Forms.TreeView();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.FilterTxtBox);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.DisplayTree);
			this.splitContainer.Size = new System.Drawing.Size(642, 417);
			this.splitContainer.SplitterDistance = 30;
			this.splitContainer.TabIndex = 0;
			// 
			// FilterTxtBox
			// 
			this.FilterTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FilterTxtBox.Location = new System.Drawing.Point(0, 0);
			this.FilterTxtBox.Name = "FilterTxtBox";
			this.FilterTxtBox.Size = new System.Drawing.Size(642, 26);
			this.FilterTxtBox.TabIndex = 0;
			// 
			// DisplayTree
			// 
			this.DisplayTree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DisplayTree.Location = new System.Drawing.Point(0, 0);
			this.DisplayTree.Name = "DisplayTree";
			this.DisplayTree.Size = new System.Drawing.Size(642, 383);
			this.DisplayTree.TabIndex = 0;
			// 
			// FilterTreeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer);
			this.Name = "FilterTreeView";
			this.Size = new System.Drawing.Size(642, 417);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel1.PerformLayout();
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		System.Windows.Forms.SplitContainer splitContainer;
		public System.Windows.Forms.TextBox FilterTxtBox;
		public System.Windows.Forms.TreeView DisplayTree;
	}
}
