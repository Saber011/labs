namespace WindowsFormsControlLibrary1
{
    partial class ColorControl
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbDec = new System.Windows.Forms.RadioButton();
            this.rdbHex = new System.Windows.Forms.RadioButton();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtB = new WindowsFormsControlLibrary1.NumberTextBox(this.components);
            this.txtG = new WindowsFormsControlLibrary1.NumberTextBox(this.components);
            this.txtR = new WindowsFormsControlLibrary1.NumberTextBox(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "R:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "G:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "B:";
            // 
            // rdbDec
            // 
            this.rdbDec.AutoSize = true;
            this.rdbDec.Checked = true;
            this.rdbDec.Location = new System.Drawing.Point(18, 129);
            this.rdbDec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbDec.Name = "rdbDec";
            this.rdbDec.Size = new System.Drawing.Size(45, 17);
            this.rdbDec.TabIndex = 2;
            this.rdbDec.TabStop = true;
            this.rdbDec.Text = "Dec";
            this.rdbDec.UseVisualStyleBackColor = true;
            this.rdbDec.CheckedChanged += new System.EventHandler(this.RdbDec_CheckedChanged);
            // 
            // rdbHex
            // 
            this.rdbHex.AutoSize = true;
            this.rdbHex.Location = new System.Drawing.Point(85, 129);
            this.rdbHex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbHex.Name = "rdbHex";
            this.rdbHex.Size = new System.Drawing.Size(44, 17);
            this.rdbHex.TabIndex = 2;
            this.rdbHex.Text = "Hex";
            this.rdbHex.UseVisualStyleBackColor = true;
            this.rdbHex.CheckedChanged += new System.EventHandler(this.RdbHex_CheckedChanged);
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Lime;
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor.Location = new System.Drawing.Point(171, 5);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(101, 103);
            this.lblColor.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(54, 90);
            this.txtB.Margin = new System.Windows.Forms.Padding(2);
            this.txtB.Name = "txtB";
            this.txtB.NumberSystem = WindowsFormsControlLibrary1.NumberSystems.Dec;
            this.txtB.Size = new System.Drawing.Size(73, 20);
            this.txtB.TabIndex = 0;
            this.txtB.Text = "0";
            this.txtB.Value = ((byte)(0));
            this.txtB.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(54, 58);
            this.txtG.Margin = new System.Windows.Forms.Padding(2);
            this.txtG.Name = "txtG";
            this.txtG.NumberSystem = WindowsFormsControlLibrary1.NumberSystems.Dec;
            this.txtG.Size = new System.Drawing.Size(73, 20);
            this.txtG.TabIndex = 0;
            this.txtG.Text = "0";
            this.txtG.Value = ((byte)(0));
            this.txtG.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(54, 25);
            this.txtR.Margin = new System.Windows.Forms.Padding(2);
            this.txtR.Name = "txtR";
            this.txtR.NumberSystem = WindowsFormsControlLibrary1.NumberSystems.Dec;
            this.txtR.Size = new System.Drawing.Size(73, 20);
            this.txtR.TabIndex = 0;
            this.txtR.Text = "0";
            this.txtR.Value = ((byte)(0));
            this.txtR.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // ColorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rdbHex);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.rdbDec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ColorControl";
            this.Size = new System.Drawing.Size(287, 161);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumberTextBox txtR;
        private NumberTextBox txtG;
        private NumberTextBox txtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbDec;
        private System.Windows.Forms.RadioButton rdbHex;
        private System.Windows.Forms.Label lblColor;
    }
}
