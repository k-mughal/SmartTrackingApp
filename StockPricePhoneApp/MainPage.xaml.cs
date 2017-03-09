// a Windows Phone 8 app which calls an operation on a RESTful web service and displays the results
// also uses ASP.Net Web API client utilities - NuGet install
// display on a long list selector (flat not grouped)
using System.Windows.Controls;
using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows;

using SmartTracking.Models;
using System.Collections.ObjectModel;

namespace StockPricePhoneApp
{
    // main page for app
    public partial class MainPage : PhoneApplicationPage
    {
        // URI for RESTful service (implemented using Web API)
        private const String serviceURI = "http://smarttracking.azurewebsites.net/";
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        // display prices button clicked - event handler
  

        private void historyTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            
        }

        private void Button_Click_DisplayPage2(object sender, RoutedEventArgs e)
        {
           // NavigationService.Navigate(new Uri("/TrackingHistory.xaml?msg=" + trackingTextBox.Text, UriKind.Relative));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // NavigationService.Navigate(new Uri("/TrackingHistory.xaml?msg=" + trackingTextBox.Text, UriKind.Relative));
            NavigationService.Navigate(new Uri("/TrackingHistory.xaml", UriKind.Relative));
        }

        private void admin(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DeliveriesDetail.xaml", UriKind.Relative));
        }
    }
}