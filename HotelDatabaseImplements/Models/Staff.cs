using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseImplements.Models
{
    public class Staff
    {
        public int? Id { get; set; }
        public string FIOname { get; set; }
        public string Post { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
