using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
	class ListViewItemComparer : IComparer
	{
		private int col;
		private bool flag = true;

		public ListViewItemComparer(bool flag = true)
		{
			col = 0;
			this.flag = flag;
		}
		public ListViewItemComparer(int column, bool flag = true)
		{
			col = column;
			this.flag = flag;
		}

		public int Compare(object x, object y)
		{

			if (flag)
			{
				return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
			}
			else
			{
				return String.Compare(((ListViewItem)y).SubItems[col].Text, ((ListViewItem)x).SubItems[col].Text);
			}		
		}
	}
}
