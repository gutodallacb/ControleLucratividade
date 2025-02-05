using System.Runtime.InteropServices.JavaScript;

namespace ProjetoSQLserver.Controller
{
	public class AlphaVantageAPI
	{
		private string apiKey = "6N3NI7XIPQSNHKLK";
		private string url = "https://www.alphavantage.co/query";

		public async Task ConsumirAPI_Restful(string acao)
		{
			using (HttpClient client = new HttpClient())
			{
				string urlCompleto = ($"{url}?function=TIME_SERIES_INTRADAY&symbol={acao}&interval=5min&apikey={apiKey}");
				HttpResponseMessage resposta = await client.GetAsync(urlCompleto);

				if (resposta.IsSuccessStatusCode)
				{
					string json = await resposta.Content.ReadAsStringAsync();

					MessageBox.Show("Resposta da API:");
					MessageBox.Show(json);
				}
			}
		}
	}
}
