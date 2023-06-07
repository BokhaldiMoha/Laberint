using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laberint
{
	public partial class Joc : Form
	{
		Timer timer;
		char[,] laberint;
		int x;
		int y;
		public Joc(Laberint lab)
		{
			laberint = lab.Lab;
			x = lab.X;
			y = lab.Y;

			for (int i = 0; i < laberint.GetLength(0); i++)
			{
				for (int j = 0; j < laberint.GetLength(1); j++)
				{
					if (laberint[i, j] == 'M')
					{
						laberint[i, j] = '.';
						break;
					}
				}
			}
			InitializeComponent();
			laberint[y, x] = 'M';
			txLaberint.Text = Imprimir(laberint);
			txLaberint.Enabled = false;
			txLaberint.ReadOnly = true;
			TxAutoResize(txLaberint);
			Select();
			this.Size = new Size(0, 0);
			this.AutoSize = true;
			this.Padding = new Padding(10);

			Label lb = new Label();
			lb.Name = "lbContador";
			lb.Font = new Font("Calibri", 16);
			lb.Text = "30";
			lb.Location = new Point(this.Width / 2 - 25, this.Height - 45);
			Controls.Add(lb);

			timer = new Timer();
			timer.Interval = 4000;

			this.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);

			int tempsRestant = 30;

			timer.Tick += (s, ev) =>
			{
				if (tempsRestant == 30)
					this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
				timer.Interval = 1000;
				tempsRestant--;
				Controls["lbContador"].Text = tempsRestant.ToString("00");

				if (tempsRestant == 0)
				{
					timer.Stop();
					MessageBox.Show("Temps agotat!");
					TriarNivell trN = (TriarNivell)Application.OpenForms["TriarNivell"];
					if (trN == null)
					{
						trN = new TriarNivell();
					}
					trN.Show();
					this.Hide();
				}
			};

			timer.Start();
		}
		private String Imprimir(char[,] array)
		{
			String result = "";
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					result += array[i, j] + " ";
				}
				result += Environment.NewLine;
			}
			result = result.Substring(0, result.Length - 1);
			return result;
		}
		private void TxAutoResize(TextBox textBox)
		{
			textBox.Multiline = true;
			textBox.MinimumSize = new Size(0, 0);
			textBox.Size = TextRenderer.MeasureText(textBox.Text, textBox.Font);
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && y != 0 && laberint[y - 1, x] == '.')
			{
				laberint[y, x] = '.';
				y--;
				laberint[y, x] = 'M';
				txLaberint.Text = Imprimir(laberint);
			}
			else if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && y != laberint.GetLength(0) - 1 && laberint[y + 1, x] == '.')
			{
				laberint[y, x] = '.';
				y++;
				laberint[y, x] = 'M';
				txLaberint.Text = Imprimir(laberint);
			}
			else if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && x != 0 && laberint[y, x - 1] == '.')
			{
				laberint[y, x] = '.';
				x--;
				laberint[y, x] = 'M';
				txLaberint.Text = Imprimir(laberint);
			}
			else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && x != laberint.GetLength(1) - 1 && laberint[y, x + 1] == '.')
			{
				laberint[y, x] = '.';
				x++;
				laberint[y, x] = 'M';
				txLaberint.Text = Imprimir(laberint);
			}
			if (x == 0 || x == laberint.GetLength(1) - 1 || y == 0 || y == laberint.GetLength(0) - 1)
			{
				timer.Stop();
				MessageBox.Show("Has escapat, ben fet!");
				TriarNivell trN = (TriarNivell)Application.OpenForms["TriarNivell"];
				if (trN == null)
				{
					trN = new TriarNivell();
				}
				trN.Show();
				this.Hide();
			}
		}

		private void Joc_FormClosed(object sender, FormClosedEventArgs e)
		{
			TriarNivell trN = (TriarNivell)Application.OpenForms["TriarNivell"];
			if (trN == null)
			{
				trN = new TriarNivell();
			}
			timer.Stop();
			trN.Show();
			this.Hide();
		}
	}
}
