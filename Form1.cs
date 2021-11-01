using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class WeatherForm : Form
    {

        public static async Task<WeatherApiResponse> GetWeatherData(string searchValue)
        {
            using (var httpClient = new HttpClient())
            {
                var url = $"https://api.weatherapi.com/vX/current.json?key=cfa41a0b8eaf441fb53103144212510&q={searchValue}&aqi=no";
                var response = await httpClient.GetAsync(url);
                var contentString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<WeatherApiResponse>(contentString);
            }
        }

        public WeatherForm()
        {
            InitializeComponent();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();

            settingsForm.ShowDialog();
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            var weatherDetail = await GetWeatherData(searchTextBox.Text);
            

            MessageBox.Show(weatherDetail.Location.Country);
        }


    }
}
