using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseImplements.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int CountRooms { get; set; }
        public int CountBusyRooms { get; set; }
    }
}
