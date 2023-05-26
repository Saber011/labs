namespace CurrencyConverterClient
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnCalc = new Button();
			txtSum = new TextBox();
			txtSourc = new TextBox();
			txtDest = new TextBox();
			sum = new Label();
			source = new Label();
			dest = new Label();
			SuspendLayout();
			// 
			// btnCalc
			// 
			btnCalc.Location = new Point(452, 310);
			btnCalc.Name = "btnCalc";
			btnCalc.Size = new Size(94, 29);
			btnCalc.TabIndex = 0;
			btnCalc.Text = "Расчитать";
			btnCalc.UseVisualStyleBackColor = true;
			btnCalc.Click += btnCalc_Click;
			// 
			// txtSum
			// 
			txtSum.Location = new Point(219, 108);
			txtSum.Name = "txtSum";
			txtSum.Size = new Size(125, 27);
			txtSum.TabIndex = 1;
			// 
			// txtSourc
			// 
			txtSourc.Location = new Point(219, 182);
			txtSourc.Name = "txtSourc";
			txtSourc.Size = new Size(125, 27);
			txtSourc.TabIndex = 2;
			// 
			// txtDest
			// 
			txtDest.Location = new Point(219, 262);
			txtDest.Name = "txtDest";
			txtDest.Size = new Size(125, 27);
			txtDest.TabIndex = 3;
			// 
			// sum
			// 
			sum.AutoSize = true;
			sum.Location = new Point(115, 113);
			sum.Name = "sum";
			sum.Size = new Size(53, 20);
			sum.TabIndex = 4;
			sum.Text = "сумма";
			// 
			// source
			// 
			source.AutoSize = true;
			source.Location = new Point(66, 185);
			source.Name = "source";
			source.Size = new Size(128, 20);
			source.TabIndex = 5;
			source.Text = "исходная валюта";
			// 
			// dest
			// 
			dest.AutoSize = true;
			dest.Location = new Point(74, 265);
			dest.Name = "dest";
			dest.Size = new Size(120, 20);
			dest.TabIndex = 6;
			dest.Text = "целевая валюта";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dest);
			Controls.Add(source);
			Controls.Add(sum);
			Controls.Add(txtDest);
			Controls.Add(txtSourc);
			Controls.Add(txtSum);
			Controls.Add(btnCalc);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCalc;
		private TextBox txtSum;
		private TextBox txtSourc;
		private TextBox txtDest;
		private Label sum;
		private Label source;
		private Label dest;
	}
}