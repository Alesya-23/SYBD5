using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseImplements.Models
{
    public class CheckIn
    {
        public int? Id { get; set; }
        public int ClientId { get; set; }

        public DateTime DateArrival { get; set; }
        public DateTime Datedepature { get; set; }
        public virtual Client Client { get; set; }
    }
}
