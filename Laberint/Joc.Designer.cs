namespace Laberint
{
	partial class Joc
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.txLaberint = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txLaberint
			// 
			this.txLaberint.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txLaberint.Location = new System.Drawing.Point(13, 13);
			this.txLaberint.Name = "txLaberint";
			this.txLaberint.Size = new System.Drawing.Size(100, 26);
			this.txLaberint.TabIndex = 0;
			// 
			// Joc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txLaberint);
			this.Name = "Joc";
			this.Text = "Podràs sortir del laberint?";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Joc_FormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txLaberint;
	}
}

