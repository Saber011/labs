namespace SoapServiceClient
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			rbtCelsius.Checked = true;
		}

		private void rbt_CheckedChanged(object sender, EventArgs e)
		{
			txtCelsius.ReadOnly = !rbtCelsius.Checked;
			txtFahrenheit.ReadOnly = !rbtFahrenheit.Checked;
		}

		private async void txtCelsius_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != 13)
				return;

			var client = new SoapServices.ConversionServiceClient();

			double value = 0;
			if (double.TryParse(txtCelsius.Text, out value))
			{
				txtFahrenheit.Text = (await client.CelsiusToFahrenheitAsync(value)).ToString();
			}

		}
		private async void txtFahrenheit_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != 13)
				return;

			var client = new SoapServices.ConversionServiceClient();

			double value = 0;
			if (double.TryParse(txtFahrenheit.Text, out value))
			{
				txtCelsius.Text =  (await client.FahrenheitToCelsiusAsync(value)).ToString();
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}