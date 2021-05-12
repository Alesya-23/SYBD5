using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseBusinessLogic.BindingModels
{
    public class CheckInBindingModel
    {
        public int? Id { get; set; }
        public DateTime DateArrival { get; set; }
        public  DateTime Datedepature  { get; set; }
        public int CountDays { get; set; }
    }
}
