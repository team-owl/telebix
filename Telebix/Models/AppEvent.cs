using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Telebix.Models
{
    public class AppEvent
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

    }
}
