using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class CustomerInfoChart
    {
        public int CustomerInfoChartId { get; set; }
        public string CustomerDayOfWeek { get; set; }
        public bool PickUpConfirm { get; set; }
        public double CustomerPickUpCharge { get; set; }
    }
}
