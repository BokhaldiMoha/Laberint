﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laberint
{
	public partial class TriarNivell : Form
	{
		List<Laberint> laberints = new List<Laberint>();
		public TriarNivell()
		{
			InitializeComponent();

			char[,] laberint = new char[,]
			{
				{ '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
				{ '#', '.', '.', '.', '#', '.', '.', '.', '.', '#' },
				{ '#', '.', '#', '.', '#', '.', '#', '#', '.', '#' },
				{ '#', '.', '#', '.', '.', '.', '#', '.', '.', '#' },
				{ '#', '.', '#', '#', '#', '#', '#', '.', '#', '#' },
				{ '#', '.', '.', '.', '.', '.', '#', '.', '.', '.' },
				{ '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
			};
			laberints.Add(new Laberint(laberint, 2, 1));

			laberint = new char[,]
			{
				{ '#', '#', '#', '#', '#', '#', '#', '#', '.', '#' },
				{ '#', '.', '.', '.', '.', '.', '.', '#', '.', '#' },
				{ '#', '#', '#', '.', '#', '#', '.', '#', '.', '#' },
				{ '#', '.', '.', '.', '#', '.', '.', '.', '.', '#' },
				{ '#', '.', '#', '#', '#', '#', '#', '#', '.', '#' },
				{ '#', '.', '.', '.', '.', '.', '.', '#', '.', '#' },
				{ '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
			};
			laberints.Add(new Laberint(laberint, 1, 5));

			laberint = new char[,]
			{
				{ '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
				{ '#', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
				{ '#', '#', '#', '.', '#', '#', '#', '#', '#', '#' },
				{ '#', '.', '.', '.', '#', '.', '.', '.', '.', '#' },
				{ '#', '.', '#', '#', '#', '#', '#', '#', '.', '#' },
				{ '#', '.', '.', '.', '.', '.', '.', '.', '.', '#' },
				{ '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
			};
			laberints.Add(new Laberint(laberint, 8, 5));

			laberint = new char[,]
			{
				{'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
				{'#', '.', '.', '.', '#', '.', '.', '.', '.', '#'},
				{'#', '.', '#', '.', '#', '.', '#', '#', '.', '#'},
				{'#', '.', '#', '.', '.', '.', '.', '.', '.', '#'},
				{'#', '.', '#', '#', '#', '.', '#', '#', '.', '#'},
				{'#', '.', '.', '.', '#', '.', '.', '.', '.', '#'},
				{'#', '#', '#', '.', '#', '#', '#', '#', '.', '#'},
				{'#', '.', '.', '.', '.', '.', '.', '#', '.', '#'},
				{'#', '#', '#', '#', '#', '#', '.', '#', '.', '#'},
				{'#', '.', '.', '.', '.', '.', '.', '#', '#', '#'},
			};
			laberints.Add(new Laberint(laberint, 8, 8));

			laberint = new char[,]
			{
				{'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
				{'#', '.', '.', '.', '#', '.', '.', '.', '.', '#'},
				{'#', '.', '#', '.', '#', '.', '#', '#', '.', '#'},
				{'#', '.', '#', '.', '.', '.', '.', '#', '.', '#'},
				{'#', '.', '#', '#', '#', '.', '.', '#', '.', '#'},
				{'#', '.', '.', '.', '#', '#', '#', '#', '.', '#'},
				{'#', '.', '#', '#', '#', '.', '.', '.', '.', '#'},
				{'#', '.', '.', '.', '#', '#', '#', '#', '.', '#'},
				{'#', '#', '#', '.', '#', '.', '.', '.', '.', '#'},
				{'#', '#', '#', '#', '#', '.', '#', '#', '#', '#'}
			};
			laberints.Add(new Laberint(laberint, 3, 8));

			laberint = new char[,]
			{
				{'#', '#', '#', '#', '#', '.', '#', '#', '#', '#', '#', '#'},
				{'#', '.', '.', '.', '#', '.', '#', '.', '.', '.', '.', '#'},
				{'#', '.', '#', '.', '#', '.', '#', '.', '#', '#', '.', '#'},
				{'#', '.', '#', '.', '#', '.', '.', '.', '.', '#', '.', '#'},
				{'#', '.', '#', '#', '.', '#', '#', '.', '#', '#', '.', '#'},
				{'#', '.', '.', '#', '.', '#', '.', '.', '#', '.', '.', '#'},
				{'#', '#', '.', '#', '.', '#', '#', '#', '#', '#', '.', '#'},
				{'#', '.', '.', '#', '.', '.', '.', '.', '.', '#', '.', '#'},
				{'#', '.', '#', '#', '#', '.', '#', '.', '.', '#', '.', '#'},
				{'#', '.', '.', '.', '.', '.', '#', '#', '.', '#', '.', '#'},
				{'#', '.', '#', '.', '#', '.', '.', '#', '.', '.', '.', '#'},
				{'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
			};
			laberints.Add(new Laberint(laberint, 1, 1));

			laberint = new char[,]
			{
				{ '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
				{ '#', '.', '.', '.', '#', '.', '.', '.', '.', '#', '.', '.', '.', '.', '#' },
				{ '#', '#', '#', '.', '#', '#', '#', '#', '.', '#', '#', '#', '#', '.', '#' },
				{ '#', '.', '#', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '#' },
				{ '#', '.', '#', '#', '#', '#', '.', '#', '.', '#', '#', '.', '#', '.', '#' },
				{ '#', '.', '.', '.', '.', '.', '.', '#', '.', '#', '#', '.', '#', '.', '#' },
				{ '#', '.', '#', '#', '#', '#', '.', '#', '.', '.', '.', '.', '#', '.', '#' },
				{ '#', '.', '#', '.', '.', '.', '.', '#', '.', '#', '#', '#', '#', '.', '#' },
				{ '#', '.', '#', '#', '#', '#', '.', '#', '.', '#', '.', '.', '.', '.', '#' },
				{ '#', '.', '.', '.', '.', '.', '.', '#', '.', '#', '.', '#', '#', '#', '#' },
				{ '#', '.', '#', '#', '#', '#', '#', '#', '.', '#', '.', '#', '.', '.', '.' },
				{ '#', '.', '#', '.', '.', '.', '.', '.', '.', '#', '.', '#', '#', '.', '#' },
				{ '#', '.', '#', '.', '#', '#', '.', '#', '#', '#', '.', '.', '#', '.', '#' },
				{ '#', '.', '.', '.', '.', '#', '.', '.', '.', '.', '#', '.', '.', '.', '#' },
				{ '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
			};
			laberints.Add(new Laberint(laberint, 1, 1));

			laberint = new char[,]
			{
				{'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
				{'#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '#'},
				{'#', '.', '#', '#', '.', '#', '#', '.', '#', '#', '#', '.', '.', '#', '#', '.', '.', '#', '.', '.', '#', '.', '#', '#', '.', '.', '.', '#', '#'},
				{'#', '.', '.', '#', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '#', '.', '.', '#', '#', '#', '.', '.', '#', '.', '.', '#', '.', '.', '#'},
				{'#', '#', '.', '.', '#', '#', '#', '#', '#', '#', '#', '#', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '#', '.', '.', '#', '.', '.', '#'},
				{'#', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '#', '#', '.', '#', '.', '#', '#', '#', '#', '#', '#', '.', '.', '.', '#'},
				{'#', '.', '.', '#', '.', '.', '#', '.', '.', '.', '.', '#', '.', '.', '#', '.', '.', '#', '.', '.', '#', '.', '.', '.', '.', '.', '.', '#', '#'},
				{'#', '.', '#', '#', '.', '.', '#', '#', '#', '#', '#', '#', '#', '.', '#', '.', '.', '#', '.', '.', '#', '.', '.', '#', '.', '.', '.', '#', '#'},
				{'#', '.', '.', '#', '.', '#', '.', '.', '#', '.', '.', '#', '.', '.', '.', '.', '#', '.', '.', '#', '.', '.', '#', '#', '.', '#', '#', '#', '#'},
				{'#', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '#', '.', '.', '#', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '#'},
				{'#', '.', '.', '.', '#', '.', '.', '#', '.', '.', '.', '#', '.', '.', '#', '#', '.', '#', '.', '#', '#', '.', '.', '.', '.', '#', '.', '.', '#'},
				{'#', '#', '.', '.', '#', '.', '.', '#', '.', '#', '#', '#', '.', '.', '.', '.', '.', '#', '.', '#', '#', '.', '#', '#', '#', '#', '#', '.', '#'},
				{'#', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '#', '.', '.', '#', '.', '.', '#', '.', '.', '#', '.', '.', '.', '.', '.', '#', '#', '#'},
				{'#', '.', '#', '.', '.', '.', '#', '.', '#', '.', '.', '#', '.', '.', '.', '.', '.', '#', '#', '.', '#', '.', '.', '.', '#', '.', '.', '.', '#'},
				{'#', '.', '.', '.', '#', '.', '.', '.', '#', '.', '.', '#', '.', '.', '#', '.', '.', '#', '#', '.', '#', '.', '.', '.', '#', '.', '#', '#', '#'},
				{'#', '#', '#', '#', '#', '.', '#', '.', '.', '#', '.', '.', '#', '.', '#', '#', '.', '#', '#', '.', '#', '.', '#', '.', '#', '.', '.', '.', '.'},
				{'#', '.', '.', '.', '.', '.', '#', '.', '.', '#', '.', '.', '#', '.', '#', '.', '.', '.', '.', '.', '#', '.', '#', '.', '#', '.', '#', '#', '#'},
				{'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
			};
			laberints.Add(new Laberint(laberint, 1, 16));

			int x = 10;
			int y = 10;
			int cont = 0;

			foreach (Laberint l in laberints)
			{
				Button btn = new Button();
				btn.Text = (cont + 1).ToString();
				btn.Size = new Size(60, 30);
				btn.Location = new Point(x, y);
				x += 70;
				cont++;

				if (cont % 5 == 0)
				{
					y += 40;
					x = 10;
				}
				btn.Click += new EventHandler(btn_Click);

				Controls.Add(btn);
			}

			this.Size = new Size(0, 0);
			this.AutoSize = true;
			this.Padding = new Padding(10);
		}
		private void btn_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			int lab = int.Parse(btn.Text);

			Joc joc = new Joc(laberints[lab - 1]);

			this.Hide();
			joc.Show();
		}

		private void TriarNivell_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
