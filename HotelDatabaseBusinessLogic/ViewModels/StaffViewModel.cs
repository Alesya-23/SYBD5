using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HotelDatabaseBusinessLogic.ViewModels
{
    public class StaffViewModel
    {
        public int? Id { get; set; }
        public int HotelId { get; set; }
        [DisplayName("ФИО персонала")]
        public string FIOname { get; set; }
        [DisplayName("Пост")]
        public string Post { get; set; }

        [DisplayName("Название отеля")]
        public string HotelName { get; set; }
        public Dictionary<int, string> HotelRooms { get; set; }
    }
}
