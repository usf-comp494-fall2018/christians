using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Final_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<ThreeDay> _results;
        public MainPage()
        {
            this.InitializeComponent();
            _results = new List<ThreeDay>();


        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            using (var client = new HttpClient())
            {
                Current curResults;

                //current conditions api call
                var response =
                    await client.GetStringAsync("https://finalprojectcomp494.azurewebsites.net/api/weather/4");
                var forecast = JsonConvert.DeserializeObject<Current>(response);

                //set data binding
                curResults = forecast;
                currentResults.DataContext = curResults;

                //three day forecast api call
                var _3forecast =
                    await client.GetStringAsync("https://finalprojectcomp494.azurewebsites.net/api/weather/");
                var dayList = JsonConvert.DeserializeObject<List<ThreeDay>>(_3forecast);

                //adds weather data for next 3 days into list
                foreach (var day in dayList.Where(c => c.id > 1))
                {
                    _results.Add(new ThreeDay()
                    {
                        id = day.id,
                        period = day.period,
                        icon = day.icon,
                        title = day.title,
                        fcttext = day.fcttext,
                        lastcheck = day.lastcheck,
                        ImagePath = getImage(day.icon.ToUpper())
                    });
                }

                //set data binding
                _3DayResults.ItemsSource = _results;
            }
        }

        //returns image path for icon
        private string getImage(string icon)
        {
            string imagePath = "ms-appx:///Assets/CLEAR.png";
            switch (icon)
            {
                case "OVERCAST":
                    imagePath = "ms-appx:///Assets/OVERCAST.png";
                    break;
                case "CLOUDY":
                    imagePath = "ms-appx:///Assets/CLOUDY.png";
                    break;
                case "PARTLYCLOUDY":
                    imagePath = "ms-appx:///Assets/PARTLYCLOUDY.png";
                    break;
                case "NT_PARTLYCLOUDY":
                    imagePath = "ms-appx:///Assets/NT_PARTLYCLOUDY.png";
                    break;
                case "RAIN":
                    imagePath = "ms-appx:///Assets/RAIN.png";
                    break;
                case "NT_RAIN":
                    imagePath = "ms-appx:///Assets/NT_RAIN.png";
                    break;
                case "SNOW":
                    imagePath = "ms-appx:///Assets/SNOW.png";
                    break;
                case "NT_SNOW":
                    imagePath = "ms-appx:///Assets/NT_SNOW.png";
                    break;
                case "CLEAR":
                    imagePath = "ms-appx:///Assets/CLEAR.png";
                    break;
                case "NT_CLEAR":
                    imagePath = "ms-appx:///Assets/NT_CLEAR.png";
                    break;
                case "STORM":
                    imagePath = "ms-appx:///Assets/STORM.png";
                    break;
                case "WINDY":
                    imagePath = "ms-appx:///Assets/WINDY.png";
                    break;
                case "CHANCERAIN":
                    imagePath = "ms-appx:///Assets/CHANCERAIN.png";
                    break;
                case "NT_CHANCERAIN":
                    imagePath = "ms-appx:///Assets/NT_CHANCERAIN.png";
                    break;
                case "MOSTLYCLOUDY":
                    imagePath = "ms-appx:///Assets/MOSTLYCLOUDY.png";
                    break;
                case "NT_MOSTLYCLOUDY":
                    imagePath = "ms-appx:///Assets/NT_MOSTLYCLOUDY.png";
                    break;

            }

            return imagePath;
        }


    
    }
}
