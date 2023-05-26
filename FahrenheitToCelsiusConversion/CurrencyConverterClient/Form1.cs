using CurrencyConverterServiceClient;
using System.ServiceModel;
using System.Xml;
using System.Xml.Linq;

namespace CurrencyConverterClient
{
	public partial class Form1 : Form
	{
		private readonly DailyInfoSoapClient _client;

		public Form1()
		{
			InitializeComponent();
			var binding = new BasicHttpBinding();
			var endpoint = new EndpointAddress("http://www.cbr.ru/DailyInfoWebServ/DailyInfo.asmx");
			_client = new DailyInfoSoapClient(binding, endpoint);
		}


		public async Task<decimal> ConvertCurrencyAsync(string fromCurrency, string toCurrency, decimal amount)
		{
			var cursOnDateResponse = await _client.GetCursOnDateAsync(DateTime.Now);

			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(cursOnDateResponse.Nodes[1].ToString());
			XmlNode valuteNode = xmlDoc.SelectSingleNode($"//ValuteCursOnDate[VchCode='{fromCurrency.ToUpper()}']");
			decimal fromRate, toRate;
			if (valuteNode != null)
			{
				string vchCode = valuteNode.SelectSingleNode("VchCode")?.InnerText;
				fromRate = Convert.ToDecimal(valuteNode.SelectSingleNode("Vcurs")?.InnerText.Replace(".", ","));

			}
			else
			{
				throw new Exception($"Валюта с кодом {fromCurrency} не найдена.");
			}

			XmlNode valuteNodeToCurrency = xmlDoc.SelectSingleNode($"//ValuteCursOnDate[VchCode='{toCurrency.ToUpper()}']");

			if (valuteNodeToCurrency != null)
			{
				string vchCode = valuteNodeToCurrency.SelectSingleNode("VchCode")?.InnerText;
				toRate = Convert.ToDecimal(valuteNodeToCurrency.SelectSingleNode("Vcurs")?.InnerText.Replace(".", ","));

			}
			else
			{
				throw new Exception($"Валюта с кодом {toCurrency} не найдена.");
			}

			decimal result = amount * fromRate / toRate;

			return result;
		}

		private async void btnCalc_Click(object sender, EventArgs e)
		{
			try
			{
				decimal amount = decimal.Parse(txtSum.Text);
				decimal result = await ConvertCurrencyAsync(txtSourc.Text, txtDest.Text, amount);
				MessageBox.Show($"{amount} {txtSourc.Text} = {result} {txtDest.Text}");
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}
	}
}