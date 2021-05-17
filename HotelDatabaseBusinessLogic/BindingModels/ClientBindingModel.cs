using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseBusinessLogic.BindingModels
{
    public class ClientBindingModel
    {
        public int? Id { get; set; }
        public int HotelId { get; set; }
        public string fioname { get; set; }
        public int passport { get; set; }
    }
}
