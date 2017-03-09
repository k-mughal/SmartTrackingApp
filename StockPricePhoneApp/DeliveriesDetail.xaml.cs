using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using System.Net.Http;
using System.Net.Http.Headers;

namespace StockPricePhoneApp
{
    public partial class DeliveriesDetail : PhoneApplicationPage
    {
        private const String serviceURI = "http://smarttracking.azurewebsites.net/";
        public DeliveriesDetail()
        {
            InitializeComponent();
        }

        private void goBackbutton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private async void Button_Click_DisplayDeliveries(object sender, RoutedEventArgs e)
        {
            try
            {

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(serviceURI);

                    // add an Accept header for JSON
                    client.DefaultRequestHeaders.
                        Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // GET ../TransitWebServices/ShowLogHistory/UNQ1001

                    HttpResponseMessage response = await client.GetAsync("TransitWebServices/DeliveryDetail");

                    // continue
                    if (response.IsSuccessStatusCode)
                    {
                        // read result and display on UI

                        var listings = await response.Content.ReadAsAsync<IEnumerable<Delivery>>();
                        deliveryListBox.Items.Clear();
                        foreach (var lists in listings)
                        {
                            deliveryListBox.Items.Add(lists);
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