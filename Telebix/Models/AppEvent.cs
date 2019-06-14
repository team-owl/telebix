using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Telebix.Models
{
    public partial class AppEvent
    {
        public DateTime EventDt { get; set; }
        public int PhoneId { get; set; }
        public string UserId { get; set; }
        public string ClinicName { get; set; }
        public string AppVersion { get; set; }
        public string AndroidVersion { get; set; }
        public bool Success { get; set; }
        public float Value { get; set; }
        public string Message { get; set; }

        // Since the sample data values are not properly formatted, make up random values instead
        public string ValueString()
        {
            if (this.Value < 0)
            {
                return "-1";
            }

            Random r = new Random();
            double d = Math.Round(r.NextDouble() * 60) / 2; //Increments of 0.5
            return String.Format("{0:P1}", d / 100);
        }
    }
}
