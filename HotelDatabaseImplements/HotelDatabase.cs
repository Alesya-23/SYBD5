using HotelDatabaseImplements.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseImplements
{
    public class HotelDatabase : DbContext
    {
        public virtual DbSet<CheckIn> CheckIns { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<HotelRoom> HotelRooms { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
    }
}
