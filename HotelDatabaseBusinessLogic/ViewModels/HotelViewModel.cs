using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HotelDatabaseBusinessLogic.ViewModels
{
    public class HotelViewModel
    {
        public int Id { get; set; }
        [DisplayName("ФИО")]
        public string name { get; set; }
        [DisplayName("Кол-во номеров")]
        public int CountRooms { get; set; }

        [DisplayName("Кол-во занятых номеров")]
        public int CountBusyRooms { get; set; }

    }
}
