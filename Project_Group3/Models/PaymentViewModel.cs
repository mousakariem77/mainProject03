using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Group3.Models
{
    public class PaymentViewModel
    {
        public int LeanrerId { get; set; }
        public int courseId { get; set; }
        public decimal? Price { get; set; }
        public string Email { get; set; }
        public DateTime enrollmentDate { get; set; }       
        public string courseName { get; set; }
        public string learnerName { get; set; }
        public string? voucher { get; set; }
        public string status { get; set; }



    }
}