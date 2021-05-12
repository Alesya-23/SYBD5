using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseImplements.Models
{
    public class Client
    {
        public int? Id { get; set; }
        public string fioname { get; set; }
        public int passport { get; set; }

        public virtual Hotel Hotel { get; set; }
    }
}
