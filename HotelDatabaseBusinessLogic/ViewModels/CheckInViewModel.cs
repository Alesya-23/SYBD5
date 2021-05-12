﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HotelDatabaseBusinessLogic.ViewModels
{
    public class CheckInViewModel
    {
        public int? Id { get; set; }

        [DisplayName("Дата прибытия")]
        public DateTime DateArrival { get; set; }

        [DisplayName("Дата отбытия")]
        public DateTime Datedepature { get; set; }

        [DisplayName("Количество дней")]
        public int CountDays { get; set; }
    }
}