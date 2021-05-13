using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HotelDatabaseBusinessLogic.ViewModels
{
    public class HotelRoomViewModel
    {
        public int? Id { get; set; }
        public int HotelId { get; set; }
        public int ClientId { get; set; }

        [DisplayName("Тип номера")]
        public string TypeRoom { get; set; }
        [DisplayName("Цена")]
        public double Price { get; set; }
        [DisplayName("Бронь(0-нет, 1-есть)")]
        public int Reservation { get; set; }
        public Dictionary<int, string> Staff { get; set; }
    }
}
