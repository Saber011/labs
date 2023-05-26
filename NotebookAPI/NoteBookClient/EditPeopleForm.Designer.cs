namespace NoteBookClient
{
	partial class EditPeopleForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Button btnEdit;
		private TextBox txtFirstname;
		private TextBox txtLastname;
		private Label lblFirstname;
		private Label lblLastname;

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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnEdit = new Button();
			txtFirstname = new TextBox();
			txtLastname = new TextBox();
			lblFirstname = new Label();
			lblLastname = new Label();
			birthDate = new DateTimePicker();
			label1 = new Label();
			SuspendLayout();
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(16, 158);
			btnEdit.Margin = new Padding(4, 5, 4, 5);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(100, 35);
			btnEdit.TabIndex = 3;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// txtFirstname
			// 
			txtFirstname.Location = new Point(111, 18);
			txtFirstname.Margin = new Padding(4, 5, 4, 5);
			txtFirstname.Name = "txtFirstname";
			txtFirstname.Size = new Size(251, 27);
			txtFirstname.TabIndex = 0;
			// 
			// txtLastname
			// 
			txtLastname.Location = new Point(111, 65);
			txtLastname.Margin = new Padding(4, 5, 4, 5);
			txtLastname.Name = "txtLastname";
			txtLastname.Size = new Size(251, 27);
			txtLastname.TabIndex = 1;
			// 
			// lblFirstname
			// 
			lblFirstname.AutoSize = true;
			lblFirstname.Location = new Point(16, 23);
			lblFirstname.Margin = new Padding(4, 0, 4, 0);
			lblFirstname.Name = "lblFirstname";
			lblFirstname.Size = new Size(76, 20);
			lblFirstname.TabIndex = 4;
			lblFirstname.Text = "Firstname:";
			// 
			// lblLastname
			// 
			lblLastname.AutoSize = true;
			lblLastname.Location = new Point(16, 69);
			lblLastname.Margin = new Padding(4, 0, 4, 0);
			lblLastname.Name = "lblLastname";
			lblLastname.Size = new Size(75, 20);
			lblLastname.TabIndex = 5;
			lblLastname.Text = "Lastname:";
			// 
			// birthDate
			// 
			birthDate.Location = new Point(111, 110);
			birthDate.Name = "birthDate";
			birthDate.Size = new Size(250, 27);
			birthDate.TabIndex = 6;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(16, 115);
			label1.Name = "label1";
			label1.Size = new Size(67, 20);
			label1.TabIndex = 7;
			label1.Text = "BirhDate";
			// 
			// EditPeopleForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(379, 248);
			Controls.Add(label1);
			Controls.Add(birthDate);
			Controls.Add(btnEdit);
			Controls.Add(txtFirstname);
			Controls.Add(txtLastname);
			Controls.Add(lblFirstname);
			Controls.Add(lblLastname);
			Margin = new Padding(4, 5, 4, 5);
			Name = "EditPeopleForm";
			Text = "EditPeopleForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker birthDate;
		private Label label1;
	}
}