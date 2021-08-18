using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BusinessLogic.ViewModels.ReportModels
{
    public class ReportRoomViewModel
    {
        public int RoomId { get; set; }

        [DisplayName("Тип")]
        public string Type { get; set; }

        [DisplayName("Цена")]
        public double Price { get; set; }
    }
}
