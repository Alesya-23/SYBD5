using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HotelDatabaseBusinessLogic.ViewModels
{
    public class ClientViewModel
    {
        public int? Id { get; set; }
        [DisplayName("ФИО")]
        public string fioname { get; set; }
        [DisplayName("Паспорт")]
        public int passport { get; set; }
        public int HotelId { get; set; }
    }
}
