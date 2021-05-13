using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseBusinessLogic.BindingModels
{
    public class StaffBindingModel
    {
        public int? Id { get; set; }
        public string FIOname { get; set; }
        public string Post { get; set; }
        public int HotelId { get; set; }
        public Dictionary<int, string> HotelRooms { get; set; }
    }
}
