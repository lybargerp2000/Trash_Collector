using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Date
    {
        public int DateId { get; set; }
        public int CalenderDate { get; set; }
        public string DayOfWeek { get; set; }
        public string WeekOfMonth { get; set; }
        public int ExtraPickUpDate { get; set; }
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
