using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseBusinessLogic.BindingModels
{
    public class HotelRoomBindingModel
    {
        public int? Id { get; set; }
        public int HotelId { get; set; }
        public int ClientId { get; set; }
        public string TypeRoom { get; set; }
        public double Price { get; set; }
        public int Reservation { get; set; }
        public Dictionary<int, string> Staff { get; set; }
    }
}
