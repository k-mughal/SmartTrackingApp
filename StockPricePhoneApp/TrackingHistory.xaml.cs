using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using System.Net.Http.Headers;
using System.Net.Http;
using SmartTracking.Models;


namespace StockPricePhoneApp
{
    public partial class TrackingHistory : PhoneApplicationPage
    {
        // URI for RESTful service (implemented using Web API)
        private const String serviceURI = "http://smarttracking.azurewebsites.net/";
        public TrackingHistory()
        {
            InitializeComponent();
          
        }
          

        private void goBackbutton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private async void Button_Click_DisplayTrackHistory(object sender, RoutedEventArgs e)
        {
            try
            {

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(serviceURI);                             // base URL for API Controller i.e. RESTFul service

                    // add an Accept header for JSON
                    client.DefaultRequestHeaders.
                        Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // GET ../TransitWebServices/ShowLogHistory/UNQ1001

                    HttpResponseMessage response = await client.GetAsync("TransitWebServices/ShowLogHistory/" + trackingTextBox.Text);

                    // continue
                    if (response.IsSuccessStatusCode)
                    {
                        // read result and display on UI

                        var listings = await response.Content.ReadAsAsync<IEnumerable<TrackingList>>();
                        logHistoryListBox.Items.Clear();
                        foreach (var lists in listings)
                        {

                            logHistoryListBox.Items.Add(lists);
                        }

                    }
                
                }
            }
            catch (Exception)
            {
                //;
            }
        }

     
    }
}
