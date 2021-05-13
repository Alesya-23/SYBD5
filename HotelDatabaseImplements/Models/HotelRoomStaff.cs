using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseImplements.Models
{
    public class HotelRoomStaff
    {
        public int Id { get; set; }
        public int HotelRoomId { get; set; }
        public int StaffId { get; set; }
        public virtual HotelRoom HotelRoom { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
