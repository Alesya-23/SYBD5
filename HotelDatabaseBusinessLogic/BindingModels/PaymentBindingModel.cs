using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseBusinessLogic.BindingModels
{
    public class PaymentBindingModel
    {
        public int? Id { get; set; }
        public int ClientId { get; set; }
        public int HotelId { get; set; }
        public int CheckInId { get; set; }
        public DateTime DatePayment { get; set; }
        public double SumPayment { get; set; }
    }
}
