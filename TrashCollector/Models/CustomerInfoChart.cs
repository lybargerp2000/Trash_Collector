using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("Customer")]
        [Display(Name  = "Adress")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [NotMapped]
        public IEnumerable<Customer> Customers { get; set; }

    }
}
