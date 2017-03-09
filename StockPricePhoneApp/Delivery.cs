using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPricePhoneApp
{
    class Delivery
    {

        public string DeliveryID { get; set; }
        public string ClientID { get; set; }
        public string DriverID { get; set; }
        public DateTime Date { get; set; }
        public string CurrentStatus { get; set; }
        public string Type { get; set; }
        public string PickUpLocation { get; set; }
        public string DeliverTo { get; set; }

        public override string ToString()
        {
            return "Tracking ID" +  DeliveryID + " Date " + Date + "\n";
        }
    }
}
