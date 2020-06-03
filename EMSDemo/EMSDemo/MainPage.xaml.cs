using System;
using System.Net.Http;
using Xamarin.Forms;

namespace EMSDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private async void ButtonON_Clicked(object sender, EventArgs e)
        {
            string requestURL = "http://192.168.2.87/?p8=1";
            
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(requestURL);
            
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }
        }

        private async void ButtonOFF_Clicked(object sender, EventArgs e)
        {
            string requestURL = "http://192.168.2.87/?p8=0";
            
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(requestURL);
            
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}