using NotebookAPI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBookClient
{
	public partial class EditPeopleForm : Form
	{
		public EditPeopleForm(int personId)
		{
			InitializeComponent();
			_personId = personId;
			EditPersonForm_Load();
		}

		private readonly int _personId;

		private async void EditPersonForm_Load()
		{
			try
			{
				using var client = Form1.CreateHttpClient();
				HttpResponseMessage response = await client.GetAsync($"api/People/{_personId}");
				if (response.IsSuccessStatusCode)
				{
					Person person = await response.Content.ReadFromJsonAsync<Person>();

					// Заполнение элементов управления данными редактируемого контакта
					txtFirstname.Text = person.Firstname;
					txtLastname.Text = person.Secondname;
					birthDate.Value = person.BirthDay;
				}
				else
				{
					MessageBox.Show("Failed to retrieve person: " + response.ReasonPhrase);
					DialogResult = DialogResult.Cancel;
					Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to retrieve person: " + ex.Message);
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}
		public Person GetPersonData()
		{
			// Считывание данных из элементов управления формы
			string firstName = txtFirstname.Text;
			string lastName = txtLastname.Text;
			DateTime date = birthDate.Value;

			// Создание объекта Person
			Person updatedPerson = new Person
			{
				Id = _personId,
				Firstname = firstName,
				Secondname = lastName,
				BirthDay = date
			};

			return updatedPerson;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
