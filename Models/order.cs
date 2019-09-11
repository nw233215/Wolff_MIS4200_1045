using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wolff_MIS4200_1045.Models
{
    public class order
    {
        public int orderId { get; set; }
        public int customerId { get; set; }
        public virtual Customer customer { get; set; }
        public DateTime orderDate { get; set; }
    }
}