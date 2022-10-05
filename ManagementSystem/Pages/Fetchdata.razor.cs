using ManagementSystem.Models;
using System.Net.Http.Json;

namespace ManagementSystem.Pages
{
    public partial class Fetchdata
    {
        private Machine[]? forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<Machine[]>("sample-data/weather.json");
            Console.WriteLine();
        }
    }
}
