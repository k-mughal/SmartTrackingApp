
using System;

namespace SmartTracking.Models
{

    public class TrackingList
    {
  
        public DateTime Date
        {
            get;
            set;
        }

      
        public string Status                      //  Binding in status with listBox
        {
            get;
            set;
        }
        public override string ToString()
        {
            return " " + Date + " " + Status +"\n";
        }

    }
}
