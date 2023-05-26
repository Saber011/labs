using NotebookAPI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBookClient
{
	public partial class AddPeopleForm : Form
	{
		public AddPeopleForm()
		{
			InitializeComponent();
		}
		public Person GetPersonData()
		{
			// Считывание данных из элементов управления формы
			string firstName = txtFirstname.Text;
			string lastName = txtLastname.Text;
			//DateTime birthDate = datePickerBirthDate.Value;

			// Создание объекта Person
			Person newPerson = new Person
			{
				Firstname = firstName,
				Secondname = lastName,
				BirthDay = birthDate.Value
			};

			return newPerson;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
