using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HotelDatabaseBusinessLogic.ViewModels
{
    public class ClientViewModel
    {
        public int? Id { get; set; }
        public int HotelId { get; set; }

        [DisplayName("Название отеля")]
        public string HotelName { get; set; }

        [DisplayName("ФИО")]
        public string fioname { get; set; }
        [DisplayName("Паспорт")]
        public int passport { get; set; }
    }
}
