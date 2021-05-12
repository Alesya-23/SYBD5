using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseImplements.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime DatePayment { get; set; }
        public double SumPayment { get; set; }
    }
}
