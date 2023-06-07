using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberint
{
	public class Laberint
	{
		private char[,] lab;
		private int x, y;
		public Laberint(char[,] lab, int x, int y)
		{
			this.lab = lab;
			this.x = x;
			this.y = y;
		}

		public char[,] Lab
		{
			get { return lab; }
			set { lab = value; }
		}
		public int X
		{
			get { return x; }
			set { x = value; }
		}
		public int Y
		{
			get { return y; }
			set { y = value; }
		}

	}
}
