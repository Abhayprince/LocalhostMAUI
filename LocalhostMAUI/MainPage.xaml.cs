using System.Net.Http.Json;

namespace LocalhostMAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCallApiBtnClicked(object sender, EventArgs e)
	{
		var httpClient = new HttpClient();
		var baseUrl = DeviceInfo.Platform == DevicePlatform.Android
						? "http://10.0.2.2:5167"
						: "http://localhost:5167";

        var response = await httpClient.GetAsync($"{baseUrl}/WeatherForecast");

		var data = await response.Content.ReadAsStringAsync();
	}
}

