using System;
using BlazorApp.Data;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
	public partial class FetchData
	{
		private WeatherForecast[] forcasts;

		protected override async Task OnInitializeAsync()
		{
			forcasts = await WeatherForecastService.GetForecastAsync(DateTime.Now);
		}
	}
}

