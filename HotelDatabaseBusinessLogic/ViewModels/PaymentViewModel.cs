using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HotelDatabaseBusinessLogic.ViewModels
{
    public class PaymentViewModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int HotelId { get; set; }
        public int CheckInId { get; set; }
        [DisplayName("Дата")]
        public DateTime DatePayment { get; set; }
        [DisplayName("Сумма оплаты")]
        public double SumPayment { get; set; }
    }
}
