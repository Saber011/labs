namespace SoapServiceClient
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
			rbtCelsius = new RadioButton();
			rbtFahrenheit = new RadioButton();
			txtCelsius = new TextBox();
			txtFahrenheit = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// rbtCelsius
			// 
			rbtCelsius.AutoSize = true;
			rbtCelsius.Location = new Point(293, 124);
			rbtCelsius.Name = "rbtCelsius";
			rbtCelsius.Size = new Size(148, 24);
			rbtCelsius.TabIndex = 0;
			rbtCelsius.TabStop = true;
			rbtCelsius.Text = "Градусы цельсия";
			rbtCelsius.UseVisualStyleBackColor = true;
			// 
			// rbtFahrenheit
			// 
			rbtFahrenheit.AutoSize = true;
			rbtFahrenheit.Location = new Point(293, 213);
			rbtFahrenheit.Name = "rbtFahrenheit";
			rbtFahrenheit.Size = new Size(173, 24);
			rbtFahrenheit.TabIndex = 1;
			rbtFahrenheit.TabStop = true;
			rbtFahrenheit.Text = "Градусы Фаренгейта";
			rbtFahrenheit.UseVisualStyleBackColor = true;
			// 
			// txtCelsius
			// 
			txtCelsius.Location = new Point(316, 154);
			txtCelsius.Name = "txtCelsius";
			txtCelsius.Size = new Size(166, 27);
			txtCelsius.TabIndex = 2;
			txtCelsius.KeyPress += txtCelsius_KeyPress;
			// 
			// txtFahrenheit
			// 
			txtFahrenheit.Location = new Point(316, 243);
			txtFahrenheit.Name = "txtFahrenheit";
			txtFahrenheit.Size = new Size(166, 27);
			txtFahrenheit.TabIndex = 3;
			txtFahrenheit.KeyPress += txtFahrenheit_KeyPress;
			// 
			// button1
			// 
			button1.Location = new Point(626, 322);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 4;
			button1.Text = "Закрыть";
			button1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(txtFahrenheit);
			Controls.Add(txtCelsius);
			Controls.Add(rbtFahrenheit);
			Controls.Add(rbtCelsius);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private RadioButton rbtCelsius;
		private RadioButton rbtFahrenheit;
		private TextBox txtCelsius;
		private TextBox txtFahrenheit;
		private Button button1;
	}
}