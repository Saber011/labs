namespace NoteBookClient;

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
		listView = new ListView();
		clmFirstName = new ColumnHeader();
		clmLastName = new ColumnHeader();
		clmBirthDay = new ColumnHeader();
		button1 = new Button();
		btnAdd = new Button();
		btnEdit = new Button();
		btnDelete = new Button();
		SuspendLayout();
		// 
		// listView
		// 
		listView.Columns.AddRange(new ColumnHeader[] { clmFirstName, clmLastName, clmBirthDay });
		listView.FullRowSelect = true;
		listView.GridLines = true;
		listView.Location = new Point(82, 79);
		listView.Name = "listView";
		listView.Size = new Size(518, 196);
		listView.TabIndex = 0;
		listView.UseCompatibleStateImageBehavior = false;
		listView.View = View.Details;
		// 
		// clmFirstName
		// 
		clmFirstName.Tag = "";
		clmFirstName.Text = "Имя";
		clmFirstName.Width = 150;
		// 
		// clmLastName
		// 
		clmLastName.Text = "Фамилия";
		clmLastName.Width = 150;
		// 
		// clmBirthDay
		// 
		clmBirthDay.Text = "Дата рождения";
		clmBirthDay.Width = 150;
		// 
		// button1
		// 
		button1.Location = new Point(93, 310);
		button1.Name = "button1";
		button1.Size = new Size(94, 29);
		button1.TabIndex = 1;
		button1.Text = "Обновить";
		button1.UseVisualStyleBackColor = true;
		button1.Click += button1_Click;
		// 
		// btnAdd
		// 
		btnAdd.Location = new Point(220, 310);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(94, 29);
		btnAdd.TabIndex = 2;
		btnAdd.Text = "Добавить";
		btnAdd.UseVisualStyleBackColor = true;
		btnAdd.Click += btnAdd_Click;
		// 
		// btnEdit
		// 
		btnEdit.Location = new Point(356, 311);
		btnEdit.Name = "btnEdit";
		btnEdit.Size = new Size(94, 29);
		btnEdit.TabIndex = 3;
		btnEdit.Text = "Изменить";
		btnEdit.UseVisualStyleBackColor = true;
		btnEdit.Click += btnEdit_Click;
		// 
		// btnDelete
		// 
		btnDelete.Location = new Point(483, 314);
		btnDelete.Name = "btnDelete";
		btnDelete.Size = new Size(94, 29);
		btnDelete.TabIndex = 4;
		btnDelete.Text = "Удалить";
		btnDelete.UseVisualStyleBackColor = true;
		btnDelete.Click += btnDelete_Click;
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF(8F, 20F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 450);
		Controls.Add(btnDelete);
		Controls.Add(btnEdit);
		Controls.Add(btnAdd);
		Controls.Add(button1);
		Controls.Add(listView);
		Name = "Form1";
		Text = "Form1";
		ResumeLayout(false);
	}

	#endregion

	private ListView listView;
	private ColumnHeader clmFirstName;
	private ColumnHeader clmLastName;
	private ColumnHeader clmBirthDay;
	private Button button1;
	private Button btnAdd;
	private Button btnEdit;
	private Button btnDelete;
}