using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseBusinessLogic.BindingModels
{
    public class PaymentBindingModel
    {
        public int? Id { get; set; }
        public DateTime DatePayment { get; set; }
        public double SumPayment { get; set; }
    }
}
