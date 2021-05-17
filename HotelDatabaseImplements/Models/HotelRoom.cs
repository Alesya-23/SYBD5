using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelDatabaseImplements.Models
{
    public class HotelRoom
    {
        public int? Id { get; set; }
        public int ClientId { get; set; }
        public string TypeRoom { get; set; }
        public double Price { get; set; }
        public int Reservation { get; set; }
        [ForeignKey("HotelId")]
        public virtual Hotel Hotel { get; set; }
        public int? HotelId { get; set; }
        public virtual Client Client { get; set; }

        [ForeignKey("StaffId")]
        public virtual List<HotelRoomStaff> HotelRoomStaffs { get; set; }
    }
}
