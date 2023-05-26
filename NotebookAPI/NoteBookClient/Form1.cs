using NotebookAPI.Model;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace NoteBookClient;

public partial class Form1 : Form
{
	const string _baseAddress = "https://localhost:7055/";

	public Form1()
	{
		InitializeComponent();
		_ = UpdateAsync();
	}

	private async void button1_Click(object sender, EventArgs e)
	{
		await UpdateAsync();
	}

	private async Task UpdateAsync()
	{
		using var client = CreateHttpClient();

		var response = await client.GetAsync("api/People");
		if (response.IsSuccessStatusCode)
		{
			listView.Items.Clear();

			var reports = await response.Content.ReadFromJsonAsync<Person[]>();
			foreach (var p in reports)
			{
				var item = new ListViewItem(new[] { p.Firstname, p.Secondname, p.BirthDay.ToShortDateString() });
				item.Tag = p.Id;
				listView.Items.Add(item);
			}
		}
	}



	private void Delete(int delete)
	{
		using var client = CreateHttpClient();

		HttpResponseMessage response = client.DeleteAsync("api/People/" + delete).Result;

	}

	private async void btnDelete_Click(object sender, EventArgs e)
	{
		if (listView.SelectedItems.Count != 0)
		{
			int id = (int)listView.SelectedItems[0].Tag;

			Delete(id);

			await UpdateAsync();
		}
	}
	private async void btnAdd_Click(object sender, EventArgs e)
	{
		var form = new AddPeopleForm();
		var result = form.ShowDialog();

		if (result == DialogResult.OK)
		{
			Person newPerson = form.GetPersonData();

			try
			{
				using var client = CreateHttpClient();
				HttpResponseMessage response = await client.PostAsJsonAsync("api/People", newPerson);
				if (response.IsSuccessStatusCode)
				{
					await UpdateAsync();
				}
				else
				{
					MessageBox.Show("Failed to add person: " + response.ReasonPhrase);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to add person: " + ex.Message);
			}
		}
	}

	private async void btnEdit_Click(object sender, EventArgs e)
	{
		if (listView.SelectedItems.Count != 0)
		{
			int id = (int)listView.SelectedItems[0].Tag;

			var form = new EditPeopleForm(id);
			var result = form.ShowDialog();

			if (result == DialogResult.OK)
			{
				Person updatedPerson = form.GetPersonData();

				try
				{
					using var client = CreateHttpClient();
					var response = await client.PutAsJsonAsync("api/People/" + id, updatedPerson);
					if (response.IsSuccessStatusCode)
					{
						await UpdateAsync();
					}
					else
					{
						MessageBox.Show("Failed to update person: " + response.ReasonPhrase);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Failed to update person: " + ex.Message);
				}
			}
		}
	}
	public static HttpClient CreateHttpClient()
	{
		var client = Program.HttpClientFactory.CreateClient();
		client.BaseAddress = new Uri(_baseAddress);
		client.DefaultRequestHeaders.Accept.Clear();
		client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		return client;
	}
}